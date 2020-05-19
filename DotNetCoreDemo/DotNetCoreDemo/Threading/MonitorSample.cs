using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

/// <summary>
///  Monitor的Wait、Pulse、PulseAll的使用方法介绍
///  同步的对象包含若干引用，其中包括对当前拥有锁的线程的引用、对就绪队列的引用和对等待队列的引用
///  
/// ----程序的目的是多个线程操作同一个Queue，保持线程安全
/// 有两种情况：
///     1.FirstThread获得smplQueue的同步对象锁，可以对smplQueue进行操作
///     2.SecondThread获得smplQueue的同步对象锁，可以对smplQueue进行操作
/// Condition One:
///         1、开始循环，调用Monitor.Wait(smplQueue)：FirstThread释放自己对同步对象的锁，流放自己到
///     等待队列（SecondThread一开始就竞争同步锁所以处于就绪队列中），直到自己再次获得锁，否则一直阻塞。
///     所以FirstThread运行到这里就暂停了。
///         2、这时候B直接从就绪队列出来获得了smplQueue对象锁，Monitor.Pulse(smplQueue)：执
///     行时，会将FirstThread放行到就绪队列，A准备获取对锁的拥有权。
///         3、执行循环，Monitor.Wait(smplQueue, 1000)：SecondThread将自己流放到等待队列并释放自身对
///     同步锁的独占，该等待设置了1S的超时值，当SecondThread在1S之内没有再次获取到锁则自动添加到就绪
///     队列，或者这期间收到Pulse的脉冲信号。
///         4、SecondThread由于1S之内都返回false，lock块迅速结束，也即退出对smplQueue独占权,A由就绪
///     队列中进入对smplQueue的独占、继续.
///         5、在1中陈述的Monitor.Wait(smplQueue) 的阻塞结束，返回true，执行接下来的代码：
///     smplQueue.Enqueue(counter) 向队列中加入元素，执行下一行的Monitor.Pulse(smplQueue)，
///     由于第3条的1S没到（我相信地球上目前已没有这么慢的CPU了），SecondThread收到脉冲，将自己添加到就
///     绪队列，counter计数+1，FirstThread的lock结束,A则进入等待队列.
///         6、由于B从就绪队列再次获得独占权，Monitor.Wait(smplQueue, 1000)返回true，while进入循
///     同时while结束，lock块结束，B退出对对象锁的独占进入到等待队列中.
///         7、A继续，遵循这个规律循环往复知道所有的数被打印出来...
///  Condition Two:       
///         1、进入lock块，Monitor.Pulse(smplQueue)执行：由于当前的FirstThread已经处于就绪队列
///     所以收到也没作用（那么你肯定再问那这句有什么用啊？没错是得问，你发现没如果是FirstThread开始是
///     否就有用了啊！这就是它的作用！）.
///         2、开始while(Monitor.Wait(smplQueue, 1000))中的判断，技术细节还是遵循上面所讲的，B这时
///     候会自动将自己流放到等待队列并在这里阻塞（也许1S到期了也会将它放置到就绪队列中去，这个作用
///     主要是防止死锁，因为咱们的就绪队列可不能为空啊，这在上面我忘了讲了这里补充下），于是乎A
///     获得了smplQueue独占权，于是乎又回到了上面从A先获得线程锁的流程.
/// </summary>
namespace DotNetCoreDemo.Threading
{
    public class MonitorSample
    {
        private const int MAX_LOOP_TIME = 100;

        private  int count;

        public int Count
        {
            get => smplQueue.Count;
        }

        private Queue<int> smplQueue;

        public MonitorSample()
        {
            this.count = 0;
            this.smplQueue = new Queue<int>();
        }

        /// <summary>
        ///  生产者，每次生产一个
        /// </summary>
        public void FirstThread()
        {
            int counter = 0;
            lock (smplQueue) //只允许一个线程进入，独占对象访问权限
            {
                while (counter < MAX_LOOP_TIME)
                {
                    //将当前有锁的线程加入到等待队列，直到调用才继续，否则会一直阻塞
                    Monitor.Wait(smplQueue);//释放自己对同步对象的锁，流放到等待队列中----进入等待队列，等待消费者消费放回脉冲信号
                    //添加元素到队列中
                    smplQueue.Enqueue(counter);
                    //给等待队列的线程进入就绪队列的
                    Monitor.Pulse(smplQueue);//激活SecondThread
                    counter++; //生产下一个产品
                }
            }
        }

        /// <summary>
        ///  消费者，需要等待生产者生产后才能消费
        /// </summary>
        public void SecondThread()
        {
            lock (smplQueue)
            {
                //将一个等待队列的线程进入就绪队列中
                Monitor.Pulse(smplQueue);//----开始时就处于同步锁，所以就处于绪队列中
                //在一个循环中等待，直到Wait再次获取线程的拥有权
                // 等待1s自动唤醒线程可以防止死锁的产生
                while (Monitor.Wait(smplQueue,1_000)) //等待1秒钟，如果没有收到激活的脉冲就会自行进去就绪队列(CPU没有这么慢)
                {
                    //弹出第一个元素
                    int counter = smplQueue.Dequeue();
                    //打印第一个元素
                    Console.WriteLine("element->" + counter);
                    //打印完毕，让另一个等待队列的线程进入就绪队列
                    Monitor.Pulse(smplQueue);
                }
            }
        }
    }
}

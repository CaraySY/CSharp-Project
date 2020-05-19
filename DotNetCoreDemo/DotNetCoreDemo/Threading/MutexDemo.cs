using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

/// <summary>
///  Mutex锁定的是调用者，而Monitor和lock锁定的是被调用者，Mutex的实现由操作系统的内核态，、
///  因此需要在用户态和内核态之间转换，效率较低。但是可以同步多个进程的线程同步问题
/// </summary>
namespace DotNetCoreDemo.Threading
{
    public class MutexDemo 
    {
        private Mutex mutex = null;

        public void OnStartup()
        {
            bool canCreate; 
            // 创建mutex对象，由操作系统管理，它的拥有权属于当前调用的线程并起了一个唯一的名字
            // 另一个线程打算创建名称相同的Mutex对象会让canCreate返回false，会直接退出程序
            // 利用互斥对象，确保了操作系统中，同时只有一个进程在运行----即：不同进程中的线程同步问题
            mutex = new Mutex(true, "Login", out canCreate);
            if (canCreate)
            {
                Console.WriteLine("do something...");
                Console.WriteLine("Startup Login Page...");
            }
            else
            {
                Environment.Exit(-1);
            }
        }

        /// <summary>
        ///  模拟美女称重问题----
        /// </summary>
        private Mutex mt2 = new Mutex();

        private const int peopleCount= 3;

        public void GetWeight()
        {
            mt2.WaitOne();//上锁
            Console.WriteLine("{0}-People{1}上称",DateTime.Now,Thread.CurrentThread.Name);
            //开始称重
            Thread.Sleep(2_000);
            Console.WriteLine("{0}-People{1}下称", DateTime.Now, Thread.CurrentThread.Name);
            mt2.ReleaseMutex();//释放锁
        }

        public int PeopleCount
        {
            get => peopleCount;
        }
    }
}

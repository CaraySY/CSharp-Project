using DotNetCoreDemo.Constructor;
using DotNetCoreDemo.Entity;
using DotNetCoreDemo.Pattern.SinglePattern;
using DotNetCoreDemo.Threading;
using System;
using System.Threading;


/// <summary>
/// str1和str2是两个string类型的变量，但是当lock（str01）之后，str2变成了临界区被锁定导致t2中lock(){ }体处于等待状态
/// 对应了只要在应用程序进程中的任何位置处具有相同内容的字符串上放置了锁，
/// 就将锁定应用程序中与该字符串具有相同内容的字符串这句话
/// </summary>
namespace DotNetCoreDemo
{
    class Program
    {
        private static string str1 = "name";
        private static string str2 = "name";

        static void Main(string[] args)
        {
            #region 测试静态构造函数
            //输出均为 Animal * 3
            // static constructor-a -> static constructor-b -> constructor-a -> constructor-b
            //Dog d = new Dog();
            //Animal a = new Animal();
            //Animal animal = new Dog();
            /*Console.WriteLine(Dog._strText);
            Console.WriteLine(Animal._strText);*/
            #endregion
            #region 测试Volatile关键字
            /*Worker workerObject = new Worker();
            Thread workThread = new Thread(workerObject.DoWork);
            // start the worker thread
            workThread.Start();
            Console.WriteLine("Main thread:starting worker thread...");
            while (!workThread.IsAlive) ;
            Thread.Sleep(5_000);
            workerObject.RequestStop();
            workThread.Join();
            Console.WriteLine("Main thread: worker thread has terminated.");
            SingletonDemo instance = SingletonDemo.Instance;
            SingletonDemo instance2 = SingletonDemo.Instance;
            Console.WriteLine(instance==instance2);*/
            /*VolatileKeywordDemo syncThread = new VolatileKeywordDemo();
            ThreadStart action = syncThread.Run;
            Thread t1 = new Thread(action);
            Thread t2 = new Thread(action);
            t1.Start();
            t2.Start();*/
            #endregion
            #region Lock关键字
            /*LockKeywordDemo lkd1 = new LockKeywordDemo(str1, "这是线程1");
            LockKeywordDemo lkd2 = new LockKeywordDemo(str2, "这是线程2");
            ThreadStart task1 = lkd1.LockString;
            Thread t1 = new Thread(task1);            
            ThreadStart task2 = lkd2.LockString;
            Thread t2 = new Thread(task2);
            t1.Start();
            t2.Start();*/
            //lock private object 对象
            LockKeywordDemo lockKeyword1 = new LockKeywordDemo();
            LockKeywordDemo lockKeyword2 = new LockKeywordDemo();
            Thread t1 = new Thread(lockKeyword1.Run);
            t1.Name = "t1";
            Thread t2 = new Thread(lockKeyword2.Run);
            t2.Name = "t2";
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("Main thread finished.");
            #endregion
        }
    }
}

using DotNetCoreDemo.Common;
using DotNetCoreDemo.Constructor;
using DotNetCoreDemo.Entity;
using DotNetCoreDemo.Linqs;
using DotNetCoreDemo.Pattern.SinglePattern;
using DotNetCoreDemo.Threading;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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
        /*private static string str1 = "name";
        private static string str2 = "name";*/

        static void Main(string[] args)
        {
            #region 测试静态构造函数  ====>   等价于Java的静态代码块，类初始化的时候执行
            //输出均为 Animal * 3
            // static constructor-a -> static constructor-b -> constructor-a -> constructor-b
            //Dog d = new Dog();
            //Animal a = new Animal();
            //Animal animal = new Dog();
            /*Console.WriteLine(Dog._strText);
            Console.WriteLine(Animal._strText);*/
            #endregion
            #region 运算符重载
            /*Apple src = new Apple()
            {
                Color="Red",
                Weight=100,
                Price=26.3m
            };            
            Apple desc = new Apple()
            {
                Color="Yellow",
                Weight=500,
                Price=45.12458m
            };
            Console.WriteLine($"苹果src和desc的和是：{src+desc},差价是{src-desc}");
            Console.WriteLine($"苹果src重量大于desc?=>{src>desc}");
            Console.WriteLine($"苹果src重量小于desc?=>{src<desc}");*/
            #endregion
            #region Linq To Object 
            /*LinqEnumerableDemo.FilterDemo();
            LinqEnumerableDemo.FruitsGroupByColor();
            LinqEnu
            eumerableDemo.FlatCollectionBySelectMany();*/
            #endregion
            #region Linq To Xml

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
            /*LockKeywordDemo lockKeyword1 = new LockKeywordDemo();
            LockKeywordDemo lockKeyword2 = new LockKeywordDemo();
            Thread t1 = new Thread(lockKeyword1.Run);
            t1.Name = "t1";
            Thread t2 = new Thread(lockKeyword2.Run);
            t2.Name = "t2";
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("Main thread finished.");*/
            #endregion
            #region Interlocked 关键字用法
            /*//InterlockedDemo.ReadStringTest();
            InterlockedDemo.ReadTextAndUseInterLockedToLockNumber();*/
            #endregion
            #region Monitor监视器的用法
            /*MonitorDemo monitorDemo1 = new MonitorDemo();
            MonitorDemo monitorDemo2 = new MonitorDemo();
            Thread t1 = new Thread(monitorDemo1.Run);            
            Thread t2 = new Thread(monitorDemo2.Run);
            t1.Name = "t1";
            t2.Name = "t2";
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("Main Thread finished.");*/
            #endregion
            #region 使用Monitor模拟生产者-消费者问题
            /*MonitorSample sample = new MonitorSample();
            Thread t_first = new Thread(sample.FirstThread);
            Thread t_second = new Thread(sample.SecondThread);
            t_first.Name = "t_first";
            t_second.Name = "t_second";
            t_first.Start();
            t_second.Start();
            t_first.Join();
            t_second.Join();
            Console.WriteLine("Thread Main finished.->"+sample.Count);*/
            #endregion
            #region 使用Mutex进行线程同步
            /*MutexDemo mutexDemo = new MutexDemo();
            Enumerable.Range(1, mutexDemo.PeopleCount).ToList().ForEach(i =>
            {
                Thread t = new Thread(mutexDemo.GetWeight);
                t.Name = " t->" + i;
                t.Start();
            });*/
            #endregion
            #region ADO.NET Demo
            SqlConnectionStringReader reader = new SqlConnectionStringReader();
            reader.Create();
            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

/// <summary>
///  Monitor.TryEnter()可以保证无论线程有没有获取到对像锁都能够返回结果，而Lock必须等待占用的线程
///  退出后才能让下一个线程进去
/// </summary>
namespace DotNetCoreDemo.Threading
{
    public class MonitorDemo
    {
        private readonly object syncRoot = new object();

        public void Run()
        {
            //没有获取到对象锁
            if (!Monitor.TryEnter(syncRoot))
            {
                Console.WriteLine("Can't visit Object" + Thread.CurrentThread.Name);
                return;
            }
            try
            {
                Monitor.Enter(syncRoot);
                //休眠三秒
                Thread.Sleep(3_000);
                Console.WriteLine("Enter Monitor"+Thread.CurrentThread.Name);
            }
            catch (ThreadInterruptedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Monitor.Exit(syncRoot);
            }
        }
    }
}

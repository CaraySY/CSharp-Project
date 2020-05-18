using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO.IsolatedStorage;
using System.Text;
using System.Threading;

/// <summary>
///  1.lock不能锁定空值，但Null是不需要被释放的。
///  2.lock不能锁定string类型，虽然它也是引用类型的。[整个程序中任何给定字符串都只有一个实例]
/// </summary>
namespace DotNetCoreDemo.Threading
{
    public class LockKeywordDemo
    {
        private string str;
        private string path;
        private static int counter = 10;

        private object syncRoot = new object();

        public LockKeywordDemo()
        {

        }

        public LockKeywordDemo(string str,string path)
        {
            this.str = str;
            this.path = path;
        }
        /// <summary>
        ///  锁定string字符串
        /// </summary>
        public void LockString()
        {
            lock (str) //锁定字符串
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(path+"->"+i);
                }
            }
        }

        public void Run()
        {
            lock (syncRoot)
            {
                while (counter > 0)
                {
                    Thread.Sleep(1_000);
                    counter--;
                    Console.WriteLine("Now,Candies have->" + counter+ " and consumer is->" + Thread.CurrentThread.Name);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreDemo.Pattern.SinglePattern
{
    /// <summary>
    ///  使用双重锁定实现单例模式
    ///  
    /// </summary>
    public class SingletonDemo
    {
        private static object syncRoot = new object();

        private static volatile SingletonDemo instance;

        private SingletonDemo() { }

        public static SingletonDemo Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonDemo();
                        }
                    }
                }
                return instance;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DotNetCoreDemo.Threading
{
    public class InterlockedDemo
    {
        public static void ReadStringTest()
        {
            char buffer = '\0'; //定义只能容纳一个字符的缓冲区
            string str = "这里面的字会一个一个读取出来，一个都不会少~";
            Thread writer=new Thread(() =>
            {
                for(int i = 0; i < str.Length; i++)
                {
                    buffer = str[i];
                    Thread.Sleep(20);
                }
            });
            Thread reader=new Thread(() =>
            {
                for(int i = 0; i < str.Length; i++)
                {
                    char temp = buffer;
                    Console.Write(temp);
                    Thread.Sleep(30);
                }
            });
            writer.Start();
            reader.Start();
        }

        //缓冲区，只能读取一个字符
        private static char buffer = '\0';

        //标识符->指示缓冲区已用的空间，初始值为0
        private static long numberOfUseBufferSpace = 0;

        public static void ReadTextAndUseInterLockedToLockNumber()
        {
            string txt = "这里面的字会一个一个读取出来，一个都不会少，，，";
            Thread writer=new Thread(() =>
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    //写入数据之前检查缓冲区是否已满----循环等待
                    while (Interlocked.Read(ref numberOfUseBufferSpace) == 1)
                    {
                        Thread.Sleep(50);
                    }
                    //开始写入数据
                    buffer = txt[i];
                    Interlocked.Increment(ref numberOfUseBufferSpace);
                }
            });

            Thread reader=new Thread(()=>
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    //读取数据
                    while (Interlocked.Read(ref numberOfUseBufferSpace) == 0)
                    {
                        Thread.Sleep(50);
                    }
                    //读取数据
                    Console.Write(buffer);
                    Interlocked.Decrement(ref numberOfUseBufferSpace);
                }
            });

            writer.Start();
            reader.Start();
        }
    }
}

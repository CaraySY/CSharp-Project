using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

/// <summary>
/// 
///  volatile:  单处理器系统中，是没有任何问题的，变量在主存中没有机会被其他人修改，多处理器有多个Data Cache会造成问题
///  不适用于都处理核心的操作系统
///  
///  volatile 不能标记double、long，因为这两个类型的读写不能保证原子操作，可以用Interlocked/lock
///  只能用于class或struct字段
///  使用volatile不会受到编译器的优化
/// </summary>
namespace DotNetCoreDemo.Threading
{
    public class VolatileKeywordDemo
    {
        private volatile int counter = 20;

        public void Run()
        {
            while (counter > 0)
            {
                Thread.Sleep(5_00);
                counter--;
                Console.WriteLine(counter);
            }
        }
    }
}

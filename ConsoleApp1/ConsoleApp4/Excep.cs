using System;

namespace Exception
{
    public class Excep:System.Exception
    {
        public void printf()
        {
            Console.WriteLine("hello world...");
            try
            {
                //int i = 1 / 0;  //在try块句中，如果有一行代码发生异常，try中剩余的代码不会往下执行
                Console.WriteLine();
                Console.WriteLine("hello world...");
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}

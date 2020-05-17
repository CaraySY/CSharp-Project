using Exception;
using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };
            try
            {
                int myEle = array[2];
                Console.WriteLine("myEle" + myEle);

            }
            catch (System.Exception ex)//捕捉异常
            {
                Console.WriteLine("IndexOutOfRangeException...");
            }
            finally
            {
                Console.WriteLine("This is finally code area...");
            }
            Excep e = new Excep();
            e.printf();

        }
    }
}

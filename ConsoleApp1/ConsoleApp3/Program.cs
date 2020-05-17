using System;

namespace ConsoleApp3
{
    //委托用于存储指向函数的引用
    //申明一个委托--同申明函数----委托无函数体
    public delegate double MyDelegate(double x, double y);

    public class Program
    {
        static double Multiply(double x, double y)
        {
            return x * y;
        }        
        
        static double Divide(double x, double y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            TestFun test = new TestFun();
            test.Write();
            StructFun fun;
            fun.firstName = "Join";
            fun.lastName = "Tom";
            Console.WriteLine(fun.GetName());
            MyDelegate de;//定义委托变量
            de = Multiply;//指向乘法运算---给予委托变量赋值时，保证返回值和参数列表一致，否则无法赋值
            Console.WriteLine("x*y="+de(10,5));
            de = Divide;//指向除法运算
            Console.WriteLine("x/y="+de(10,5));
        }
    }
}

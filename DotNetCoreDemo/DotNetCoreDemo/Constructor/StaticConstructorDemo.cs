using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

/// <summary>
///  1.静态构造方法没有参数也没有访问修饰符
///  2.静态构造方法的调用时机，是在类被实例化或者静态成员被调用的时候进行调用，
///    并且是由.net框架来调用静态构造函数来初始化静态成员变量
///  3.静态构造方法等价于Java的静态代码块，可以用于初始化静态成员
/// </summary>
namespace DotNetCoreDemo.Constructor
{
    public class StaticConstructorDemo
    {
        public static string BB;

        /*public static StaticConstructorDemo(string mm)
        {
            BB = mm;
        }*/
        
        static StaticConstructorDemo()
        {
            BB = "Right";
        }

        public StaticConstructorDemo()
        {
            BB = "Wrong";
        }

        /*public StaticConstructorDemo(string mm)
        {
            this.BB = mm;
        }*/
    }
}

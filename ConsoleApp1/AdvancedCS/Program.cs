using System;
using System.Text;

namespace AdvancedCS
{
    /// <summary>
    /// 字符串初始化之后就不可变
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ///
            /// String方法使用
            ///
            /*StringMethod stringMethod = new StringMethod();
            stringMethod.Compare();
            stringMethod.PrintString("I Love You...");
            stringMethod.Replace();
            stringMethod.Split();*/
            ///
            /// StringBuilder --- 对字符串频繁操作，效率高
            ///
            /*StringBuilderDemo demo = new StringBuilderDemo();
            StringBuilder sb = demo.Creat("www.tencent.com");
            demo.Print(sb);
            sb.Append("/xxx.html");
            demo.Print(sb);
            demo.Insert(0, sb, "http://localhost/");
            demo.Print(sb);
            demo.Replace(".", ":",sb);
            demo.Print(sb);*/
            ///
            /// 正则表达式
            ///





        }
    }
}

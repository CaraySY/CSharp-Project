using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //显式、隐式转换
            byte myByte = 123;
            int myInt = myByte;//小类型->大类型编译器进行自动转换[隐式转换]
            //大类型->小类型编译器进行自动转换[显式转换]
            myByte = (byte)myInt;

            Console.WriteLine(Convert.ToInt32(myByte).ToString());
            /*枚举类型----默认值为整数，需要进行显示转换*/
            EnumDemo demo = EnumDemo.Pause;
            Console.WriteLine("enum=" + (int)demo);
            /*结构体----使用结构体变量，相当于声明了结构体里面所有的变量*/
            StructDemo structDemo;
            structDemo.enemy1X = 12;
            structDemo.enemy1Y = 3.4f;
            structDemo.enemy1Z = 15.6f;
            Console.WriteLine(structDemo.ToString());
            /*数组*/
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            foreach (var item in array)
            {
                Console.Write(" "+item);
            }
            /*字符串的处理*/
            Console.WriteLine("\n----------------------------------");
            String str = "www.baidu.com";
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(" "+str[i]);//使用[]访问指定字符串的每一个值
            }
            Console.WriteLine();
            //相应的方法 Trim()方法对源字符串无影响
            Console.WriteLine(str.ToUpper());//变为大（小）写，对源字符串无影响
            String[] splits = str.Split(".");//将源字符串按照指定字符拆分
            foreach (var item in splits)
            {
                Console.WriteLine(" "+item);
            }
        }
    }
}

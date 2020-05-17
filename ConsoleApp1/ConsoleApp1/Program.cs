/// <summary>
/// 引入命名空间
/// </summary>
using System;

/// <summary>
/// 定义命名空间
/// </summary>
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //字符串格式化
            int a = 3, b = 4;
            Console.WriteLine("first={0},second={1}", a, b);
            // 字符串前面加上@----忽略字符串中的转义字符，出双引号其他转义字符不识别，双引号代表一个引号
            String str1 = "I love you\nChina~";
            String str2 = @"I love you\nChina~";
            // @可以定义多行字符串
            String str3 = @"I love 
            you\nChina~";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            String address1 = "C:\\xxx\\xxx\\xxx.doc";
            //@可以表示一个路径，忽略  \ 
            String address2 = @"C:\xxx\xxx\xxx.doc";
            Console.WriteLine("address1=" + address1 + ",address2=" + address2);
        }
    }
}

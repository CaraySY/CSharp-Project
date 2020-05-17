using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCS
{
    public class StringMethod
    {
        private String str1 = "www.baidu.com";//使用String类型存储字符串类型
        private String str2 = "Hello.World";

        public void Compare()
        {
            if (str1 == "www.baidu.com"&&str1.Equals("www.baidu.com"))
            {
                Console.WriteLine("相同,str1长度="+str1.Length);
            }
            else
            {
                Console.WriteLine("不同,str2长度="+str2.Length);
            }
        }

        public void PrintString(String str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]+" ");
            }
            Console.WriteLine();
        }

        public void Replace()
        {
            String x=str1.Replace(".", ":");//返回一个新的字符串
            String y=str2.Replace(".", ":");
            PrintString(x);
            PrintString(y);
        }

        public void Split()
        {
            String[] s=str1.Split(".");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCS
{
    public class StringBuilderDemo
    {
        /// <summary>
        /// StringBuilder的创建，并且其可变
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public StringBuilder Creat(String str)
        {
            // new StringBuilder(20);初始化一个空的对象，占20字符
            // new StringBuilder("Hello world",100);  创建新的对象，容量为100，超越容量自动扩容 *2
            return new StringBuilder(str,30);
        }

        public void Print(StringBuilder sb)
        {
            Console.WriteLine("str="+sb);
        }

        /// <summary>
        /// 在指定的位置插入字符串
        /// </summary>
        /// <param name="sb"></param>
        public void Insert(int position,StringBuilder sb,String str)
        {
            sb.Insert(position, str);
        }

        public void Replace(String source,String after,StringBuilder sb)
        {
            sb.Replace(source, after);
        }
    }
}

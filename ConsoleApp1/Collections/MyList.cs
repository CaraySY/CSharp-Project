using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    /// <summary>
    /// 自定义泛型列表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyList<T>
    {
        private T[] array;
        private int count;//表示当前元素的个数

        public MyList(int size)
        {
            if (size > 0)
            {
                array = new T[size];
            }
        }

        public MyList()
        {
            array = new T[0];//创建一个空数组
        }

        public int Capacity() //列表容量大小
        {
            return array.Length;
        }
    }
}

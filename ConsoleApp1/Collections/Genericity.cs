using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    /// <summary>
    /// 泛型类和方法
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Genericity<T>  //T 代表一个数据类型
    {
        private T a;
        private T b;

        public Genericity(T a,T b)
        {
            this.a = a;
            this.b = b;
        }

        public String Sum()
        {
            return a + "" + b;  //泛型不能相加减
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
///  比较运算符（如果重载）必须成对重载
///  也就是说，如果重载 ==，也必须重载 !=
///  反之亦然，< 和 > 以及 <= 和 >=
/// </summary>
namespace DotNetCoreDemo.Entity
{
    public class Apple
    {
        private string color;
        private int weight;
        private decimal price;

        public string Color { get => color; set => color = value; }
        public int Weight { get => weight; set => weight = value; }
        public decimal Price { get => price; set => price = value; }

        public static decimal operator + (Apple src,Apple desc)
        {
            return src.price + desc.price;
        }

        public static decimal operator - (Apple src,Apple desc)
        {
            return src.price - desc.price;
        }

        public static bool operator > (Apple src,Apple desc)
        {
            int flag = src.Weight - desc.Weight;
            return flag > 0 ? true : false;
        }        
        
        public static bool operator < (Apple src,Apple desc)
        {
            int flag = src.Weight - desc.Weight;
            return flag < 0 ? true : false;
        }

        //使用[]自定义索引器
        public char this[int i]
        {
            get
            {
                return this.color[i];
            }
        }

        public override string ToString()
        {
            return $"Apple [color={color},weight={weight},price={price}";
        }
    }
}

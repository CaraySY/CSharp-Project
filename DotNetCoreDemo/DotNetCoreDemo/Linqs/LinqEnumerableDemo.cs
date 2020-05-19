using DotNetCoreDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetCoreDemo.Linqs
{
    /// <summary>
    ///  数组和集合可以通过Enumerable.AsEnumerable()直接获取一个序列
    /// </summary>
    public class LinqEnumerableDemo
    {
        /// <summary>
        ///  初始化集合
        /// </summary>
        private static List<Fruit> fruits = new List<Fruit>()
        {
            new Fruit()
            {
                Color="green",
                Price=15.66m,
                Weight=100
            },            
            new Fruit()
            {
                Color="green",
                Price=66.6687m,
                Weight=300
            },            
            new Fruit()
            {
                Color="yellow",
                Price=23.45m,
                Weight=160
            },            
            new Fruit()
            {
                Color="red",
                Price=38.78m,
                Weight=200
            },            
            new Fruit()
            {
                Color="white",
                Price=50.98m,
                Weight=400
            },
        };

        /// <summary>
        ///  使用一些聚合函数
        /// </summary>
        public static void FilterDemo()
        {
            int[] array = { 3, 5, 1, 84, 10 };
            IEnumerable<int> enumerable = array.AsEnumerable();
            double x = array.AsEnumerable().Average();
            int max = array.AsEnumerable().Max();
            int min = array.AsEnumerable().Min();
            Console.WriteLine($"average is {x},max={max},min={min}");
            Console.WriteLine(enumerable.Any(i => i % 2 > 0));
            Console.WriteLine(enumerable.All(i => i > 0));
        }

        /// <summary>
        ///  按照颜色分组
        /// </summary>
        public static void FruitsGroupByColor()
        {
            IEnumerable<IGrouping<string, Fruit>> enumerable = fruits.AsEnumerable().GroupBy(fruit => fruit.Color);
            //遍历 IEnumerable<IGrouping<string, Fruit>>的方法
            // method one:
            Console.WriteLine("按照颜色分组：");
            foreach(IGrouping<string,Fruit> item in enumerable)
            {
                string key = item.Key;
                Console.WriteLine("key=>"+key);
                foreach(Fruit fruit in item)
                {
                    Console.WriteLine(fruit);
                }
            }
            // method two:
            Console.WriteLine("按照颜色分组：");
            enumerable.Select(item => item).ToList().ForEach(term =>
            {
                Console.WriteLine("key=>" + term.Key);
                term.ToList().ForEach(fruit =>
                {
                    Console.WriteLine(fruit);
                });
            });
        }

        public static void FlatCollectionBySelectMany()
        {
            List<List<Fruit>> list = new List<List<Fruit>>();
            List<Fruit> a1 = new List<Fruit>()
            {
                new Fruit()
                {
                    Color="yellow",
                    Price=23.11m,
                    Weight=100
                },                
                new Fruit()
                {
                    Color="pink",
                    Price=34.6m,
                    Weight=160
                },                
                new Fruit()
                {
                    Color="purple",
                    Price=41.11m,
                    Weight=314
                },
            };            
            List<Fruit> a2 = new List<Fruit>()
            {
                new Fruit()
                {
                    Color="yellow",
                    Price=213.11m,
                    Weight=130
                },                
                new Fruit()
                {
                    Color="pink",
                    Price=434.6m,
                    Weight=260
                },                
                new Fruit()
                {
                    Color="purple",
                    Price=461.11m,
                    Weight=140
                },
            };
            list.Add(a1);
            list.Add(a2);
            list.AsEnumerable().SelectMany(item => item).GroupBy(fruit=>fruit.Color)
                .ToList().ForEach(term =>
                {
                    Console.WriteLine("key is " + term.Key);
                    term.ToList().ForEach(res => Console.WriteLine(res));
                });
            Console.WriteLine("Method two=>");
            Enumerable.Concat(a1.AsEnumerable(), a2.AsEnumerable()).GroupBy(fruit => fruit.Color)
                .ToList().ForEach(term =>
                {
                    Console.WriteLine("key is " + term.Key);
                    term.ToList().ForEach(res => Console.WriteLine(res));
                });
        }
    }
}

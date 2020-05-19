using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreDemo.Entity
{
    public class Fruit
    {
        private string color;
        private decimal price;
        private int weight;

        public string Color { get => color; set => color = value; }
        public decimal Price { get => price; set => price = value; }
        public int Weight { get => weight; set => weight = value; }

        public override string ToString()
        {
            return $"Fruit [color={color},price={price},weight={weight}]";
        }
    }
}

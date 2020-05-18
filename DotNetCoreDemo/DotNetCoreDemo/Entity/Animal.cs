using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreDemo.Constructor
{
    public class Animal
    {
        public static string _strText;
        public string _text;

        static Animal()
        {
            _strText = "AnimalAnimalAnimal";
            Console.WriteLine("调用父类的静态构造方法...");
        }

        public Animal()
        {
            this._text = "Animalllllllllllll";
            Console.WriteLine("调用父类的构造方法...");
        }
    }
}

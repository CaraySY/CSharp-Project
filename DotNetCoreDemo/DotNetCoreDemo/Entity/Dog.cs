using DotNetCoreDemo.Constructor;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreDemo.Entity
{
    public class Dog : Animal
    {
        static Dog()
        {
            _strText = "DogDogDog"; //_strText静态变量属于类Animal的，所以自己的静态构造方法不会执行
            Console.WriteLine("调用子类的静态构造方法...");
        }

        public Dog()
        {
            this._text = "Doggggggggg";
            Console.WriteLine("调用子类的构造方法");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented
{
    public class Customer
    {
        private String name;
        private String address;
        private int age;

        public Customer()
        {

        }

        public Customer(String name,String address,int age)
        {
            this.name = name;
            this.address = address;
            this.age = age;
        }

        //public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Age { get => age; set => age = value; }

        public String Name
        {
            set { name = value; }
            get { return name; }
        }

        public override String ToString()
        {
            return String.Format("Name={0}，Address={1},Age={2}", Name, Address, Age);
        }
    }
}

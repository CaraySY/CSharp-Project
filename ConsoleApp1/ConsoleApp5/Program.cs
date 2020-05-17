using System;

namespace ObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "李四";
            customer.Address = "北京市朝阳区";
            customer.Age = 12;
            Console.WriteLine(customer);
            Customer cus = new Customer("王五","南京市",33);
            Console.WriteLine(cus);
            var cu = new Customer();//匿名类型
            Console.WriteLine(cu);
        }
    }
}

using ADONetDemo.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("连接数据库是否成功?"+ConnectionFactory.GetConnection().State);
            /*string str = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            Console.WriteLine(str);
            string x = ConfigurationManager.AppSettings["connStr"];
            Console.WriteLine(x);*/

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace DotNetCoreDemo.Common
{
    public class SqlConnectionStringReader
    {
        /// <summary>
        ///  创建数据库的连接
        /// </summary>
        public void Create()
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            // method1
            SqlConnection conn1 = new SqlConnection();
            conn1.ConnectionString = connStr;
            //method 2
            SqlConnection conn2 = new SqlConnection(connStr);
            conn2.Open();
            Console.WriteLine($"{conn2.Database}");
            Console.WriteLine($"{conn2.DataSource}");

            conn2.Close();
        }

        /// <summary>
        ///  使用连接池
        /// </summary>
        public void UseConnectionPool()
        {

        }
    }
}

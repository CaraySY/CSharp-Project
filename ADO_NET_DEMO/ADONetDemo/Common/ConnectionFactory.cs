using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetDemo.Common
{
    public class ConnectionFactory
    {
        public static SqlConnection GetConnection()
        {
            /*string str = "server=.;database=test;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            return conn;*/
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DotNetCoreDemo.Common
{
    public class DBHelper
    {
        private static readonly string connStr = ConfigurationManager
            .ConnectionStrings["connStr"].ConnectionString;

        public enum SQLStoredType
        {
            Common,
            StoredProcedure
        }

        /// <summary>
        ///  增删改通用方法
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql,int cmdType,params SqlParameter[] parameters)
        {
            int count = 0;
            using (SqlConnection conn=new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmdType == 2)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                if(parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                //打开连接
                conn.Open();
                //执行Sql语句
                count=cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return count;
        }

        /// <summary>
        ///  获取一条记录，其他全部忽略
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql,int cmdType,params SqlParameter[] parameters)
        {
            object count = 0;
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmdType == 2)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                conn.Open();
                count=cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return count;
        }        

        /// <summary>
        ///  使用SqlDataReader读取数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql,int cmdType,params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = null;
            if (cmdType == 2)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            if(parameters!=null && parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
            }
            //没有使用using，需要捕获异常
            try
            {
                conn.Open();
                // CommandBehavior.CloseConnection 当SqlDataReader释放，Connection会自动释放
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                //清空集合的参数
                cmd.Parameters.Clear();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                throw new Exception("Sql 查询出现异常...");
            }
            return reader;
        }

        /// <summary>
        ///  获取一个DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql, int cmdType, params SqlParameter[] parameters)
        {
            //相当于一个微型的数据库，只不过其存储在内存中
            DataSet ds = new DataSet();
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmdType == 2)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                //绑定cmd到SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(ds, "table"); //填充到表名字为table的表
                conn.Close();
            }
            return ds;
        }        

        /// <summary>
        /// 只返回单个表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, int cmdType, params SqlParameter[] parameters)
        {
            //相当于一个微型的数据库，只不过其存储在内存中
            DataTable dt = new DataTable();
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmdType == 2)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                //绑定cmd到SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //提升性能
                conn.Open();
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }
    }
}

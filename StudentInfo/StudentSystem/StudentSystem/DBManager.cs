using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    /// <summary>
    /// 数据操作层
    /// </summary>
    public  class DBManager
    {
        /// <summary>
        /// 添加学生信息
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="sex"></param>
        /// <param name="birth"></param>
        /// <returns></returns>
        public static bool AddStudent(string code,string name,string sex,DateTime birth)
        {
            //限定条件
            if (code.Length < 4 || code.Length > 10) return false;//code  4~10长度
            if (name.Length > 10 || name=="") return false;
            if (sex != "男" && sex != "女" && sex != "未知") return false;
            if (birth > DateTime.Now || birth<new DateTime(1980,1,1)) return false;

            if (string.IsNullOrEmpty(code)) return false;
            try
            {
                string sql = $"insert into student(code,Name,sex,birth) values('{code}','{name}','{sex}','{birth}')";
                DbHelperSQL.connectionString = ParkConfig.ConnectionString;
                return DbHelperSQL.ExecuteSql(sql) > 0 ? true : false;
            }
            catch (Exception ex)
            {
                LogInfo.WriteLog("插入学生信息异常:" + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static bool DelStudent(string code)
        {
            if (string.IsNullOrEmpty(code)) return false;
            try
            {
                string sql = $"delete from student where code='{code}'";
                DbHelperSQL.connectionString = ParkConfig.ConnectionString;
                return DbHelperSQL.ExecuteSql(sql) > 0 ? true : false;
            }
            catch (Exception ex)
            {
                LogInfo.WriteLog("删除学生信息异常:" + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 清空数据
        /// </summary>
        /// <returns></returns>
        public static bool DelAll()
        {
            try
            {
                string sql = $"delete from student ";
                DbHelperSQL.connectionString = ParkConfig.ConnectionString;
                return DbHelperSQL.ExecuteSql(sql) > 0 ? true : false;
            }
            catch (Exception ex)
            {
                LogInfo.WriteLog("清空学生信息异常:" + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 根据学号查询学生信息  （返回结果 1查询成功  0不存在  -1失败）
        /// </summary>
        /// <param name="code">学号</param>
        /// <returns>1查询成功  0不存在  -1失败</returns>
        public static int QueryStudent(string code)
        {
            try
            {
                Student stu = new Student();
                string sql = $"select code,name,sex,birth  from student where code='{code}'";
                DbHelperSQL.connectionString = ParkConfig.ConnectionString;
                DataSet ds = DbHelperSQL.Query(sql);
                if (ds != null)
                {
                    DataTable dt = ds.Tables[0];
                    stu.Code = Convert.ToString(dt.Rows[0][0]);
                    stu.Name = Convert.ToString(dt.Rows[0][1]);
                    stu.Sex = Convert.ToString(dt.Rows[0][2]);
                    stu.Birth = Convert.ToDateTime(dt.Rows[0][3]);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                LogInfo.WriteLog("QueryStudent 异常:" + ex.Message);
                return -1;
            }
        }

        /// <summary>
        /// 添加学生信息
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="sex"></param>
        /// <param name="birth"></param>
        /// <returns>1成功  -1失败  2code异常  3 name异常 4 sex 错误</returns>
        public static int AddStudent2(string code, string name, string sex, DateTime birth,ref string Error)
        {
            int i = 0;
            //限定条件
            if (code.Length < 4 || code.Length > 10)
            {
                Error = "code 异常";
                return 2;//code  4~10长度
            }
            if (name.Length > 10 || name == "") return 3;
            if (sex != "男" && sex != "女" && sex != "未知") return 3;
            if (birth > DateTime.Now || birth < new DateTime(1980, 1, 1)) return 4;

            if (string.IsNullOrEmpty(code)) return 2;
            try
            {
                string sql = $"insert into student(code,Name,sex,birth) values('{code}','{name}','{sex}','{birth}')";
                DbHelperSQL.connectionString = ParkConfig.ConnectionString;
                return DbHelperSQL.ExecuteSql(sql) > 0 ? 1 : -1;
            }
            catch (Exception ex)
            {
                Error = "插入学生信息异常";
                LogInfo.WriteLog("插入学生信息异常:" + ex.Message);
                return -1;
            }
        }

    }

}

using DotNetCoreDemo.Common;
using StuMS.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace StuMS.DAL
{
    public class StudentDao : IStudentDao
    {
        public bool AddStudent(Student student)
        {
            string sql = "insert into student values(@code,@name,@sex,@birth)";
            int flag = DBHelper.ExecuteNonQuery(sql,1,new SqlParameter("@code",student.Code)
                ,new SqlParameter("@name",student.Name),new SqlParameter("@sex",student.Sex),new SqlParameter("@birth",student.Birth));
            return flag > 0 ? true : false;
        }

        public bool DeleteStudent(string code)
        {
            string sql = "delete from student where code=@code";
            int flag = DBHelper.ExecuteNonQuery(sql, 1, new SqlParameter("@code", code));
            return flag > 0 ? true : false;
        }

        public bool UpdateStudent(Student student)
        {
            string sql = "update student set name=@name,sex=@sex,birth=@birth where code=@code";
            int flag = DBHelper.ExecuteNonQuery(sql, 1, new SqlParameter("@code", student.Code)
                , new SqlParameter("@name", student.Name), new SqlParameter("@sex", student.Sex), new SqlParameter("@birth", student.Birth));
            return flag > 0 ? true : false;
        }

        public List<Student> QueryAllStudent()
        {
            List<Student> res = new List<Student>();
            DataSet ds=DBHelper.GetDataSet("select * from student",1);
            DataTable dt=ds.Tables["table"];
            //使用foreach遍历dt的每一列
            foreach (DataRow row in dt.Rows)
            {

                string code = row["code"] as string;
                string name = row["name"] as string;
                string sex = row["sex"] as string;
                DateTime birth = Convert.ToDateTime(row["birth"]);
                res.Add(new Student()
                {
                    Code = code,
                    Name = name,
                    Sex = sex,
                    Birth = birth
                });
            }
            return res.Count > 0 && res!=null ? res : new List<Student>();
        }

        public List<Student> QueryAllStudentToDataTable()
        {
            List<Student> res = new List<Student>();
            DataTable dt = DBHelper.GetDataTable("select * from student", 1);
            foreach(DataRow row in dt.Rows)
            {
                string code = row["code"] as string;
                string name = row["name"] as string;
                string sex = row["sex"] as string;
                DateTime birth = Convert.ToDateTime(row["birth"]);
                res.Add(new Student()
                {
                    Code = code,
                    Name = name,
                    Sex = sex,
                    Birth = birth
                });
            }
            return res.Count > 0 && res != null ? res : new List<Student>();
        }

        public Student QueryOneStudent(string code)
        {
            SqlDataReader reader = DBHelper.ExecuteReader("select * from student where code=@code", 1, new SqlParameter("@code", code));
            Student res = null;
            while (reader.Read())
            {
                string id = reader.GetString("code");
                string name = reader.GetString("code");
                string sex = reader.GetString("sex");
                DateTime birth = reader.GetDateTime("birth");
                res=new Student()
                {
                    Code = id,
                    Name = name,
                    Sex = sex,
                    Birth = birth
                };
            }
            return res ?? new Student();
        }
    }
}

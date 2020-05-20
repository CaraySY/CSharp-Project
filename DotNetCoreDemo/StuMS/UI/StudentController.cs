using StuMS.BLL;
using StuMS.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StuMS.UI
{
    public class StudentController
    {
        private static IStudentService studentService = new StudentService();

        public static void AddStudent()
        {
            Student student = new Student()
            {
                Code="0004",
                Name="马六",
                Sex="女",
                Birth=DateTime.Now
            };
            studentService.AddStudent(student);
        }  
        
        public static void DeleteStudent(string code)
        {
            studentService.DeleteStudent(code);
        }

        public static void UpdateStudent()
        {
            Student student = new Student()
            {
                Code = "0001",
                Name = "赵起鹏",
                Sex = "男",
                Birth = DateTime.Now
            };
            studentService.UpdateStudent(student);
        }

        public static void QueryOneStudent()
        {
            Student student = studentService.QueryOneStudent("0004");
            Console.WriteLine("查询的信息=>"+student);
        }

        public static void QueryAllStudent()
        {
            List<Student> res = studentService.QueryAllStudent();
            Console.WriteLine("查询所有学生的信息=>");
            res.ForEach(Console.WriteLine);
        }
    }
}

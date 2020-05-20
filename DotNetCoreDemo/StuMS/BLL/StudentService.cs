using StuMS.DAL;
using StuMS.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StuMS.BLL
{
    public class StudentService : IStudentService
    {
        private IStudentDao studentDao = new StudentDao();

        public bool AddStudent(Student student)
        {
            return studentDao.AddStudent(student);
        }

        public bool DeleteStudent(string code)
        {
            return studentDao.DeleteStudent(code);
        }

        public List<Student> QueryAllStudent()
        {
            //return studentDao.QueryAllStudentToDataTable();
            return studentDao.QueryAllStudent();
        }

        public Student QueryOneStudent(string code)
        {
            return studentDao.QueryOneStudent(code);
        }

        public bool UpdateStudent(Student student)
        {
            return studentDao.UpdateStudent(student);
        }
    }
}

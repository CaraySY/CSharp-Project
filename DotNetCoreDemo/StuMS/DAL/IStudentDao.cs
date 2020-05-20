using StuMS.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StuMS.DAL
{
    public interface IStudentDao
    {
        public bool AddStudent(Student student);
        public bool DeleteStudent(string code);
        public bool UpdateStudent(Student student);
        public Student QueryOneStudent(string code);
        public List<Student> QueryAllStudent();
        public List<Student> QueryAllStudentToDataTable();
    }
}

using StuMS.Entity;
using System.Collections.Generic;

namespace StuMS.BLL
{
    public interface IStudentService
    {
        public bool AddStudent(Student student);
        public bool DeleteStudent(string code);
        public bool UpdateStudent(Student student);
        public Student QueryOneStudent(string code);
        public List<Student> QueryAllStudent();
    }
}

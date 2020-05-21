using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkPractice.Entity
{
    public class Course
    {
        private int courseID;
        private string courseName;
        //导航属性多对多
        private ICollection<Student> students = new HashSet<Student>();

        public int CourseID { get => courseID; set => courseID = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        //多对多的关系
        public ICollection<Student> Students { get => students; set => students = value; }
    }
}

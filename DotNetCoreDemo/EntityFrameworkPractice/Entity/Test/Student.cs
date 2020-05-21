using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

/// <summary>
///  Student 表和 StudentAddress为一对一关系
/// </summary>
namespace EntityFrameworkPractice.Entity
{
    public class Student
    {
        private int studentID;
        private string studentName;
        private int? standardID; //外键关系，可以为空
        private byte[] rowVersion;
        private StudentAddress studentAddress;
        //实体导航属性
        private ICollection<Course> courses = new HashSet<Course>();

        public int StudentID { get => studentID; set => studentID = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public int? StandardID { get => standardID; set => standardID = value; }
        public byte[] RowVersion { get => rowVersion; set => rowVersion = value; }
        //实体导航属性
        public virtual StudentAddress StudentAddress { get => studentAddress; set => studentAddress = value; }
        public virtual ICollection<Course> Courses { get => courses; set => courses = value; }
    }
}

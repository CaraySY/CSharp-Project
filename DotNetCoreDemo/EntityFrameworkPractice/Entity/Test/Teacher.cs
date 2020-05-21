using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkPractice.Entity
{
    public class Teacher
    {
        private int teacherID;
        private string teacherName;
        private int? teacherType;
        private int? standardID;
        //实体导航属性
        private Standard standard;

        public int TeacherID { get => teacherID; set => teacherID = value; }
        public string TeacherName { get => teacherName; set => teacherName = value; }
        public int? TeacherType { get => teacherType; set => teacherType = value; }
        //外键关系
        public int? StandardID { get => standardID; set => standardID = value; }
        //实体导航
        public Standard Standard { get => standard; set => standard = value; }
    }
}

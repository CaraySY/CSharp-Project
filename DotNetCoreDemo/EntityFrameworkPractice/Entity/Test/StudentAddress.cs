using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkPractice.Entity
{
    public class StudentAddress
    {
        private int? studentID; // 此处为外键关系，在Student为主键
        private string address1;
        private string address2;
        private string city;
        private string state;
        private Student student;

        public int? StudentID { get => studentID; set => studentID = value; }
        public string Address1 { get => address1; set => address1 = value; }
        public string Address2 { get => address2; set => address2 = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        //实体导航属性
        public virtual Student Student { get => student; set => student = value; }
    }
}

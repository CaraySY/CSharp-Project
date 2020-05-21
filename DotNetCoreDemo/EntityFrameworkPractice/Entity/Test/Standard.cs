using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkPractice.Entity
{
    public class Standard
    {
        private int standardID;
        private string standardName;
        private string description;

        //实体导航属性
        private ICollection<Teacher> teachers = new HashSet<Teacher>();

        public int StandardID { get => standardID; set => standardID = value; }
        public string StandardName { get => standardName; set => standardName = value; }
        public string Description { get => description; set => description = value; }
        // 一个标准可以有多个老师
        public virtual ICollection<Teacher> Teachers { get => teachers; set => teachers = value; }
    }
}

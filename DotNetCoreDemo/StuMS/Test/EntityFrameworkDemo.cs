using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity.;
using System.Data.Entity;

namespace StuMS.Test
{
    public class EntityFrameworkDemo
    {
        public static void Add()
        {
            using(DbContext db=new CodeFirstModel())
            {
                Console.WriteLine("");
            }
        }
    }
}

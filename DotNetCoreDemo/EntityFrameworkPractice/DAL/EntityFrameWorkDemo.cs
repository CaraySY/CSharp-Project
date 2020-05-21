using EntityFrameworkPractice.DbContexts;
using EntityFrameworkPractice.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkPractice.DAL
{
    public class EntityFrameWorkDemo
    {
        public static void Add()
        {
            using(MyDbContext context =new MyDbContext())
            {
                Person p = new Person()
                {
                    Id=2,
                    LastName="Fox",
                    FirstName="Netty"
                };
                context.Persons.Add(p);
                context.SaveChanges();
            }
        }
    }
}

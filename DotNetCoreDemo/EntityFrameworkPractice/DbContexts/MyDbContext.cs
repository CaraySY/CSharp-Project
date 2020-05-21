using EntityFrameworkPractice.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace EntityFrameworkPractice.DbContexts
{
    public class MyDbContext : DbContext
    {
        //建立实体和数据库的关系
        public DbSet<Person> Persons { get; set; }

        /// <summary>
        ///  配置连接数据库
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
        }
    }
}

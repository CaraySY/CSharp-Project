using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Tests
{
    [TestClass()]
    public class DBManagerTests
    {
        [TestMethod()]
        public void AddStudentTest()
        {
            Assert.IsTrue(DBManager.AddStudent("0001", "张三", "男", new DateTime(2000, 1, 1)));//正确,再执行一次报错

            //学号 要求 4~10位
            Assert.IsTrue(DBManager.AddStudent("0002", "张三", "男", new DateTime(2000, 1, 1)));//code位数不足
            Assert.IsTrue(DBManager.AddStudent("0123456789", " 张三", "男", new DateTime(2000, 1, 1)));//code位数超出
            Assert.IsTrue(DBManager.AddStudent("0003", "张三", "男", new DateTime(2000, 1, 1)));//学号不能为空

            //姓名  要求10个字符(包含)以下
            Assert.IsTrue(DBManager.AddStudent("88881", "李四", "男", new DateTime(2018, 1, 1)));//名字不能为空
            Assert.IsTrue(DBManager.AddStudent("0004", "张三李四王五周六朝气", "男", new DateTime(2000, 1, 1)));//名字 超过10位
            Assert.IsTrue(DBManager.AddStudent("8888", "张三", "男", new DateTime(2000, 1, 1)));//名字 非法字符


            //性别 男  女 未知
            Assert.IsTrue(DBManager.AddStudent("0005", "张三", "未知", new DateTime(2000, 1, 1)));//性别 Man

            //出入日期
            Assert.IsTrue(DBManager.AddStudent("0006", "张三", "男", new DateTime(2018, 11, 1)));//出入日期 大于当前
            Assert.IsTrue(DBManager.AddStudent("0007", "张三", "男", new DateTime(1999, 11, 1)));//出入日期小于当前

            Assert.IsTrue(DBManager.AddStudent("00017", "张三", "男", new DateTime(1989, 11, 1)));//编号重复  出入日期小于当前

        }

        [TestMethod()]
        public void DelStudentTest()
        {
            Assert.IsTrue(DBManager.DelStudent("0001"));//正确
            //Assert.IsTrue(DBManager.DelStudent(""));//学号不能为空
            //Assert.IsTrue(DBManager.DelStudent("00015'"));//非法字符
            //Assert.IsTrue(DBManager.DelStudent("00015123456789"));//过长

        }

        [TestMethod()]
        public void QueryStudentTest()
        {
            Assert.IsTrue(DBManager.QueryStudent("0001") == 0);
            //Assert.IsTrue(DBManager.QueryStudent("00015") == 1);
            //Assert.IsTrue(DBManager.QueryStudent("0001'") == 1);

        }

        [TestMethod()]
        public void DelAllTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddStudent2Test()
        {
            string err=string.Empty;
            int re = DBManager.AddStudent2("01", "男", "男", new DateTime(2000, 1, 1),ref err);

            Assert.IsTrue(re==1);
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    /// <summary>
    /// 配置信息类
    /// </summary>
    public static class ParkConfig
    {
        /// <summary>
        /// e7服务地址
        /// </summary>
        public static string APIServer { set; get; }

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static string ConnectionString { set; get; } = "server=192.168.8.29;database=E7_8120;uid=sa;pwd=123456";

        /// <summary>
        /// 项目编号 GID
        /// </summary>
        public static string Gid { set; get; }

    }

    public class Student
    {
        public string Code { set; get; }
        public string Name { set; get; }
        public string Sex { set; get; }
        public DateTime Birth { set; get; }
    }

}

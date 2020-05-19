using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace StudentSystem
{
    public class LogInfo
    {
        /// <summary>写入日志
        /// 写入log文件夹下
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool WriteLog(string msg)
        {
            string fileName = $"{AppDomain.CurrentDomain.BaseDirectory}\\log\\{DateTime.Now.ToString("yyyy年MM月")}";

            try
            {
                if (!System.IO.Directory.Exists(fileName))
                {
                    System.IO.Directory.CreateDirectory(fileName);
                }


                fileName += "\\" + DateTime.Now.ToString("yyyyMMdd") + ".log";

                //追加消息内容
                System.IO.File.AppendAllText(fileName, DateTime.Now.ToString() + "\t" + msg + "\r\n", System.Text.Encoding.GetEncoding("GB2312"));

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>写入日志
        /// 写入log文件夹下
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="dir"></param>
        /// <returns></returns>
        public static bool WriteLog(string msg, string dir)
        {
           
            string fileName = Application.StartupPath + "\\" + dir;
            try
            {
                if (!System.IO.Directory.Exists(fileName))
                {
                    System.IO.Directory.CreateDirectory(fileName);
                }

                string filePath = fileName + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".log";
                //追加消息内容
                System.IO.File.AppendAllText(filePath, DateTime.Now.ToString() + "\t" + msg + "\r\n", Encoding.GetEncoding("GB2312"));

                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        delegate void SetListViewCallBack(string funName, string msg, int msgstate);
        /// <summary>
        /// 列表显示相关信息
        /// </summary>
        /// <param name="funName"></param>
        /// <param name="msg"></param>
        /// <param name="msgstate"></param>
        private void ShowInfo(string funName, string msg, int msgstate = 0)
        {
            if (listView1.InvokeRequired)
            {
                SetListViewCallBack slvcb = new SetListViewCallBack(ShowInfo);
                this.Invoke(slvcb, new object[] { funName, msg, msgstate });
            }
            else
            {
                if (listView1.Items.Count > 5000)
                    listView1.Items.RemoveAt(5000);
                listView1.Items.Insert(0, new ListViewItem(new string[] { DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "【" + funName + "】" + msg }));
                LogInfo.WriteLog($"{funName}:{msg}");
                if (msgstate == 0)
                    listView1.Items[0].SubItems[0].ForeColor = System.Drawing.Color.Green;
                else
                    listView1.Items[0].SubItems[0].ForeColor = System.Drawing.Color.Red;
            }
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtName.Text.Trim();
            string sex = cmbSex.Text;
            DateTime birth = dtpBirth.Value;
            bool b = DBManager.AddStudent(code, name, sex, birth);
            string info = b ? "成功" : "失败";
            ShowInfo("新增数据", $"插入数据{info}", b==true?0:1);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            bool b = DBManager.DelStudent(code);
            string info = b ? "成功" : "失败";
            ShowInfo("删除数据", $"删除数据{info}", b == true ? 0 : 1);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            int intQ = DBManager.QueryStudent(code);
            string info = intQ == -1 ? "失败" : (intQ == 0 ? "不存在" : "成功");
            ShowInfo("查询数据", $"查询数据{info}", intQ == 1 ? 0 : 1);
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            ReadConfig();
            txtCode.Text = "0001";
            txtName.Text = "张三";
            dtpBirth.Value = new DateTime(1998, 10, 1);
            cmbSex.SelectedIndex = 0;
        }

        /// <summary>
        /// 读取基础信息
        /// </summary>
        public void ReadConfig()
        {
            ParkConfig.ConnectionString = AppconfigManager.GetConfigValue("ConnectionString");
        }

        private void FrmStudent_Resize(object sender, EventArgs e)
        {
            panel3.Top = panel1.Top;
            panel3.Left = (panel1.Width - panel3.Width) / 2;
            listView1.Columns[1].Width = listView1.Width - listView1.Columns[0].Width - 10;
        }

        private void FrmStudent_Activated(object sender, EventArgs e)
        {
            txtCode.Focus();
        }

        /// <summary>
        /// 批量插入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBatchAdd_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Student stu = new Student();
            int count = 500;
            for (int i = 0; i <count; i++)
            {
                stu.Code = (20000 + i).ToString().PadLeft(5, '0');
                stu.Name = "张三" + i.ToString();
                stu.Sex = "男";
                stu.Birth = new DateTime(2000, 1, 1);
                bool b=DBManager.AddStudent(stu.Code, stu.Name, stu.Sex, stu.Birth);
                ShowInfo("批量插入数据", $"[{stu.Code}][{stu.Name}][{stu.Sex}][{stu.Birth}] 插入{b}",b==true?0:1);
                Application.DoEvents();
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            ShowInfo("批量插入数据", $"插入{count}条数据，耗时{ts.TotalMilliseconds}毫秒");

        }

        private void ss(int Start)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Student stu = new Student();
            int count =Start+ 500;
            for (int i = 0; i < count; i++)
            {
                stu.Code = (20000 + i).ToString().PadLeft(5, '0');
                stu.Name = "张三" + i.ToString();
                stu.Sex = "男";
                stu.Birth = new DateTime(2000, 1, 1);
                bool b = DBManager.AddStudent(stu.Code, stu.Name, stu.Sex, stu.Birth);
                ShowInfo("批量插入数据", $"[{stu.Code}][{stu.Name}][{stu.Sex}][{stu.Birth}] 插入{b}", b == true ? 0 : 1);
                Application.DoEvents();
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            ShowInfo("批量插入数据", $"插入{count}条数据，耗时{ts.TotalMilliseconds}毫秒");
        }

        private void swws()
        {
            
            var tsak1= Task.Run(() => ss(1000));
            var tsak2 = Task.Run(() => ss(1500));
            var tsak3 =Task.Run(() => ss(2000));
            Task.WaitAll(tsak1, tsak2, tsak3);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bool b = DBManager.DelAll();
            ShowInfo("删除所有", $"删除所有数据{b}", b==true?0:1);

        }

        /// <summary>
        /// 高并发插入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHighCon_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Student stu = new Student();
            int count = 1000;
            for (int i = 0; i < count; i++)
            {
                //ThreadPool.QueueUserWorkItem(f => { ProcessAddStu(i); });

                //创建线程  主线程
                Thread Th = new Thread(delegate ()
                {
                    ProcessAddStu(i);
                });

                //启动线程
                Th.Start();

                //Task task = new Task(() => { ProcessAddStu(i); });
                //task.Start();
                ////task.Wait();
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            ShowInfo("并发插入数据", $"插入{count}条数据，耗时{ts.TotalMilliseconds}毫秒");
        }

        private void ProcessAddStu(int i)
        {
            Student stu = new Student();
            stu.Code = (50000 + i).ToString().PadLeft(5, '0');
            stu.Name = "张三" + i.ToString();
            stu.Sex = "男";
            stu.Birth = new DateTime(2000, 1, 1);
            bool b = DBManager.AddStudent(stu.Code, stu.Name, stu.Sex, stu.Birth);
            ShowInfo("并发插入数据", $"[{stu.Code}][{stu.Name}][{stu.Sex}][{stu.Birth}] 插入{b}", b == true ? 0 : 1);
        }
    }
}

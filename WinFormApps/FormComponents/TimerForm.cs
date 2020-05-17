using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormComponents
{
    public partial class ProgressBarFormrForm : Form
    {
        public ProgressBarFormrForm()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //dtPicker.Value = DateTime.Now;
            //使用代码创建一个System.Timers.Timer

            
        }

        private void UpdateTime()
        {
            dtPicker.Value = DateTime.Now;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            int counter = 0; //定义计时器停止标志

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += (send, msg) => //使用Lambda表达式绑定事件
            {
                //定义委托
                Action action = UpdateTime;
                //执行该委托修改dateTimePicker的值
                this.dtPicker.Invoke(action);
                counter++;
                if (counter > 10)
                {
                    System.Timers.Timer stopTimer = (System.Timers.Timer)send;
                    stopTimer.Stop();
                }
            };
            timer.Interval = 1000;
            timer.Start();
            int num = 0;
            System.Threading.Timer timer2 = new System.Threading.Timer(
                new System.Threading.TimerCallback((para)=>
                {
                    num=num+2;
                    Action act = () => tbCount.Text = num + "";
                    this.tbCount.Invoke(act);
                }),
                null,//参数 s
                100, //延迟时间
                1_000); //间隔时间-----参数小于等于0只会触发一次
            //Change方法会让定时器重新启动
            //timer2.Change(200, 3_000);
        }
    }
}

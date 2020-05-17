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
    public partial class ProgressBarForm : Form
    {
        public ProgressBarForm()
        {
            InitializeComponent();
        }

        private void ProgressBarForm_Load(object sender, EventArgs e)
        {
            //初始化数据
            proBar.MarqueeAnimationSpeed = 1_000; //动画速度
            proBar.Style = ProgressBarStyle.Blocks;
            proBar.Maximum = 100;
            proBar.Minimum = 0;
            proBar.Value = 0;
            proBar.Step = 10;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (tbContent.Text.Trim() != "")
            {
                //使用文本框指定的大小去设置最大长度
                int max = Convert.ToInt32(tbContent.Text.Trim());
                //清零
                proBar.Maximum = 0;
                proBar.Maximum = max;
            }
                timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (proBar.Value < proBar.Maximum)
            {
                proBar.PerformStep();//执行进度条的动画
                lbShow.Text = proBar.Value.ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("加载完成...");
                //结束定时器
            }
        }
    }
}

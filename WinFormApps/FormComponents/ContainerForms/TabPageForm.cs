using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormComponents.ContainerForms
{
    public partial class TabPageForm : Form
    {
        public TabPageForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  切换选项卡的时候触发该事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
             TabControl tabControl = sender as TabControl;
            int index = tabControl.SelectedIndex;
            if (index == 0)
            {
                MessageBox.Show("this is page one");
            }else if (index == 1)
            {
                MessageBox.Show("this is page Two");
            }
        }
    }
}

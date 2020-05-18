using FormComponents.RemainForms.Classes;
using FormComponents.RemainForms.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormComponents.RemainForms
{
    public partial class CreateMenuStripByCodeForm : Form
    {
        public CreateMenuStripByCodeForm()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miStudentAdd_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            //不能使用Form.Show()方法在Mdi容器中显示回话框 Form.ShowDialog();
            studentForm.MdiParent = this;//将当前窗体的父MDI容器设置为当前DMIContainer
            studentForm.Show();
        }

        private void miClassAdd_Click(object sender, EventArgs e)
        {
            ClassesForm classesForm = new ClassesForm();
            classesForm.MdiParent = this;
            classesForm.Show();
        }

        /// <summary>
        ///  实现鼠标滑动的过程能够显示菜单栏信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateMenuStripByCodeForm_Load(object sender, EventArgs e)
        {
            //主窗体初始化时就绑定鼠标滑动事件
            menuStu.Items[0].MouseHover += CreateMenuStripByCodeForm_MouseHover; 
        }

        /// <summary>
        ///  判断sender是否为ToolStripMenuItem 对象，是的话就显示下拉列表实现鼠标滑动显示子菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateMenuStripByCodeForm_MouseHover(object sender, EventArgs e)
        {
            if(sender is ToolStripMenuItem)
            {
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                if(item.HasDropDownItems && !item.DropDown.Visible)
                {
                    item.ShowDropDown();
                }
            }
        }
    }
}

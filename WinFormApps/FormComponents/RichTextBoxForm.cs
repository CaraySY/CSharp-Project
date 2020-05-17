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
    public partial class RichTextBoxForm : Form
    {
        public RichTextBoxForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            richTB.LoadFile(@"E:\AdminController.txt",
            //指定文件流
             RichTextBoxStreamType.PlainText
            );
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            richTB.SaveFile(@"E:\Yes.txt", RichTextBoxStreamType.PlainText);
            MessageBox.Show("保存成功~");
        }

        private void richTB_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            //打开一个会话，处理超链接
            System.Diagnostics.Process.Start(e.LinkText);
        }

        /// <summary>
        /// 使用剪切板进行图片的显示关闭等操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsertImg_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            // 获取图片流
            Image img=Image.FromFile(@"E:\girl.png");
            // 将图片粘贴到剪切板
            Clipboard.SetImage(img);
            // 富文本粘贴
            richTB.Paste();
        }

        private void btnStrong_Click(object sender, EventArgs e)
        {
            Font oldFont = richTB.SelectionFont;
            Font newFont = oldFont.Bold ? new Font(oldFont, oldFont.Style & ~FontStyle.Bold) :
                new Font(oldFont, oldFont.Style | FontStyle.Bold);
            richTB.SelectionFont = newFont;
            //显示选择光标
            richTB.Focus();
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            richTB.SelectionAlignment = richTB.SelectionAlignment == HorizontalAlignment.Center ? 
                HorizontalAlignment.Left : HorizontalAlignment.Center;
            richTB.Focus();
        }
    }
}

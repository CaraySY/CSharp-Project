using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormComponents
{
    public partial class ImgListForm : Form
    {
        public ImgListForm()
        {
            InitializeComponent();
        }

        private void ImgListForm_Load(object sender, EventArgs e)
        {
            string path = @"E:\imgs";
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                if (files.Length > 0)
                {
                    string[] fileType = new string[] { ".jpg", ".png" };
                    foreach (string name in files)
                    {
                        if (fileType.Contains(Path.GetExtension(name)))
                        {
                            string key = Path.GetFileNameWithoutExtension(name);
                            MessageBox.Show(key);
                            imgList.Images.Add(key, Image.FromFile(name));
                        }
                    }
                }
            }
            imgList.ImageSize = new Size(30, 30);
            label1.ImageIndex = 2;
        }
    }
}

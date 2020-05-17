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
    public partial class UseListView : Form
    {
        //存储图片和其下标顺序
        private Dictionary<int, string> dictionary = new Dictionary<int, string>();

        public UseListView()
        {
            InitializeComponent();
        }

        private void UseListView_Load(object sender, EventArgs e)
        {
            //默认以大图标的方式显示在ListView中
            lsViewShow.Items.Clear();
            //不显示组
            lsViewShow.ShowGroups = false;
            //加载图片到ImageList中
            LoadImgList();
            if (imgListHuge != null && imgListHuge.Images.Count > 0)
            {
                //开始添加ListViewItem
                for(int i = 0; i < imgListHuge.Images.Count; i++)
                {
                    string txt = imgListHuge.Images.Keys[i];
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;
                    item.Text = txt;
                    //添加到项集合中
                    lsViewShow.Items.Add(item);
                }
            }
            //设置视图的模式
            lsViewShow.View = View.LargeIcon;
            //加载图像列表
            lsViewShow.SmallImageList = imgListSmall;
            lsViewShow.LargeImageList = imgListHuge;
        }

        private void LoadImgList()
        {
            string path = @"E:\imgs";
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                if (files.Length > 0)
                {
                    string[] type = new string[] { ".jpg", ".png" };
                    //清空集合
                    imgListSmall.Images.Clear();
                    imgListHuge.Images.Clear();
                    int index = 0; //字典序列
                    foreach(string name in files)
                    {
                        if (type.Contains(Path.GetExtension(name)))
                        {
                            //获取无扩展的文件名作为imglist的key
                            string keyName = Path.GetFileNameWithoutExtension(name);
                            //使用文件名获取图像流
                            Image img = Image.FromFile(name);
                            //大、小图像列表初始化
                            imgListHuge.Images.Add(keyName, img);
                            imgListSmall.Images.Add(keyName, img);
                            //存入字典中
                            dictionary.Add(index++, name);
                        }
                    }
                    //设置大小图片显示
                    imgListHuge.ImageSize = new Size(50, 70);
                    imgListSmall.ImageSize = new Size(30, 30);
                }
            }
        }

        /// <summary>
        ///  大图标视图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSmall_Click(object sender, EventArgs e)
        {
            lsViewShow.View = View.SmallIcon;
        }

        /// <summary>
        ///  小图标视图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHuge_Click(object sender, EventArgs e)
        {
            lsViewShow.View = View.LargeIcon;
        }

        /// <summary>
        ///  列表视图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnList_Click(object sender, EventArgs e)
        {
            lsViewShow.View = View.List;
        }

        /// <summary>
        ///  Tile视图模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTitle_Click(object sender, EventArgs e)
        {
            lsViewShow.View = View.Tile;
        }

        /// <summary>
        ///  详细信息视图---重点-----与列有关，有列标题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetail_Click(object sender, EventArgs e)
        {
            lsViewShow.Items.Clear();
            lsViewShow.Columns.Clear();
            //lsViewShow.ShowGroups = false;
            /*   Init data   */
            //添加列
            lsViewShow.Columns.Add("文件名", 100, HorizontalAlignment.Left);
            lsViewShow.Columns.Add("修改日期", 150, HorizontalAlignment.Left);
            lsViewShow.Columns.Add("类型", 80, HorizontalAlignment.Left);
            lsViewShow.Columns.Add("大小", 60, HorizontalAlignment.Left);
            //添加项
            for(int i = 0; i < dictionary.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                //获取图片的名字并设置项的名字
                item.Text = imgListSmall.Images.Keys[i];
                item.ImageIndex = i;
                //获取文件创建的时间
                item.SubItems.Add(File.GetCreationTime(dictionary[i]).ToString()
                    );
                //获取文件扩展名
                item.SubItems.Add(Path.GetExtension(dictionary[i]));
                //获取文件的大小--B
                long len = new FileInfo(dictionary[i]).Length;
                //设置大小为KB
                item.SubItems.Add((len / 1024) + " KB");
                //添加到ListView控件中
                lsViewShow.Items.Add(item);
            }
            lsViewShow.GridLines = true;//显示网格
            //显示数据
            lsViewShow.View = View.Details;
        }

        /// <summary>
        ///  分组显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGroup_Click(object sender, EventArgs e)
        {
            lsViewShow.ShowGroups = true;
            //添加组
            lsViewShow.Groups.Clear();
            lsViewShow.Groups.Add(new ListViewGroup("花", HorizontalAlignment.Center));
            lsViewShow.Groups.Add(new ListViewGroup("动物", HorizontalAlignment.Center));
            lsViewShow.Groups.Add(new ListViewGroup("人物", HorizontalAlignment.Center));
            lsViewShow.Groups.Add(new ListViewGroup("风景", HorizontalAlignment.Center));
            //使用字典映射组名和数字的关系
            Dictionary<string, string> dicGroup = new Dictionary<string, string>();
            dicGroup.Add("花", "02");
            dicGroup.Add("动物", "01");
            dicGroup.Add("人物", "03");
            dicGroup.Add("风景", "04");
            //开始分组
            //遍历ListView中的项
            for(int i = 0; i < lsViewShow.Items.Count; i++)
            {
                //遍历项中的组，找到满足的并分组
                foreach(ListViewGroup group in lsViewShow.Groups)
                {
                    // 判断item的名字的前两位是否等于字典中groupName-编号
                    if (lsViewShow.Items[i].Text.Substring(0, 2) == dicGroup[group.Header])
                    {
                        lsViewShow.Items[i].Group = group; //重新分组
                        break; //退出循环
                    }
                }
            }
        }
    }
}

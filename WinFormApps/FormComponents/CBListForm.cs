using FormComponents.Entity;
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
    public partial class CBListForm : Form
    {
        public CBListForm()
        {
            InitializeComponent();
        }

        private void CBListForm_Load(object sender, EventArgs e)
        {
            cbo1.Items.Clear(); // clear all data
            cbo1.Items.Add(12);
            cbo1.Items.Add(true);
            cbo1.Items.Add("Hello World...");
            cbo1.Items.Add(9.15);
            cbo1.Items.Add("You bitch");
            cbo1.SelectedIndex = 0;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int index=cbo1.SelectedIndex;
            // can remove any element
            cbo1.Items.RemoveAt(index);
            // use BeginUpdate() - EndUpdate()
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbo1.Items.Clear();
            cbo1.BeginUpdate();
            List<UserInfo> userInfos = new List<UserInfo>()
            {
                new UserInfo()
                {
                    Id=1,
                    Name="刘德华"
                },
                new UserInfo()
                {
                    Id=2,
                    Name="赵瑞"
                },
                new UserInfo()
                {
                    Id=3,
                    Name="杨幂"
                },
                new UserInfo()
                {
                    Id=4,
                    Name="曹静"
                },
                new UserInfo()
                {
                    Id=5,
                    Name="刘恺威"
                },
            };
            cbo1.DataSource = userInfos;
            cbo1.EndUpdate();
            // must be specify to show info
            cbo1.DisplayMember = "Name";
            cbo1.ValueMember = "Name";
        }

        private void btnDSDel_Click(object sender, EventArgs e)
        {
            int index = cbo1.SelectedIndex;
            List<UserInfo> list = cbo1.DataSource as List<UserInfo>;
            list.RemoveAt(index);
            cbo1.DataSource = null;
            cbo1.DataSource = list;
            // must be specify to show info
            cbo1.DisplayMember = "Name";
            cbo1.ValueMember = "Name";
        }

        private void cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbo1.SelectedItem.ToString());
        }
    }
}

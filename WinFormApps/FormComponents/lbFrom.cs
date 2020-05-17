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
using static System.Windows.Forms.ListBox;

namespace FormComponents
{
    public partial class lbForm : Form
    {
        public lbForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((listBox1.SelectedValue.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectedObjectCollection items = listBox1.SelectedItems; 
            foreach(UserInfo item in items)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void lbForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
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
            // use DataSource init ListBox but it can't modifiy
            /*listBox1.DataSource = userInfos;*/
            // specify property of entity
            BindingSource bs = new BindingSource();
            bs.DataSource = userInfos;
            listBox1.DataSource = bs;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Name";
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            SelectedIndexCollection selectedIndices = listBox1.SelectedIndices;
            // can select one or more
            foreach(int i in selectedIndices)
            {
                MessageBox.Show("选择第"+i+"项");
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            // DataSource can't modified because it's readonly
            //listBox1.Items.RemoveAt(2);
            /*listBox1.Items.Add(new UserInfo()
            {
                Id=0,
                Name="李彦龙"
            });*/

            /*List<UserInfo> newList = listBox1.DataSource as List<UserInfo>;
            // must be set DataSource = null
            listBox1.DataSource = null;
            listBox1.DataSource = newList;*/
            // muse be set null
            BindingSource newBS = listBox1.DataSource as BindingSource;
            List<UserInfo> newList=newBS.DataSource as List<UserInfo>;
            newList.Add(new UserInfo()
            {
                Id = 999,
                Name="赵日天"
            }) ;
            listBox1.DataSource = null;
            listBox1.DataSource = newBS;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Name";
        }

        private void DelteBtn_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            BindingSource bs = listBox1.DataSource as BindingSource;
            List<UserInfo> newList = bs.DataSource as List<UserInfo>;
            newList.RemoveAt(index);
            listBox1.DataSource = null;
            listBox1.DataSource = bs;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Name";
        }
    }
}

using DotNetCoreDemo.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormComponents.DataDisplayForms
{
    public partial class DataGridViewBindDataSource : Form
    {
        public DataGridViewBindDataSource()
        {
            InitializeComponent();
        }

        private void DataGridViewBindDataSource_Load(object sender, EventArgs e)
        {
            string sql = "select * from student";
            //string sql="select code as 编号 ,name 名字,Sex as 性别,birth 生日 from student";
            DataTable dt = DBHelper.GetDataTable(sql, 1);
            // 在绑定数据源之前取消自动创列
            dgvShow.AutoGenerateColumns = false;
            dgvShow.DataSource = dt;
            // 没有事先手动添加列
            //dgvShow.AutoGenerateColumns = true;
            // 1、解决中文标题的问题 -- as 起别名
            // 2、使用手动添加列
            // 不让DataGridView创建列
        }
    }
}

using DotNetCoreDemo.Common;
using FormComponents.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///  使用DataTable --List列表 行=>对象 多行=>List集合
///  //SqlDataReader ---读取过程，需要占用连接，适用数据量较小
/// </summary>
namespace FormComponents.DataDisplayForms
{
    public partial class DataGridViewBindList : Form
    {
        public DataGridViewBindList()
        {
            InitializeComponent();
        }

        private void DataGridViewBindList_Load(object sender, EventArgs e)
        {
            string sql = "select * from student";
            SqlDataReader reader = DBHelper.ExecuteReader(sql, 1);
            List<Student> res = new List<Student>();
            if(reader == null) { throw new Exception("查询出错"); }
            while (reader.Read())
            {
                string code= reader["code"] as string;
                string name= reader["name"] as string;
                string sex= reader["sex"] as string;
                DateTime birth = Convert.ToDateTime(reader["birth"]);
                res.Add(new Student()
                {
                    Code=code,
                    Name=name,
                    Sex=sex,
                    Birth=birth
                });
            }
            reader.Close();
            //绑定到DataGridView
            dgvShow.DataSource = res;
        }

        /// <summary>
        ///  适用DataTable绑定对象，适用DataGridView.Rows[index].DataBoundItem 获取到DataRow 而不是对象
        ///   如果对数据进行修改，必须断开数据源和DataGridView的关系 设置为空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetObj_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(tbGetNum.Text.Trim());
            MessageBox.Show("获取到第" + index + "行的对象信息");
            // 绑定List集合的，获取指定的对象
            Student stu = dgvShow.Rows[index].DataBoundItem as Student;
            MessageBox.Show(stu.ToString());
        }
    }
}

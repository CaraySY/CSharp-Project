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

namespace FormComponents.DataDisplayForms
{
    public partial class DataGridView2ComboxBindDSForm : Form
    {
        public DataGridView2ComboxBindDSForm()
        {
            InitializeComponent();
        }

        private void DataGridView2ComboxBindDSForm_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetDataTable("select * from department",1);
            DataGridViewComboBoxColumn cmb = dgvShow.Columns["dept"] as DataGridViewComboBoxColumn;
            cmb.DataSource = dt;
            cmb.DisplayMember = "dept";
            cmb.ValueMember = "dept";

            string sql = "select * from student";
            SqlDataReader reader = DBHelper.ExecuteReader(sql, 1);
            List<Student> res = new List<Student>();
            if (reader == null) { throw new Exception("查询出错"); }
            while (reader.Read())
            {
                string code = reader["code"] as string;
                string name = reader["name"] as string;
                string sex = reader["sex"] as string;
                DateTime birth = Convert.ToDateTime(reader["birth"]);
                res.Add(new Student()
                {
                    Code = code,
                    Name = name,
                    Sex = sex,
                    Birth = birth
                });
            }
            reader.Close();
            //绑定到DataGridView
            dgvShow.DataSource = res;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(dgvShow.Rows.Count > 0) //如果存在数据
            {
                List<Student> delStus = new List<Student>();
                for (int i = 0; i < dgvShow.Rows.Count; i++)
                {
                    //获取第i行指定的单元格
                    DataGridViewCheckBoxCell cell = dgvShow.Rows[i].Cells["ckbDel"] as DataGridViewCheckBoxCell;
                    // FormattedValue -- 获取单元格显示的值
                    if (cell.FormattedValue.ToString().Equals("True"))
                    {
                        //获取第i行的整个数据对象
                        Student stu = dgvShow.Rows[i].DataBoundItem as Student;
                        delStus.Add(stu);
                    }

                }
                if (delStus.Count > 0)
                {
                    MessageBox.Show("删除数据...");
                }
                else
                {
                    MessageBox.Show("请选择要删除的数据...");
                }
            }
        }
    }
}

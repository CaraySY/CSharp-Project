using DotNetCoreDemo.Common;
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
    public partial class DataGirdViewCRUDForm : Form
    {
        public DataGirdViewCRUDForm()
        {
            InitializeComponent();
        }

        private void DataGirdViewCRUDForm_Load(object sender, EventArgs e)
        {
            string sql = "select * from student";
            DataTable dt = DBHelper.GetDataTable(sql, 1);
            dgvShow.AutoGenerateColumns = false;
            dgvShow.DataSource = dt;
        }

        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 使用 DataGridViewCellEventArgs 获取指定行、列的单元格信息
            DataGridViewCell cell = dgvShow.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.FormattedValue.ToString().Equals("删除"))
            {
                DataRow dr = (dgvShow.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;
                dr.Delete();//删除行
                //MessageBox.Show(dr.ItemArray[0].ToString()); //获取行数据
                //MessageBox.Show(dr.ToString());
            }
        }

        /// <summary>
        ///  使用SqlCommandBuilder Adapter自动配置要执行操作命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn=new SqlConnection("server=127.0.0.1;database=Hello;uid=sa;pwd=123456"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from student", conn);
                //使用SqlCommandBuilder更新数据库
                //---使用系统自带的SqlCommandBuilder SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                // 手动为SqlDataAdapter配置增删改命令
                /// 配置insert cmd
                string sqlInsert = "insert into student(code,name,sex,birth) " +
                    "values(@code,@name,@sex,@birth)";
                SqlCommand insertCmd = new SqlCommand(sqlInsert, conn);
                SqlParameter[] paras =
                {
                    new SqlParameter("@code",SqlDbType.VarChar,50,"code"),
                    new SqlParameter("@name",SqlDbType.VarChar,50,"name"),
                    new SqlParameter("@sex",SqlDbType.VarChar,10,"sex"),
                    new SqlParameter("@birth",SqlDbType.DateTime,50,"birth"),
                };
                insertCmd.Parameters.Clear();
                //绑定到InsertCommond
                insertCmd.Parameters.AddRange(paras);
                adapter.InsertCommand = insertCmd;
                ///                
                /// 配置insert cmd
                string sqlUpdate = "update student set name=@name,sex=@sex,birth=@birth where code=@code ";
                SqlCommand updateCmd = new SqlCommand(sqlUpdate, conn);
                SqlParameter[] paras2 =
                {
                    new SqlParameter("@code",SqlDbType.VarChar,50,"code"),
                    new SqlParameter("@name",SqlDbType.VarChar,50,"name"),
                    new SqlParameter("@sex",SqlDbType.VarChar,10,"sex"),
                    new SqlParameter("@birth",SqlDbType.DateTime,50,"birth"),
                };
                updateCmd.Parameters.Clear();
                //绑定到UpdateCommond
                updateCmd.Parameters.AddRange(paras2);
                adapter.UpdateCommand = updateCmd;
                ///                
                /// 配置 delete cmd
                string sqlDelete = "delete from student where code=@code ";
                SqlCommand deleteCmd = new SqlCommand(sqlDelete, conn);
                SqlParameter[] paras3 =
                {
                    new SqlParameter("@code",SqlDbType.VarChar,50,"code")
                };
                deleteCmd.Parameters.Clear();
                //绑定到InsertCommond
                deleteCmd.Parameters.AddRange(paras3);
                adapter.DeleteCommand = deleteCmd;
                ///
                DataTable dt = dgvShow.DataSource as DataTable;
                ///---------------------执行对数据库的更新操作 
                int flag = adapter.Update(dt);
                MessageBox.Show(flag > 0 ? "更新成功~":"更新失败~");
            }
        }
    }
}

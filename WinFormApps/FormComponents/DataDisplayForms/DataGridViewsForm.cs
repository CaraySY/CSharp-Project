using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormComponents.DataDisplayForms
{
    public partial class DataGridViewsForm : Form
    {
        public DataGridViewsForm()
        {
            InitializeComponent();
        }

        private void DataGridViewsForm_Load(object sender, EventArgs e)
        {
            DataGridViewColumn dgv1 = new DataGridViewCheckBoxColumn()
            {
                Name = "edit",
                HeaderText = "编辑"
            };
            dgvByCode.Columns.Add(dgv1);            
            DataGridViewColumn dgv2 = new DataGridViewTextBoxColumn()
            {
                Name = "seqNum",
                HeaderText = "编号"
            };
            dgvByCode.Columns.Add(dgv2);            
            DataGridViewColumn dgv3 = new DataGridViewTextBoxColumn()
            {
                Name = "username",
                HeaderText = "姓名"
            };
            dgvByCode.Columns.Add(dgv3);            
            DataGridViewColumn dgv4 = new DataGridViewLinkColumn()
            {
                Name = "delUnderline",
                HeaderText = "删除"
            };
            dgvByCode.Columns.Add(dgv4);
            //添加行数据
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewCell c1 = new DataGridViewCheckBoxCell()
            {
                Value = false
            };            
            DataGridViewCell c2 = new DataGridViewTextBoxCell()
            {
                Value = 18
            };            
            DataGridViewCell c3 = new DataGridViewTextBoxCell()
            {
                Value = "XiaoHua"
            };            
            DataGridViewCell c4 = new DataGridViewLinkCell()
            {
                Value = "删除"
            };
            //将cell添加到Row中
            row.Cells.AddRange(new DataGridViewCell[] { c1, c2, c3, c4 });
            //将row添加到datagridView组件中
            dgvByCode.Rows.Add(row);
        }

        /// <summary>
        ///  点击单元格内容时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Hello World");
            //使用Row - Column定位到指定的单元格
            DataGridViewCell cell = dgvStudent.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.FormattedValue.ToString().Equals("删除"))
            {
                MessageBox.Show("删除操作~");
            }else if (cell.FormattedValue.ToString().Equals("更新"))
            {
                MessageBox.Show("更新操作~");
            }
        }

        /// <summary>
        ///  单元格状态能够及时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStudent_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //判断当前单元格是否存在没有提交的更改
            if (dgvStudent.IsCurrentCellDirty)
            {
                //如果有，直接提交
                dgvStudent.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormComponents.Tree
{
    public partial class AddTreeNodeByCode : Form
    {
        public AddTreeNodeByCode()
        {
            InitializeComponent();
        }

        private void AddTreeNodeByCode_Load(object sender, EventArgs e)
        {
            //清楚所有的节点
            treeViewMenu.Nodes.Clear();
            //添加根节点
            TreeNode root = new TreeNode()
            {
                Name="root",
                Text="学生成绩管理系统"
            };
            //添加节点到TreeView
            treeViewMenu.Nodes.Add(root);
            TreeNode subNode = new TreeNode()
            {
                Name="stuManager",
                Text="学生管理"
            };
            root.Nodes.Add(subNode);
        }
    }
}

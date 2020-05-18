using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormComponents.RemainForms
{
    public partial class ContextMenuForm : Form
    {
        public ContextMenuForm()
        {
            InitializeComponent();
        }

        private void miColorRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void miColorGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void miColorDefault_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }
    }
}

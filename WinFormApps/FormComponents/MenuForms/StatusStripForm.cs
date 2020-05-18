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
    public partial class StatusStripForm : Form
    {
        public StatusStripForm()
        {
            InitializeComponent();
        }

        private void StatusStripForm_Load(object sender, EventArgs e)
        {
            statusLbl.Text = "Welcome to FUJICA Company~";
        }
    }
}

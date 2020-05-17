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
    public partial class ComBoxForm : Form
    {
        public ComBoxForm()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            SelectedObjectCollection items = comboxList.SelectedItems;
            foreach(object user in items)
            {
                MessageBox.Show(user as string);
            }
        }
    }
}

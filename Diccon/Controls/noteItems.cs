using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccon.Controls
{
    public partial class noteItems : UserControl
    {
        public noteItems()
        {
            InitializeComponent();
        }

        private void btExpand_Click(object sender, EventArgs e)
        {
            this.Height += 200;
            this.Refresh();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            btMenu.Visible = false;
            btExpand.Visible = true;
            btClose.Visible = true;
            btSave.Visible = true;
            btDelete.Visible = true;
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

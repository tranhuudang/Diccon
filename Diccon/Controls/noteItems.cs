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
            
            btExpand.Visible = true;
            btSave.Visible = true;
            btDelete.Visible = true;
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void noteItems_Load(object sender, EventArgs e)
        {
            roundedPanel1.BackColor = dicconProp.ColorA5;
            richContent.BackColor = dicconProp.ColorA9;
            tbTitle.BackColor = dicconProp.ColorA5;
        }

        private void btMenu_MouseEnter(object sender, EventArgs e)
        {
            dicconProp.Control_MouseEnter(sender, e);
        }

        private void btMenu_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.Control_MouseLeave(sender, e);
        }
    }
}

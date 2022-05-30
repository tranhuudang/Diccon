using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccon.Pages
{
    public partial class donate : Form
    {
        public donate()
        {
            InitializeComponent();
        }

        private void btOpenQr_Click(object sender, EventArgs e)
        {
            panelQr.Visible = true;
            btOpenQr.Visible = false;
        }
        private void RoundedLabel_MouseEnter(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_MouseEnter(sender, e);
        }
        private void RoundedLabel_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_MouseLeave(sender, e);
        }

        private void donate_Load(object sender, EventArgs e)
        {
            btOpenQr.BackColor = dicconProp.ColorA5;
        }
    }
}

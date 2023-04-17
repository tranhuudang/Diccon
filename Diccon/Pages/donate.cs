using System;
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
            DicconProp.RoundedLabel_MouseEnter(sender, e);
        }
        private void RoundedLabel_MouseLeave(object sender, EventArgs e)
        {
            DicconProp.RoundedLabel_MouseLeave(sender, e);
        }

        private void donate_Load(object sender, EventArgs e)
        {
            btOpenQr.BackColor = DicconProp.ColorA5;
        }
    }
}

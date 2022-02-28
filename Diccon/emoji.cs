using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Diccon
{
    public partial class emoji : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // width of ellipse
          int nHeightEllipse // height of ellipse
      );
        public emoji()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void emoji_MouseEnter(object sender, EventArgs e)
        {
            PictureBox target = (sender as PictureBox);
            target.Size= new Size(target.Width+2, target.Height+2);
        }

        private void emoji_MouseLeave(object sender, EventArgs e)
        {
            PictureBox target = (sender as PictureBox);
            target.Size = new Size(target.Width - 2, target.Height - 2);
        }

        private void emoji_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

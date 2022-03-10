using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Diccon
{
    public partial class SpeechToText : Form
    {
        int count = 0;
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
        public SpeechToText()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void SpeechToText_Load(object sender, EventArgs e)
        {
            lbMessage.Dock = DockStyle.Fill;
        }

        private void timerAutoClose_Tick(object sender, EventArgs e)
        {

            if (count == 3)
            {
                lbMessage.Text = "Keep talking";
            }
            if (count > 5)
            {
                lbMessage.Text = "Analyzing..";
            }
            if (count++ >= 7)
            {
                timerAutoClose.Stop();
                this.Close();
            }

        }
    }
}

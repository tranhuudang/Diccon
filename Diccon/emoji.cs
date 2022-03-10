using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diccon
{
    public partial class emoji : Form
    {
        public emoji()
        {
            InitializeComponent();
            /// With dropShadow Class to create a shadow for this form
            /// 
            (new Diccon.dropShadow()).ApplyShadows(this);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void emoji_MouseEnter(object sender, EventArgs e)
        {
            PictureBox target = (sender as PictureBox);
            target.Size = new Size(target.Width + 2, target.Height + 2);
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
        private void emojiClick(object sender, EventArgs e)
        {
            lbEmojiText.Text = (sender as PictureBox).Name;
            Clipboard.SetText(lbEmojiText.Text);
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbEmojiText.Text);
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

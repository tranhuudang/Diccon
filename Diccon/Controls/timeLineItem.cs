using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diccon
{
    public partial class timeLineItem : UserControl
    {
        SoundRelated sound = new SoundRelated();
        public timeLineItem(string word)
        {
            InitializeComponent();
            lbText.Text = word;
        }
        public timeLineItem()
        {
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            sound.OfflinePlay(lbText.Text);
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbText.Text);
        }
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (sender as PictureBox);
            int X = pictureBox.Location.X;
            int Y = pictureBox.Location.Y - 2;
            pictureBox.Location = new Point(X, Y);
        }
        /// <summary>
        /// Change position of PictureBox to create a illusion that the box is push down a little bit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (sender as PictureBox);
            int X = pictureBox.Location.X;
            int Y = pictureBox.Location.Y + 2;
            pictureBox.Location = new Point(X, Y);
        }
    }
}

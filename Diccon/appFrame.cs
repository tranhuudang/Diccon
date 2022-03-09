using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccon
{
    public partial class appFrame : Form
    {
        Form currentForm = null;
        Form dictionaryForm = null;
        public appFrame()
        {
            InitializeComponent();
        }

        private void AppFrame_Load(object sender, EventArgs e)
        {
            // Stack up quotation
            quote quote = new quote();
            lbQuotation.Text = quote.getQuote("en");
        }

        /// <summary>
        /// Change Red and Green background of Rounded-Label to a darker shade of  color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoundedLabel_MouseEnter(object sender, EventArgs e)
        {
            RoundedLabel roundedLabel = (sender as RoundedLabel);
            int R = roundedLabel.BackColor.R >= 50 ? roundedLabel.BackColor.R - 50 : roundedLabel.BackColor.R;
            int G = roundedLabel.BackColor.G >= 50 ? roundedLabel.BackColor.G - 50 : roundedLabel.BackColor.G;
            int B = roundedLabel.BackColor.B;

            roundedLabel.BackColor = Color.FromArgb(R, G, B);
        }
        /// <summary>
        /// Change Red and Green background of Rounded-Label to a lighter shade of  color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoundedLabel_MouseLeave(object sender, EventArgs e)
        {
            RoundedLabel roundedLabel = (sender as RoundedLabel);
            int R = roundedLabel.BackColor.R <= 205 ? roundedLabel.BackColor.R + 50 : roundedLabel.BackColor.R;
            int G = roundedLabel.BackColor.G <= 205 ? roundedLabel.BackColor.G + 50 : roundedLabel.BackColor.G;
            int B = roundedLabel.BackColor.B;

            roundedLabel.BackColor = Color.FromArgb(R, G, B);
        }
        /// <summary>
        /// Change position of PictureBox to create a illusion that the box is lift up a little bit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (PanelOfFind.Visible == true) PanelOfFind.Visible = false;
            else
            {
                PanelOfFind.Visible = true;
                tbFind.Focus();
            }
        }

        private void tbFind_Leave(object sender, EventArgs e)
        {
            PanelOfFind.Visible = false;
        }

        private void btDictionary_Click(object sender, EventArgs e)
        {
            if (dictionaryForm != null)
            {
                
                openForm(dictionaryForm);
            }
            else
            {
                dictionaryForm = new dictionary();
                openForm(dictionaryForm);
            }
        }
        private void openForm(Form targetForm)
        {
            logo.Image = Properties.Resources.back_36;
            if (currentForm!= null)
            {
                currentForm.Hide();
                panelHome.Visible = false;
                currentForm = targetForm;
                currentForm.TopLevel = false;
                currentForm.FormBorderStyle = FormBorderStyle.None;
                currentForm.Dock = DockStyle.Fill;
                playGroundPanel.Controls.Add(currentForm);
                currentForm.Show();
            }
            else
            {
                panelHome.Visible = false;
                currentForm = targetForm;
                currentForm.TopLevel = false;
                currentForm.FormBorderStyle = FormBorderStyle.None;
                currentForm.Dock = DockStyle.Fill;
                playGroundPanel.Controls.Add(currentForm);
                currentForm.Show();
            }

        }

        private void logo_Click(object sender, EventArgs e)
        {
            logo.Image = Properties.Resources.ninja_64;
            if( currentForm!=null)
            {
                currentForm.Hide();
                panelHome.Visible = true;
            }
        }
    }
}

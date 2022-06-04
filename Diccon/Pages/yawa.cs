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
    public partial class yawa : Form
    {
        Panel currentPanel = null;
        public yawa()
        {
            InitializeComponent();
        }

        private void yawa_Load(object sender, EventArgs e)
        {
            btAsk.BackColor = dicconProp.ColorA8;
            btInstantAsk.BackColor = dicconProp.ColorA8;
            btAnswer.BackColor = dicconProp.ColorA3;
            btPeople.BackColor = dicconProp.ColorA3;
            btPrevious.BackColor = dicconProp.ColorA3;
            btAskPanel.BackColor = dicconProp.ColorA3;
            richQuestion_1.BackColor = dicconProp.ColorA9;
            richQuestion_2.BackColor = dicconProp.ColorA9;
            panelOfRichQuestion_1.BackColor = dicconProp.ColorA9;
            panelOfRichQuestion_2.BackColor = dicconProp.ColorA9;
            richAnswer.BackColor = dicconProp.ColorA9;
            panelOfRichAnswer.BackColor = dicconProp.ColorA9;
        }


        private void richQuestion_TextChanged(object sender, EventArgs e)
        {
            if (richQuestion_1.Text.Length <= 20)
            {
                countWord.Visible = false;

                notice.Visible = false;
            }
            else if (richQuestion_1.Text.Length > 20)
            {
                countWord.Text = richQuestion_1.Text.Length.ToString() + "/500";
                countWord.Visible = true;
                notice.Visible = true;
            }
        }

        private void btGlobal_MouseEnter(object sender, EventArgs e)
        {
            dicconProp.PictureBox_MouseEnter(sender, e);
        }

        private void btGlobal_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.PictureBox_MouseLeave(sender, e);
        }
        private void btRecent_MouseEnter(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_MouseEnter(sender, e);
        }

        private void btRecent_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_MouseLeave(sender, e);
        }

        private void btRecent_Click(object sender, EventArgs e)
        {
            openPanel(panelAnswer);
            btAnswer.Visible = false;
            btAskPanel.Visible = true;
        }
        private void openPanel(Panel panel)
        {
            currentPanel = panel;
            panelMain.Controls.Add(currentPanel);
            currentPanel.Visible = true;
            currentPanel.Dock = DockStyle.Fill;
            currentPanel.BringToFront();
        }

        private void btAskPanel_Click(object sender, EventArgs e)
        {
            currentPanel.Visible=false;
            btAskPanel.Visible=false;
            ///
            btAnswer.Visible=true;
            btPrevious.Visible=true;
            btPeople.Visible=true;
            ///
        }

        private void btAskPanel_MouseEnter(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_Darker_MouseEnter(sender, e);
        }

        private void btAskPanel_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_Darker_MouseLeave(sender, e);
        }
    }
}

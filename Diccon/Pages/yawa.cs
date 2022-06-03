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
        public yawa()
        {
            InitializeComponent();
        }

        private void yawa_Load(object sender, EventArgs e)
        {
            btAsk.BackColor = dicconProp.ColorA5;
            btInstantAsk.BackColor = dicconProp.ColorA5;
            btRecent.BackColor = dicconProp.ColorA5;
            btPeople.BackColor = dicconProp.ColorA5;
            btPrevious.BackColor = dicconProp.ColorA5;
            richQuestion.BackColor = dicconProp.ColorA9;
            panelOfRichQuestion.BackColor = dicconProp.ColorA9;
        }


        private void richQuestion_TextChanged(object sender, EventArgs e)
        {
            if(richQuestion.Text.Length<=20)
            {
                countWord.Visible = false;
                
                notice.Visible = false;
            }    
            else if(richQuestion.Text.Length>20)
            {
                countWord.Text = richQuestion.Text.Length.ToString() + "/500";
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

        private void btGlobal_Click(object sender, EventArgs e)
        {
            panelGlobal.Visible = true;
            panelGlobal.Dock = DockStyle.Fill;
            panelGlobal.BringToFront();
        }

        private void btRecent_MouseEnter(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_MouseEnter(sender, e);
        }

        private void btRecent_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_MouseLeave(sender, e);
        }
    }
}

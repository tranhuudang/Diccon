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
        botBehavior bot = new botBehavior();
        userAction user = new userAction();
        SQLHandler sqlHandler = new SQLHandler();

        Panel currentPanel = null;
        public yawa()
        {
            InitializeComponent();
        }

        private void yawa_Load(object sender, EventArgs e)
        {
            btAsk.BackColor = dicconProp.ColorA8;
            btInstantAsk.BackColor = dicconProp.ColorA8;
            btPeopleTop.BackColor = dicconProp.ColorA3;
            btYoursTop.BackColor = dicconProp.ColorA3;
            btAskTop.BackColor = dicconProp.ColorA3;
            richQuestion.BackColor = dicconProp.ColorA9;
            globalExamplePanel.BackColor = dicconProp.ColorA9;
            panelOfRichQuestion_1.BackColor = dicconProp.ColorA9;
        }


        private void richQuestion_TextChanged(object sender, EventArgs e)
        {
            if (richQuestion.Text.Length <= 20)
            {
                countWord.Visible = false;

                notice.Visible = false;
            }
            else if (richQuestion.Text.Length > 20)
            {
                countWord.Text = richQuestion.Text.Length.ToString() + "/500";
                countWord.Visible = true;
                notice.Visible = true;
            }
        }

        private void btGlobal_MouseEnter(object sender, EventArgs e)
        {
            dicconProp.Control_MouseEnter(sender, e);
        }

        private void btGlobal_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.Control_MouseLeave(sender, e);
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

        }

        private void btAskPanel_MouseEnter(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_Darker_MouseEnter(sender, e);
        }

        private void btAskPanel_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_Darker_MouseLeave(sender, e);
        }

        private void btAsk_Click(object sender, EventArgs e)
        {
            SQLHandler sqlHandler = new SQLHandler();
            sqlHandler.Insert("Insert into dbo.DicconAsking(Question, AskUserId, AskDate) values(N'" + richQuestion.Text + "','" + dicconProp.userID + "','" + DateTime.Today + "')");
        }

        private void globalRefresher_Tick(object sender, EventArgs e)
        {

        }

        private void btPeople_Click(object sender, EventArgs e)
        {

            ///
            openPanel(panelGlobal);
            btReload_Click(null, null);
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            globalFlowPanel.Controls.Clear();
            DataTable dataTable = sqlHandler.Select("Select Question, AskDate from dbo.DicconAsking");
            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                RoundedPanel roundedPanel = new RoundedPanel();
                roundedPanel.Size = globalExamplePanel.Size;
                roundedPanel.BackColor = globalExamplePanel.BackColor;
                Label label = new Label();
                label.Text = dataTable.Rows[index][0].ToString();
                label.ForeColor = globalExamplePanel.ForeColor;
                label.Size = globalExampleAsk.Size;
                label.Click += GoToAnswer_Click;
                roundedPanel.Controls.Add(label);
                label.Location = globalExampleAsk.Location;
                globalFlowPanel.Controls.Add(roundedPanel);
            }
        }

        private void GoToAnswer_Click(object sender, EventArgs e)
        {
            TopControlSwitch("answerBox");
            openPanel(panelAnswer);
            ///

        }

        private void TopControlSwitch(string controlName)
        {
            switch (controlName)
            {
                case "btAskTop":
                    btAskTop.Visible = false;
                    btPeopleTop.Visible = true;
                    btYoursTop.Visible = true;
                    break;
                case "btPeopleTop":
                    btAskTop.Visible = true;
                    btPeopleTop.Visible = false;
                    btYoursTop.Visible = true;
                    break;
                case "btYoursTop":
                    btAskTop.Visible = true;
                    btPeopleTop.Visible = true;
                    btYoursTop.Visible = false;
                    break;
                case "answerBox":
                    btAskTop.Visible = true;
                    btPeopleTop.Visible = true;
                    btYoursTop.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void btAskTop_Click(object sender, EventArgs e)
        {
            TopControlSwitch("btAskTop");
            currentPanel.Visible = false;
        }

        private void btPeopleTop_Click(object sender, EventArgs e)
        {
            TopControlSwitch("btPeopleTop");
            openPanel(panelGlobal);
            btReload_Click(null, null);
        }

        private void btYoursTop_Click(object sender, EventArgs e)
        {
            TopControlSwitch("btYoursTop");
            openPanel(panelYours);
        }

        private void btReload_MouseEnter(object sender, EventArgs e)
        {
            dicconProp.Control_MouseEnter(sender, e);
        }

        private void btReload_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.Control_MouseLeave(sender, e);
        }

        private void globalExampleAsk_Click(object sender, EventArgs e)
        {

        }

        private void answer_textBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                user.userLongMessage(answer_textBox.Text, exampleAskLongText, exampleAskLongColoredPanel, exampleAskLongPanel, flowChatBox);

            }
        }

        private void answer_textBox_TextChanged(object sender, EventArgs e)
        {
            if(answer_textBox.Text.Length > 0)
            {
                answer_TextHolder.Visible = false;
            }
            else
            {
                answer_TextHolder.Visible = true;
            }
        }
    }
}

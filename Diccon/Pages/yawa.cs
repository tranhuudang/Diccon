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
        string currentAnswerString;
        string currentQuestionUserID; // ID of user who ask the question
        string currentQuestionID; // ID of current question displayed in flowchatbox
        Panel currentPanel = null;
        public yawa()
        {
            InitializeComponent();
        }

        private void yawa_Load(object sender, EventArgs e)
        {
            //panelMain.Dock = DockStyle.Fill;
            btAsk.BackColor = dicconProp.ColorA8;
            btInstantAsk.BackColor = dicconProp.ColorA8;
            btPeopleTop.BackColor = dicconProp.ColorA3;
            btYoursTop.BackColor = dicconProp.ColorA3;
            btAskTop.BackColor = dicconProp.ColorA3;
            richQuestion.BackColor = dicconProp.ColorA9;
            globalExamplePanel.BackColor = dicconProp.ColorA9;
            panelOfRichQuestion_1.BackColor = dicconProp.ColorA9;
            exampleAnswerColoredPanel.BackColor = dicconProp.ColorA3;
            answer_textBox.BackColor = dicconProp.ColorA9;
            roundedPanelChatBox.BackColor = dicconProp.ColorA9;
            /// load Global first 
            btPeopleTop_Click(null, null);
        }


        private void richQuestion_TextChanged(object sender, EventArgs e)
        {
            if (richQuestion.Text.Length <= 20)
            {
                countWord.Visible = false;
                btAsk.Enabled = false;
                notice.Visible = false;
            }
            else if (richQuestion.Text.Length > 20)
            {
                countWord.Text = richQuestion.Text.Length.ToString() + "/500";
                countWord.Visible = true;
                notice.Visible = true;
                btAsk.Enabled = true;

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
            richQuestion.Text = "";
            btPeopleTop_Click(null, null);
        }


        private void btReload_Click(object sender, EventArgs e)
        {
            globalFlowPanel.Controls.Clear();
            DataTable dataTable = sqlHandler.Select("Select Question, Id, AskDate from dbo.DicconAsking");
            for (int index = dataTable.Rows.Count - 1; index >= 0; index--)
            {
                RoundedPanel roundedPanel = new RoundedPanel();
                roundedPanel.Size = globalExamplePanel.Size;
                roundedPanel.BackColor = globalExamplePanel.BackColor;
                Label label = new Label();
                label.Text = dataTable.Rows[index][0].ToString();
                label.Tag = dataTable.Rows[index][1].ToString();
                label.ForeColor = globalExamplePanel.ForeColor;
                label.Size = globalExampleAsk.Size;
                label.Cursor = Cursors.Hand;
                label.Click += GoToAnswer_Click;
                roundedPanel.Controls.Add(label);
                label.Location = globalExampleAsk.Location;
                globalFlowPanel.Controls.Add(roundedPanel);
            }

        }
        string listLoadedMessage ;
        private void GoToAnswer_Click(object sender, EventArgs e)
        {
            newMessageChecker.Interval = 5000;
            newMessageChecker.Enabled = true;
            TopControlSwitch("answerBox");
            openPanel(panelAnswer);
            ///
            /// Sample Answer from SQL: #đây là câu trả lời#?Đây là câu hỏi#?đây là câu hỏi kế#đây là câu trả lời
            DataTable dataTable = sqlHandler.Select("Select Answer, AskUserId from dbo.DicconAsking where Id=" + (sender as Label).Tag.ToString());
            if (currentAnswerString != dataTable.Rows[0][0].ToString())
            {
                // clear flowchatbox for a new bunch of conversasion
                flowChatBox.Controls.Clear();
                currentAnswerString = dataTable.Rows[0][0].ToString();
                string[] strings = dataTable.Rows[0][0].ToString().Split('#');
                currentQuestionUserID = dataTable.Rows[0][1].ToString();
                currentQuestionID = (sender as Label).Tag.ToString();

                foreach (var item in strings)
                {
                    listLoadedMessage+=item;
                    if (item.StartsWith("?"))
                    {

                        user.userLongMessage(item.Substring(1), exampleAskLongText, exampleAskLongColoredPanel, exampleAskLongPanel, flowChatBox);
                    }
                    else if (item != "")
                    {
                        bot.botAnswerLongMessage(item, exampleAnswerText, exampleAnswerColoredPanel, exampleAnswerPanel, flowChatBox);
                    }
                }
            }
        }


        private void ReloadInChat()
        {
            try
            {
                /// Sample Answer from SQL: #đây là câu trả lời#?Đây là câu hỏi#?đây là câu hỏi kế#đây là câu trả lời
                DataTable dataTable = sqlHandler.Select("Select Answer from dbo.DicconAsking where Id=" + currentQuestionID);
                if (currentAnswerString != dataTable.Rows[0][0].ToString())
                {
                    // clear flowchatbox for a new bunch of conversasion
                    //flowChatBox.Controls.Clear();
                    currentAnswerString = dataTable.Rows[0][0].ToString();
                    string[] strings = dataTable.Rows[0][0].ToString().Split('#');
                    foreach (var item in strings)
                    {
                        if (!listLoadedMessage.Contains(item))
                            if (item.StartsWith("?"))
                            {
                                user.userLongMessage(item.Substring(1), exampleAskLongText, exampleAskLongColoredPanel, exampleAskLongPanel, flowChatBox);
                            }
                            else if ((item != "") && (!item.StartsWith("?")))
                            {
                                bot.botAnswerLongMessage(item, exampleAnswerText, exampleAnswerColoredPanel, exampleAnswerPanel, flowChatBox);

                            }
                    }

                }
            }
            catch (Exception)
            {

            }
            
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
            listLoadedMessage = "";

            TopControlSwitch("btAskTop");
            openPanel(panelAsk);
            btReload_Click(null, null);
            btReload.BringToFront();
        }

        private void btPeopleTop_Click(object sender, EventArgs e)
        {
            listLoadedMessage = "";


            TopControlSwitch("btPeopleTop");
            openPanel(panelGlobal);
            btReload_Click(null, null);
            btReload.BringToFront();
        }

        private void btYoursTop_Click(object sender, EventArgs e)
        {
            listLoadedMessage = "";


            TopControlSwitch("btYoursTop");
            openPanel(panelYours);
            btReloadYours_Click(null, null);
            btReloadYours.BringToFront();
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

                if (dicconProp.userID == currentQuestionUserID)
                {
                    //user.userLongMessage(answer_textBox.Text, exampleAskLongText, exampleAskLongColoredPanel, exampleAskLongPanel, flowChatBox);
                    sqlHandler.Update("Update dbo.DicconAsking Set Answer=N'" + currentAnswerString + "#?" + answer_textBox.Text + "' where Id=" + currentQuestionID);

                }
                else
                {
                    //bot.botAnswerLongMessage(answer_textBox.Text, exampleAnswerText, exampleAnswerColoredPanel, exampleAnswerPanel, flowChatBox);
                    sqlHandler.Update("Update dbo.DicconAsking Set Answer=N'" + currentAnswerString + "#" + answer_textBox.Text + "' where Id=" + currentQuestionID);

                }
                ReloadInChat();
                answer_textBox.Text = "";
            }
        }

        private void answer_textBox_TextChanged(object sender, EventArgs e)
        {
            if (answer_textBox.Text.Length > 0)
            {
                answer_TextHolder.Visible = false;
            }
            else
            {
                answer_TextHolder.Visible = true;
            }
        }

        private void answer_TextHolder_Click(object sender, EventArgs e)
        {
            answer_textBox.Focus();
        }

        private void btReloadYours_Click(object sender, EventArgs e)
        {
            flowYours.Controls.Clear();
            DataTable yourDatatable = sqlHandler.Select("Select Question, Id from dbo.DicconAsking where AskUserId=" + dicconProp.userID);
            for (int index = yourDatatable.Rows.Count - 1; index >= 0; index--)
            {
                RoundedPanel roundedPanel = new RoundedPanel();
                roundedPanel.Size = yourPanel.Size;
                roundedPanel.BackColor = yourPanel.BackColor;
                Label label = new Label();
                label.Text = yourDatatable.Rows[index][0].ToString();
                label.Tag = yourDatatable.Rows[index][1].ToString();
                label.ForeColor = yourPanel.ForeColor;
                label.Size = yourLabel.Size;
                label.Cursor = Cursors.Hand;
                label.Click += GoToAnswer_Click;
                roundedPanel.Controls.Add(label);
                label.Location = yourLabel.Location;
                flowYours.Controls.Add(roundedPanel);
            }
        }

        private void flowChatBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowChatBox_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void newMessageChecker_Tick(object sender, EventArgs e)
        {
            ReloadInChat();
        }

        private void flowYours_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowYours_Enter(object sender, EventArgs e)
        {
        }

        private void flowYours_ControlAdded(object sender, ControlEventArgs e)
        {


        }
    }
}

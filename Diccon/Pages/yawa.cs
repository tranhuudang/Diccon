using System;
using System.Data;
using System.Windows.Forms;

namespace Diccon.Pages
{
    public partial class yawa : Form
    {
        BotBehavior bot = new BotBehavior();
        UserAction user = new UserAction();
        SQLHandler sqlHandler = new SQLHandler();
        Connectivity connectivity = new Connectivity();

        string currentAnswerString;
        string currentQuestionUserID; // ID of user who ask the question
        string currentQuestionID; // ID of current question displayed in flowchatbox
        public yawa()
        {
            InitializeComponent();
        }

        private void yawa_Load(object sender, EventArgs e)
        {
            panelMain.Dock = DockStyle.Fill;
            panelMain.BringToFront();
            panelTop.Dock = DockStyle.Top;
            btAsk.BackColor = DicconProp.ColorA8;
            btYourQuestion.BackColor = DicconProp.ColorA3;
            btInstantAsk.BackColor = DicconProp.ColorA8;
            btPeopleTop.BackColor = DicconProp.ColorA3;
            btAskTop.BackColor = DicconProp.ColorA3;
            richQuestion.BackColor = DicconProp.ColorA9;
            globalExamplePanel.BackColor = DicconProp.ColorA9;
            panelOfRichQuestion_1.BackColor = DicconProp.ColorA9;
            exampleAnswerColoredPanel.BackColor = DicconProp.ColorA3;
            answer_textBox.BackColor = DicconProp.ColorA9;
            roundedPanelChatBox.BackColor = DicconProp.ColorA9;
            /// load Global first 
            btPeopleTop_Click(null, null);
        }


        private void richQuestion_TextChanged(object sender, EventArgs e)
        {
            if (richQuestion.Text.Length <= 20)
            {
                countWord.Visible = false;
                btAsk.Enabled = false;
            }
            else if (richQuestion.Text.Length > 20)
            {
                countWord.Text = richQuestion.Text.Length.ToString() + "/500";
                countWord.Visible = true;
                btAsk.Enabled = true;

            }
        }

        private void btGlobal_MouseEnter(object sender, EventArgs e)
        {
            DicconProp.Control_MouseEnter(sender, e);
        }

        private void btGlobal_MouseLeave(object sender, EventArgs e)
        {
            DicconProp.Control_MouseLeave(sender, e);
        }
        private void btRecent_MouseEnter(object sender, EventArgs e)
        {
            DicconProp.RoundedLabel_MouseEnter(sender, e);
        }

        private void btRecent_MouseLeave(object sender, EventArgs e)
        {
            DicconProp.RoundedLabel_MouseLeave(sender, e);
        }

        private void btRecent_Click(object sender, EventArgs e)
        {
            openPanel(panelAnswer);
        }
        private void openPanel(Panel panel)
        {
            panelMain.Controls.Add(panel);
            panel.Visible = true;
            panel.Dock = DockStyle.Fill;
            panel.BringToFront();
        }

        private void btAskPanel_Click(object sender, EventArgs e)
        {

        }

        private void btAskPanel_MouseEnter(object sender, EventArgs e)
        {
            DicconProp.RoundedLabel_Darker_MouseEnter(sender, e);
        }

        private void btAskPanel_MouseLeave(object sender, EventArgs e)
        {
            DicconProp.RoundedLabel_Darker_MouseLeave(sender, e);
        }

        private async void btAsk_Click(object sender, EventArgs e)
        {

            SQLHandler sqlHandler = new SQLHandler();
            await sqlHandler.InsertAsync("Insert into dbo.DicconAsking(Question, AskUserId, AskDate) values(N'" + richQuestion.Text.Replace("'", "") + "','" + DicconProp.UserID + "','" + DateTime.Today + "')");
            richQuestion.Text = "";
            btPeopleTop_Click(null, null);
        }


        private async void btReload_Click(object sender, EventArgs e)
        {
            globalFlowPanel.Controls.Clear();
            DataTable dataTable = await sqlHandler.SelectAsync("Select Question, Id, AskDate from dbo.DicconAsking");
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
        string listLoadedMessage;
        private async void GoToAnswer_Click(object sender, EventArgs e)
        {
            newMessageChecker.Enabled = true;
            TopControlSwitch("answerBox");
            openPanel(panelAnswer);
            try
            {

                ///
                /// Sample Answer from SQL: #đây là câu trả lời#?Đây là câu hỏi#?đây là câu hỏi kế#đây là câu trả lời
                DataTable dataTable = await sqlHandler.SelectAsync("Select Answer, AskUserId, Question from dbo.DicconAsking where Id=" + (sender as Label).Tag.ToString());
                if (currentAnswerString != dataTable.Rows[0][0].ToString())
                {
                    // clear flowchatbox for a new bunch of conversasion
                    flowChatBox.Controls.Clear();
                    currentAnswerString = dataTable.Rows[0][0].ToString();
                    string[] strings = dataTable.Rows[0][0].ToString().Split('#');
                    currentQuestionUserID = dataTable.Rows[0][1].ToString();
                    lbQuestionTitle.Text = dataTable.Rows[0][2].ToString();
                    currentQuestionID = (sender as Label).Tag.ToString();

                    foreach (var item in strings)
                    {
                        listLoadedMessage += item;
                        if (item.StartsWith("?"))
                        {

                            user.UserLongMessage(item.Substring(1), exampleAskLongText, exampleAskLongColoredPanel, exampleAskLongPanel, flowChatBox);
                        }
                        else if (item != "")
                        {
                            bot.BotAnswerLongMessage(item, exampleAnswerText, exampleAnswerColoredPanel, exampleAnswerPanel, flowChatBox);
                        }
                    }
                }
            }
            catch (Exception)
            {


            }
        }


        private async void ReloadInChat()
        {
            try
            {
                /// Sample Answer from SQL: #đây là câu trả lời#?Đây là câu hỏi#?đây là câu hỏi kế#đây là câu trả lời
                DataTable dataTable = await sqlHandler.SelectAsync("Select Answer, AskUserId from dbo.DicconAsking where Id=" + currentQuestionID);
                if (currentAnswerString != dataTable.Rows[0][0].ToString())
                {
                    // clear flowchatbox for a new bunch of conversasion
                    //flowChatBox.Controls.Clear();
                    currentAnswerString = dataTable.Rows[0][0].ToString();
                    string[] strings = dataTable.Rows[0][0].ToString().Split('#');
                    foreach (var item in strings)
                    {
                        if (!listLoadedMessage.Contains(item) && !listLoadedMessage.Contains("?" + item))
                            if ((item.Trim() != "") && (item.StartsWith("?")))
                            {
                                user.UserLongMessage(item.Substring(1), exampleAskLongText, exampleAskLongColoredPanel, exampleAskLongPanel, flowChatBox);
                                listLoadedMessage += item;
                            }
                            else if ((item.Trim() != "") && (!item.StartsWith("?")))
                            {
                                bot.BotAnswerLongMessage(item, exampleAnswerText, exampleAnswerColoredPanel, exampleAnswerPanel, flowChatBox);
                                listLoadedMessage += item;

                            }
                    }
                }
                if (DicconProp.UserID == dataTable.Rows[0][1].ToString()) // if userId == AskUserId -> this is the one who create this question
                {
                    btRemove.Visible = true;
                }
                else
                {
                    btRemove.Visible = false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show(DicconProp.ErrorUnknown + "- #165-435-996", DicconProp.caption);
            }

        }

        private void TopControlSwitch(string controlName)
        {
            switch (controlName)
            {
                case "btAskTop":
                    btAskTop.Visible = false;
                    btPeopleTop.Visible = true;
                    break;
                case "btPeopleTop":
                    btAskTop.Visible = true;
                    btPeopleTop.Visible = false;
                    break;
                case "btYoursTop":
                    btAskTop.Visible = true;
                    btPeopleTop.Visible = true;
                    break;
                case "answerBox":
                    btAskTop.Visible = true;
                    btPeopleTop.Visible = true;
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
            // Disable MessageChecker when going out of answer tab
            newMessageChecker.Enabled = false;
        }

        private void btPeopleTop_Click(object sender, EventArgs e)
        {
            listLoadedMessage = "";


            TopControlSwitch("btPeopleTop");
            openPanel(panelGlobal);
            btReload_Click(null, null);
            btReload.BringToFront();
            // Disable MessageChecker when going out of answer tab
            newMessageChecker.Enabled = false;
        }

        private void btYoursTop_Click(object sender, EventArgs e)
        {
            listLoadedMessage = "";


            TopControlSwitch("btYoursTop");
            openPanel(panelYours);
            btReloadYours_Click(null, null);
            btReloadYours.BringToFront();
            // Disable MessageChecker when going out of answer tab
            newMessageChecker.Enabled = false;
        }

        private void btReload_MouseEnter(object sender, EventArgs e)
        {
            DicconProp.Control_MouseEnter(sender, e);
        }

        private void btReload_MouseLeave(object sender, EventArgs e)
        {
            DicconProp.Control_MouseLeave(sender, e);
        }

        private void globalExampleAsk_Click(object sender, EventArgs e)
        {

        }

        private async void answer_textBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (connectivity.IsOnline())
                {
                    if (DicconProp.UserID == currentQuestionUserID)
                    {
                        //user.userLongMessage(answer_textBox.Text, exampleAskLongText, exampleAskLongColoredPanel, exampleAskLongPanel, flowChatBox);
                        await sqlHandler.UpdateAsync("Update dbo.DicconAsking Set Answer=N'" + currentAnswerString + "#?" + answer_textBox.Text.Replace("'", "") + "' where Id=" + currentQuestionID);

                    }
                    else
                    {
                        //bot.botAnswerLongMessage(answer_textBox.Text, exampleAnswerText, exampleAnswerColoredPanel, exampleAnswerPanel, flowChatBox);
                        await sqlHandler.UpdateAsync("Update dbo.DicconAsking Set Answer=N'" + currentAnswerString + "#" + answer_textBox.Text.Replace("'", "") + "' where Id=" + currentQuestionID);

                    }
                    answer_textBox.Text = "";
                }

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

        private async void btReloadYours_Click(object sender, EventArgs e)
        {
            flowYours.Controls.Clear();
            if (connectivity.IsOnline())
            {
                DataTable yourDatatable = await sqlHandler.SelectAsync("Select Question, Id from dbo.DicconAsking where AskUserId=" + DicconProp.UserID);
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
        }

        private void flowChatBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowChatBox_VisibleChanged(object sender, EventArgs e)
        {

        }
        private void newMessageChecker_Tick(object sender, EventArgs e)
        {
            newMessageChecker.Enabled = false;
            if (connectivity.IsOnline())
            {
                ReloadInChat();
            }
            newMessageChecker.Enabled = true;

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

        private async void btRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (connectivity.IsOnline())
                {
                    await sqlHandler.DeleteAsync("Delete from dbo.DicconAsking where Id=" + currentQuestionID);
                    btPeopleTop_Click(null, null);
                }
            }
            catch (Exception)
            {


            }

        }

        private void lbQuestionTitle_Click(object sender, EventArgs e)
        {

        }

        private void btYourQuestion_Click(object sender, EventArgs e)
        {
            listLoadedMessage = "";


            TopControlSwitch("btYoursTop");
            openPanel(panelYours);
            btReloadYours_Click(null, null);
            btReloadYours.BringToFront();
            // Disable MessageChecker when going out of answer tab
            newMessageChecker.Enabled = false;
        }
    }
}

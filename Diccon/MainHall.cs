using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Diccon
{
    public partial class mainHall : Form
    {
        botBehavior bot = new botBehavior();
        userAction user = new userAction();

        public mainHall()
        {
            InitializeComponent();
        }

        private void mainHall_Load(object sender, EventArgs e)
        {
            panelBottom.Height = dicconProp.bottomPanel_DefaultHeight;
            // setup flowchatbox to only show vertical scrollbar
            flowChatBox.HorizontalScroll.Visible = false;
            flowChatBox.HorizontalScroll.Enabled = false;
            flowChatBox.Padding = new Padding(10, 0, 0, 0);
            // Stack up quotation
            quote quote = new quote();
            lbQuotation.Text = quote.getQuote("en");
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

        private void textFromMic_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                SpeechToText speechToText = new SpeechToText();
                speechToText.Location = new Point(Cursor.Position.X - speechToText.Width / 2, Cursor.Position.Y - speechToText.Height - 15);
                speechToText.ShowDialog();

            });
            thread.Start();
            soundRelated sound = new soundRelated();
            searchTextBox.Text = sound.SpeechToText("00:00:07");
        }

        private void textFromEmoji_Click(object sender, EventArgs e)
        {


        }

        private async void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                dicconProp.currentWord = searchTextBox.Text;
                await searchAndShow(dicconProp.currentWord);


            }
        }
        private async Task searchAndShow(string searchWord)
        {
            if (dicconProp.currentWord != "")
            {
                wordRelated word = new wordRelated();

                // if user type in just one word, so the case is we will use userSingMessage instead of userLongMessage
                int numberOfWord = word.countWord(searchTextBox.Text);
                if (numberOfWord == 0)
                {
                }
                else if (numberOfWord == 1)
                {

                    user.userSingleMessage(searchTextBox.Text, exampleShortText, exampleShortPanel, flowChatBox);
                    bot.botSoundMessage(searchTextBox.Text, exampleTextHolder, examplePlayButton, examplePlayColoredPanel, examplePlayAlignPanel, examplePlayPanel, flowChatBox);
                    bot.botAnswerLongMessage(searchMatchWord(searchTextBox.Text), exampleAnswerText, exampleAnswerColoredPanel, exampleAnswerPanel, flowChatBox);
                    suggestionTimer.Enabled = true;
                }
                else if (numberOfWord > 1)
                {
                    bool isOnline = new connectivity().isOnline();
                    if (isOnline)
                    {
                        user.userLongMessage(searchTextBox.Text + "\n", exampleAskLongText, exampleAskLongColoredPanel, exampleAskLongPanel, flowChatBox);
                        dicconProp.currentTranslatedWord = await bot.getTranslatedTextAsync(dicconProp.currentWord);
                        bot.botAnswerLongMessage(dicconProp.currentTranslatedWord + "\n", exampleAnswerText, exampleAnswerColoredPanel, exampleAnswerPanel, flowChatBox);
                    }
                    else
                    {
                        MessageBox.Show(dicconProp.connectError);
                    }
                }
                searchTextBox.Text = "";
            }
        }

        public string searchMatchWord(string wordsToSearch) // THIS IS FUNCTION TO SEARCH TEXT 
        {

            // xử lí từ ngữ được người dùng nhập vào------------------
            wordRelated word = new wordRelated();
            // Nạp từ vào đối tượng
            word.PreWord = wordsToSearch;
            // Xử lí từ và lấy kết quả
            wordsToSearch = word.SearchWordProcess();


            int indexOfArray = 0;
            // đọc từng dòng trong paragraph sau đó gán giá trị cho line 
            // ** using class to improve searching speed
            //string[] splitedText = TextDataFromResources.Split("@".ToCharArray());
            foreach (string wordAndMeanning in dicconProp.splitedText)
            {

                if (wordAndMeanning.Contains("•" + wordsToSearch))
                {
                    return dicconProp.splitedText[indexOfArray];

                }
                indexOfArray++;



            }
            return "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSuggestFunction.Visible = true;
            flowChatBox.Controls.SetChildIndex(panelSuggestFunction, flowChatBox.Controls.Count);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                labelTypeToSearch.Visible = true;
                btSend.SendToBack();
            }
            else
            {
                labelTypeToSearch.Visible = false;
                btSend.BringToFront();

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (panelBottom.Height == dicconProp.bottomPanel_ExpandedHeight)
                panelBottom.Height = dicconProp.bottomPanel_DefaultHeight;
            else
                panelBottom.Height = dicconProp.bottomPanel_ExpandedHeight;
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            panelBottom.Height = dicconProp.bottomPanel_DefaultHeight;
        }

        private void addNote_Click(object sender, EventArgs e)
        {
            user.userAddNote(exampleNoteMenu, exampleNoteRichTextBox, exampleNoteColoredPanel, exampleNotePanel, flowChatBox);
        }

        private void addNote_MouseEnter(object sender, EventArgs e)
        {
            addNote.BackColor = dicconProp.hover_addNote_BackColor;
        }

        private void addNote_MouseLeave(object sender, EventArgs e)
        {
            addNote.BackColor = dicconProp.default_addNote_BackColor;
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // turn of Ding sound after hit Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void aWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {

            int X = Cursor.Position.X - 120;
            int Y = Cursor.Position.Y + 15;
            contextMenu.Show(X, Y);
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
        private void tbFind_Leave(object sender, EventArgs e)
        {
            PanelOfFind.Visible = false;
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            labelTypeToSearch.Visible = searchTextBox.Text == "" ? true : false;
        }

        private void labelTypeToSearch_Click(object sender, EventArgs e)
        {
            searchTextBox.Focus();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.ShowDialog();
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/zeroclubvn/Diccon");
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument updateFile = new XmlDocument();
                updateFile.Load(dicconProp.updateInfo + "?" + DateTime.Now.Ticks.ToString());
                Version netVersion = new Version(updateFile.SelectSingleNode("//currentVersion/version").InnerText);
                string describe = updateFile.SelectSingleNode("//currentVersion/describe").InnerText;
                string linkSetup = updateFile.SelectSingleNode("//path").InnerText;
                Version currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
                if (netVersion > currentVersion)
                {

                    if (MessageBox.Show(dicconProp.updateAvailableMessage, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Thread thread = new Thread(() =>
                        {

                            WebClient webClient = new WebClient();
                            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
                            webClient.DownloadFileAsync(new Uri(linkSetup), dicconProp.setupName);
                        });
                        thread.Start();
                    }

                }
                else
                {
                    MessageBox.Show(dicconProp.noUpdateAvailableMessage, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't connect to the internet!");
            }
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (MessageBox.Show(dicconProp.downloadSetupCompleteMessage, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start(dicconProp.setupName);
                Application.Exit();
            }
        }


        private void exampleAnswerText_HScroll(object sender, EventArgs e)
        {

        }

        private async void suggestionTimer_TickAsync(object sender, EventArgs e)
        {
            bool isOnline = new connectivity().isOnline();
            if (isOnline)
            {
                sysnonym sysnonym = new sysnonym();
                if (await sysnonym.getSynonymListAsync(dicconProp.currentWord) == null)
                {
                    btSynonym.Visible = false;
                }
                else
                {
                    btSynonym.Visible = true;
                }
            }
            suggestionTimer.Enabled = false;

        }

        private async void btSynonym_Click(object sender, EventArgs e)
        {
            sysnonym sysnonym = new sysnonym();
            List<string> synonymList = await sysnonym.getSynonymListAsync(dicconProp.currentWord);
            bot.botSynonym(synonymList, exampleItemSynonym, exampleflowLayoutSynonym, flowChatBox);
            btSynonym.Visible = false;
        }

        private void textFromClipboard_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                searchTextBox.Text = Clipboard.GetText();
            }
        }

        private void addEmoji_Click(object sender, EventArgs e)
        {
            emoji emoji = new emoji();
            emoji.Location = new Point(Cursor.Position.X - emoji.Width / 2, Cursor.Position.Y - emoji.Height - 15);
            emoji.Show();
        }

        private async void btSend_Click(object sender, EventArgs e)
        {
            dicconProp.currentWord = searchTextBox.Text;
            await searchAndShow(dicconProp.currentWord);
        }

        private void realTimeDetermine_Tick(object sender, EventArgs e)
        {
            textFromClipboard.Visible = Clipboard.ContainsText() ? true : false;
        }
    }

}

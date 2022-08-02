using Diccon.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Diccon
{

    public partial class dictionary : Form
    {
        botBehavior bot = new botBehavior();
        userAction user = new userAction();
        connectivity connectivity = new connectivity();
        string spellingCorrectorCurrentWord = "";
        [STAThreadAttribute]
        private void mainHall_Load(object sender, EventArgs e)
        {
            synonymChecker.Enabled = true;
            //searchTextBox.Text = Clipboard.GetText();
            ///////  T   H   E   M   E  ///////////////
            panelNotice.BackColor = dicconProp.ColorA3;
            exampleAnswerColoredPanel.BackColor = dicconProp.ColorA3;
            exampleColoredPicturePanel.BackColor = dicconProp.ColorA3;
            exampleItemSynonym.BackColor = dicconProp.ColorA5;
            examplePlayColoredPanel.BackColor = dicconProp.ColorA5;
            btSynonym.BackColor = dicconProp.ColorA8;
            btImage.BackColor = dicconProp.ColorA8;
            addEmoji.BackColor = dicconProp.ColorA8;
            examplePictureBox.BackColor = dicconProp.ColorA7;
            roundedPanel1.BackColor = dicconProp.ColorA9;
            searchTextBox.BackColor = dicconProp.ColorA9;

            ///////////////////////////////////////////
            ///
            panelBottom.Height = dicconProp.bottomPanel_DefaultHeight;
            panelAdd.Visible = false;

            // setup flowchatbox to only show vertical scrollbar
            flowChatBox.HorizontalScroll.Visible = false;
            flowChatBox.HorizontalScroll.Enabled = false;
            flowChatBox.Padding = new Padding(10, 0, 0, 0);


        }



        private void textFromMic_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                speechToText speechToText = new speechToText();
                speechToText.Location = new Point(Cursor.Position.X - speechToText.Width / 2, Cursor.Position.Y - speechToText.Height - 15);
                speechToText.ShowDialog();

            });
            thread.Start();
            soundRelated sound = new soundRelated();
            searchTextBox.Text = sound.SpeechToText(dicconProp.listenTimeInString);
        }

        private void VisibleControlInSuggestionBar()
        {
            btSpellingCorrector.Visible = false;
            btSynonym.Visible = false;
            btImage.Visible = false;
        }
        private async void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e == null)
            {

                VisibleControlInSuggestionBar();

                dicconProp.currentWord = searchTextBox.Text.Trim();
                await searchAndShow(dicconProp.currentWord);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                VisibleControlInSuggestionBar();

                dicconProp.currentWord = searchTextBox.Text.Trim();
                await searchAndShow(dicconProp.currentWord);


            }




        }
        private string spellingCorrector(string word)
        {
            Spelling spelling = new Spelling();
            return spelling.Correct(word);
        }
        private async Task searchAndShow(string searchWord)
        {
            if (dicconProp.currentWord != "")
            {
                wordRelated word = new wordRelated();

                // if user type in just one word, so the case is we will use userSingMessage instead of userLongMessage
                int numberOfWord = word.countWord(searchTextBox.Text);

                if (numberOfWord > 1)
                {
                    bool isOnline = new connectivity().isOnline();
                    if (isOnline)
                    {
                        // add word to history file
                        addHistory(searchTextBox.Text);
                        // display message
                        user.userLongMessage(searchTextBox.Text + "\n", exampleAskLongText, exampleAskLongColoredPanel, exampleAskLongPanel, flowChatBox);
                        dicconProp.currentTranslatedWord = await bot.getTranslatedTextAsync(dicconProp.currentWord);
                        bot.botAnswerLongMessage(dicconProp.currentTranslatedWord + "\n", exampleAnswerText, exampleAnswerColoredPanel, exampleAnswerPanel, flowChatBox);
                    }
                    else
                    {
                        MessageBox.Show(dicconProp.errorInternet, dicconProp.caption);
                    }
                }
                else if (numberOfWord == 1)
                {
                    // display message 
                    user.userSingleMessage(searchTextBox.Text, exampleShortText, exampleShortPanel, flowChatBox);
                    bot.botSoundMessage(searchTextBox.Text, exampleTextHolder, examplePlayButton, examplePlayColoredPanel, examplePlayAlignPanel, examplePlayPanel, flowChatBox);
                    string definitionResult = searchMatchWord(searchTextBox.Text);
                    if(definitionResult != dicconProp.promptMissingWord)
                    {
                        // add word to history file if the word is exist in the dictionary database
                        addHistory(searchTextBox.Text);
                        bot.botAnswerLongMessage(definitionResult, exampleAnswerText, exampleAnswerColoredPanel, exampleAnswerPanel, flowChatBox);
                    }
                    else
                    {
                        bot.botAnswerLongMessage(definitionResult, exampleAnswerText, exampleAnswerColoredPanel, exampleAnswerPanel, flowChatBox);
                    }
                    suggestionTimer.Enabled = true;
                }
                searchTextBox.Text = "";
            }
        }
        private void addHistory(string word)
        {
            if (!File.Exists(dicconProp.historyFileName))
            {
                StreamWriter history = new StreamWriter(dicconProp.historyFileName);
                history.Write(word);
                history.Close();
            }
            else
            {
                StreamWriter history = new StreamWriter(dicconProp.historyFileName, true);
                history.Write(dicconProp.saparateCharactorInHistory);
                history.Write(word);
                history.Close();
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
            // update missing word to database
            if (connectivity.isOnline())
            {
                SQLHandler sqlHandler = new SQLHandler();
                if (wordsToSearch.Length > 9)
                    sqlHandler.Insert("Insert into dbo.DicconMissing values(N'" + dicconProp.userID + "',N'" + wordsToSearch.Substring(0, 9) + "')");
                else
                    sqlHandler.Insert("Insert into dbo.DicconMissing values(N'" + dicconProp.userID + "',N'" + wordsToSearch + "')");



            }
            return dicconProp.promptMissingWord;

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
            {
                panelAdd.Visible = false;
                panelBottom.Height = dicconProp.bottomPanel_DefaultHeight;

            }
            else
            {
                panelAdd.Visible = true;
                panelBottom.Height = dicconProp.bottomPanel_ExpandedHeight;

            }
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            panelBottom.Height = dicconProp.bottomPanel_DefaultHeight;
        }



        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // turn of Ding sound after hit Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void RoundedLabel_MouseEnter(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_MouseEnter(sender, e);
        }
        private void RoundedLabel_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_MouseLeave(sender, e);
        }
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            dicconProp.Control_MouseEnter(sender, e);
        }
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.Control_MouseLeave(sender, e);
        }
        private void tbFind_Leave(object sender, EventArgs e)
        {

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

        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




        private void exampleAnswerText_HScroll(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Suggest timer run when key down is triggered in search box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void suggestionTimer_TickAsync(object sender, EventArgs e)
        {
            // Get correct form of word from Spelling Corrector library
            spellingCorrectorCurrentWord = spellingCorrector(dicconProp.currentWord);
            if ((spellingCorrectorCurrentWord.Length > 1) && (spellingCorrectorCurrentWord.ToLower() != dicconProp.currentWord.ToLower()))
            {
                btSpellingCorrector.Text = spellingCorrectorCurrentWord.Replace(spellingCorrectorCurrentWord.Substring(0, 1), spellingCorrectorCurrentWord.Substring(0, 1).ToUpper());
                btSpellingCorrector.Visible = true;
            }
            else
            {
                btSpellingCorrector.Visible = false;
            }
            // Get other suggestions
            bool isOnline = new connectivity().isOnline();
            if (isOnline)
            {
                suggestionTimer.Enabled = false;
                sysnonym sysnonym = new sysnonym();
                if (await sysnonym.getSynonymListAsync(dicconProp.currentWord) == null)
                {
                    btSynonym.Visible = false;
                }
                else
                {
                    btSynonym.Visible = true;
                }
                imageRelated image = new imageRelated();
                if (await image.getImageUrl(dicconProp.currentWord) == "none")
                {
                    btImage.Visible = false;
                }
                else
                {
                    btImage.Visible = true;
                }

            }



        }

        private async void btSynonym_Click(object sender, EventArgs e)
        {
            btSynonym.Visible = false;
            sysnonym sysnonym = new sysnonym();
            List<string> synonymList = await sysnonym.getSynonymListAsync(dicconProp.currentWord);
            bot.botSynonym(synonymList, exampleItemSynonym, exampleflowLayoutSynonym, flowChatBox);

        }

        private void textFromClipboard_Click(object sender, EventArgs e)
        {

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


        public dictionary()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as ToolStripMenuItem).Owner.TopLevelControl.Name, dicconProp.caption);
        }

        private void btImage_Click(object sender, EventArgs e)
        {
            btImage.Visible = false;
            bot.botImageAnswer(examplePixabayLogo, examplePictureBox, exampleColoredPicturePanel, examplePicturePanel, flowChatBox);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dictionary_VisibleChanged(object sender, EventArgs e)
        {
            if (dicconProp.wordFromTimeline != "")
            {
                searchTextBox.Text = dicconProp.wordFromTimeline.Trim();
                dicconProp.wordFromTimeline = "";
            }
            //enable event to listen to clipboard changes if enable

        }
        private void issueLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void exampleNoteSave_Click(object sender, EventArgs e)
        {

        }

        private void dictionary_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btSpellingCorrector_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = btSpellingCorrector.Text;
            btSpellingCorrector.Visible = false;
            searchTextBox_KeyDown(null, null);
        }

        private void synonymChecker_Tick(object sender, EventArgs e)
        {
            if (dicconProp.wordFromSynonym != "")
            {
                searchTextBox.Text = dicconProp.wordFromSynonym;
                searchTextBox_KeyDown(null, null);
                dicconProp.wordFromSynonym = "";
            }
        }

        private void dictionary_Leave(object sender, EventArgs e)
        {

        }
    }

}

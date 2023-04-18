using Diccon.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccon
{

    public partial class dictionary : Form
    {
        BotBehavior bot = new BotBehavior();
        UserAction user = new UserAction();
        Connectivity connectivity = new Connectivity();
        string spellingCorrectorCurrentWord = "";
        Emoji emoji = new Emoji();
        [STAThreadAttribute]
        private void mainHall_Load(object sender, EventArgs e)
        {
            synonymChecker.Enabled = true;
            //searchTextBox.Text = Clipboard.GetText();
            ///////  T   H   E   M   E  ///////////////
            //panelNotice.BackColor = dicconProp.ColorA3;
            exampleAnswerColoredPanel.BackColor = DicconProp.ColorA3;
            exampleColoredPicturePanel.BackColor = DicconProp.ColorA3;
            exampleItemSynonym.BackColor = DicconProp.ColorA5;
            examplePlayColoredPanel.BackColor = DicconProp.ColorA5;
            listeningPanel.BackColor = DicconProp.ColorA9;
            btSynonym.BackColor = DicconProp.ColorA8;
            btImage.BackColor = DicconProp.ColorA8;
            addEmoji.BackColor = DicconProp.ColorA8;
            examplePictureBox.BackColor = DicconProp.ColorA7;
            roundedPanel1.BackColor = DicconProp.ColorA9;
            searchTextBox.BackColor = DicconProp.ColorA9;

            ///////////////////////////////////////////
            ///
            panelBottom.Height = DicconProp.BottomPanel_DefaultHeight;
            panelAdd.Visible = false;

            // setup flowchatbox to only show vertical scrollbar
            flowChatBox.HorizontalScroll.Visible = false;
            flowChatBox.HorizontalScroll.Enabled = false;
            flowChatBox.Padding = new Padding(10, 0, 0, 0);

            // load up one single random translate in the first time go here 
            if (DicconProp.FirstTimeOpen == true)
            {
                searchTextBox.Text = Properties.Settings.Default["lastWord"].ToString() ?? "hello";
                searchTextBox_KeyDown(null, null);
            }
            DicconProp.FirstTimeOpen = false;

        }



        private void textFromMic_Click(object sender, EventArgs e)
        {
            listeningPanel.Visible = true;
            listeningPanel.Refresh();
            SoundRelated sound = new SoundRelated();
            searchTextBox.Text = sound.SpeechToText(DicconProp.ListenTimeInString);
            listeningPanel.Visible = false;
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
                DicconProp.CurrentWord = searchTextBox.Text.Trim();
                await SearchAndShow(DicconProp.CurrentWord);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                VisibleControlInSuggestionBar();

                DicconProp.CurrentWord = searchTextBox.Text.Trim();
                await SearchAndShow(DicconProp.CurrentWord);
            }
        }
        private string SpellingCorrector(string word)
        {
            SpellingCorrector spelling = new SpellingCorrector();
            return spelling.Correct(word);
        }
        private async Task SearchAndShow(string searchWord)
        {
            if (string.IsNullOrEmpty(DicconProp.CurrentWord)) return;

            WordRelated word = new WordRelated();
            var numberOfWord = word.CountWord(searchWord);
            if (numberOfWord > 3)
                user.UserLongMessage($"{searchWord}\n", exampleAskLongText, exampleAskLongColoredPanel, exampleAskLongPanel, flowChatBox);
            else
                user.UserSingleMessage(searchWord, exampleShortText, exampleShortPanel, flowChatBox);


            bot.BotSoundMessage(searchWord, exampleTextHolder, examplePlayButton, examplePlayColoredPanel, examplePlayAlignPanel, examplePlayPanel, flowChatBox);
            var definitionResult = await SearchMatchWord(searchWord);

            if (definitionResult != DicconProp.PromptMissingWord)
            {
                // add word to history file if the word is exist in the dictionary database
                AddHistory(searchWord);
                Properties.Settings.Default["lastWord"] = searchWord;
                Properties.Settings.Default.Save();
                bot.BotAnswerLongMessage(definitionResult, exampleAnswerText, exampleAnswerColoredPanel, exampleAnswerPanel, flowChatBox);
            }
            else
            {
                bool isOnline = new Connectivity().IsOnline();
                if (isOnline)
                {
                    // add word to history file
                    AddHistory(searchWord);
                    // display message
                    DicconProp.CurrentTranslatedWord = await bot.GetEnViTranslatedTextAsync(DicconProp.CurrentWord);
                    if (DicconProp.CurrentTranslatedWord == DicconProp.CurrentWord)
                        DicconProp.CurrentTranslatedWord = await bot.GetViEnTranslatedTextAsync(DicconProp.CurrentWord);
                    bot.BotAnswerLongMessage(DicconProp.CurrentTranslatedWord + "\n", exampleAnswerText, exampleAnswerColoredPanel, exampleAnswerPanel, flowChatBox);
                }
                else
                {
                    MessageBox.Show(DicconProp.ErrorInternet, DicconProp.caption);
                }
            }
            suggestionTimer.Enabled = true;

            searchTextBox.Text = "";

        }
        private void AddHistory(string word)
        {
            if (!File.Exists(DicconProp.HistoryFileName))
            {
                using (StreamWriter history = new StreamWriter(DicconProp.HistoryFileName))
                {
                    history.Write(word);
                }
            }
            else
            {
                using (StreamWriter history = new StreamWriter(DicconProp.HistoryFileName, true))
                {
                    history.Write(DicconProp.SaparateCharactorInHistory);
                    history.Write(word);
                }
            }
        }
        public async Task<string> SearchMatchWord(string wordsToSearch) // THIS IS FUNCTION TO SEARCH TEXT 
        {
            // xử lí từ ngữ được người dùng nhập vào------------------
            WordRelated word = new WordRelated();
            // Nạp từ vào đối tượng
            word.PreWord = wordsToSearch;
            // Xử lí từ và lấy kết quả
            wordsToSearch = word.SearchWordProcess();
            var resultFromList = DicconProp.splitedText.FirstOrDefault(w => w.Contains("•" + wordsToSearch));
            if (!string.IsNullOrEmpty(resultFromList))
            {
                return resultFromList.ToString();
            }
            else
            {
                // update missing word to database
                if (connectivity.IsOnline())
                {
                    var wordsToInsert = wordsToSearch.Length > 9 ? wordsToSearch.Substring(0, 9) : wordsToSearch;
                    SQLHandler sqlHandler = new SQLHandler();
                    await sqlHandler.InsertAsync($"Insert into dbo.DicconMissing values(N'{DicconProp.UserID}', N'{wordsToInsert}')");

                }
                return DicconProp.PromptMissingWord;
            }
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
            if (panelBottom.Height == DicconProp.BottomPanel_ExpandedHeight)
            {
                panelAdd.Visible = false;
                panelBottom.Height = DicconProp.BottomPanel_DefaultHeight;

            }
            else
            {
                panelAdd.Visible = true;
                panelBottom.Height = DicconProp.BottomPanel_ExpandedHeight;

            }
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            panelBottom.Height = DicconProp.BottomPanel_DefaultHeight;
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
            DicconProp.RoundedLabel_MouseEnter(sender, e);
        }
        private void RoundedLabel_MouseLeave(object sender, EventArgs e)
        {
            DicconProp.RoundedLabel_MouseLeave(sender, e);
        }
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            DicconProp.Control_MouseEnter(sender, e);
        }
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            DicconProp.Control_MouseLeave(sender, e);
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

        /// <summary>
        /// Suggest timer run when key down is triggered in search box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void suggestionTimer_TickAsync(object sender, EventArgs e)
        {
            // Get correct form of word from Spelling Corrector library
            spellingCorrectorCurrentWord = SpellingCorrector(DicconProp.CurrentWord);
            spellingCorrectorCurrentWord = spellingCorrectorCurrentWord.ToLower();
            if ((spellingCorrectorCurrentWord.Length > 1) && (spellingCorrectorCurrentWord != DicconProp.CurrentWord.ToLower()))
            {

                btSpellingCorrector.Text = spellingCorrectorCurrentWord.Replace(spellingCorrectorCurrentWord.Substring(0, 1), spellingCorrectorCurrentWord.Substring(0, 1).ToUpper());
                btSpellingCorrector.Visible = true;
            }
            else
            {
                btSpellingCorrector.Visible = false;
            }
            // Get other suggestions
            bool isOnline = new Connectivity().IsOnline();
            if (isOnline)
            {
                suggestionTimer.Enabled = false;
                var synonyms = new Synonym();
                if (await synonyms.GetSynonymListAsync(DicconProp.CurrentWord) == null)
                {
                    btSynonym.Visible = false;
                }
                else
                {
                    btSynonym.Visible = true;
                }
                ImageRelated image = new ImageRelated();
                if (await image.GetImageUrl(DicconProp.CurrentWord) == "none")
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
            var synonyms = new Synonym();
            List<string> synonymList = await synonyms.GetSynonymListAsync(DicconProp.CurrentWord);
            bot.BotSynonym(synonymList, exampleItemSynonym, exampleflowLayoutSynonym, flowChatBox);

        }

        private void textFromClipboard_Click(object sender, EventArgs e)
        {

        }

        private void addEmoji_Click(object sender, EventArgs e)
        {
            emoji.TopLevel = false;
            flowChatBox.Controls.Add(emoji);
            emoji.Show();
            flowChatBox.ScrollControlIntoView(emoji);
            buttonAdd_Click(null, null);
        }

        private async void btSend_Click(object sender, EventArgs e)
        {
            DicconProp.CurrentWord = searchTextBox.Text;
            await SearchAndShow(DicconProp.CurrentWord);
        }


        public dictionary()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as ToolStripMenuItem).Owner.TopLevelControl.Name, DicconProp.caption);
        }

        private void btImage_Click(object sender, EventArgs e)
        {
            btImage.Visible = false;
            bot.BotImageAnswer(examplePixabayLogo, examplePictureBox, exampleColoredPicturePanel, examplePicturePanel, flowChatBox);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dictionary_VisibleChanged(object sender, EventArgs e)
        {
            if (DicconProp.WordFromTimeline != "")
            {
                searchTextBox.Text = DicconProp.WordFromTimeline.Trim();
                DicconProp.WordFromTimeline = "";
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
            if (DicconProp.WordFromSynonym != "")
            {
                searchTextBox.Text = DicconProp.WordFromSynonym;
                searchTextBox_KeyDown(null, null);
                DicconProp.WordFromSynonym = "";
            }
        }

        private void dictionary_Leave(object sender, EventArgs e)
        {

        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (PanelOfFind.Visible == true) PanelOfFind.Visible = false;
            else PanelOfFind.Visible = true;
        }

        private void textFromMic_Click(object sender, EventArgs e)
        {
            soundRelated sound = new soundRelated();
            searchTextBox.Text = sound.SpeechToText("00:00:07");
        }

        private void textFromEmoji_Click(object sender, EventArgs e)
        {


        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (searchTextBox.Text.Replace(" ", "") != "")
                {
                    wordFunction word = new wordFunction();
                    // if user type in just one word, so the case is we will use userSingMessage instead of userLongMessage
                    int numberOfWord = word.countWord(searchTextBox.Text);
                    switch (numberOfWord)
                    {
                        case 0:
                        case 1:
                            user.userSingleMessage(searchTextBox.Text, exampleShortText, exampleShortPanel, flowChatBox);
                            bot.botSoundMessage(searchTextBox.Text, examplePlayButton, examplePlayColoredPanel, examplePlayAlignPanel, examplePlayPanel, flowChatBox);
                            bot.botAnswerLongMessage(searchMatchWord(searchTextBox.Text), exampleAnswerText, exampleAnswerColoredPanel, exampleAnswerPanel, flowChatBox);
                            break;

                        default:
                            user.userLongMessage(searchTextBox.Text, exampleAskLongText, exampleAskLongPanel, exampleAskLongPanel, flowChatBox);
                            break;
                    }
                    searchTextBox.Text = "";
                }

            }
        }

        private void roundedLabel3_Click(object sender, EventArgs e)
        {

        }
        public string searchMatchWord(string wordsToSearch) // THIS IS FUNCTION TO SEARCH TEXT 
        {

            // xử lí từ ngữ được người dùng nhập vào------------------
            wordFunction word = new wordFunction();
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

        }

        private void exampleAnswerText_Layout(object sender, LayoutEventArgs e)
        {

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
            int R = roundedLabel.BackColor.R > 50 ? roundedLabel.BackColor.R - 50 : roundedLabel.BackColor.R;
            int G = roundedLabel.BackColor.G > 50 ? roundedLabel.BackColor.G - 50 : roundedLabel.BackColor.G;
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
            int R = roundedLabel.BackColor.R < 200 ? roundedLabel.BackColor.R + 50 : roundedLabel.BackColor.R;
            int G = roundedLabel.BackColor.G < 200 ? roundedLabel.BackColor.G + 50 : roundedLabel.BackColor.G;
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
            int X= pictureBox.Location.X;
            int Y= pictureBox.Location.Y-2;
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
    }

}

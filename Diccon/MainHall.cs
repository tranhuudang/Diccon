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
            // download data if not yet dowloaded or loss
            //if (!Directory.Exists(dicconProp.resource_directory))
            //{
            //    Directory.CreateDirectory(dicconProp.resource_directory);
            //    DownloadData();
            //}
            //else
            //{
            //    // re-download if not found in resource folder or loss
            //    if (!File.Exists(dicconProp.envi_data_filename))
            //    {
            //        DownloadData();
            //    }
            //    else
            //    {

            //        //TextDataFromResources = File.ReadAllText(dicconProp.envi_data_filename);
            //        //splitedText = TextDataFromResources.Split("@".ToCharArray());

            //    }
            //}


        }
        //private void DownloadData()
        //{
        //    Thread downloadData = new Thread(() =>
        //    {
        //        WebClient client = new WebClient();
        //        client.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadData_DownloadFileCompleted);
        //        client.DownloadFileAsync(new Uri(dicconProp.envi_data_url), dicconProp.envi_data_filename);
        //    }
        //       );
        //    downloadData.Start();

        //}
        //void downloadData_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        //{
        //    this.BeginInvoke((MethodInvoker)delegate
        //    {

        //        if (File.Exists(dicconProp.envi_data_filename))
        //        {
        //            //TextDataFromResources = File.ReadAllText(dicconProp.envi_data_filename);
        //        }

        //    });
        //}


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
                            var timer = new Stopwatch();
                            timer.Start();

                            bot.botAnswerLongMessage(searchMatchWord(searchTextBox.Text), exampleAnswerText, exampleAnswerColoredPanel, exampleAnswerPanel, flowChatBox);

                            timer.Stop();
                            TimeSpan timeTaken = timer.Elapsed;
                            MessageBox.Show("Time taken: " + timeTaken.ToString(@"m\:ss\.fff"));
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
    }

}

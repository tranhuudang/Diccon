using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccon
{
    internal class botBehavior
    {
        string Setting_ShortView = Properties.Settings.Default["shortView"].ToString();
        public void botAnswerLongMessage(string answerText, RichTextBox exampleRichTextBox, Panel exampleColoredPanel, Panel exampleParentPanel, FlowLayoutPanel targetFlowLayout)
        {
            Panel newAnswerPanel = new Panel();
            RoundedPanel newColoredPanel = new RoundedPanel();
            newColoredPanel.Dock = exampleColoredPanel.Dock;
            newColoredPanel.BackColor = exampleColoredPanel.BackColor;
            newColoredPanel.Width = exampleColoredPanel.Width;


            RichTextBox newRichTextBox = new RichTextBox();
            if (Setting_ShortView == "True") newRichTextBox.Text = answerText;
            newRichTextBox.Click += newRichTextBox_ClickToExpand;
            newRichTextBox.TextChanged += newRichTextBox_TextChanged;
            newRichTextBox.BackColor = exampleRichTextBox.BackColor;
            newRichTextBox.ForeColor = exampleRichTextBox.ForeColor;
            newRichTextBox.Font = exampleRichTextBox.Font;
            newRichTextBox.Width = exampleRichTextBox.Width;
            newRichTextBox.Dock = exampleRichTextBox.Dock;
            newRichTextBox.Location = exampleRichTextBox.Location;
            newRichTextBox.BorderStyle = BorderStyle.None;
            newRichTextBox.ScrollBars = RichTextBoxScrollBars.None;
            newRichTextBox.Cursor = exampleRichTextBox.Cursor;


            newColoredPanel.Controls.Add(newRichTextBox);
            newRichTextBox.Parent = newColoredPanel;


            newAnswerPanel.Width = exampleParentPanel.Width;
            newAnswerPanel.Height = newRichTextBox.Height + 28;


            newAnswerPanel.Controls.Add(newColoredPanel);

            targetFlowLayout.Controls.Add(newAnswerPanel);

            // these if condition is a way to display short/long message (original from a bug :))) )
            if (Setting_ShortView == "False") newRichTextBox.Text = answerText;

            targetFlowLayout.ScrollControlIntoView(newAnswerPanel);
        }

        private void newRichTextBox_ClickToExpand(object sender, EventArgs e)
        {
            RichTextBox textMessage = (sender as RichTextBox);
            FlowLayoutPanel grandFlowLayout = (textMessage.Parent.Parent.Parent as FlowLayoutPanel);
            Panel panel = (textMessage.Parent.Parent as Panel);
            int lineHeight = 20;
            int lineCount = textMessage.GetLineFromCharIndex(textMessage.TextLength);
            textMessage.Height = lineHeight * lineCount;
            textMessage.Parent.Parent.Height = textMessage.Height + 20;
            grandFlowLayout.ScrollControlIntoView(panel);
            // refresh to get rid of unrendered design
            grandFlowLayout.Refresh();
        }

        private void newRichTextBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox textMessage = (sender as RichTextBox);
            var parentPanel = textMessage.Parent.Parent;
            parentPanel.Visible = false;

            int lineHeight = 20;
            int lineCount = textMessage.GetLineFromCharIndex(textMessage.TextLength);
            textMessage.Height = lineHeight * lineCount;
            parentPanel.Height = textMessage.Height + 20;
            parentPanel.Visible = true;

        }
        public void botSoundMessage(String textToPlay,PictureBox examplePlayButton, RoundedPanel exampleColoredPanel, Panel examplePlayAlignPanel, Panel examplePanel, FlowLayoutPanel targetFlowPanel)
        {
            Panel newPanel = new Panel();
            Panel newAlignPanel = new Panel();
            RoundedPanel newColoredPanel = new RoundedPanel();
            PictureBox playButton = new PictureBox();


            playButton.Location = examplePlayButton.Location;
            playButton.Size= examplePlayButton.Size;
            playButton.Image = examplePlayButton.Image;
            playButton.Tag = textToPlay;
            playButton.Cursor = examplePlayButton.Cursor;
            playButton.Click += PlayButton_Click;

            newColoredPanel.Size = exampleColoredPanel.Size;
            newColoredPanel.BackColor = exampleColoredPanel.BackColor;
            newColoredPanel.Location = exampleColoredPanel.Location;

            newAlignPanel.Dock = examplePlayAlignPanel.Dock;
            newAlignPanel.Size = examplePlayAlignPanel.Size;

            newPanel.Size = examplePanel.Size;

            newColoredPanel.Controls.Add(playButton);
            newAlignPanel.Controls.Add(newColoredPanel);
            newPanel.Controls.Add(newAlignPanel);
            targetFlowPanel.Controls.Add(newPanel);

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            string text= (sender as PictureBox).Tag.ToString();
            botSoundPlay(text, "us");
        }

        /// <summary>
        /// Play sound of a word in a area ("us"/"uk")
        /// </summary>
        /// <param name="text"></param>
        /// <param name="area"></param>
        public void botSoundPlay(string text, string area)
        {
            soundRelated player = new soundRelated();
            wordFunction word = new wordFunction();
            word.PreWord = text;
            word.SearchWordProcess();
            player.SoundUrl = word.OnlineUrlProcess(area);
            player.OnlinePlay();
            if (player.OnlinePlay() == false)
            {
                player.MachinePlay(word.OutWord);
            }
        }
    }
}

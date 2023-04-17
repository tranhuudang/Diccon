using System;
using System.Windows.Forms;

namespace Diccon
{
    internal class UserAction
    {
        /// <summary>
        /// Create long message box, often use when user want to translate a paragraph
        /// </summary>
        /// <param name="userMessage"></param>
        /// <param name="exampleRichTextBox"></param>
        /// <param name="exampleColoredPanel"></param>
        /// <param name="exampleParentPanel"></param>
        /// <param name="targetFlowLayout"></param>
        public void UserLongMessage(string userMessage, Label exampleLabel, Panel exampleColoredPanel, Panel exampleParentPanel, FlowLayoutPanel targetFlowLayout)
        {
            Panel newAnswerPanel = new Panel();
            RoundedPanel newColoredPanel = new RoundedPanel();
            newColoredPanel.Dock = exampleColoredPanel.Dock;
            newColoredPanel.BackColor = exampleColoredPanel.BackColor;
            newColoredPanel.Width = exampleColoredPanel.Width;

            Label newLabel = new Label();
            newLabel.Text = userMessage;
            newLabel.MaximumSize = exampleLabel.MaximumSize;
            newLabel.Location = exampleLabel.Location;
            newLabel.AutoSize = false;
            newLabel.Height = newColoredPanel.Height - 20;
            newLabel.Width = exampleLabel.MaximumSize.Width;
            newLabel.Font = exampleLabel.Font;
            newLabel.ForeColor = exampleLabel.ForeColor;
            newLabel.Click += NewLabel_Click; ;
            newLabel.Cursor = Cursors.Hand;
            newColoredPanel.Controls.Add(newLabel);
            newLabel.Parent = newColoredPanel;

            newAnswerPanel.Width = exampleParentPanel.Width;
            newAnswerPanel.Controls.Add(newColoredPanel);

            targetFlowLayout.Controls.Add(newAnswerPanel);
            targetFlowLayout.ScrollControlIntoView(newAnswerPanel);
        }

        private void NewLabel_Click(object sender, EventArgs e)
        {
            Label lb = (sender as Label);
            FlowLayoutPanel grandFlowLayout = (lb.Parent.Parent.Parent as FlowLayoutPanel);
            lb.AutoSize = true;
            lb.Parent.Height = lb.Height + 20;
            lb.Parent.Parent.Height = lb.Height + 20;
            lb.Cursor = Cursors.Default;
            // refresh to get rid of unrendered design
            grandFlowLayout.Refresh();
        }


        public void UserSingleMessage(string userMessage, Label exampleText, Panel examplePanel, FlowLayoutPanel targetFlowLayout)
        {
            int searchText_Len = userMessage.Length;
            RoundedLabel newLabel = new RoundedLabel();
            string processedText = userMessage[0].ToString().ToUpper() + userMessage.Substring(1).ToLower();
            newLabel.Text = processedText;
            newLabel.BackColor = exampleText.BackColor;
            newLabel.ForeColor = exampleText.ForeColor;
            newLabel.Font = exampleText.Font;
            newLabel.AutoSize = true;
            newLabel.TextAlign = exampleText.TextAlign;
            newLabel.Dock = exampleText.Dock;
            newLabel.Padding = exampleText.Padding;

            Panel newPanel = new Panel();
            newPanel.Width = examplePanel.Width;
            newPanel.Height = examplePanel.Height;

            newPanel.Controls.Add(newLabel);

            targetFlowLayout.Controls.Add(newPanel);
            targetFlowLayout.ScrollControlIntoView(newPanel);
        }

    }
}

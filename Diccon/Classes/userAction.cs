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
        public void UserLongMessage(string userMessage, System.Windows.Forms.Label exampleLabel, Panel exampleColoredPanel, Panel exampleParentPanel, FlowLayoutPanel targetFlowLayout)
        {
            RoundedPanel newColoredPanel = new RoundedPanel()
            {
                Dock = exampleColoredPanel.Dock,
                BackColor = exampleColoredPanel.BackColor,
                Width = exampleColoredPanel.Width,
            };
            System.Windows.Forms.Label newLabel = new System.Windows.Forms.Label()
            {
                Text = userMessage,
                MaximumSize = exampleLabel.MaximumSize,
                Location = exampleLabel.Location,
                AutoSize = false,
                Height = newColoredPanel.Height - 20,
                Width = exampleLabel.MaximumSize.Width,
                Font = exampleLabel.Font,
                ForeColor = exampleLabel.ForeColor,
                Cursor = Cursors.Hand,
                Parent = newColoredPanel,
            };
            newLabel.Click += NewLabel_Click;

            Panel newAnswerPanel = new Panel()
            {
                Width = exampleParentPanel.Width,
            };
            newAnswerPanel.Controls.Add(newColoredPanel);

            targetFlowLayout.Controls.Add(newAnswerPanel);
            targetFlowLayout.ScrollControlIntoView(newAnswerPanel);
        }

        private void NewLabel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Label lb = (sender as System.Windows.Forms.Label);
            FlowLayoutPanel grandFlowLayout = (lb.Parent.Parent.Parent as FlowLayoutPanel);
            lb.AutoSize = true;
            lb.Parent.Height = lb.Height + 20;
            lb.Parent.Parent.Height = lb.Height + 20;
            lb.Cursor = Cursors.Default;
            // refresh to get rid of unrendered design
            grandFlowLayout.Refresh();
        }


        public void UserSingleMessage(string userMessage, System.Windows.Forms.Label exampleText, Panel examplePanel, FlowLayoutPanel targetFlowLayout)
        {
            int searchText_Len = userMessage.Length;
            string processedText = userMessage[0].ToString().ToUpper() + userMessage.Substring(1).ToLower();
            RoundedLabel newLabel = new RoundedLabel()
            {
                Text = processedText,
                BackColor = exampleText.BackColor,
                ForeColor = exampleText.ForeColor,
                Font = exampleText.Font,
                AutoSize = true,
                TextAlign = exampleText.TextAlign,
                Dock = exampleText.Dock,
                Padding = exampleText.Padding,
            };
            Panel newPanel = new Panel()
            {
                Width = examplePanel.Width,
                Height = examplePanel.Height,
            };

            newPanel.Controls.Add(newLabel);

            targetFlowLayout.Controls.Add(newPanel);
            targetFlowLayout.ScrollControlIntoView(newPanel);
        }

    }
}

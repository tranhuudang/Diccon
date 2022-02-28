using System.Windows.Forms;

namespace Diccon
{
    internal class userAction
    {

        public void userLongMessage(string userMessage, RichTextBox exampleRichTextBox, Panel exampleColoredPanel, Panel exampleParentPanel, FlowLayoutPanel targetFlowLayout)
        {
            Panel newAnswerPanel = new Panel();
            RoundedPanel newColoredPanel = new RoundedPanel();
            newColoredPanel.Dock = exampleColoredPanel.Dock;
            newColoredPanel.BackColor = exampleColoredPanel.BackColor;
            newColoredPanel.Width = exampleColoredPanel.Width;

            RichTextBox newRichTextBox = new RichTextBox();
            newRichTextBox.Click += NewRichTextBox_Click;
            newRichTextBox.BackColor = exampleRichTextBox.BackColor;
            newRichTextBox.ForeColor = exampleRichTextBox.ForeColor;
            newRichTextBox.Font = exampleRichTextBox.Font;
            newRichTextBox.Width = exampleRichTextBox.Width;
            newRichTextBox.Dock = exampleRichTextBox.Dock;
            newRichTextBox.Location = exampleRichTextBox.Location;
            newRichTextBox.BorderStyle = BorderStyle.None;
            newRichTextBox.ScrollBars = RichTextBoxScrollBars.None;
            newRichTextBox.Cursor = exampleRichTextBox.Cursor;

            newRichTextBox.TextChanged += NewRichTextBox_TextChanged;

            newColoredPanel.Controls.Add(newRichTextBox);
            newRichTextBox.Parent = newColoredPanel;

            newAnswerPanel.Width = exampleParentPanel.Width;
            newAnswerPanel.Height = newRichTextBox.Height + 28;

            newAnswerPanel.Controls.Add(newColoredPanel);
            newAnswerPanel.MinimumSize= exampleParentPanel.MinimumSize;

            targetFlowLayout.Controls.Add(newAnswerPanel);

            // these if condition is a way to display short and long message when click (original from a bug :))) )
            newRichTextBox.Text = userMessage;

            targetFlowLayout.ScrollControlIntoView(newAnswerPanel);
        }

        private void NewRichTextBox_TextChanged(object sender, System.EventArgs e)
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


        private void NewRichTextBox_Click(object sender, System.EventArgs e)
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

        public void userSingleMessage(string userMessage, Label exampleText, Panel examplePanel, FlowLayoutPanel targetFlowLayout)
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
        public void userAddNote(Label exampleMenu, RichTextBox exampleRichtextbox, RoundedPanel coloredPanel, Panel panel, FlowLayoutPanel targetFlowLayout)
        {
            Label newMenu = new Label();
            RichTextBox newRichtextbox = new RichTextBox();
            RoundedPanel newColoredPanel = new RoundedPanel();
            Panel newPanel = new Panel();

            newMenu.Location = exampleMenu.Location;
            newMenu.Text = exampleMenu.Text;
            newMenu.Font = exampleMenu.Font;
            newMenu.ForeColor = exampleMenu.ForeColor;

            newRichtextbox.Size = exampleRichtextbox.Size;
            newRichtextbox.Font = exampleRichtextbox.Font;
            newRichtextbox.Location = exampleRichtextbox.Location;
            newRichtextbox.BorderStyle = exampleRichtextbox.BorderStyle;
            newRichtextbox.BackColor = exampleRichtextbox.BackColor;
            newRichtextbox.ForeColor = exampleRichtextbox.ForeColor;

            newColoredPanel.Size = coloredPanel.Size;
            newColoredPanel.BackColor = coloredPanel.BackColor;

            newPanel.Size = panel.Size;

            newColoredPanel.Controls.Add(newMenu);
            newColoredPanel.Controls.Add(newRichtextbox);
            newPanel.Controls.Add(newColoredPanel);
            targetFlowLayout.Controls.Add(newPanel);
            targetFlowLayout.ScrollControlIntoView(newPanel);
        }

    }
}

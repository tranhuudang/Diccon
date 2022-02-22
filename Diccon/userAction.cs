using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccon
{
    internal class userAction
    {
       
        public void userLongMessage(string userMessage, Label exampleText, Panel exampleColoredPanel, Panel exampleParentPanel, FlowLayoutPanel targetFlowLayout)
        {

            RoundedPanel newColoredPanel = new RoundedPanel();
            newColoredPanel.Dock = exampleColoredPanel.Dock;
            newColoredPanel.BackColor = exampleColoredPanel.BackColor;
            newColoredPanel.Width = exampleColoredPanel.Width;


            Label newLabel = new Label();
            newLabel.Text = userMessage;
            newLabel.BackColor = exampleText.BackColor;
            newLabel.ForeColor = exampleText.ForeColor;
            newLabel.Font = exampleText.Font;
            newLabel.Width = exampleText.Width;
            newLabel.TextAlign = exampleText.TextAlign;
            newLabel.Dock = exampleText.Dock;
            newLabel.Location = exampleText.Location;
            newLabel.AutoSize = true;

            newColoredPanel.Controls.Add(newLabel);
            newLabel.Parent = newColoredPanel;

            Panel newAnswerPanel = new Panel();
            newAnswerPanel.Width = exampleParentPanel.Width;
            newAnswerPanel.Height = newLabel.Height + 25;

            newAnswerPanel.Controls.Add(newColoredPanel);

            targetFlowLayout.Controls.Add(newAnswerPanel);
            targetFlowLayout.ScrollControlIntoView(newAnswerPanel);
        }
        public void userSingleMessage(string userMessage, Label exampleText,Panel examplePanel, FlowLayoutPanel targetFlowLayout)
        {
            int searchText_Len = userMessage.Length;
            RoundedLabel newLabel = new RoundedLabel();
            string processedText = userMessage[0].ToString().ToUpper() + userMessage.Substring(1).ToLower();
            newLabel.Text = processedText;
            newLabel.BackColor = exampleText.BackColor;
            newLabel.ForeColor = exampleText.ForeColor;
            newLabel.Font = exampleText.Font;
            int calculatedWidth = exampleText.Width + searchText_Len * 5;
            newLabel.Width = calculatedWidth;
            newLabel.TextAlign = exampleText.TextAlign;
            newLabel.Dock = exampleText.Dock;
            newLabel.Padding= exampleText.Padding;

            Panel newPanel = new Panel();
            newPanel.Width = examplePanel.Width;
            newPanel.Height = examplePanel.Height;

            newPanel.Controls.Add(newLabel);

            targetFlowLayout.Controls.Add(newPanel);
            targetFlowLayout.ScrollControlIntoView(newPanel);
        }
        public void userAddNote(Label exampleMenu, RichTextBox exampleRichtextbox, RoundedPanel coloredPanel, Panel panel, FlowLayoutPanel targetFlowLayout)
        {
            Label newMenu= new Label();
            RichTextBox newRichtextbox = new RichTextBox();
            RoundedPanel newColoredPanel = new RoundedPanel();
            Panel newPanel= new Panel();

            newMenu.Location = exampleMenu.Location;
            newMenu.Text = exampleMenu.Text;
            newMenu.Font = exampleMenu.Font;
            newMenu.ForeColor = exampleMenu.ForeColor;

            newRichtextbox.Size = exampleRichtextbox.Size;
            newRichtextbox.Font = exampleRichtextbox.Font;
            newRichtextbox.Location = exampleRichtextbox.Location;
            newRichtextbox.BorderStyle = exampleRichtextbox.BorderStyle;
            newRichtextbox.BackColor= exampleRichtextbox.BackColor;
            newRichtextbox.ForeColor=exampleRichtextbox.ForeColor;

            newColoredPanel.Size = coloredPanel.Size;
            newColoredPanel.BackColor= coloredPanel.BackColor;

            newPanel.Size = panel.Size;

            newColoredPanel.Controls.Add(newMenu);
            newColoredPanel.Controls.Add(newRichtextbox);
            newPanel.Controls.Add(newColoredPanel);
            targetFlowLayout.Controls.Add(newPanel);
            targetFlowLayout.ScrollControlIntoView(newPanel);
        }

    }
}

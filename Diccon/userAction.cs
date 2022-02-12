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

            Panel newColoredPanel = new Panel();
            newColoredPanel.Dock = exampleColoredPanel.Dock;
            newColoredPanel.BackColor = exampleColoredPanel.BackColor;
            newColoredPanel.Width = exampleColoredPanel.Width;


            MultiLineLabel newLabel = new MultiLineLabel();
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
            Label newLabel = new Label();
            string processedText = userMessage[0].ToString().ToUpper() + userMessage.Substring(1).ToLower();
            newLabel.Text = processedText;
            newLabel.BackColor = exampleText.BackColor;
            newLabel.ForeColor = exampleText.ForeColor;
            newLabel.Font = exampleText.Font;
            int calculatedWidth = exampleText.Width + searchText_Len * 7;
            newLabel.Width = calculatedWidth;
            newLabel.TextAlign = exampleText.TextAlign;
            newLabel.Dock = exampleText.Dock;

            Panel newPanel = new Panel();
            newPanel.Width = examplePanel.Width;
            newPanel.Height = examplePanel.Height;

            newPanel.Controls.Add(newLabel);

            targetFlowLayout.Controls.Add(newPanel);
            targetFlowLayout.ScrollControlIntoView(newPanel);
        }


    }
}

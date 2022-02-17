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
        string Setting_ShortView= Properties.Settings.Default["shortView"].ToString();
        public void botAnswerLongMessage(string answerText, RichTextBox exampleRichTextBox, Panel exampleColoredPanel, Panel exampleParentPanel, FlowLayoutPanel targetFlowLayout)
        {
            Panel newAnswerPanel = new Panel();
            RoundedPanel newColoredPanel = new RoundedPanel();
            newColoredPanel.Dock = exampleColoredPanel.Dock;
            newColoredPanel.BackColor = exampleColoredPanel.BackColor;
            newColoredPanel.Width = exampleColoredPanel.Width;


            RichTextBox newRichTextBox = new RichTextBox();
            if (Setting_ShortView=="True") newRichTextBox.Text = answerText;
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
            parentPanel.Height= textMessage.Height+20;
            parentPanel.Visible = true;

        }
    }
}

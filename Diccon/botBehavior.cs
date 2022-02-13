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
        public void botAnswerLongMessage(string answerText, Label exampleText, Panel exampleColoredPanel, Panel exampleParentPanel, FlowLayoutPanel targetFlowLayout)
        {

            RoundedPanel newColoredPanel = new RoundedPanel();
            newColoredPanel.Dock = exampleColoredPanel.Dock;
            newColoredPanel.BackColor = exampleColoredPanel.BackColor;
            newColoredPanel.Width = exampleColoredPanel.Width;


            MultiLineLabel newLabel = new MultiLineLabel();
            newLabel.Text = answerText;
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

    }
}

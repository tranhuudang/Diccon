using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccon
{
    public partial class mainHall : Form
    {
        public mainHall()
        {
            InitializeComponent();
        }

        private void mainHall_Load(object sender, EventArgs e)
        {
            flowChatBox.VerticalScroll.Value = flowChatBox.VerticalScroll.Maximum;
        }

        private void sent_Click(object sender, EventArgs e)
        {
            //Label newLabel = new Label();
            //newLabel.Text = searchBox.Text;
            //newLabel.BackColor = Color.Silver;
            //newLabel.ForeColor = Color.Black;
            //newLabel.Font= Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            //newLabel.Width = 299;
            //newLabel.TextAlign = ContentAlignment.MiddleLeft;
            //newLabel.Dock = DockStyle.Left;

            //Panel newPanel = new Panel();
            //newPanel.Width = 377;
            //newPanel.Height = 46;

            //newPanel.Controls.Add(newLabel);

            //flowChatBox.Controls.Add(newPanel);

            userMessage(searchBox.Text);


        }
       
        void userMessage(string searchText)
        {
            int searchText_Len = searchText.Length;
            Label newLabel = new Label();
            string processedText = searchText[0].ToString().ToUpper() + searchText.Substring(1).ToLower();
            newLabel.Text = processedText;
            newLabel.BackColor = exampleText.BackColor;
            newLabel.ForeColor = exampleText.ForeColor;
            newLabel.Font = exampleText.Font;
            int calculatedWidth= exampleText.Width + searchText_Len * 7;
            newLabel.Width = calculatedWidth;
            newLabel.TextAlign = exampleText.TextAlign;
            newLabel.Dock = exampleText.Dock;

            Panel newPanel = new Panel();
            newPanel.Width = examplePanel.Width;
            newPanel.Height = examplePanel.Height;

            newPanel.Controls.Add(newLabel);

            flowChatBox.Controls.Add(newPanel);
        }



        private void answer_Click(object sender, EventArgs e)
        {
            botAnswer("sdfsdfjksdhfkjsdhfjkshdkjfhjsdhf");
        }


        void botAnswer(string answerText)
        {

            Label newLabel = new Label();
            newLabel.Text = answerText;
            newLabel.BackColor = exampleAnswerText.BackColor;
            newLabel.ForeColor = exampleAnswerText.ForeColor;
            newLabel.Font = exampleAnswerText.Font;
            newLabel.Width = exampleAnswerText.Width;
            newLabel.TextAlign = exampleAnswerText.TextAlign;
            newLabel.Dock = exampleAnswerText.Dock;
            newLabel.Location = exampleAnswerText.Location;

            Panel newColoredPanel = new Panel();
            newColoredPanel.Dock = exampleAnswerColoredPanel.Dock;
            newColoredPanel.BackColor = exampleAnswerColoredPanel.BackColor;
            newColoredPanel.Width = exampleAnswerColoredPanel.Width;
            newColoredPanel.Controls.Add(newLabel);

            Panel newAnswerPanel = new Panel();
            newAnswerPanel.Width = exampleAnswerPanel.Width;
            newAnswerPanel.Height = exampleAnswerPanel.Height;

            newAnswerPanel.Controls.Add(newColoredPanel);

            flowChatBox.Controls.Add(newAnswerPanel);
        }
    }
}

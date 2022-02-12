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
            flowChatBox.HorizontalScroll.Visible = false;
            flowChatBox.HorizontalScroll.Enabled = false;
            flowChatBox.Padding = new Padding(10, 0, 0,0);
        }

        private void sent_Click(object sender, EventArgs e)
        {
            userAction user = new userAction();
            user.userSingleMessage(searchBox.Text,exampleShortText,exampleShortPanel,flowChatBox);


        }
       
    

        private void answer_Click(object sender, EventArgs e)
        {
            botBehavior bot = new botBehavior();
            bot.botAnswerLongMessage("to protect someone or something against attack or criticism",exampleAnswerText,exampleAnswerColoredPanel,exampleAnswerPanel,flowChatBox);
        }


     

        private void flowChatBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userAction user = new userAction();
            user.userLongMessage(searchBox.Text, exampleAskLongText, exampleAskLongColoredPanel, exampleAskLongPanel, flowChatBox);
        }
    }
}

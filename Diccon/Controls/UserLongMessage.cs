using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccon.Pages
{
    public partial class UserLongMessage : UserControl
    {
        public string TextContent;
        public UserLongMessage()
        {
            InitializeComponent();
            label1.Text = "Asdsdasd";
            label1.Text = TextContent;

        }

        private void UserLongMessage_Load(object sender, EventArgs e)
        {
            //label1.Text = TextContent;
        }

        private void UserLongMessage_SizeChanged(object sender, EventArgs e)
        {
           
        }
    }
}

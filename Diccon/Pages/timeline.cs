using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccon.Pages
{
    public partial class timeline : Form
    {
        public timeline()
        {
            InitializeComponent();
        }

        private void timeline_Load(object sender, EventArgs e)
        {
            if (File.Exists(dicconProp.historyFileName))
            {
                string[] contents = File.ReadAllText(dicconProp.historyFileName).Split(dicconProp.saparateCharactorInHistory);
                foreach (var item in contents)
                {
                    timeLineItem timeLineItem = new timeLineItem(item);
                    timeLineItem.Dock = DockStyle.Top;
                    flowList.Controls.Add(timeLineItem);
                }
            }
        }
    }
}

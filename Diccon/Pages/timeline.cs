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

            loadUpTimeline();
        }
        private void loadUpTimeline()
        {
            List<string> listItem = new List<string>();
            if (File.Exists(dicconProp.historyFileName))
            {
                string[] contents = File.ReadAllText(dicconProp.historyFileName).Split(dicconProp.saparateCharactorInHistory);
                foreach (var item in contents)
                {
                    listItem.Add("      " + item);
                }
                listItem.Reverse();
                List<string>filterdList= listItem.Distinct().ToList();
                listHistory.DataSource = filterdList;
            }
        }
        private void listHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listHistory_DrawItem(object sender, DrawItemEventArgs e)
        {
            bool isSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            if (e.Index > -1)
            {
                /* If the item is selected set the background color to SystemColors.Highlight 
                 or else set the color to either WhiteSmoke or White depending if the item index is even or odd */
                Color color = isSelected ? Color.MediumSlateBlue :
                    e.Index % 2 == 0 ? Color.FromArgb(245, 240, 255)  : Color.White;

                // Background item brush
                SolidBrush backgroundBrush = new SolidBrush(color);
                // Text color brush
                SolidBrush textBrush = new SolidBrush(e.ForeColor);

                // Draw the background
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                // Draw the text
                e.Graphics.DrawString(listHistory.Items[e.Index].ToString(), e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);

                // Clean up
                backgroundBrush.Dispose();
                textBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
               
        }


        private void timeline_VisibleChanged(object sender, EventArgs e)
        {
            loadUpTimeline();
        }

        private void listHistory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dicconProp.wordFromTimeline = listHistory.SelectedItem.ToString();
        }

        private void doubleClickDetector_Tick(object sender, EventArgs e)
        {
            
        }
    }
}

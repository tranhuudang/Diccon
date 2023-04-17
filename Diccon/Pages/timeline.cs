using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Diccon.Pages
{
    public partial class timeline : Form
    {
        List<string> filterdList;
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
            if (File.Exists(DicconProp.HistoryFileName))
            {
                string[] contents = File.ReadAllText(DicconProp.HistoryFileName).Split(DicconProp.SaparateCharactorInHistory);
                foreach (var item in contents)
                {
                    listItem.Add("      " + item.ToLower());
                }
                listItem.Reverse();
                filterdList = listItem.Distinct().ToList();
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
                Color color = isSelected ? DicconProp.ColorA3 :
                    e.Index % 2 == 0 ? DicconProp.ColorA9 : Color.White;

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


        private void timeline_VisibleChanged(object sender, EventArgs e)
        {
            listHistory.DataSource = null;
            loadUpTimeline();
        }

        private void listHistory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DicconProp.WordFromTimeline = listHistory.SelectedItem.ToString();
        }

    }
}

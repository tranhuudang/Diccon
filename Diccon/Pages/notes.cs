using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Diccon.Controls;

namespace Diccon.Pages
{
   
    public partial class notes : Form
    {

        public notes()
        {
            InitializeComponent();
        }

        private void notes_Load(object sender, EventArgs e)
        {
            flowPlayground.HorizontalScroll.Visible = false;
            flowPlayground.Controls.Clear();
            List<noteObject> listNote= getNoteInNoteFile();
            foreach (noteObject note in listNote)
            {
                noteItems newItem= new noteItems();
                newItem.tbTitle.Text = note.Name;
                newItem.richContent.Text = note.Content;
                flowPlayground.Controls.Add(newItem);
            }

        }


        private List<noteObject> getNoteInNoteFile()
        {
            List<noteObject> list = new List<noteObject>();

            try
            {
                // read from file the collection of all available filter in a xml file then fetch it in flowlist
                XmlDocument filters = new XmlDocument();
                filters.Load(dicconProp.noteFilePath);
                XmlNodeList nodes = filters.GetElementsByTagName("user_note");
                foreach (XmlNode note in nodes)
                {
                    string title = note["title"].InnerText;
                    string content = note["content"].InnerText;
                    string favourite = note["favourite"].InnerText;
                    // add filters and it's description in to list
                    list.Add(new noteObject(title, content, favourite));
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            return list;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            notes_Load(null, null);
        }
    }
    class noteObject
    {
        string name;
        string content;
        string favourite;
        public noteObject(string n, string d, string l)
        {
            this.Name = n;
            this.Content = d;
            this.Favourite = l;
        }

        public string Name { get => name; set => name = value; }
        public string Content { get => content; set => content = value; }
        public string Favourite { get => favourite; set => favourite = value; }
    }
}

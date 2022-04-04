using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Diccon
{
    class userNote
    {

        public string title = "untitled";
        public string content;
        public bool favourite = false;
    }
    internal class userAction
    {
        /// <summary>
        /// Create long message box, often use when user want to translate a paragraph
        /// </summary>
        /// <param name="userMessage"></param>
        /// <param name="exampleRichTextBox"></param>
        /// <param name="exampleColoredPanel"></param>
        /// <param name="exampleParentPanel"></param>
        /// <param name="targetFlowLayout"></param>
        public void userLongMessage(string userMessage, Label exampleLabel, Panel exampleColoredPanel, Panel exampleParentPanel, FlowLayoutPanel targetFlowLayout)
        {
            Panel newAnswerPanel = new Panel();
            RoundedPanel newColoredPanel = new RoundedPanel();
            newColoredPanel.Dock = exampleColoredPanel.Dock;
            newColoredPanel.BackColor = exampleColoredPanel.BackColor;
            newColoredPanel.Width = exampleColoredPanel.Width;

            Label newLabel = new Label();
            newLabel.Text = userMessage;
            newLabel.MaximumSize = exampleLabel.MaximumSize;
            newLabel.Location = exampleLabel.Location;
            newLabel.AutoSize = false;
            newLabel.Height = newColoredPanel.Height - 20;
            newLabel.Width = exampleLabel.MaximumSize.Width;
            newLabel.Font = exampleLabel.Font;
            newLabel.ForeColor = exampleLabel.ForeColor;
            newLabel.Click += NewLabel_Click; ;
            newLabel.Cursor = Cursors.Hand;
            newColoredPanel.Controls.Add(newLabel);
            newLabel.Parent = newColoredPanel;

            newAnswerPanel.Width = exampleParentPanel.Width;
            newAnswerPanel.Controls.Add(newColoredPanel);

            targetFlowLayout.Controls.Add(newAnswerPanel);
            targetFlowLayout.ScrollControlIntoView(newAnswerPanel);
        }

        private void NewLabel_Click(object sender, EventArgs e)
        {
            Label lb = (sender as Label);
            FlowLayoutPanel grandFlowLayout = (lb.Parent.Parent.Parent as FlowLayoutPanel);
            lb.AutoSize = true;
            lb.Parent.Height = lb.Height + 20;
            lb.Parent.Parent.Height = lb.Height + 20;
            lb.Cursor = Cursors.Default;
            // refresh to get rid of unrendered design
            grandFlowLayout.Refresh();
        }

        /// <summary>
        /// TextChanged event for userLongMessage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewRichTextBox_TextChanged(object sender, System.EventArgs e)
        {
            RichTextBox textMessage = (sender as RichTextBox);
            var parentPanel = textMessage.Parent.Parent;
            parentPanel.Visible = false;

            int lineHeight = 20;
            int lineCount = textMessage.GetLineFromCharIndex(textMessage.TextLength);
            textMessage.Height = lineHeight * lineCount;
            parentPanel.Height = textMessage.Height + 20;
            parentPanel.Visible = true;
        }

        /// <summary>
        /// Click event to expand the box for longMessage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewRichTextBox_Click(object sender, System.EventArgs e)
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

        public void userSingleMessage(string userMessage, Label exampleText, Panel examplePanel, FlowLayoutPanel targetFlowLayout)
        {
            int searchText_Len = userMessage.Length;
            RoundedLabel newLabel = new RoundedLabel();
            string processedText = userMessage[0].ToString().ToUpper() + userMessage.Substring(1).ToLower();
            newLabel.Text = processedText;
            newLabel.BackColor = exampleText.BackColor;
            newLabel.ForeColor = exampleText.ForeColor;
            newLabel.Font = exampleText.Font;
            newLabel.AutoSize = true;
            newLabel.TextAlign = exampleText.TextAlign;
            newLabel.Dock = exampleText.Dock;
            newLabel.Padding = exampleText.Padding;

            Panel newPanel = new Panel();
            newPanel.Width = examplePanel.Width;
            newPanel.Height = examplePanel.Height;

            newPanel.Controls.Add(newLabel);

            targetFlowLayout.Controls.Add(newPanel);
            targetFlowLayout.ScrollControlIntoView(newPanel);
        }
        public void userAddNote(PictureBox exampleNoteSave, PictureBox exampleNoteDelete, PictureBox exampleNoteClose, RichTextBox exampleRichtextbox, RoundedPanel coloredPanel, Panel panel, FlowLayoutPanel targetFlowLayout)
        {
            PictureBox btSave = new PictureBox();
            PictureBox btDelete = new PictureBox();
            PictureBox btClose = new PictureBox();
            RichTextBox newRichtextbox = new RichTextBox();
            RoundedPanel newColoredPanel = new RoundedPanel();
            Panel newPanel = new Panel();
            userNote note = new userNote();
            newPanel.Tag = note;

            btSave.Image = exampleNoteSave.Image;
            btSave.Location = exampleNoteSave.Location;
            btSave.Size = exampleNoteSave.Size;
            btSave.Cursor = exampleNoteSave.Cursor;
            btSave.MouseEnter += PictureBox_MouseEnter;
            btSave.MouseLeave += PictureBox_MouseLeave;
            btSave.Click += BtSave_Click;

            btDelete.Image = exampleNoteDelete.Image;
            btDelete.Location = exampleNoteDelete.Location;
            btDelete.Size = exampleNoteDelete.Size;
            btDelete.Cursor = exampleNoteDelete.Cursor;
            btDelete.MouseEnter += PictureBox_MouseEnter;
            btDelete.MouseLeave += PictureBox_MouseLeave;

            btClose.Image = exampleNoteClose.Image;
            btClose.Location = exampleNoteClose.Location;
            btClose.Size = exampleNoteClose.Size;
            btClose.Cursor = exampleNoteClose.Cursor;
            btClose.MouseEnter += PictureBox_MouseEnter;
            btClose.MouseLeave += PictureBox_MouseLeave;
            btClose.Click += BtClose_Click;

            newRichtextbox.Size = exampleRichtextbox.Size;
            newRichtextbox.Font = exampleRichtextbox.Font;
            newRichtextbox.Location = exampleRichtextbox.Location;
            newRichtextbox.BorderStyle = exampleRichtextbox.BorderStyle;
            newRichtextbox.BackColor = exampleRichtextbox.BackColor;
            newRichtextbox.ForeColor = exampleRichtextbox.ForeColor;
            newRichtextbox.TextChanged += NewRichtextbox_TextChanged;

            newColoredPanel.Size = coloredPanel.Size;
            newColoredPanel.BackColor = coloredPanel.BackColor;

            newPanel.Size = panel.Size;

            newColoredPanel.Controls.Add(btSave);
            newColoredPanel.Controls.Add(btDelete);
            newColoredPanel.Controls.Add(btClose);
            newColoredPanel.Controls.Add(newRichtextbox);

            newPanel.Controls.Add(newColoredPanel);
            targetFlowLayout.Controls.Add(newPanel);
            targetFlowLayout.ScrollControlIntoView(newPanel);
        }

        private void NewRichtextbox_TextChanged(object sender, EventArgs e)
        {

            (((sender as RichTextBox).Parent.Parent.Tag) as userNote).content = (sender as RichTextBox).Text;
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            object parentPanelTag = (sender as PictureBox).Parent.Parent.Tag;
            userNote noteInTag = (userNote)parentPanelTag;
            saveAsXml(noteInTag);
        }
        private void saveAsXml(userNote noteInTag)
        {
            if (!File.Exists("Note.xml"))
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                XmlWriter xml = XmlWriter.Create("Note.xml", xmlWriterSettings);
                xml.WriteStartDocument(true);
                xml.WriteStartElement("DicconNote");
                noteInXml(noteInTag.title, noteInTag.content, noteInTag.favourite, xml);
                xml.WriteEndElement();
                xml.Close();
            }
            else
            {
                XDocument xDocument = XDocument.Load("Note.xml");
                XElement root = xDocument.Element("DicconNote");
                IEnumerable<XElement> rows = root.Descendants("user_note");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("user_note",
                   new XElement("title", noteInTag.title),
                   new XElement("content", noteInTag.content),
                   new XElement("favourite", noteInTag.favourite)));
                xDocument.Save("Note.xml");
            }

        }
        private void noteInXml(string title, string content, bool favourite, XmlWriter xml)
        {
            xml.WriteStartElement("user_note");
            xml.WriteStartElement("title");
            xml.WriteString(title);
            xml.WriteEndElement();
            xml.WriteStartElement("content");
            xml.WriteString(content);
            xml.WriteEndElement();
            xml.WriteStartElement("favourite");
            xml.WriteString(favourite.ToString());
            xml.WriteEndElement();
            xml.WriteEndElement();

        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            (sender as PictureBox).Parent.Parent.Dispose();
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (sender as PictureBox);
            int X = pictureBox.Location.X;
            int Y = pictureBox.Location.Y - 2;
            pictureBox.Location = new Point(X, Y);
        }
        /// <summary>
        /// Change position of PictureBox to create a illusion that the box is push down a little bit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (sender as PictureBox);
            int X = pictureBox.Location.X;
            int Y = pictureBox.Location.Y + 2;
            pictureBox.Location = new Point(X, Y);
        }
    }
}

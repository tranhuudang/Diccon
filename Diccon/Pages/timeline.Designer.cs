namespace Diccon.Pages
{
    partial class timeline
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timeline));
            this.panelList = new System.Windows.Forms.Panel();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRemove = new FontAwesome.Sharp.IconPictureBox();
            this.panelList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.listHistory);
            this.panelList.Controls.Add(this.panel2);
            this.panelList.Controls.Add(this.panel1);
            resources.ApplyResources(this.panelList, "panelList");
            this.panelList.Name = "panelList";
            // 
            // listHistory
            // 
            resources.ApplyResources(this.listHistory, "listHistory");
            this.listHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listHistory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listHistory.Name = "listHistory";
            this.listHistory.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listHistory_DrawItem);
            this.listHistory.SelectedIndexChanged += new System.EventHandler(this.listHistory_SelectedIndexChanged);
            this.listHistory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listHistory_MouseDoubleClick);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btRemove);
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btRemove
            // 
            resources.ApplyResources(this.btRemove, "btRemove");
            this.btRemove.BackColor = System.Drawing.Color.White;
            this.btRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btRemove.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btRemove.IconColor = System.Drawing.SystemColors.ControlText;
            this.btRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRemove.IconSize = 27;
            this.btRemove.Name = "btRemove";
            this.btRemove.TabStop = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // timeline
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelList);
            this.Name = "timeline";
            this.Load += new System.EventHandler(this.timeline_Load);
            this.VisibleChanged += new System.EventHandler(this.timeline_VisibleChanged);
            this.panelList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.ListBox listHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox btRemove;
    }
}
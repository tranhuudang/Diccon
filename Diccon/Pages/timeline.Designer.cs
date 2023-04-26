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
            this.topPanel = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.topControlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonMenu = new System.Windows.Forms.PictureBox();
            this.btStar = new FontAwesome.Sharp.IconPictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelList.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.topControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.listHistory);
            this.panelList.Controls.Add(this.topPanel);
            resources.ApplyResources(this.panelList, "panelList");
            this.panelList.Name = "panelList";
            // 
            // listHistory
            // 
            this.listHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.listHistory, "listHistory");
            this.listHistory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listHistory.Name = "listHistory";
            this.listHistory.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listHistory_DrawItem);
            this.listHistory.SelectedIndexChanged += new System.EventHandler(this.listHistory_SelectedIndexChanged);
            this.listHistory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listHistory_MouseDoubleClick);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.topPanel.Controls.Add(this.title);
            this.topPanel.Controls.Add(this.topControlPanel);
            this.topPanel.Controls.Add(this.logo);
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.Name = "topPanel";
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.title, "title");
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Name = "title";
            // 
            // topControlPanel
            // 
            this.topControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.topControlPanel.Controls.Add(this.buttonMenu);
            this.topControlPanel.Controls.Add(this.btStar);
            resources.ApplyResources(this.topControlPanel, "topControlPanel");
            this.topControlPanel.Name = "topControlPanel";
            // 
            // buttonMenu
            // 
            resources.ApplyResources(this.buttonMenu, "buttonMenu");
            this.buttonMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Image = global::Diccon.Properties.Resources.menu_24;
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.TabStop = false;
            // 
            // btStar
            // 
            resources.ApplyResources(this.btStar, "btStar");
            this.btStar.BackColor = System.Drawing.Color.Transparent;
            this.btStar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStar.ForeColor = System.Drawing.Color.Black;
            this.btStar.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btStar.IconColor = System.Drawing.Color.Black;
            this.btStar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btStar.IconSize = 28;
            this.btStar.Name = "btStar";
            this.btStar.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.logo, "logo");
            this.logo.Image = global::Diccon.Properties.Resources.back_24;
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
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
            this.topPanel.ResumeLayout(false);
            this.topControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.ListBox listHistory;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.FlowLayoutPanel topControlPanel;
        private System.Windows.Forms.PictureBox buttonMenu;
        private FontAwesome.Sharp.IconPictureBox btStar;
        private System.Windows.Forms.PictureBox logo;
    }
}
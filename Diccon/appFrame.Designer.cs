﻿namespace Diccon
{
    partial class appFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appFrame));
            this.topPanel = new System.Windows.Forms.Panel();
            this.topControlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonMenu = new System.Windows.Forms.PictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btStar = new FontAwesome.Sharp.IconPictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.playGroundPanel = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btDonate = new Diccon.RoundedLabel();
            this.lbQuotation = new System.Windows.Forms.Label();
            this.btDictionary = new Diccon.RoundedLabel();
            this.btTimeline = new Diccon.RoundedLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btNotes = new Diccon.RoundedLabel();
            this.btCommunity = new Diccon.RoundedLabel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpSyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInWithGoogleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vietnameseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timeLineDetector = new System.Windows.Forms.Timer(this.components);
            this.notificationDetector = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            this.topControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.playGroundPanel.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.topPanel.Controls.Add(this.topControlPanel);
            this.topPanel.Controls.Add(this.logo);
            this.topPanel.Controls.Add(this.title);
            this.topPanel.Name = "topPanel";
            // 
            // topControlPanel
            // 
            resources.ApplyResources(this.topControlPanel, "topControlPanel");
            this.topControlPanel.Controls.Add(this.buttonMenu);
            this.topControlPanel.Controls.Add(this.iconPictureBox1);
            this.topControlPanel.Controls.Add(this.btStar);
            this.topControlPanel.Name = "topControlPanel";
            // 
            // buttonMenu
            // 
            resources.ApplyResources(this.buttonMenu, "buttonMenu");
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Image = global::Diccon.Properties.Resources.menu_24;
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.TabStop = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            this.buttonMenu.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.buttonMenu.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // iconPictureBox1
            // 
            resources.ApplyResources(this.iconPictureBox1, "iconPictureBox1");
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconPictureBox1.IconSize = 28;
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.TabStop = false;
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
            this.btStar.Click += new System.EventHandler(this.btStar_Click);
            this.btStar.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.btStar.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // logo
            // 
            resources.ApplyResources(this.logo, "logo");
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.Image = global::Diccon.Properties.Resources.diccon_32_2;
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            this.logo.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.logo.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // title
            // 
            resources.ApplyResources(this.title, "title");
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Name = "title";
            // 
            // playGroundPanel
            // 
            resources.ApplyResources(this.playGroundPanel, "playGroundPanel");
            this.playGroundPanel.Controls.Add(this.panelHome);
            this.playGroundPanel.Name = "playGroundPanel";
            this.playGroundPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.playGroundPanel_ControlAdded);
            // 
            // panelHome
            // 
            resources.ApplyResources(this.panelHome, "panelHome");
            this.panelHome.BackColor = System.Drawing.Color.White;
            this.panelHome.Controls.Add(this.label7);
            this.panelHome.Controls.Add(this.btDonate);
            this.panelHome.Controls.Add(this.lbQuotation);
            this.panelHome.Controls.Add(this.btDictionary);
            this.panelHome.Controls.Add(this.btTimeline);
            this.panelHome.Controls.Add(this.label3);
            this.panelHome.Controls.Add(this.label6);
            this.panelHome.Controls.Add(this.label4);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.btNotes);
            this.panelHome.Controls.Add(this.btCommunity);
            this.panelHome.Name = "panelHome";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Name = "label7";
            // 
            // btDonate
            // 
            resources.ApplyResources(this.btDonate, "btDonate");
            this.btDonate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btDonate.BorderColor = System.Drawing.Color.White;
            this.btDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDonate.Image = global::Diccon.Properties.Resources.support_36;
            this.btDonate.Name = "btDonate";
            this.btDonate.Radius = 50;
            this.btDonate.Thickness = 5F;
            this.btDonate.Click += new System.EventHandler(this.btDonate_Click);
            this.btDonate.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btDonate.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // lbQuotation
            // 
            resources.ApplyResources(this.lbQuotation, "lbQuotation");
            this.lbQuotation.Name = "lbQuotation";
            // 
            // btDictionary
            // 
            resources.ApplyResources(this.btDictionary, "btDictionary");
            this.btDictionary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btDictionary.BorderColor = System.Drawing.Color.White;
            this.btDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDictionary.Image = global::Diccon.Properties.Resources.translate_36;
            this.btDictionary.Name = "btDictionary";
            this.btDictionary.Radius = 50;
            this.btDictionary.Thickness = 5F;
            this.btDictionary.Click += new System.EventHandler(this.btDictionary_Click);
            this.btDictionary.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btDictionary.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // btTimeline
            // 
            resources.ApplyResources(this.btTimeline, "btTimeline");
            this.btTimeline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btTimeline.BorderColor = System.Drawing.Color.White;
            this.btTimeline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTimeline.Image = global::Diccon.Properties.Resources.timeline_36;
            this.btTimeline.Name = "btTimeline";
            this.btTimeline.Radius = 50;
            this.btTimeline.Thickness = 5F;
            this.btTimeline.Click += new System.EventHandler(this.btTimeline_Click);
            this.btTimeline.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btTimeline.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btNotes
            // 
            resources.ApplyResources(this.btNotes, "btNotes");
            this.btNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btNotes.BorderColor = System.Drawing.Color.White;
            this.btNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNotes.Image = global::Diccon.Properties.Resources.your_note_36;
            this.btNotes.Name = "btNotes";
            this.btNotes.Radius = 50;
            this.btNotes.Thickness = 5F;
            this.btNotes.Click += new System.EventHandler(this.buttonYourNote_Click);
            this.btNotes.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btNotes.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // btCommunity
            // 
            resources.ApplyResources(this.btCommunity, "btCommunity");
            this.btCommunity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btCommunity.BorderColor = System.Drawing.Color.White;
            this.btCommunity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCommunity.Image = global::Diccon.Properties.Resources.chat_36;
            this.btCommunity.Name = "btCommunity";
            this.btCommunity.Radius = 50;
            this.btCommunity.Thickness = 5F;
            this.btCommunity.Click += new System.EventHandler(this.roundedLabel7_Click);
            this.btCommunity.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btCommunity.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // contextMenu
            // 
            resources.ApplyResources(this.contextMenu, "contextMenu");
            this.contextMenu.DropShadowEnabled = false;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.backUpSyncToolStripMenuItem,
            this.logInWithGoogleToolStripMenuItem,
            this.toolStripMenuItem4,
            this.languageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.githubToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            // 
            // accountToolStripMenuItem
            // 
            resources.ApplyResources(this.accountToolStripMenuItem, "accountToolStripMenuItem");
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // backUpSyncToolStripMenuItem
            // 
            resources.ApplyResources(this.backUpSyncToolStripMenuItem, "backUpSyncToolStripMenuItem");
            this.backUpSyncToolStripMenuItem.Name = "backUpSyncToolStripMenuItem";
            this.backUpSyncToolStripMenuItem.Click += new System.EventHandler(this.backUpSyncToolStripMenuItem_Click);
            // 
            // logInWithGoogleToolStripMenuItem
            // 
            resources.ApplyResources(this.logInWithGoogleToolStripMenuItem, "logInWithGoogleToolStripMenuItem");
            this.logInWithGoogleToolStripMenuItem.Name = "logInWithGoogleToolStripMenuItem";
            this.logInWithGoogleToolStripMenuItem.Click += new System.EventHandler(this.logInWithGoogleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.vietnameseToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // vietnameseToolStripMenuItem
            // 
            resources.ApplyResources(this.vietnameseToolStripMenuItem, "vietnameseToolStripMenuItem");
            this.vietnameseToolStripMenuItem.Name = "vietnameseToolStripMenuItem";
            this.vietnameseToolStripMenuItem.Click += new System.EventHandler(this.vietnameseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            resources.ApplyResources(this.checkForUpdatesToolStripMenuItem, "checkForUpdatesToolStripMenuItem");
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // githubToolStripMenuItem
            // 
            resources.ApplyResources(this.githubToolStripMenuItem, "githubToolStripMenuItem");
            this.githubToolStripMenuItem.Image = global::Diccon.Properties.Resources.github_20;
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Image = global::Diccon.Properties.Resources.info_20;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // timeLineDetector
            // 
            this.timeLineDetector.Enabled = true;
            this.timeLineDetector.Interval = 500;
            this.timeLineDetector.Tick += new System.EventHandler(this.timeLineDetector_Tick);
            // 
            // notificationDetector
            // 
            this.notificationDetector.Interval = 5000;
            this.notificationDetector.Tick += new System.EventHandler(this.notificationDetector_Tick);
            // 
            // appFrame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.playGroundPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "appFrame";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.appFrame_FormClosing);
            this.Load += new System.EventHandler(this.AppFrame_Load);
            this.topPanel.ResumeLayout(false);
            this.topControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.playGroundPanel.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox buttonMenu;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel playGroundPanel;
        private System.Windows.Forms.Panel panelHome;
        private RoundedLabel btDonate;
        private System.Windows.Forms.Label lbQuotation;
        private RoundedLabel btDictionary;
        private RoundedLabel btTimeline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private RoundedLabel btCommunity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RoundedLabel btNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vietnameseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconPictureBox btStar;
        private System.Windows.Forms.Timer timeLineDetector;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem logInWithGoogleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.FlowLayoutPanel topControlPanel;
        private System.Windows.Forms.Timer notificationDetector;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpSyncToolStripMenuItem;
    }
}
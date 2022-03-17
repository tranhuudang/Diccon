namespace Diccon
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.btStar = new FontAwesome.Sharp.IconPictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.buttonMenu = new System.Windows.Forms.PictureBox();
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
            this.roundedLabel7 = new Diccon.RoundedLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonYourNote = new Diccon.RoundedLabel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vietnameseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eachSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).BeginInit();
            this.playGroundPanel.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel9.Controls.Add(this.btStar);
            this.panel9.Controls.Add(this.logo);
            this.panel9.Controls.Add(this.buttonMenu);
            this.panel9.Controls.Add(this.title);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(407, 70);
            this.panel9.TabIndex = 5;
            // 
            // btStar
            // 
            this.btStar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btStar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStar.ForeColor = System.Drawing.Color.Black;
            this.btStar.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btStar.IconColor = System.Drawing.Color.Black;
            this.btStar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btStar.IconSize = 28;
            this.btStar.Location = new System.Drawing.Point(339, 23);
            this.btStar.Name = "btStar";
            this.btStar.Size = new System.Drawing.Size(28, 28);
            this.btStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btStar.TabIndex = 8;
            this.btStar.TabStop = false;
            this.btStar.Visible = false;
            this.btStar.Click += new System.EventHandler(this.btStar_Click);
            this.btStar.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.btStar.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.Image = global::Diccon.Properties.Resources.ninja_64;
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(64, 64);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            this.logo.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.logo.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Image = global::Diccon.Properties.Resources.menu_24;
            this.buttonMenu.Location = new System.Drawing.Point(372, 23);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(24, 24);
            this.buttonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.buttonMenu.TabIndex = 6;
            this.buttonMenu.TabStop = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            this.buttonMenu.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.buttonMenu.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Location = new System.Drawing.Point(66, 3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(199, 64);
            this.title.TabIndex = 1;
            this.title.Text = "Diccon";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playGroundPanel
            // 
            this.playGroundPanel.Controls.Add(this.panelHome);
            this.playGroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playGroundPanel.Location = new System.Drawing.Point(0, 70);
            this.playGroundPanel.Name = "playGroundPanel";
            this.playGroundPanel.Size = new System.Drawing.Size(407, 622);
            this.playGroundPanel.TabIndex = 6;
            this.playGroundPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.playGroundPanel_ControlAdded);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.label7);
            this.panelHome.Controls.Add(this.btDonate);
            this.panelHome.Controls.Add(this.lbQuotation);
            this.panelHome.Controls.Add(this.btDictionary);
            this.panelHome.Controls.Add(this.btTimeline);
            this.panelHome.Controls.Add(this.label3);
            this.panelHome.Controls.Add(this.label6);
            this.panelHome.Controls.Add(this.label4);
            this.panelHome.Controls.Add(this.roundedLabel7);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.buttonYourNote);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(407, 622);
            this.panelHome.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(173, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "ZeroClub";
            // 
            // btDonate
            // 
            this.btDonate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btDonate.BorderColor = System.Drawing.Color.White;
            this.btDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDonate.Image = global::Diccon.Properties.Resources.support_36;
            this.btDonate.Location = new System.Drawing.Point(170, 308);
            this.btDonate.Name = "btDonate";
            this.btDonate.Radius = 50;
            this.btDonate.Size = new System.Drawing.Size(75, 71);
            this.btDonate.TabIndex = 7;
            this.btDonate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDonate.Thickness = 5F;
            this.btDonate.Click += new System.EventHandler(this.btDonate_Click);
            this.btDonate.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btDonate.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // lbQuotation
            // 
            this.lbQuotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuotation.Location = new System.Drawing.Point(4, 44);
            this.lbQuotation.Name = "lbQuotation";
            this.lbQuotation.Size = new System.Drawing.Size(400, 94);
            this.lbQuotation.TabIndex = 6;
            this.lbQuotation.Text = "“Don’t wish it were easier; wish you were better.”";
            this.lbQuotation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDictionary
            // 
            this.btDictionary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btDictionary.BorderColor = System.Drawing.Color.White;
            this.btDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDictionary.Image = global::Diccon.Properties.Resources.translate_36;
            this.btDictionary.Location = new System.Drawing.Point(79, 207);
            this.btDictionary.Name = "btDictionary";
            this.btDictionary.Radius = 50;
            this.btDictionary.Size = new System.Drawing.Size(75, 71);
            this.btDictionary.TabIndex = 5;
            this.btDictionary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDictionary.Thickness = 5F;
            this.btDictionary.Click += new System.EventHandler(this.btDictionary_Click);
            this.btDictionary.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btDictionary.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // btTimeline
            // 
            this.btTimeline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btTimeline.BorderColor = System.Drawing.Color.White;
            this.btTimeline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTimeline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimeline.Image = global::Diccon.Properties.Resources.timeline_36;
            this.btTimeline.Location = new System.Drawing.Point(79, 308);
            this.btTimeline.Name = "btTimeline";
            this.btTimeline.Radius = 50;
            this.btTimeline.Size = new System.Drawing.Size(75, 71);
            this.btTimeline.TabIndex = 5;
            this.btTimeline.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btTimeline.Thickness = 5F;
            this.btTimeline.Click += new System.EventHandler(this.btTimeline_Click);
            this.btTimeline.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btTimeline.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dictionary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Donate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Timeline";
            // 
            // roundedLabel7
            // 
            this.roundedLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roundedLabel7.BorderColor = System.Drawing.Color.White;
            this.roundedLabel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel7.Image = global::Diccon.Properties.Resources.chat_36;
            this.roundedLabel7.Location = new System.Drawing.Point(170, 207);
            this.roundedLabel7.Name = "roundedLabel7";
            this.roundedLabel7.Radius = 50;
            this.roundedLabel7.Size = new System.Drawing.Size(75, 71);
            this.roundedLabel7.TabIndex = 5;
            this.roundedLabel7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.roundedLabel7.Thickness = 5F;
            this.roundedLabel7.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.roundedLabel7.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yawa";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Notes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonYourNote
            // 
            this.buttonYourNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonYourNote.BorderColor = System.Drawing.Color.White;
            this.buttonYourNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonYourNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYourNote.Image = global::Diccon.Properties.Resources.your_note_36;
            this.buttonYourNote.Location = new System.Drawing.Point(261, 207);
            this.buttonYourNote.Name = "buttonYourNote";
            this.buttonYourNote.Radius = 50;
            this.buttonYourNote.Size = new System.Drawing.Size(75, 71);
            this.buttonYourNote.TabIndex = 3;
            this.buttonYourNote.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonYourNote.Thickness = 5F;
            this.buttonYourNote.Click += new System.EventHandler(this.buttonYourNote_Click);
            this.buttonYourNote.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.buttonYourNote.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // contextMenu
            // 
            this.contextMenu.DropShadowEnabled = false;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.clearHistoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.githubToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(172, 170);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.vietnameseToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // vietnameseToolStripMenuItem
            // 
            this.vietnameseToolStripMenuItem.Name = "vietnameseToolStripMenuItem";
            this.vietnameseToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.vietnameseToolStripMenuItem.Text = "Vietnamese";
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eachSessionToolStripMenuItem,
            this.aWeekToolStripMenuItem,
            this.aMonthToolStripMenuItem});
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.clearHistoryToolStripMenuItem.Text = "Clear history";
            // 
            // eachSessionToolStripMenuItem
            // 
            this.eachSessionToolStripMenuItem.Name = "eachSessionToolStripMenuItem";
            this.eachSessionToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.eachSessionToolStripMenuItem.Text = "After a day";
            // 
            // aWeekToolStripMenuItem
            // 
            this.aWeekToolStripMenuItem.Checked = true;
            this.aWeekToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aWeekToolStripMenuItem.Name = "aWeekToolStripMenuItem";
            this.aWeekToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aWeekToolStripMenuItem.Text = "A week";
            // 
            // aMonthToolStripMenuItem
            // 
            this.aMonthToolStripMenuItem.Name = "aMonthToolStripMenuItem";
            this.aMonthToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aMonthToolStripMenuItem.Text = "Never";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 6);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Image = global::Diccon.Properties.Resources.github_20;
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.githubToolStripMenuItem.Text = "Github";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Diccon.Properties.Resources.info_20;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // appFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 692);
            this.Controls.Add(this.playGroundPanel);
            this.Controls.Add(this.panel9);
            this.MaximumSize = new System.Drawing.Size(423, 10000);
            this.Name = "appFrame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.appFrame_FormClosing);
            this.Load += new System.EventHandler(this.AppFrame_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).EndInit();
            this.playGroundPanel.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
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
        private RoundedLabel roundedLabel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RoundedLabel buttonYourNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vietnameseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eachSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aWeekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconPictureBox btStar;
    }
}
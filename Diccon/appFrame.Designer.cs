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
            this.lbQuotation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logInWithGoogleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btDonate = new Diccon.RoundedLabel();
            this.btDictionary = new Diccon.RoundedLabel();
            this.btTimeline = new Diccon.RoundedLabel();
            this.btNotes = new Diccon.RoundedLabel();
            this.btCommunity = new Diccon.RoundedLabel();
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
            this.topPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.topPanel.Controls.Add(this.topControlPanel);
            this.topPanel.Controls.Add(this.logo);
            this.topPanel.Controls.Add(this.title);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(355, 70);
            this.topPanel.TabIndex = 5;
            // 
            // topControlPanel
            // 
            this.topControlPanel.Controls.Add(this.buttonMenu);
            this.topControlPanel.Controls.Add(this.iconPictureBox1);
            this.topControlPanel.Controls.Add(this.btStar);
            this.topControlPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.topControlPanel.Location = new System.Drawing.Point(229, 17);
            this.topControlPanel.Name = "topControlPanel";
            this.topControlPanel.Size = new System.Drawing.Size(123, 34);
            this.topControlPanel.TabIndex = 10;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Image = global::Diccon.Properties.Resources.menu_24;
            this.buttonMenu.Location = new System.Drawing.Point(98, 3);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(22, 24);
            this.buttonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMenu.TabIndex = 6;
            this.buttonMenu.TabStop = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            this.buttonMenu.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.buttonMenu.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconPictureBox1.IconSize = 28;
            this.iconPictureBox1.Location = new System.Drawing.Point(64, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(28, 28);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 9;
            this.iconPictureBox1.TabStop = false;
            // 
            // btStar
            // 
            this.btStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStar.BackColor = System.Drawing.Color.Transparent;
            this.btStar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStar.ForeColor = System.Drawing.Color.Black;
            this.btStar.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btStar.IconColor = System.Drawing.Color.Black;
            this.btStar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btStar.IconSize = 28;
            this.btStar.Location = new System.Drawing.Point(30, 3);
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
            this.logo.Image = global::Diccon.Properties.Resources.diccon_32_2;
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
            this.playGroundPanel.Size = new System.Drawing.Size(355, 550);
            this.playGroundPanel.TabIndex = 6;
            this.playGroundPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.playGroundPanel_ControlAdded);
            // 
            // panelHome
            // 
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
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(355, 550);
            this.panelHome.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(142, 512);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "ZeroClub";
            // 
            // lbQuotation
            // 
            this.lbQuotation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuotation.Location = new System.Drawing.Point(12, 44);
            this.lbQuotation.Name = "lbQuotation";
            this.lbQuotation.Size = new System.Drawing.Size(331, 94);
            this.lbQuotation.TabIndex = 6;
            this.lbQuotation.Text = "“Don’t wish it were easier; wish you were better.”";
            this.lbQuotation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dictionary";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(149, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Donate";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Timeline";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Community";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Notes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenu
            // 
            this.contextMenu.DropShadowEnabled = false;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInWithGoogleToolStripMenuItem,
            this.toolStripMenuItem4,
            this.themeToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.githubToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(175, 182);
            // 
            // logInWithGoogleToolStripMenuItem
            // 
            this.logInWithGoogleToolStripMenuItem.Name = "logInWithGoogleToolStripMenuItem";
            this.logInWithGoogleToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.logInWithGoogleToolStripMenuItem.Text = "Log in with Google";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(171, 6);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.vietnameseToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 6);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Image = global::Diccon.Properties.Resources.github_20;
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(171, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Diccon.Properties.Resources.info_20;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
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
            // btDonate
            // 
            this.btDonate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btDonate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btDonate.BorderColor = System.Drawing.Color.White;
            this.btDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDonate.Image = global::Diccon.Properties.Resources.support_36;
            this.btDonate.Location = new System.Drawing.Point(142, 291);
            this.btDonate.Name = "btDonate";
            this.btDonate.Radius = 50;
            this.btDonate.Size = new System.Drawing.Size(73, 69);
            this.btDonate.TabIndex = 7;
            this.btDonate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDonate.Thickness = 5F;
            this.btDonate.Click += new System.EventHandler(this.btDonate_Click);
            this.btDonate.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btDonate.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // btDictionary
            // 
            this.btDictionary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btDictionary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btDictionary.BorderColor = System.Drawing.Color.White;
            this.btDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDictionary.Image = global::Diccon.Properties.Resources.translate_36;
            this.btDictionary.Location = new System.Drawing.Point(51, 190);
            this.btDictionary.Name = "btDictionary";
            this.btDictionary.Radius = 50;
            this.btDictionary.Size = new System.Drawing.Size(73, 69);
            this.btDictionary.TabIndex = 5;
            this.btDictionary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDictionary.Thickness = 5F;
            this.btDictionary.Click += new System.EventHandler(this.btDictionary_Click);
            this.btDictionary.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btDictionary.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // btTimeline
            // 
            this.btTimeline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btTimeline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btTimeline.BorderColor = System.Drawing.Color.White;
            this.btTimeline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTimeline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimeline.Image = global::Diccon.Properties.Resources.timeline_36;
            this.btTimeline.Location = new System.Drawing.Point(142, 190);
            this.btTimeline.Name = "btTimeline";
            this.btTimeline.Radius = 50;
            this.btTimeline.Size = new System.Drawing.Size(73, 69);
            this.btTimeline.TabIndex = 5;
            this.btTimeline.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btTimeline.Thickness = 5F;
            this.btTimeline.Click += new System.EventHandler(this.btTimeline_Click);
            this.btTimeline.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btTimeline.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // btNotes
            // 
            this.btNotes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btNotes.BorderColor = System.Drawing.Color.White;
            this.btNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNotes.Image = global::Diccon.Properties.Resources.your_note_36;
            this.btNotes.Location = new System.Drawing.Point(51, 293);
            this.btNotes.Name = "btNotes";
            this.btNotes.Radius = 50;
            this.btNotes.Size = new System.Drawing.Size(73, 69);
            this.btNotes.TabIndex = 3;
            this.btNotes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btNotes.Thickness = 5F;
            this.btNotes.Click += new System.EventHandler(this.buttonYourNote_Click);
            this.btNotes.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btNotes.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // btCommunity
            // 
            this.btCommunity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btCommunity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btCommunity.BorderColor = System.Drawing.Color.White;
            this.btCommunity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCommunity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCommunity.Image = global::Diccon.Properties.Resources.chat_36;
            this.btCommunity.Location = new System.Drawing.Point(233, 190);
            this.btCommunity.Name = "btCommunity";
            this.btCommunity.Radius = 50;
            this.btCommunity.Size = new System.Drawing.Size(73, 69);
            this.btCommunity.TabIndex = 5;
            this.btCommunity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCommunity.Thickness = 5F;
            this.btCommunity.Click += new System.EventHandler(this.roundedLabel7_Click);
            this.btCommunity.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btCommunity.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // appFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 620);
            this.Controls.Add(this.playGroundPanel);
            this.Controls.Add(this.topPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(423, 10000);
            this.MinimumSize = new System.Drawing.Size(371, 659);
            this.Name = "appFrame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
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
    }
}
namespace Diccon
{
    partial class dictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dictionary));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btAdd = new FontAwesome.Sharp.IconPictureBox();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.addEmoji = new Diccon.RoundedLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new Diccon.RoundedPanel();
            this.textFromClipboard = new FontAwesome.Sharp.IconPictureBox();
            this.labelTypeToSearch = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.textFromMic = new FontAwesome.Sharp.IconPictureBox();
            this.btSend = new FontAwesome.Sharp.IconPictureBox();
            this.flowChatBox = new System.Windows.Forms.FlowLayoutPanel();
            this.exampleAnswerPanel = new System.Windows.Forms.Panel();
            this.exampleAnswerColoredPanel = new Diccon.RoundedPanel();
            this.exampleAnswerText = new System.Windows.Forms.Label();
            this.exampleflowLayoutSynonym = new System.Windows.Forms.FlowLayoutPanel();
            this.exampleItemSynonym = new Diccon.RoundedLabel();
            this.roundedLabel3 = new Diccon.RoundedLabel();
            this.exampleShortPanel = new System.Windows.Forms.Panel();
            this.exampleShortText = new Diccon.RoundedLabel();
            this.exampleAskLongPanel = new System.Windows.Forms.Panel();
            this.exampleAskLongColoredPanel = new Diccon.RoundedPanel();
            this.exampleAskLongText = new System.Windows.Forms.Label();
            this.examplePlayPanel = new System.Windows.Forms.Panel();
            this.examplePlayAlignPanel = new System.Windows.Forms.Panel();
            this.examplePlayColoredPanel = new Diccon.RoundedPanel();
            this.exampleTextHolder = new System.Windows.Forms.Label();
            this.examplePlayButton = new System.Windows.Forms.PictureBox();
            this.examplePicturePanel = new System.Windows.Forms.Panel();
            this.examplePixabayLogo = new System.Windows.Forms.PictureBox();
            this.exampleColoredPicturePanel = new Diccon.RoundedPanel();
            this.examplePictureBox = new Diccon.RoundedPictureBox();
            this.suggestionTimer = new System.Windows.Forms.Timer(this.components);
            this.flowSuggestion = new System.Windows.Forms.FlowLayoutPanel();
            this.btSpellingCorrector = new Diccon.RoundedLabel();
            this.btSynonym = new Diccon.RoundedLabel();
            this.roundedLabel9 = new Diccon.RoundedLabel();
            this.roundedLabel12 = new Diccon.RoundedLabel();
            this.btImage = new Diccon.RoundedLabel();
            this.contextMenuNote = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFavouriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.e = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synonymChecker = new System.Windows.Forms.Timer(this.components);
            this.listeningPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btAdd)).BeginInit();
            this.panelAdd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textFromClipboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFromMic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSend)).BeginInit();
            this.flowChatBox.SuspendLayout();
            this.exampleAnswerPanel.SuspendLayout();
            this.exampleAnswerColoredPanel.SuspendLayout();
            this.exampleflowLayoutSynonym.SuspendLayout();
            this.exampleShortPanel.SuspendLayout();
            this.exampleAskLongPanel.SuspendLayout();
            this.exampleAskLongColoredPanel.SuspendLayout();
            this.examplePlayPanel.SuspendLayout();
            this.examplePlayAlignPanel.SuspendLayout();
            this.examplePlayColoredPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examplePlayButton)).BeginInit();
            this.examplePicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examplePixabayLogo)).BeginInit();
            this.exampleColoredPicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examplePictureBox)).BeginInit();
            this.flowSuggestion.SuspendLayout();
            this.contextMenuNote.SuspendLayout();
            this.listeningPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btAdd);
            this.panelBottom.Controls.Add(this.panelAdd);
            this.panelBottom.Controls.Add(this.panel1);
            resources.ApplyResources(this.panelBottom, "panelBottom");
            this.panelBottom.Name = "panelBottom";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btAdd.IconColor = System.Drawing.SystemColors.ControlText;
            this.btAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAdd.IconSize = 28;
            resources.ApplyResources(this.btAdd, "btAdd");
            this.btAdd.Name = "btAdd";
            this.btAdd.TabStop = false;
            this.btAdd.UseGdi = true;
            this.btAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.btAdd.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.btAdd.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.addEmoji);
            resources.ApplyResources(this.panelAdd, "panelAdd");
            this.panelAdd.Name = "panelAdd";
            // 
            // addEmoji
            // 
            this.addEmoji.BackColor = System.Drawing.Color.Silver;
            this.addEmoji.BorderColor = System.Drawing.Color.White;
            this.addEmoji.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.addEmoji, "addEmoji");
            this.addEmoji.Image = global::Diccon.Properties.Resources.emoji_36;
            this.addEmoji.Name = "addEmoji";
            this.addEmoji.Radius = 50;
            this.addEmoji.Thickness = 5F;
            this.addEmoji.Click += new System.EventHandler(this.addEmoji_Click);
            this.addEmoji.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.addEmoji.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roundedPanel1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // roundedPanel1
            // 
            resources.ApplyResources(this.roundedPanel1, "roundedPanel1");
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.textFromClipboard);
            this.roundedPanel1.Controls.Add(this.labelTypeToSearch);
            this.roundedPanel1.Controls.Add(this.searchTextBox);
            this.roundedPanel1.Controls.Add(this.textFromMic);
            this.roundedPanel1.Controls.Add(this.btSend);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 20;
            this.roundedPanel1.Thickness = 5F;
            // 
            // textFromClipboard
            // 
            resources.ApplyResources(this.textFromClipboard, "textFromClipboard");
            this.textFromClipboard.BackColor = System.Drawing.Color.Transparent;
            this.textFromClipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textFromClipboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textFromClipboard.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.textFromClipboard.IconColor = System.Drawing.SystemColors.ControlText;
            this.textFromClipboard.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.textFromClipboard.IconSize = 28;
            this.textFromClipboard.Name = "textFromClipboard";
            this.textFromClipboard.TabStop = false;
            this.textFromClipboard.UseGdi = true;
            this.textFromClipboard.Click += new System.EventHandler(this.textFromClipboard_Click);
            this.textFromClipboard.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.textFromClipboard.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // labelTypeToSearch
            // 
            resources.ApplyResources(this.labelTypeToSearch, "labelTypeToSearch");
            this.labelTypeToSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelTypeToSearch.ForeColor = System.Drawing.Color.Gray;
            this.labelTypeToSearch.Name = "labelTypeToSearch";
            this.labelTypeToSearch.Click += new System.EventHandler(this.labelTypeToSearch_Click);
            // 
            // searchTextBox
            // 
            resources.ApplyResources(this.searchTextBox, "searchTextBox");
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // textFromMic
            // 
            resources.ApplyResources(this.textFromMic, "textFromMic");
            this.textFromMic.BackColor = System.Drawing.Color.Transparent;
            this.textFromMic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textFromMic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textFromMic.IconChar = FontAwesome.Sharp.IconChar.Microphone;
            this.textFromMic.IconColor = System.Drawing.SystemColors.ControlText;
            this.textFromMic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.textFromMic.IconSize = 28;
            this.textFromMic.Name = "textFromMic";
            this.textFromMic.TabStop = false;
            this.textFromMic.UseGdi = true;
            this.textFromMic.Click += new System.EventHandler(this.textFromMic_Click);
            this.textFromMic.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.textFromMic.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // btSend
            // 
            resources.ApplyResources(this.btSend, "btSend");
            this.btSend.BackColor = System.Drawing.Color.Transparent;
            this.btSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSend.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btSend.IconColor = System.Drawing.SystemColors.ControlText;
            this.btSend.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btSend.IconSize = 28;
            this.btSend.Name = "btSend";
            this.btSend.TabStop = false;
            this.btSend.UseGdi = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            this.btSend.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.btSend.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // flowChatBox
            // 
            resources.ApplyResources(this.flowChatBox, "flowChatBox");
            this.flowChatBox.BackColor = System.Drawing.Color.White;
            this.flowChatBox.Controls.Add(this.exampleAnswerPanel);
            this.flowChatBox.Controls.Add(this.exampleflowLayoutSynonym);
            this.flowChatBox.Controls.Add(this.exampleShortPanel);
            this.flowChatBox.Controls.Add(this.exampleAskLongPanel);
            this.flowChatBox.Controls.Add(this.examplePlayPanel);
            this.flowChatBox.Controls.Add(this.examplePicturePanel);
            this.flowChatBox.Name = "flowChatBox";
            // 
            // exampleAnswerPanel
            // 
            this.exampleAnswerPanel.Controls.Add(this.exampleAnswerColoredPanel);
            resources.ApplyResources(this.exampleAnswerPanel, "exampleAnswerPanel");
            this.exampleAnswerPanel.Name = "exampleAnswerPanel";
            // 
            // exampleAnswerColoredPanel
            // 
            this.exampleAnswerColoredPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.exampleAnswerColoredPanel.BorderColor = System.Drawing.Color.White;
            this.exampleAnswerColoredPanel.Controls.Add(this.exampleAnswerText);
            resources.ApplyResources(this.exampleAnswerColoredPanel, "exampleAnswerColoredPanel");
            this.exampleAnswerColoredPanel.Name = "exampleAnswerColoredPanel";
            this.exampleAnswerColoredPanel.Radius = 20;
            this.exampleAnswerColoredPanel.Thickness = 5F;
            // 
            // exampleAnswerText
            // 
            resources.ApplyResources(this.exampleAnswerText, "exampleAnswerText");
            this.exampleAnswerText.ForeColor = System.Drawing.Color.White;
            this.exampleAnswerText.Name = "exampleAnswerText";
            // 
            // exampleflowLayoutSynonym
            // 
            resources.ApplyResources(this.exampleflowLayoutSynonym, "exampleflowLayoutSynonym");
            this.exampleflowLayoutSynonym.Controls.Add(this.exampleItemSynonym);
            this.exampleflowLayoutSynonym.Controls.Add(this.roundedLabel3);
            this.exampleflowLayoutSynonym.Name = "exampleflowLayoutSynonym";
            // 
            // exampleItemSynonym
            // 
            resources.ApplyResources(this.exampleItemSynonym, "exampleItemSynonym");
            this.exampleItemSynonym.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exampleItemSynonym.BorderColor = System.Drawing.Color.White;
            this.exampleItemSynonym.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exampleItemSynonym.Name = "exampleItemSynonym";
            this.exampleItemSynonym.Radius = 20;
            this.exampleItemSynonym.Thickness = 5F;
            // 
            // roundedLabel3
            // 
            resources.ApplyResources(this.roundedLabel3, "roundedLabel3");
            this.roundedLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roundedLabel3.BorderColor = System.Drawing.Color.White;
            this.roundedLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedLabel3.Name = "roundedLabel3";
            this.roundedLabel3.Radius = 20;
            this.roundedLabel3.Thickness = 5F;
            // 
            // exampleShortPanel
            // 
            this.exampleShortPanel.Controls.Add(this.exampleShortText);
            resources.ApplyResources(this.exampleShortPanel, "exampleShortPanel");
            this.exampleShortPanel.Name = "exampleShortPanel";
            // 
            // exampleShortText
            // 
            resources.ApplyResources(this.exampleShortText, "exampleShortText");
            this.exampleShortText.BackColor = System.Drawing.Color.LightGray;
            this.exampleShortText.BorderColor = System.Drawing.Color.White;
            this.exampleShortText.Name = "exampleShortText";
            this.exampleShortText.Radius = 20;
            this.exampleShortText.Thickness = 5F;
            // 
            // exampleAskLongPanel
            // 
            this.exampleAskLongPanel.Controls.Add(this.exampleAskLongColoredPanel);
            resources.ApplyResources(this.exampleAskLongPanel, "exampleAskLongPanel");
            this.exampleAskLongPanel.Name = "exampleAskLongPanel";
            // 
            // exampleAskLongColoredPanel
            // 
            this.exampleAskLongColoredPanel.BackColor = System.Drawing.Color.LightGray;
            this.exampleAskLongColoredPanel.BorderColor = System.Drawing.Color.White;
            this.exampleAskLongColoredPanel.Controls.Add(this.exampleAskLongText);
            resources.ApplyResources(this.exampleAskLongColoredPanel, "exampleAskLongColoredPanel");
            this.exampleAskLongColoredPanel.Name = "exampleAskLongColoredPanel";
            this.exampleAskLongColoredPanel.Radius = 20;
            this.exampleAskLongColoredPanel.Thickness = 5F;
            // 
            // exampleAskLongText
            // 
            resources.ApplyResources(this.exampleAskLongText, "exampleAskLongText");
            this.exampleAskLongText.Name = "exampleAskLongText";
            // 
            // examplePlayPanel
            // 
            this.examplePlayPanel.Controls.Add(this.examplePlayAlignPanel);
            resources.ApplyResources(this.examplePlayPanel, "examplePlayPanel");
            this.examplePlayPanel.Name = "examplePlayPanel";
            // 
            // examplePlayAlignPanel
            // 
            this.examplePlayAlignPanel.Controls.Add(this.examplePlayColoredPanel);
            resources.ApplyResources(this.examplePlayAlignPanel, "examplePlayAlignPanel");
            this.examplePlayAlignPanel.Name = "examplePlayAlignPanel";
            // 
            // examplePlayColoredPanel
            // 
            resources.ApplyResources(this.examplePlayColoredPanel, "examplePlayColoredPanel");
            this.examplePlayColoredPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.examplePlayColoredPanel.BorderColor = System.Drawing.Color.White;
            this.examplePlayColoredPanel.Controls.Add(this.exampleTextHolder);
            this.examplePlayColoredPanel.Controls.Add(this.examplePlayButton);
            this.examplePlayColoredPanel.Name = "examplePlayColoredPanel";
            this.examplePlayColoredPanel.Radius = 20;
            this.examplePlayColoredPanel.Thickness = 5F;
            // 
            // exampleTextHolder
            // 
            resources.ApplyResources(this.exampleTextHolder, "exampleTextHolder");
            this.exampleTextHolder.Name = "exampleTextHolder";
            // 
            // examplePlayButton
            // 
            this.examplePlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.examplePlayButton, "examplePlayButton");
            this.examplePlayButton.Name = "examplePlayButton";
            this.examplePlayButton.TabStop = false;
            // 
            // examplePicturePanel
            // 
            this.examplePicturePanel.Controls.Add(this.examplePixabayLogo);
            this.examplePicturePanel.Controls.Add(this.exampleColoredPicturePanel);
            resources.ApplyResources(this.examplePicturePanel, "examplePicturePanel");
            this.examplePicturePanel.Name = "examplePicturePanel";
            // 
            // examplePixabayLogo
            // 
            this.examplePixabayLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.examplePixabayLogo.Image = global::Diccon.Properties.Resources.pixabay_logo;
            resources.ApplyResources(this.examplePixabayLogo, "examplePixabayLogo");
            this.examplePixabayLogo.Name = "examplePixabayLogo";
            this.examplePixabayLogo.TabStop = false;
            this.examplePixabayLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // exampleColoredPicturePanel
            // 
            this.exampleColoredPicturePanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.exampleColoredPicturePanel.BorderColor = System.Drawing.Color.White;
            this.exampleColoredPicturePanel.Controls.Add(this.examplePictureBox);
            resources.ApplyResources(this.exampleColoredPicturePanel, "exampleColoredPicturePanel");
            this.exampleColoredPicturePanel.Name = "exampleColoredPicturePanel";
            this.exampleColoredPicturePanel.Radius = 20;
            this.exampleColoredPicturePanel.Thickness = 5F;
            // 
            // examplePictureBox
            // 
            this.examplePictureBox.BackColor = System.Drawing.Color.White;
            this.examplePictureBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.examplePictureBox.ErrorImage = global::Diccon.Properties.Resources.doubtful;
            resources.ApplyResources(this.examplePictureBox, "examplePictureBox");
            this.examplePictureBox.InitialImage = global::Diccon.Properties.Resources.reluctant;
            this.examplePictureBox.Name = "examplePictureBox";
            this.examplePictureBox.Radius = 20;
            this.examplePictureBox.TabStop = false;
            this.examplePictureBox.Thickness = 5F;
            // 
            // suggestionTimer
            // 
            this.suggestionTimer.Interval = 500;
            this.suggestionTimer.Tick += new System.EventHandler(this.suggestionTimer_TickAsync);
            // 
            // flowSuggestion
            // 
            resources.ApplyResources(this.flowSuggestion, "flowSuggestion");
            this.flowSuggestion.Controls.Add(this.btSpellingCorrector);
            this.flowSuggestion.Controls.Add(this.btSynonym);
            this.flowSuggestion.Controls.Add(this.roundedLabel9);
            this.flowSuggestion.Controls.Add(this.roundedLabel12);
            this.flowSuggestion.Controls.Add(this.btImage);
            this.flowSuggestion.Name = "flowSuggestion";
            // 
            // btSpellingCorrector
            // 
            resources.ApplyResources(this.btSpellingCorrector, "btSpellingCorrector");
            this.btSpellingCorrector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btSpellingCorrector.BorderColor = System.Drawing.Color.White;
            this.btSpellingCorrector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSpellingCorrector.Name = "btSpellingCorrector";
            this.btSpellingCorrector.Radius = 20;
            this.btSpellingCorrector.Thickness = 5F;
            this.btSpellingCorrector.Click += new System.EventHandler(this.btSpellingCorrector_Click);
            // 
            // btSynonym
            // 
            resources.ApplyResources(this.btSynonym, "btSynonym");
            this.btSynonym.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btSynonym.BorderColor = System.Drawing.Color.White;
            this.btSynonym.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSynonym.Name = "btSynonym";
            this.btSynonym.Radius = 20;
            this.btSynonym.Thickness = 5F;
            this.btSynonym.Click += new System.EventHandler(this.btSynonym_Click);
            this.btSynonym.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btSynonym.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // roundedLabel9
            // 
            resources.ApplyResources(this.roundedLabel9, "roundedLabel9");
            this.roundedLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roundedLabel9.BorderColor = System.Drawing.Color.White;
            this.roundedLabel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedLabel9.Name = "roundedLabel9";
            this.roundedLabel9.Radius = 20;
            this.roundedLabel9.Thickness = 5F;
            // 
            // roundedLabel12
            // 
            resources.ApplyResources(this.roundedLabel12, "roundedLabel12");
            this.roundedLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roundedLabel12.BorderColor = System.Drawing.Color.White;
            this.roundedLabel12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedLabel12.Name = "roundedLabel12";
            this.roundedLabel12.Radius = 20;
            this.roundedLabel12.Thickness = 5F;
            // 
            // btImage
            // 
            resources.ApplyResources(this.btImage, "btImage");
            this.btImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btImage.BorderColor = System.Drawing.Color.White;
            this.btImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImage.Name = "btImage";
            this.btImage.Radius = 20;
            this.btImage.Thickness = 5F;
            this.btImage.Click += new System.EventHandler(this.btImage_Click);
            // 
            // contextMenuNote
            // 
            this.contextMenuNote.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuNote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.addToFavouriteToolStripMenuItem,
            this.e,
            this.closeToolStripMenuItem});
            this.contextMenuNote.Name = "contextMenuNote";
            resources.ApplyResources(this.contextMenuNote, "contextMenuNote");
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            // 
            // addToFavouriteToolStripMenuItem
            // 
            this.addToFavouriteToolStripMenuItem.Name = "addToFavouriteToolStripMenuItem";
            resources.ApplyResources(this.addToFavouriteToolStripMenuItem, "addToFavouriteToolStripMenuItem");
            // 
            // e
            // 
            this.e.Name = "e";
            resources.ApplyResources(this.e, "e");
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // synonymChecker
            // 
            this.synonymChecker.Interval = 500;
            this.synonymChecker.Tick += new System.EventHandler(this.synonymChecker_Tick);
            // 
            // listeningPanel
            // 
            this.listeningPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listeningPanel.Controls.Add(this.label3);
            resources.ApplyResources(this.listeningPanel, "listeningPanel");
            this.listeningPanel.Name = "listeningPanel";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // dictionary
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listeningPanel);
            this.Controls.Add(this.flowChatBox);
            this.Controls.Add(this.flowSuggestion);
            this.Controls.Add(this.panelBottom);
            this.Name = "dictionary";
            this.ShowIcon = false;
            this.Tag = "423, 753";
            this.Load += new System.EventHandler(this.mainHall_Load);
            this.SizeChanged += new System.EventHandler(this.dictionary_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.dictionary_VisibleChanged);
            this.Leave += new System.EventHandler(this.dictionary_Leave);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btAdd)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textFromClipboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFromMic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSend)).EndInit();
            this.flowChatBox.ResumeLayout(false);
            this.flowChatBox.PerformLayout();
            this.exampleAnswerPanel.ResumeLayout(false);
            this.exampleAnswerColoredPanel.ResumeLayout(false);
            this.exampleAnswerColoredPanel.PerformLayout();
            this.exampleflowLayoutSynonym.ResumeLayout(false);
            this.exampleflowLayoutSynonym.PerformLayout();
            this.exampleShortPanel.ResumeLayout(false);
            this.exampleShortPanel.PerformLayout();
            this.exampleAskLongPanel.ResumeLayout(false);
            this.exampleAskLongColoredPanel.ResumeLayout(false);
            this.exampleAskLongColoredPanel.PerformLayout();
            this.examplePlayPanel.ResumeLayout(false);
            this.examplePlayAlignPanel.ResumeLayout(false);
            this.examplePlayAlignPanel.PerformLayout();
            this.examplePlayColoredPanel.ResumeLayout(false);
            this.examplePlayColoredPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examplePlayButton)).EndInit();
            this.examplePicturePanel.ResumeLayout(false);
            this.examplePicturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examplePixabayLogo)).EndInit();
            this.exampleColoredPicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examplePictureBox)).EndInit();
            this.flowSuggestion.ResumeLayout(false);
            this.flowSuggestion.PerformLayout();
            this.contextMenuNote.ResumeLayout(false);
            this.listeningPanel.ResumeLayout(false);
            this.listeningPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel panelBottom;
        public System.Windows.Forms.FlowLayoutPanel flowChatBox;
        private System.Windows.Forms.Panel exampleShortPanel;
        private System.Windows.Forms.Panel exampleAnswerPanel;
        private System.Windows.Forms.Panel examplePlayPanel;
        private System.Windows.Forms.PictureBox examplePlayButton;
        private System.Windows.Forms.Panel exampleAskLongPanel;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Panel examplePlayAlignPanel;
        private RoundedPanel examplePlayColoredPanel;
        private RoundedPanel exampleAnswerColoredPanel;
        private RoundedLabel exampleShortText;
        private RoundedPanel exampleAskLongColoredPanel;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTypeToSearch;
        private RoundedLabel btSynonym;
        private System.Windows.Forms.Timer suggestionTimer;
        private System.Windows.Forms.FlowLayoutPanel exampleflowLayoutSynonym;
        private RoundedLabel exampleItemSynonym;
        private RoundedLabel roundedLabel3;
        private System.Windows.Forms.FlowLayoutPanel flowSuggestion;
        private RoundedLabel roundedLabel9;
        private RoundedLabel btSpellingCorrector;
        private RoundedLabel btImage;
        private RoundedLabel roundedLabel12;
        private System.Windows.Forms.Label exampleTextHolder;
        private RoundedLabel addEmoji;
        private System.Windows.Forms.ContextMenuStrip contextMenuNote;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToFavouriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator e;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel examplePicturePanel;
        private RoundedPanel exampleColoredPicturePanel;
        private System.Windows.Forms.PictureBox examplePixabayLogo;
        private RoundedPictureBox examplePictureBox;
        private System.Windows.Forms.Label exampleAnswerText;
        private System.Windows.Forms.Label exampleAskLongText;
        private FontAwesome.Sharp.IconPictureBox btAdd;
        private FontAwesome.Sharp.IconPictureBox textFromMic;
        private FontAwesome.Sharp.IconPictureBox btSend;
        private FontAwesome.Sharp.IconPictureBox textFromClipboard;
        private System.Windows.Forms.Timer synonymChecker;
        private System.Windows.Forms.FlowLayoutPanel listeningPanel;
        private System.Windows.Forms.Label label3;
    }
}


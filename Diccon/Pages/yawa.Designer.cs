namespace Diccon.Pages
{
    partial class yawa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yawa));
            this.panelMain = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btInstantAsk = new Diccon.RoundedLabel();
            this.panelOfRichQuestion_1 = new Diccon.RoundedPanel();
            this.richQuestion = new System.Windows.Forms.RichTextBox();
            this.notice = new System.Windows.Forms.Label();
            this.countWord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAsk = new Diccon.RoundedLabel();
            this.panelYours = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAnswer = new System.Windows.Forms.Panel();
            this.flowChatBox = new System.Windows.Forms.FlowLayoutPanel();
            this.exampleAnswerPanel = new System.Windows.Forms.Panel();
            this.exampleAnswerColoredPanel = new Diccon.RoundedPanel();
            this.exampleAnswerText = new System.Windows.Forms.Label();
            this.exampleAskLongPanel = new System.Windows.Forms.Panel();
            this.exampleAskLongColoredPanel = new Diccon.RoundedPanel();
            this.exampleAskLongText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new Diccon.RoundedPanel();
            this.answer_TextHolder = new System.Windows.Forms.Label();
            this.answer_textBox = new System.Windows.Forms.TextBox();
            this.textFromClipboard = new System.Windows.Forms.PictureBox();
            this.btSend = new FontAwesome.Sharp.IconPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelGlobal = new System.Windows.Forms.Panel();
            this.globalFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.globalExamplePanel = new Diccon.RoundedPanel();
            this.globalExampleDatetime = new System.Windows.Forms.Label();
            this.globalExampleAsk = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btAskTop = new Diccon.RoundedLabel();
            this.btPeopleTop = new Diccon.RoundedLabel();
            this.btYoursTop = new Diccon.RoundedLabel();
            this.btReload = new FontAwesome.Sharp.IconPictureBox();
            this.panelMain.SuspendLayout();
            this.panelOfRichQuestion_1.SuspendLayout();
            this.panelYours.SuspendLayout();
            this.panelAnswer.SuspendLayout();
            this.flowChatBox.SuspendLayout();
            this.exampleAnswerPanel.SuspendLayout();
            this.exampleAnswerColoredPanel.SuspendLayout();
            this.exampleAskLongPanel.SuspendLayout();
            this.exampleAskLongColoredPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textFromClipboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSend)).BeginInit();
            this.panelGlobal.SuspendLayout();
            this.globalFlowPanel.SuspendLayout();
            this.globalExamplePanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btReload)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.btInstantAsk);
            this.panelMain.Controls.Add(this.panelOfRichQuestion_1);
            this.panelMain.Controls.Add(this.notice);
            this.panelMain.Controls.Add(this.countWord);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.btAsk);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Name = "label4";
            // 
            // btInstantAsk
            // 
            resources.ApplyResources(this.btInstantAsk, "btInstantAsk");
            this.btInstantAsk.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btInstantAsk.BorderColor = System.Drawing.Color.White;
            this.btInstantAsk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInstantAsk.ForeColor = System.Drawing.Color.Black;
            this.btInstantAsk.Name = "btInstantAsk";
            this.btInstantAsk.Radius = 20;
            this.btInstantAsk.Thickness = 5F;
            this.btInstantAsk.MouseEnter += new System.EventHandler(this.btRecent_MouseEnter);
            this.btInstantAsk.MouseLeave += new System.EventHandler(this.btRecent_MouseLeave);
            // 
            // panelOfRichQuestion_1
            // 
            this.panelOfRichQuestion_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelOfRichQuestion_1.BorderColor = System.Drawing.Color.White;
            this.panelOfRichQuestion_1.Controls.Add(this.richQuestion);
            resources.ApplyResources(this.panelOfRichQuestion_1, "panelOfRichQuestion_1");
            this.panelOfRichQuestion_1.Name = "panelOfRichQuestion_1";
            this.panelOfRichQuestion_1.Radius = 20;
            this.panelOfRichQuestion_1.Thickness = 5F;
            // 
            // richQuestion
            // 
            this.richQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richQuestion, "richQuestion");
            this.richQuestion.Name = "richQuestion";
            this.richQuestion.TextChanged += new System.EventHandler(this.richQuestion_TextChanged);
            // 
            // notice
            // 
            resources.ApplyResources(this.notice, "notice");
            this.notice.Name = "notice";
            // 
            // countWord
            // 
            resources.ApplyResources(this.countWord, "countWord");
            this.countWord.ForeColor = System.Drawing.Color.DarkGray;
            this.countWord.Name = "countWord";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Name = "label1";
            // 
            // btAsk
            // 
            resources.ApplyResources(this.btAsk, "btAsk");
            this.btAsk.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btAsk.BorderColor = System.Drawing.Color.White;
            this.btAsk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAsk.ForeColor = System.Drawing.Color.Black;
            this.btAsk.Name = "btAsk";
            this.btAsk.Radius = 20;
            this.btAsk.Thickness = 5F;
            this.btAsk.Click += new System.EventHandler(this.btAsk_Click);
            this.btAsk.MouseEnter += new System.EventHandler(this.btRecent_MouseEnter);
            this.btAsk.MouseLeave += new System.EventHandler(this.btRecent_MouseLeave);
            // 
            // panelYours
            // 
            this.panelYours.Controls.Add(this.label2);
            resources.ApplyResources(this.panelYours, "panelYours");
            this.panelYours.Name = "panelYours";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Name = "label2";
            // 
            // panelAnswer
            // 
            this.panelAnswer.Controls.Add(this.flowChatBox);
            this.panelAnswer.Controls.Add(this.panel1);
            resources.ApplyResources(this.panelAnswer, "panelAnswer");
            this.panelAnswer.Name = "panelAnswer";
            // 
            // flowChatBox
            // 
            resources.ApplyResources(this.flowChatBox, "flowChatBox");
            this.flowChatBox.BackColor = System.Drawing.Color.White;
            this.flowChatBox.Controls.Add(this.exampleAnswerPanel);
            this.flowChatBox.Controls.Add(this.exampleAskLongPanel);
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
            this.roundedPanel1.Controls.Add(this.answer_TextHolder);
            this.roundedPanel1.Controls.Add(this.answer_textBox);
            this.roundedPanel1.Controls.Add(this.textFromClipboard);
            this.roundedPanel1.Controls.Add(this.btSend);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 20;
            this.roundedPanel1.Thickness = 5F;
            // 
            // answer_TextHolder
            // 
            resources.ApplyResources(this.answer_TextHolder, "answer_TextHolder");
            this.answer_TextHolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.answer_TextHolder.ForeColor = System.Drawing.Color.Gray;
            this.answer_TextHolder.Name = "answer_TextHolder";
            // 
            // answer_textBox
            // 
            resources.ApplyResources(this.answer_textBox, "answer_textBox");
            this.answer_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.answer_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answer_textBox.ForeColor = System.Drawing.Color.Black;
            this.answer_textBox.Name = "answer_textBox";
            this.answer_textBox.TextChanged += new System.EventHandler(this.answer_textBox_TextChanged);
            this.answer_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answer_textBox_KeyDown);
            // 
            // textFromClipboard
            // 
            resources.ApplyResources(this.textFromClipboard, "textFromClipboard");
            this.textFromClipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textFromClipboard.Image = global::Diccon.Properties.Resources.clipboard_24;
            this.textFromClipboard.Name = "textFromClipboard";
            this.textFromClipboard.TabStop = false;
            // 
            // btSend
            // 
            resources.ApplyResources(this.btSend, "btSend");
            this.btSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.btSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSend.ForeColor = System.Drawing.Color.Black;
            this.btSend.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btSend.IconColor = System.Drawing.Color.Black;
            this.btSend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSend.IconSize = 27;
            this.btSend.Name = "btSend";
            this.btSend.TabStop = false;
            // 
            // panelGlobal
            // 
            this.panelGlobal.Controls.Add(this.globalFlowPanel);
            resources.ApplyResources(this.panelGlobal, "panelGlobal");
            this.panelGlobal.Name = "panelGlobal";
            // 
            // globalFlowPanel
            // 
            resources.ApplyResources(this.globalFlowPanel, "globalFlowPanel");
            this.globalFlowPanel.Controls.Add(this.globalExamplePanel);
            this.globalFlowPanel.Name = "globalFlowPanel";
            // 
            // globalExamplePanel
            // 
            this.globalExamplePanel.BackColor = System.Drawing.Color.DarkGray;
            this.globalExamplePanel.BorderColor = System.Drawing.Color.White;
            this.globalExamplePanel.Controls.Add(this.globalExampleDatetime);
            this.globalExamplePanel.Controls.Add(this.globalExampleAsk);
            resources.ApplyResources(this.globalExamplePanel, "globalExamplePanel");
            this.globalExamplePanel.Name = "globalExamplePanel";
            this.globalExamplePanel.Radius = 20;
            this.globalExamplePanel.Thickness = 5F;
            // 
            // globalExampleDatetime
            // 
            resources.ApplyResources(this.globalExampleDatetime, "globalExampleDatetime");
            this.globalExampleDatetime.Name = "globalExampleDatetime";
            // 
            // globalExampleAsk
            // 
            resources.ApplyResources(this.globalExampleAsk, "globalExampleAsk");
            this.globalExampleAsk.ForeColor = System.Drawing.Color.Black;
            this.globalExampleAsk.Name = "globalExampleAsk";
            this.globalExampleAsk.Click += new System.EventHandler(this.globalExampleAsk_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btAskTop);
            this.flowLayoutPanel1.Controls.Add(this.btPeopleTop);
            this.flowLayoutPanel1.Controls.Add(this.btYoursTop);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btAskTop
            // 
            this.btAskTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btAskTop.BorderColor = System.Drawing.Color.White;
            this.btAskTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAskTop.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btAskTop, "btAskTop");
            this.btAskTop.Name = "btAskTop";
            this.btAskTop.Radius = 20;
            this.btAskTop.Thickness = 5F;
            this.btAskTop.Click += new System.EventHandler(this.btAskTop_Click);
            this.btAskTop.MouseEnter += new System.EventHandler(this.btAskPanel_MouseEnter);
            this.btAskTop.MouseLeave += new System.EventHandler(this.btAskPanel_MouseLeave);
            // 
            // btPeopleTop
            // 
            this.btPeopleTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btPeopleTop.BorderColor = System.Drawing.Color.White;
            this.btPeopleTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPeopleTop.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btPeopleTop, "btPeopleTop");
            this.btPeopleTop.Name = "btPeopleTop";
            this.btPeopleTop.Radius = 20;
            this.btPeopleTop.Thickness = 5F;
            this.btPeopleTop.Click += new System.EventHandler(this.btPeopleTop_Click);
            this.btPeopleTop.MouseEnter += new System.EventHandler(this.btAskPanel_MouseEnter);
            this.btPeopleTop.MouseLeave += new System.EventHandler(this.btAskPanel_MouseLeave);
            // 
            // btYoursTop
            // 
            this.btYoursTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btYoursTop.BorderColor = System.Drawing.Color.White;
            this.btYoursTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btYoursTop.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btYoursTop, "btYoursTop");
            this.btYoursTop.Name = "btYoursTop";
            this.btYoursTop.Radius = 20;
            this.btYoursTop.Thickness = 5F;
            this.btYoursTop.Click += new System.EventHandler(this.btYoursTop_Click);
            this.btYoursTop.MouseEnter += new System.EventHandler(this.btAskPanel_MouseEnter);
            this.btYoursTop.MouseLeave += new System.EventHandler(this.btAskPanel_MouseLeave);
            // 
            // btReload
            // 
            this.btReload.BackColor = System.Drawing.Color.White;
            this.btReload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btReload.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btReload.IconColor = System.Drawing.SystemColors.ControlText;
            this.btReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resources.ApplyResources(this.btReload, "btReload");
            this.btReload.Name = "btReload";
            this.btReload.TabStop = false;
            this.btReload.UseGdi = true;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            this.btReload.MouseEnter += new System.EventHandler(this.btReload_MouseEnter);
            this.btReload.MouseLeave += new System.EventHandler(this.btReload_MouseLeave);
            // 
            // yawa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelGlobal);
            this.Controls.Add(this.panelAnswer);
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.panelYours);
            this.Controls.Add(this.panelMain);
            this.Name = "yawa";
            this.Load += new System.EventHandler(this.yawa_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelOfRichQuestion_1.ResumeLayout(false);
            this.panelYours.ResumeLayout(false);
            this.panelAnswer.ResumeLayout(false);
            this.flowChatBox.ResumeLayout(false);
            this.exampleAnswerPanel.ResumeLayout(false);
            this.exampleAnswerColoredPanel.ResumeLayout(false);
            this.exampleAnswerColoredPanel.PerformLayout();
            this.exampleAskLongPanel.ResumeLayout(false);
            this.exampleAskLongColoredPanel.ResumeLayout(false);
            this.exampleAskLongColoredPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textFromClipboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSend)).EndInit();
            this.panelGlobal.ResumeLayout(false);
            this.globalFlowPanel.ResumeLayout(false);
            this.globalExamplePanel.ResumeLayout(false);
            this.globalExamplePanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btReload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.RichTextBox richQuestion;
        private System.Windows.Forms.Panel panelYours;
        private RoundedLabel btAsk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAnswer;
        private System.Windows.Forms.Label notice;
        private System.Windows.Forms.Label countWord;
        private System.Windows.Forms.Timer timer1;
        private RoundedPanel panelOfRichQuestion_1;
        private RoundedLabel btInstantAsk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelGlobal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RoundedLabel btPeopleTop;
        private RoundedLabel btAskTop;
        private System.Windows.Forms.FlowLayoutPanel globalFlowPanel;
        private RoundedPanel globalExamplePanel;
        private System.Windows.Forms.Label globalExampleAsk;
        private System.Windows.Forms.Label globalExampleDatetime;
        private RoundedLabel btYoursTop;
        private FontAwesome.Sharp.IconPictureBox btReload;
        private System.Windows.Forms.Panel panel1;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label answer_TextHolder;
        private System.Windows.Forms.TextBox answer_textBox;
        private System.Windows.Forms.PictureBox textFromClipboard;
        private FontAwesome.Sharp.IconPictureBox btSend;
        public System.Windows.Forms.FlowLayoutPanel flowChatBox;
        private System.Windows.Forms.Panel exampleAnswerPanel;
        private RoundedPanel exampleAnswerColoredPanel;
        private System.Windows.Forms.Label exampleAnswerText;
        private System.Windows.Forms.Panel exampleAskLongPanel;
        private RoundedPanel exampleAskLongColoredPanel;
        private System.Windows.Forms.Label exampleAskLongText;
    }
}
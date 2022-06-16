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
            this.richQuestion_1 = new System.Windows.Forms.RichTextBox();
            this.notice = new System.Windows.Forms.Label();
            this.countWord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAsk = new Diccon.RoundedLabel();
            this.panelPrevious = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAnswer = new System.Windows.Forms.Panel();
            this.panelOfRichAnswer = new Diccon.RoundedPanel();
            this.richAnswer = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelOfRichQuestion_2 = new Diccon.RoundedPanel();
            this.richQuestion_2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelGlobal = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btAskPanel = new Diccon.RoundedLabel();
            this.btAnswer = new Diccon.RoundedLabel();
            this.btPeople = new Diccon.RoundedLabel();
            this.btPrevious = new Diccon.RoundedLabel();
            this.panelMain.SuspendLayout();
            this.panelOfRichQuestion_1.SuspendLayout();
            this.panelPrevious.SuspendLayout();
            this.panelAnswer.SuspendLayout();
            this.panelOfRichAnswer.SuspendLayout();
            this.panelOfRichQuestion_2.SuspendLayout();
            this.panelGlobal.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.btInstantAsk);
            this.panelMain.Controls.Add(this.panelOfRichQuestion_1);
            this.panelMain.Controls.Add(this.notice);
            this.panelMain.Controls.Add(this.countWord);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.btAsk);
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
            resources.ApplyResources(this.panelOfRichQuestion_1, "panelOfRichQuestion_1");
            this.panelOfRichQuestion_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelOfRichQuestion_1.BorderColor = System.Drawing.Color.White;
            this.panelOfRichQuestion_1.Controls.Add(this.richQuestion_1);
            this.panelOfRichQuestion_1.Name = "panelOfRichQuestion_1";
            this.panelOfRichQuestion_1.Radius = 20;
            this.panelOfRichQuestion_1.Thickness = 5F;
            // 
            // richQuestion_1
            // 
            resources.ApplyResources(this.richQuestion_1, "richQuestion_1");
            this.richQuestion_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richQuestion_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richQuestion_1.Name = "richQuestion_1";
            this.richQuestion_1.TextChanged += new System.EventHandler(this.richQuestion_TextChanged);
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
            this.btAsk.MouseEnter += new System.EventHandler(this.btRecent_MouseEnter);
            this.btAsk.MouseLeave += new System.EventHandler(this.btRecent_MouseLeave);
            // 
            // panelPrevious
            // 
            resources.ApplyResources(this.panelPrevious, "panelPrevious");
            this.panelPrevious.Controls.Add(this.label2);
            this.panelPrevious.Name = "panelPrevious";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Name = "label2";
            // 
            // panelAnswer
            // 
            resources.ApplyResources(this.panelAnswer, "panelAnswer");
            this.panelAnswer.Controls.Add(this.panelOfRichAnswer);
            this.panelAnswer.Controls.Add(this.label7);
            this.panelAnswer.Controls.Add(this.panelOfRichQuestion_2);
            this.panelAnswer.Controls.Add(this.label3);
            this.panelAnswer.Name = "panelAnswer";
            // 
            // panelOfRichAnswer
            // 
            resources.ApplyResources(this.panelOfRichAnswer, "panelOfRichAnswer");
            this.panelOfRichAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelOfRichAnswer.BorderColor = System.Drawing.Color.White;
            this.panelOfRichAnswer.Controls.Add(this.richAnswer);
            this.panelOfRichAnswer.Name = "panelOfRichAnswer";
            this.panelOfRichAnswer.Radius = 20;
            this.panelOfRichAnswer.Thickness = 5F;
            // 
            // richAnswer
            // 
            resources.ApplyResources(this.richAnswer, "richAnswer");
            this.richAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richAnswer.Name = "richAnswer";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Name = "label7";
            // 
            // panelOfRichQuestion_2
            // 
            resources.ApplyResources(this.panelOfRichQuestion_2, "panelOfRichQuestion_2");
            this.panelOfRichQuestion_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelOfRichQuestion_2.BorderColor = System.Drawing.Color.White;
            this.panelOfRichQuestion_2.Controls.Add(this.richQuestion_2);
            this.panelOfRichQuestion_2.Name = "panelOfRichQuestion_2";
            this.panelOfRichQuestion_2.Radius = 20;
            this.panelOfRichQuestion_2.Thickness = 5F;
            // 
            // richQuestion_2
            // 
            resources.ApplyResources(this.richQuestion_2, "richQuestion_2");
            this.richQuestion_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richQuestion_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richQuestion_2.Name = "richQuestion_2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Name = "label3";
            // 
            // panelGlobal
            // 
            resources.ApplyResources(this.panelGlobal, "panelGlobal");
            this.panelGlobal.Controls.Add(this.label6);
            this.panelGlobal.Name = "panelGlobal";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Name = "label6";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.btAskPanel);
            this.flowLayoutPanel1.Controls.Add(this.btAnswer);
            this.flowLayoutPanel1.Controls.Add(this.btPeople);
            this.flowLayoutPanel1.Controls.Add(this.btPrevious);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btAskPanel
            // 
            resources.ApplyResources(this.btAskPanel, "btAskPanel");
            this.btAskPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btAskPanel.BorderColor = System.Drawing.Color.White;
            this.btAskPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAskPanel.ForeColor = System.Drawing.Color.White;
            this.btAskPanel.Name = "btAskPanel";
            this.btAskPanel.Radius = 20;
            this.btAskPanel.Thickness = 5F;
            this.btAskPanel.Click += new System.EventHandler(this.btAskPanel_Click);
            this.btAskPanel.MouseEnter += new System.EventHandler(this.btAskPanel_MouseEnter);
            this.btAskPanel.MouseLeave += new System.EventHandler(this.btAskPanel_MouseLeave);
            // 
            // btAnswer
            // 
            resources.ApplyResources(this.btAnswer, "btAnswer");
            this.btAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btAnswer.BorderColor = System.Drawing.Color.White;
            this.btAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnswer.ForeColor = System.Drawing.Color.White;
            this.btAnswer.Name = "btAnswer";
            this.btAnswer.Radius = 20;
            this.btAnswer.Thickness = 5F;
            this.btAnswer.Click += new System.EventHandler(this.btRecent_Click);
            this.btAnswer.MouseEnter += new System.EventHandler(this.btAskPanel_MouseEnter);
            this.btAnswer.MouseLeave += new System.EventHandler(this.btAskPanel_MouseLeave);
            // 
            // btPeople
            // 
            resources.ApplyResources(this.btPeople, "btPeople");
            this.btPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btPeople.BorderColor = System.Drawing.Color.White;
            this.btPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPeople.ForeColor = System.Drawing.Color.White;
            this.btPeople.Name = "btPeople";
            this.btPeople.Radius = 20;
            this.btPeople.Thickness = 5F;
            this.btPeople.MouseEnter += new System.EventHandler(this.btAskPanel_MouseEnter);
            this.btPeople.MouseLeave += new System.EventHandler(this.btAskPanel_MouseLeave);
            // 
            // btPrevious
            // 
            resources.ApplyResources(this.btPrevious, "btPrevious");
            this.btPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btPrevious.BorderColor = System.Drawing.Color.White;
            this.btPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPrevious.ForeColor = System.Drawing.Color.White;
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Radius = 20;
            this.btPrevious.Thickness = 5F;
            this.btPrevious.MouseEnter += new System.EventHandler(this.btAskPanel_MouseEnter);
            this.btPrevious.MouseLeave += new System.EventHandler(this.btAskPanel_MouseLeave);
            // 
            // yawa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelGlobal);
            this.Controls.Add(this.panelAnswer);
            this.Controls.Add(this.panelPrevious);
            this.Controls.Add(this.panelMain);
            this.Name = "yawa";
            this.Load += new System.EventHandler(this.yawa_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelOfRichQuestion_1.ResumeLayout(false);
            this.panelPrevious.ResumeLayout(false);
            this.panelAnswer.ResumeLayout(false);
            this.panelAnswer.PerformLayout();
            this.panelOfRichAnswer.ResumeLayout(false);
            this.panelOfRichQuestion_2.ResumeLayout(false);
            this.panelGlobal.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.RichTextBox richQuestion_1;
        private System.Windows.Forms.Panel panelPrevious;
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
        private System.Windows.Forms.Label label6;
        private RoundedPanel panelOfRichAnswer;
        private System.Windows.Forms.RichTextBox richAnswer;
        private System.Windows.Forms.Label label7;
        private RoundedPanel panelOfRichQuestion_2;
        private System.Windows.Forms.RichTextBox richQuestion_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RoundedLabel btPrevious;
        private RoundedLabel btPeople;
        private RoundedLabel btAnswer;
        private RoundedLabel btAskPanel;
    }
}
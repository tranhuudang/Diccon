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
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.btInstantAsk);
            this.panelMain.Controls.Add(this.panelOfRichQuestion_1);
            this.panelMain.Controls.Add(this.notice);
            this.panelMain.Controls.Add(this.countWord);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.btAsk);
            this.panelMain.Location = new System.Drawing.Point(0, 38);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(355, 513);
            this.panelMain.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Instant Ask: 10 left";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Free: 100 left";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btInstantAsk
            // 
            this.btInstantAsk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btInstantAsk.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btInstantAsk.BorderColor = System.Drawing.Color.White;
            this.btInstantAsk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInstantAsk.Enabled = false;
            this.btInstantAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInstantAsk.ForeColor = System.Drawing.Color.Black;
            this.btInstantAsk.Location = new System.Drawing.Point(83, 338);
            this.btInstantAsk.Name = "btInstantAsk";
            this.btInstantAsk.Padding = new System.Windows.Forms.Padding(7);
            this.btInstantAsk.Radius = 20;
            this.btInstantAsk.Size = new System.Drawing.Size(121, 34);
            this.btInstantAsk.TabIndex = 15;
            this.btInstantAsk.Text = "Instant Ask";
            this.btInstantAsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btInstantAsk.Thickness = 5F;
            this.btInstantAsk.MouseEnter += new System.EventHandler(this.btRecent_MouseEnter);
            this.btInstantAsk.MouseLeave += new System.EventHandler(this.btRecent_MouseLeave);
            // 
            // panelOfRichQuestion_1
            // 
            this.panelOfRichQuestion_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelOfRichQuestion_1.BorderColor = System.Drawing.Color.White;
            this.panelOfRichQuestion_1.Controls.Add(this.richQuestion_1);
            this.panelOfRichQuestion_1.Location = new System.Drawing.Point(12, 119);
            this.panelOfRichQuestion_1.Name = "panelOfRichQuestion_1";
            this.panelOfRichQuestion_1.Radius = 20;
            this.panelOfRichQuestion_1.Size = new System.Drawing.Size(330, 216);
            this.panelOfRichQuestion_1.TabIndex = 13;
            this.panelOfRichQuestion_1.Thickness = 5F;
            // 
            // richQuestion_1
            // 
            this.richQuestion_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richQuestion_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richQuestion_1.Location = new System.Drawing.Point(10, 12);
            this.richQuestion_1.MaxLength = 500;
            this.richQuestion_1.Name = "richQuestion_1";
            this.richQuestion_1.Size = new System.Drawing.Size(309, 190);
            this.richQuestion_1.TabIndex = 0;
            this.richQuestion_1.Text = resources.GetString("richQuestion_1.Text");
            this.richQuestion_1.TextChanged += new System.EventHandler(this.richQuestion_TextChanged);
            // 
            // notice
            // 
            this.notice.Location = new System.Drawing.Point(12, 372);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(330, 105);
            this.notice.TabIndex = 12;
            this.notice.Text = "Your question will be answed within 2 to 15 minutes. We\'ll send you a notificatio" +
    "n when your answer is ready.";
            this.notice.Visible = false;
            // 
            // countWord
            // 
            this.countWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countWord.ForeColor = System.Drawing.Color.DarkGray;
            this.countWord.Location = new System.Drawing.Point(272, 338);
            this.countWord.Name = "countWord";
            this.countWord.Size = new System.Drawing.Size(69, 34);
            this.countWord.TabIndex = 11;
            this.countWord.Text = "500/500";
            this.countWord.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.countWord.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(9, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Your question";
            // 
            // btAsk
            // 
            this.btAsk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAsk.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btAsk.BorderColor = System.Drawing.Color.White;
            this.btAsk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAsk.ForeColor = System.Drawing.Color.Black;
            this.btAsk.Location = new System.Drawing.Point(12, 338);
            this.btAsk.Name = "btAsk";
            this.btAsk.Padding = new System.Windows.Forms.Padding(7);
            this.btAsk.Radius = 20;
            this.btAsk.Size = new System.Drawing.Size(65, 34);
            this.btAsk.TabIndex = 9;
            this.btAsk.Text = "Ask";
            this.btAsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btAsk.Thickness = 5F;
            this.btAsk.MouseEnter += new System.EventHandler(this.btRecent_MouseEnter);
            this.btAsk.MouseLeave += new System.EventHandler(this.btRecent_MouseLeave);
            // 
            // panelPrevious
            // 
            this.panelPrevious.Controls.Add(this.label2);
            this.panelPrevious.Location = new System.Drawing.Point(361, 38);
            this.panelPrevious.Name = "panelPrevious";
            this.panelPrevious.Size = new System.Drawing.Size(355, 513);
            this.panelPrevious.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(68, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "previous";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAnswer
            // 
            this.panelAnswer.Controls.Add(this.panelOfRichAnswer);
            this.panelAnswer.Controls.Add(this.label7);
            this.panelAnswer.Controls.Add(this.panelOfRichQuestion_2);
            this.panelAnswer.Controls.Add(this.label3);
            this.panelAnswer.Location = new System.Drawing.Point(722, 38);
            this.panelAnswer.Name = "panelAnswer";
            this.panelAnswer.Size = new System.Drawing.Size(355, 513);
            this.panelAnswer.TabIndex = 2;
            // 
            // panelOfRichAnswer
            // 
            this.panelOfRichAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelOfRichAnswer.BorderColor = System.Drawing.Color.White;
            this.panelOfRichAnswer.Controls.Add(this.richAnswer);
            this.panelOfRichAnswer.Location = new System.Drawing.Point(12, 216);
            this.panelOfRichAnswer.Name = "panelOfRichAnswer";
            this.panelOfRichAnswer.Radius = 20;
            this.panelOfRichAnswer.Size = new System.Drawing.Size(330, 271);
            this.panelOfRichAnswer.TabIndex = 15;
            this.panelOfRichAnswer.Thickness = 5F;
            // 
            // richAnswer
            // 
            this.richAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richAnswer.Location = new System.Drawing.Point(10, 12);
            this.richAnswer.MaxLength = 500;
            this.richAnswer.Name = "richAnswer";
            this.richAnswer.Size = new System.Drawing.Size(309, 246);
            this.richAnswer.TabIndex = 0;
            this.richAnswer.Text = resources.GetString("richAnswer.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(9, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Answer";
            // 
            // panelOfRichQuestion_2
            // 
            this.panelOfRichQuestion_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelOfRichQuestion_2.BorderColor = System.Drawing.Color.White;
            this.panelOfRichQuestion_2.Controls.Add(this.richQuestion_2);
            this.panelOfRichQuestion_2.Location = new System.Drawing.Point(12, 27);
            this.panelOfRichQuestion_2.Name = "panelOfRichQuestion_2";
            this.panelOfRichQuestion_2.Radius = 20;
            this.panelOfRichQuestion_2.Size = new System.Drawing.Size(330, 167);
            this.panelOfRichQuestion_2.TabIndex = 15;
            this.panelOfRichQuestion_2.Thickness = 5F;
            // 
            // richQuestion_2
            // 
            this.richQuestion_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richQuestion_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richQuestion_2.Location = new System.Drawing.Point(10, 13);
            this.richQuestion_2.MaxLength = 500;
            this.richQuestion_2.Name = "richQuestion_2";
            this.richQuestion_2.Size = new System.Drawing.Size(309, 141);
            this.richQuestion_2.TabIndex = 0;
            this.richQuestion_2.Text = resources.GetString("richQuestion_2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(9, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Your question";
            // 
            // panelGlobal
            // 
            this.panelGlobal.Controls.Add(this.label6);
            this.panelGlobal.Location = new System.Drawing.Point(1083, 38);
            this.panelGlobal.Name = "panelGlobal";
            this.panelGlobal.Size = new System.Drawing.Size(355, 513);
            this.panelGlobal.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(37, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "global";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btAskPanel);
            this.flowLayoutPanel1.Controls.Add(this.btAnswer);
            this.flowLayoutPanel1.Controls.Add(this.btPeople);
            this.flowLayoutPanel1.Controls.Add(this.btPrevious);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(339, 35);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btAskPanel
            // 
            this.btAskPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btAskPanel.BorderColor = System.Drawing.Color.White;
            this.btAskPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAskPanel.ForeColor = System.Drawing.Color.White;
            this.btAskPanel.Location = new System.Drawing.Point(3, 0);
            this.btAskPanel.Name = "btAskPanel";
            this.btAskPanel.Radius = 20;
            this.btAskPanel.Size = new System.Drawing.Size(57, 34);
            this.btAskPanel.TabIndex = 20;
            this.btAskPanel.Text = "Ask";
            this.btAskPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btAskPanel.Thickness = 5F;
            this.btAskPanel.Visible = false;
            this.btAskPanel.Click += new System.EventHandler(this.btAskPanel_Click);
            this.btAskPanel.MouseEnter += new System.EventHandler(this.btAskPanel_MouseEnter);
            this.btAskPanel.MouseLeave += new System.EventHandler(this.btAskPanel_MouseLeave);
            // 
            // btAnswer
            // 
            this.btAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btAnswer.BorderColor = System.Drawing.Color.White;
            this.btAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnswer.ForeColor = System.Drawing.Color.White;
            this.btAnswer.Location = new System.Drawing.Point(66, 0);
            this.btAnswer.Name = "btAnswer";
            this.btAnswer.Radius = 20;
            this.btAnswer.Size = new System.Drawing.Size(73, 34);
            this.btAnswer.TabIndex = 19;
            this.btAnswer.Text = "Answer";
            this.btAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btAnswer.Thickness = 5F;
            this.btAnswer.Click += new System.EventHandler(this.btRecent_Click);
            this.btAnswer.MouseEnter += new System.EventHandler(this.btAskPanel_MouseEnter);
            this.btAnswer.MouseLeave += new System.EventHandler(this.btAskPanel_MouseLeave);
            // 
            // btPeople
            // 
            this.btPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btPeople.BorderColor = System.Drawing.Color.White;
            this.btPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPeople.Enabled = false;
            this.btPeople.ForeColor = System.Drawing.Color.White;
            this.btPeople.Location = new System.Drawing.Point(145, 0);
            this.btPeople.Name = "btPeople";
            this.btPeople.Radius = 20;
            this.btPeople.Size = new System.Drawing.Size(73, 34);
            this.btPeople.TabIndex = 18;
            this.btPeople.Text = "People";
            this.btPeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btPeople.Thickness = 5F;
            this.btPeople.MouseEnter += new System.EventHandler(this.btAskPanel_MouseEnter);
            this.btPeople.MouseLeave += new System.EventHandler(this.btAskPanel_MouseLeave);
            // 
            // btPrevious
            // 
            this.btPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btPrevious.BorderColor = System.Drawing.Color.White;
            this.btPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPrevious.Enabled = false;
            this.btPrevious.ForeColor = System.Drawing.Color.White;
            this.btPrevious.Location = new System.Drawing.Point(224, 0);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Radius = 20;
            this.btPrevious.Size = new System.Drawing.Size(85, 34);
            this.btPrevious.TabIndex = 17;
            this.btPrevious.Text = "Previous";
            this.btPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btPrevious.Thickness = 5F;
            this.btPrevious.MouseEnter += new System.EventHandler(this.btAskPanel_MouseEnter);
            this.btPrevious.MouseLeave += new System.EventHandler(this.btAskPanel_MouseLeave);
            // 
            // yawa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1448, 551);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelGlobal);
            this.Controls.Add(this.panelAnswer);
            this.Controls.Add(this.panelPrevious);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(371, 590);
            this.Name = "yawa";
            this.Text = "Yawa";
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
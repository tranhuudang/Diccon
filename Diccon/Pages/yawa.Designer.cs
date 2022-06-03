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
            this.panelOfRichQuestion = new Diccon.RoundedPanel();
            this.richQuestion = new System.Windows.Forms.RichTextBox();
            this.notice = new System.Windows.Forms.Label();
            this.countWord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAsk = new Diccon.RoundedLabel();
            this.btHistory = new FontAwesome.Sharp.IconPictureBox();
            this.panelPrevious = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAnswer = new System.Windows.Forms.Panel();
            this.roundedPanel2 = new Diccon.RoundedPanel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new Diccon.RoundedPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelGlobal = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btPrevious = new Diccon.RoundedLabel();
            this.btPeople = new Diccon.RoundedLabel();
            this.btRecent = new Diccon.RoundedLabel();
            this.panelMain.SuspendLayout();
            this.panelOfRichQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btHistory)).BeginInit();
            this.panelPrevious.SuspendLayout();
            this.panelAnswer.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.panelGlobal.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.btInstantAsk);
            this.panelMain.Controls.Add(this.panelOfRichQuestion);
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
            // panelOfRichQuestion
            // 
            this.panelOfRichQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelOfRichQuestion.BorderColor = System.Drawing.Color.White;
            this.panelOfRichQuestion.Controls.Add(this.richQuestion);
            this.panelOfRichQuestion.Location = new System.Drawing.Point(12, 119);
            this.panelOfRichQuestion.Name = "panelOfRichQuestion";
            this.panelOfRichQuestion.Radius = 20;
            this.panelOfRichQuestion.Size = new System.Drawing.Size(330, 216);
            this.panelOfRichQuestion.TabIndex = 13;
            this.panelOfRichQuestion.Thickness = 5F;
            // 
            // richQuestion
            // 
            this.richQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richQuestion.Location = new System.Drawing.Point(10, 12);
            this.richQuestion.MaxLength = 500;
            this.richQuestion.Name = "richQuestion";
            this.richQuestion.Size = new System.Drawing.Size(309, 190);
            this.richQuestion.TabIndex = 0;
            this.richQuestion.Text = resources.GetString("richQuestion.Text");
            this.richQuestion.TextChanged += new System.EventHandler(this.richQuestion_TextChanged);
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
            // btHistory
            // 
            this.btHistory.BackColor = System.Drawing.Color.White;
            this.btHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHistory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btHistory.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btHistory.IconColor = System.Drawing.SystemColors.ControlText;
            this.btHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btHistory.IconSize = 28;
            this.btHistory.Location = new System.Drawing.Point(3, 3);
            this.btHistory.Name = "btHistory";
            this.btHistory.Size = new System.Drawing.Size(28, 28);
            this.btHistory.TabIndex = 14;
            this.btHistory.TabStop = false;
            this.btHistory.UseGdi = true;
            this.btHistory.MouseEnter += new System.EventHandler(this.btGlobal_MouseEnter);
            this.btHistory.MouseLeave += new System.EventHandler(this.btGlobal_MouseLeave);
            // 
            // panelPrevious
            // 
            this.panelPrevious.Controls.Add(this.label2);
            this.panelPrevious.Location = new System.Drawing.Point(361, 1);
            this.panelPrevious.Name = "panelPrevious";
            this.panelPrevious.Size = new System.Drawing.Size(355, 550);
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
            this.panelAnswer.Controls.Add(this.roundedPanel2);
            this.panelAnswer.Controls.Add(this.label7);
            this.panelAnswer.Controls.Add(this.roundedPanel1);
            this.panelAnswer.Controls.Add(this.label3);
            this.panelAnswer.Location = new System.Drawing.Point(722, 1);
            this.panelAnswer.Name = "panelAnswer";
            this.panelAnswer.Size = new System.Drawing.Size(355, 550);
            this.panelAnswer.TabIndex = 2;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roundedPanel2.BorderColor = System.Drawing.Color.White;
            this.roundedPanel2.Controls.Add(this.richTextBox2);
            this.roundedPanel2.Location = new System.Drawing.Point(14, 267);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Radius = 20;
            this.roundedPanel2.Size = new System.Drawing.Size(330, 271);
            this.roundedPanel2.TabIndex = 15;
            this.roundedPanel2.Thickness = 5F;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(10, 12);
            this.richTextBox2.MaxLength = 500;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(309, 246);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(11, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Answer";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.richTextBox1);
            this.roundedPanel1.Location = new System.Drawing.Point(14, 29);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 20;
            this.roundedPanel1.Size = new System.Drawing.Size(330, 216);
            this.roundedPanel1.TabIndex = 15;
            this.roundedPanel1.Thickness = 5F;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(10, 12);
            this.richTextBox1.MaxLength = 500;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(309, 190);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(11, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Your question";
            // 
            // panelGlobal
            // 
            this.panelGlobal.Controls.Add(this.label6);
            this.panelGlobal.Location = new System.Drawing.Point(1083, 1);
            this.panelGlobal.Name = "panelGlobal";
            this.panelGlobal.Size = new System.Drawing.Size(355, 550);
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
            this.flowLayoutPanel1.Controls.Add(this.btHistory);
            this.flowLayoutPanel1.Controls.Add(this.btPrevious);
            this.flowLayoutPanel1.Controls.Add(this.btPeople);
            this.flowLayoutPanel1.Controls.Add(this.btRecent);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(339, 35);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btPrevious
            // 
            this.btPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btPrevious.BorderColor = System.Drawing.Color.White;
            this.btPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPrevious.Location = new System.Drawing.Point(37, 0);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Radius = 20;
            this.btPrevious.Size = new System.Drawing.Size(85, 34);
            this.btPrevious.TabIndex = 17;
            this.btPrevious.Text = "Previous";
            this.btPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btPrevious.Thickness = 5F;
            this.btPrevious.MouseEnter += new System.EventHandler(this.btRecent_MouseEnter);
            this.btPrevious.MouseLeave += new System.EventHandler(this.btRecent_MouseLeave);
            // 
            // btPeople
            // 
            this.btPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btPeople.BorderColor = System.Drawing.Color.White;
            this.btPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPeople.Location = new System.Drawing.Point(128, 0);
            this.btPeople.Name = "btPeople";
            this.btPeople.Radius = 20;
            this.btPeople.Size = new System.Drawing.Size(82, 34);
            this.btPeople.TabIndex = 18;
            this.btPeople.Text = "People";
            this.btPeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btPeople.Thickness = 5F;
            this.btPeople.MouseEnter += new System.EventHandler(this.btRecent_MouseEnter);
            this.btPeople.MouseLeave += new System.EventHandler(this.btRecent_MouseLeave);
            // 
            // btRecent
            // 
            this.btRecent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btRecent.BorderColor = System.Drawing.Color.White;
            this.btRecent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRecent.Location = new System.Drawing.Point(216, 0);
            this.btRecent.Name = "btRecent";
            this.btRecent.Radius = 20;
            this.btRecent.Size = new System.Drawing.Size(73, 34);
            this.btRecent.TabIndex = 19;
            this.btRecent.Text = "Recent";
            this.btRecent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btRecent.Thickness = 5F;
            this.btRecent.MouseEnter += new System.EventHandler(this.btRecent_MouseEnter);
            this.btRecent.MouseLeave += new System.EventHandler(this.btRecent_MouseLeave);
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
            this.panelOfRichQuestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btHistory)).EndInit();
            this.panelPrevious.ResumeLayout(false);
            this.panelAnswer.ResumeLayout(false);
            this.panelAnswer.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.panelGlobal.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.RichTextBox richQuestion;
        private System.Windows.Forms.Panel panelPrevious;
        private RoundedLabel btAsk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAnswer;
        private System.Windows.Forms.Label notice;
        private System.Windows.Forms.Label countWord;
        private System.Windows.Forms.Timer timer1;
        private RoundedPanel panelOfRichQuestion;
        private FontAwesome.Sharp.IconPictureBox btHistory;
        private RoundedLabel btInstantAsk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelGlobal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label7;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RoundedLabel btPrevious;
        private RoundedLabel btPeople;
        private RoundedLabel btRecent;
    }
}
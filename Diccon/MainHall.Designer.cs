namespace Diccon
{
    partial class mainHall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainHall));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.sent = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowChatBox = new System.Windows.Forms.FlowLayoutPanel();
            this.exampleShortPanel = new System.Windows.Forms.Panel();
            this.exampleShortText = new System.Windows.Forms.Label();
            this.exampleAnswerPanel = new System.Windows.Forms.Panel();
            this.exampleAnswerColoredPanel = new System.Windows.Forms.Panel();
            this.exampleAnswerText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exampleAskLongPanel = new System.Windows.Forms.Panel();
            this.exampleAskLongColoredPanel = new System.Windows.Forms.Panel();
            this.exampleAskLongText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowChatBox.SuspendLayout();
            this.exampleShortPanel.SuspendLayout();
            this.exampleAnswerPanel.SuspendLayout();
            this.exampleAnswerColoredPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.exampleAskLongPanel.SuspendLayout();
            this.exampleAskLongColoredPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(9, 27);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(208, 20);
            this.searchBox.TabIndex = 1;
            // 
            // sent
            // 
            this.sent.Location = new System.Drawing.Point(223, 27);
            this.sent.Name = "sent";
            this.sent.Size = new System.Drawing.Size(48, 23);
            this.sent.TabIndex = 2;
            this.sent.Text = "Send";
            this.sent.UseVisualStyleBackColor = true;
            this.sent.Click += new System.EventHandler(this.sent_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.pictureBox1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(407, 70);
            this.panel9.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(73, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Diccon";
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(277, 27);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(64, 23);
            this.answer.TabIndex = 2;
            this.answer.Text = "answer";
            this.answer.UseVisualStyleBackColor = true;
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.answer);
            this.panel1.Controls.Add(this.sent);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 652);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 63);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 5);
            this.panel2.TabIndex = 7;
            // 
            // flowChatBox
            // 
            this.flowChatBox.AutoScroll = true;
            this.flowChatBox.Controls.Add(this.exampleShortPanel);
            this.flowChatBox.Controls.Add(this.exampleAskLongPanel);
            this.flowChatBox.Controls.Add(this.panel3);
            this.flowChatBox.Controls.Add(this.exampleAnswerPanel);
            this.flowChatBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowChatBox.Location = new System.Drawing.Point(0, 75);
            this.flowChatBox.Name = "flowChatBox";
            this.flowChatBox.Padding = new System.Windows.Forms.Padding(5);
            this.flowChatBox.Size = new System.Drawing.Size(407, 577);
            this.flowChatBox.TabIndex = 8;
            // 
            // exampleShortPanel
            // 
            this.exampleShortPanel.Controls.Add(this.exampleShortText);
            this.exampleShortPanel.Location = new System.Drawing.Point(8, 8);
            this.exampleShortPanel.Name = "exampleShortPanel";
            this.exampleShortPanel.Size = new System.Drawing.Size(367, 46);
            this.exampleShortPanel.TabIndex = 0;
            // 
            // exampleShortText
            // 
            this.exampleShortText.BackColor = System.Drawing.Color.Silver;
            this.exampleShortText.Dock = System.Windows.Forms.DockStyle.Left;
            this.exampleShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleShortText.ForeColor = System.Drawing.Color.Black;
            this.exampleShortText.Location = new System.Drawing.Point(0, 0);
            this.exampleShortText.Name = "exampleShortText";
            this.exampleShortText.Size = new System.Drawing.Size(103, 46);
            this.exampleShortText.TabIndex = 0;
            this.exampleShortText.Text = "Prevent";
            this.exampleShortText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exampleAnswerPanel
            // 
            this.exampleAnswerPanel.Controls.Add(this.exampleAnswerColoredPanel);
            this.exampleAnswerPanel.Location = new System.Drawing.Point(8, 256);
            this.exampleAnswerPanel.Name = "exampleAnswerPanel";
            this.exampleAnswerPanel.Size = new System.Drawing.Size(367, 145);
            this.exampleAnswerPanel.TabIndex = 1;
            // 
            // exampleAnswerColoredPanel
            // 
            this.exampleAnswerColoredPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.exampleAnswerColoredPanel.Controls.Add(this.exampleAnswerText);
            this.exampleAnswerColoredPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.exampleAnswerColoredPanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exampleAnswerColoredPanel.Location = new System.Drawing.Point(67, 0);
            this.exampleAnswerColoredPanel.Name = "exampleAnswerColoredPanel";
            this.exampleAnswerColoredPanel.Size = new System.Drawing.Size(300, 145);
            this.exampleAnswerColoredPanel.TabIndex = 1;
            // 
            // exampleAnswerText
            // 
            this.exampleAnswerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleAnswerText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exampleAnswerText.Location = new System.Drawing.Point(3, 11);
            this.exampleAnswerText.Name = "exampleAnswerText";
            this.exampleAnswerText.Size = new System.Drawing.Size(277, 122);
            this.exampleAnswerText.TabIndex = 0;
            this.exampleAnswerText.Text = resources.GetString("exampleAnswerText.Text");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(8, 211);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 39);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(67, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 39);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Diccon.Properties.Resources.volume_24;
            this.pictureBox3.Location = new System.Drawing.Point(184, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diccon.Properties.Resources.ninja_64;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(360, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Diccon.Properties.Resources.volume_24;
            this.pictureBox4.Location = new System.Drawing.Point(252, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(215, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "UK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "US";
            // 
            // exampleAskLongPanel
            // 
            this.exampleAskLongPanel.Controls.Add(this.exampleAskLongColoredPanel);
            this.exampleAskLongPanel.Location = new System.Drawing.Point(8, 60);
            this.exampleAskLongPanel.Name = "exampleAskLongPanel";
            this.exampleAskLongPanel.Size = new System.Drawing.Size(367, 145);
            this.exampleAskLongPanel.TabIndex = 3;
            // 
            // exampleAskLongColoredPanel
            // 
            this.exampleAskLongColoredPanel.BackColor = System.Drawing.Color.Silver;
            this.exampleAskLongColoredPanel.Controls.Add(this.exampleAskLongText);
            this.exampleAskLongColoredPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.exampleAskLongColoredPanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exampleAskLongColoredPanel.Location = new System.Drawing.Point(0, 0);
            this.exampleAskLongColoredPanel.Name = "exampleAskLongColoredPanel";
            this.exampleAskLongColoredPanel.Size = new System.Drawing.Size(300, 145);
            this.exampleAskLongColoredPanel.TabIndex = 1;
            // 
            // exampleAskLongText
            // 
            this.exampleAskLongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleAskLongText.ForeColor = System.Drawing.Color.Black;
            this.exampleAskLongText.Location = new System.Drawing.Point(3, 11);
            this.exampleAskLongText.Name = "exampleAskLongText";
            this.exampleAskLongText.Size = new System.Drawing.Size(277, 122);
            this.exampleAskLongText.TabIndex = 0;
            this.exampleAskLongText.Text = resources.GetString("exampleAskLongText.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send long";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(407, 715);
            this.Controls.Add(this.flowChatBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Name = "mainHall";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.mainHall_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowChatBox.ResumeLayout(false);
            this.exampleShortPanel.ResumeLayout(false);
            this.exampleAnswerPanel.ResumeLayout(false);
            this.exampleAnswerColoredPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.exampleAskLongPanel.ResumeLayout(false);
            this.exampleAskLongColoredPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button sent;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button answer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.FlowLayoutPanel flowChatBox;
        private System.Windows.Forms.Panel exampleShortPanel;
        private System.Windows.Forms.Label exampleShortText;
        private System.Windows.Forms.Panel exampleAnswerPanel;
        private System.Windows.Forms.Panel exampleAnswerColoredPanel;
        private System.Windows.Forms.Label exampleAnswerText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel exampleAskLongPanel;
        private System.Windows.Forms.Panel exampleAskLongColoredPanel;
        private System.Windows.Forms.Label exampleAskLongText;
        private System.Windows.Forms.Button button1;
    }
}


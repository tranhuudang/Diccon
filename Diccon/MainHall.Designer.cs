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
            this.flowChatBox = new System.Windows.Forms.FlowLayoutPanel();
            this.examplePanel = new System.Windows.Forms.Panel();
            this.exampleText = new System.Windows.Forms.Label();
            this.exampleAnswerPanel = new System.Windows.Forms.Panel();
            this.exampleAnswerColoredPanel = new System.Windows.Forms.Panel();
            this.exampleAnswerText = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.sent = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.answer = new System.Windows.Forms.Button();
            this.flowChatBox.SuspendLayout();
            this.examplePanel.SuspendLayout();
            this.exampleAnswerPanel.SuspendLayout();
            this.exampleAnswerColoredPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowChatBox
            // 
            this.flowChatBox.AutoScroll = true;
            this.flowChatBox.Controls.Add(this.examplePanel);
            this.flowChatBox.Controls.Add(this.exampleAnswerPanel);
            this.flowChatBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowChatBox.Location = new System.Drawing.Point(12, 76);
            this.flowChatBox.Name = "flowChatBox";
            this.flowChatBox.Size = new System.Drawing.Size(383, 586);
            this.flowChatBox.TabIndex = 0;
            // 
            // examplePanel
            // 
            this.examplePanel.Controls.Add(this.exampleText);
            this.examplePanel.Location = new System.Drawing.Point(3, 3);
            this.examplePanel.Name = "examplePanel";
            this.examplePanel.Size = new System.Drawing.Size(377, 46);
            this.examplePanel.TabIndex = 0;
            // 
            // exampleText
            // 
            this.exampleText.BackColor = System.Drawing.Color.Silver;
            this.exampleText.Dock = System.Windows.Forms.DockStyle.Left;
            this.exampleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleText.ForeColor = System.Drawing.Color.Black;
            this.exampleText.Location = new System.Drawing.Point(0, 0);
            this.exampleText.Name = "exampleText";
            this.exampleText.Size = new System.Drawing.Size(103, 46);
            this.exampleText.TabIndex = 0;
            this.exampleText.Text = "Prevent";
            this.exampleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exampleAnswerPanel
            // 
            this.exampleAnswerPanel.Controls.Add(this.exampleAnswerColoredPanel);
            this.exampleAnswerPanel.Location = new System.Drawing.Point(3, 55);
            this.exampleAnswerPanel.Name = "exampleAnswerPanel";
            this.exampleAnswerPanel.Size = new System.Drawing.Size(377, 145);
            this.exampleAnswerPanel.TabIndex = 1;
            // 
            // exampleAnswerColoredPanel
            // 
            this.exampleAnswerColoredPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.exampleAnswerColoredPanel.Controls.Add(this.exampleAnswerText);
            this.exampleAnswerColoredPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.exampleAnswerColoredPanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exampleAnswerColoredPanel.Location = new System.Drawing.Point(77, 0);
            this.exampleAnswerColoredPanel.Name = "exampleAnswerColoredPanel";
            this.exampleAnswerColoredPanel.Size = new System.Drawing.Size(300, 145);
            this.exampleAnswerColoredPanel.TabIndex = 1;
            // 
            // exampleAnswerText
            // 
            this.exampleAnswerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleAnswerText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exampleAnswerText.Location = new System.Drawing.Point(10, 10);
            this.exampleAnswerText.Name = "exampleAnswerText";
            this.exampleAnswerText.Size = new System.Drawing.Size(276, 119);
            this.exampleAnswerText.TabIndex = 0;
            this.exampleAnswerText.Text = resources.GetString("exampleAnswerText.Text");
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 682);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(208, 20);
            this.searchBox.TabIndex = 1;
            // 
            // sent
            // 
            this.sent.Location = new System.Drawing.Point(226, 682);
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
            this.pictureBox2.Location = new System.Drawing.Point(363, 671);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(280, 682);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(64, 23);
            this.answer.TabIndex = 2;
            this.answer.Text = "answer";
            this.answer.UseVisualStyleBackColor = true;
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // mainHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(407, 715);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.sent);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.flowChatBox);
            this.Name = "mainHall";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.mainHall_Load);
            this.flowChatBox.ResumeLayout(false);
            this.examplePanel.ResumeLayout(false);
            this.exampleAnswerPanel.ResumeLayout(false);
            this.exampleAnswerColoredPanel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowChatBox;
        private System.Windows.Forms.Panel examplePanel;
        private System.Windows.Forms.Label exampleText;
        private System.Windows.Forms.Panel exampleAnswerPanel;
        private System.Windows.Forms.Label exampleAnswerText;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button sent;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel exampleAnswerColoredPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button answer;
    }
}


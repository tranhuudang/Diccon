namespace Diccon
{
    partial class about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gitHubLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.downloadPercent = new System.Windows.Forms.ProgressBar();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btUpdates = new Diccon.RoundedLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Github:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Author:";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(126, 230);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(50, 13);
            this.lbVersion.TabIndex = 0;
            this.lbVersion.Text = "lbVersion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tran Huu Dang";
            // 
            // gitHubLink
            // 
            this.gitHubLink.AutoSize = true;
            this.gitHubLink.Location = new System.Drawing.Point(126, 251);
            this.gitHubLink.Name = "gitHubLink";
            this.gitHubLink.Size = new System.Drawing.Size(98, 13);
            this.gitHubLink.TabIndex = 2;
            this.gitHubLink.TabStop = true;
            this.gitHubLink.Text = "zeroclubvn\\Diccon";
            this.gitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitHubLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diccon.Properties.Resources.ninja_128;
            this.pictureBox1.Location = new System.Drawing.Point(141, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "Diccon";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "tranhuudang127@gmail.com";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(12, 498);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label8.Size = new System.Drawing.Size(383, 63);
            this.label8.TabIndex = 4;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // downloadPercent
            // 
            this.downloadPercent.Location = new System.Drawing.Point(138, 4);
            this.downloadPercent.Name = "downloadPercent";
            this.downloadPercent.Size = new System.Drawing.Size(103, 23);
            this.downloadPercent.TabIndex = 6;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.label9);
            this.panelUpdate.Controls.Add(this.downloadPercent);
            this.panelUpdate.Location = new System.Drawing.Point(15, 381);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(379, 82);
            this.panelUpdate.TabIndex = 7;
            this.panelUpdate.Visible = false;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(5, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(371, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "Downloading..";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btUpdates
            // 
            this.btUpdates.AutoSize = true;
            this.btUpdates.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btUpdates.BorderColor = System.Drawing.Color.White;
            this.btUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdates.ForeColor = System.Drawing.Color.White;
            this.btUpdates.Location = new System.Drawing.Point(125, 328);
            this.btUpdates.Name = "btUpdates";
            this.btUpdates.Padding = new System.Windows.Forms.Padding(7);
            this.btUpdates.Radius = 20;
            this.btUpdates.Size = new System.Drawing.Size(156, 34);
            this.btUpdates.TabIndex = 8;
            this.btUpdates.Text = "Check for Updates";
            this.btUpdates.Thickness = 5F;
            this.btUpdates.Click += new System.EventHandler(this.btUpdates_Click);
            this.btUpdates.MouseEnter += new System.EventHandler(this.btUpdates_MouseEnter);
            this.btUpdates.MouseLeave += new System.EventHandler(this.btUpdates_MouseLeave);
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 570);
            this.Controls.Add(this.btUpdates);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gitHubLink);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "about";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.about_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUpdate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel gitHubLink;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar downloadPercent;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Label label9;
        private RoundedLabel btUpdates;
    }
}
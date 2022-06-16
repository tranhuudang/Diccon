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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lbVersion
            // 
            resources.ApplyResources(this.lbVersion, "lbVersion");
            this.lbVersion.Name = "lbVersion";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // gitHubLink
            // 
            resources.ApplyResources(this.gitHubLink, "gitHubLink");
            this.gitHubLink.Name = "gitHubLink";
            this.gitHubLink.TabStop = true;
            this.gitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitHubLink_LinkClicked);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Diccon.Properties.Resources.diccon_128;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Name = "label8";
            // 
            // downloadPercent
            // 
            resources.ApplyResources(this.downloadPercent, "downloadPercent");
            this.downloadPercent.Name = "downloadPercent";
            // 
            // panelUpdate
            // 
            resources.ApplyResources(this.panelUpdate, "panelUpdate");
            this.panelUpdate.Controls.Add(this.label9);
            this.panelUpdate.Controls.Add(this.downloadPercent);
            this.panelUpdate.Name = "panelUpdate";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // btUpdates
            // 
            resources.ApplyResources(this.btUpdates, "btUpdates");
            this.btUpdates.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btUpdates.BorderColor = System.Drawing.Color.White;
            this.btUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdates.ForeColor = System.Drawing.Color.Black;
            this.btUpdates.Name = "btUpdates";
            this.btUpdates.Radius = 20;
            this.btUpdates.Thickness = 5F;
            this.btUpdates.Click += new System.EventHandler(this.btUpdates_Click);
            this.btUpdates.MouseEnter += new System.EventHandler(this.btUpdates_MouseEnter);
            this.btUpdates.MouseLeave += new System.EventHandler(this.btUpdates_MouseLeave);
            // 
            // about
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
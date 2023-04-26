namespace Diccon
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.btDelete = new Diccon.RoundedLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btAutoBackup = new System.Windows.Forms.CheckBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            resources.ApplyResources(this.btDelete, "btDelete");
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btDelete.BorderColor = System.Drawing.Color.White;
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Name = "btDelete";
            this.btDelete.Radius = 20;
            this.btDelete.Thickness = 5F;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            this.btDelete.MouseEnter += new System.EventHandler(this.btDelete_MouseEnter);
            this.btDelete.MouseLeave += new System.EventHandler(this.btDelete_MouseLeave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btAutoBackup
            // 
            resources.ApplyResources(this.btAutoBackup, "btAutoBackup");
            this.btAutoBackup.Checked = true;
            this.btAutoBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btAutoBackup.Name = "btAutoBackup";
            this.btAutoBackup.UseVisualStyleBackColor = true;
            this.btAutoBackup.CheckedChanged += new System.EventHandler(this.btAutoBackup_CheckedChanged);
            // 
            // topPanel
            // 
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.topPanel.Controls.Add(this.title);
            this.topPanel.Controls.Add(this.logo);
            this.topPanel.Name = "topPanel";
            // 
            // title
            // 
            resources.ApplyResources(this.title, "title");
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Name = "title";
            // 
            // logo
            // 
            resources.ApplyResources(this.logo, "logo");
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.Image = global::Diccon.Properties.Resources.back_24;
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.btAutoBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDelete);
            this.Name = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedLabel btDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox btAutoBackup;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox logo;
    }
}
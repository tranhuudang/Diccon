namespace Diccon.Pages
{
    partial class donate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(donate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelQr = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btOpenQr = new Diccon.RoundedLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelQr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelQr);
            this.panel1.Controls.Add(this.btOpenQr);
            this.panel1.Name = "panel1";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::Diccon.Properties.Resources.donate_background;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panelQr
            // 
            resources.ApplyResources(this.panelQr, "panelQr");
            this.panelQr.Controls.Add(this.comboBox1);
            this.panelQr.Controls.Add(this.pictureBox1);
            this.panelQr.Name = "panelQr";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items")});
            this.comboBox1.Name = "comboBox1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Diccon.Properties.Resources.IMG_Sacombank_png;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btOpenQr
            // 
            resources.ApplyResources(this.btOpenQr, "btOpenQr");
            this.btOpenQr.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btOpenQr.BorderColor = System.Drawing.Color.White;
            this.btOpenQr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOpenQr.ForeColor = System.Drawing.Color.Black;
            this.btOpenQr.Name = "btOpenQr";
            this.btOpenQr.Radius = 20;
            this.btOpenQr.Thickness = 5F;
            this.btOpenQr.Click += new System.EventHandler(this.btOpenQr_Click);
            this.btOpenQr.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btOpenQr.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // donate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "donate";
            this.Load += new System.EventHandler(this.donate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelQr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RoundedLabel btOpenQr;
        private System.Windows.Forms.Panel panelQr;
    }
}
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
            this.btOpenQr = new Diccon.RoundedLabel();
            this.panelQr = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelQr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btOpenQr);
            this.panel1.Controls.Add(this.panelQr);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 635);
            this.panel1.TabIndex = 1;
            // 
            // btOpenQr
            // 
            this.btOpenQr.AutoSize = true;
            this.btOpenQr.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btOpenQr.BorderColor = System.Drawing.Color.White;
            this.btOpenQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenQr.ForeColor = System.Drawing.Color.White;
            this.btOpenQr.Location = new System.Drawing.Point(109, 382);
            this.btOpenQr.Name = "btOpenQr";
            this.btOpenQr.Padding = new System.Windows.Forms.Padding(7);
            this.btOpenQr.Radius = 20;
            this.btOpenQr.Size = new System.Drawing.Size(186, 34);
            this.btOpenQr.TabIndex = 5;
            this.btOpenQr.Text = "Buy me a cup of coffee";
            this.btOpenQr.Thickness = 5F;
            this.btOpenQr.Click += new System.EventHandler(this.btOpenQr_Click);
            this.btOpenQr.MouseEnter += new System.EventHandler(this.RoundedLabel_MouseEnter);
            this.btOpenQr.MouseLeave += new System.EventHandler(this.RoundedLabel_MouseLeave);
            // 
            // panelQr
            // 
            this.panelQr.Controls.Add(this.comboBox1);
            this.panelQr.Controls.Add(this.pictureBox1);
            this.panelQr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelQr.Location = new System.Drawing.Point(0, 368);
            this.panelQr.Name = "panelQr";
            this.panelQr.Size = new System.Drawing.Size(407, 267);
            this.panelQr.TabIndex = 4;
            this.panelQr.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Saccombank Pay"});
            this.comboBox1.Location = new System.Drawing.Point(274, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Saccombank Pay";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Diccon.Properties.Resources.IMG_Sacombank_png;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::Diccon.Properties.Resources.donate_background;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(407, 244);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 135);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // donate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 635);
            this.Controls.Add(this.panel1);
            this.Name = "donate";
            this.Text = "Donate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelQr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
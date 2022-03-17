namespace Diccon
{
    partial class timeLineItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbText = new System.Windows.Forms.Label();
            this.btPlay = new FontAwesome.Sharp.IconPictureBox();
            this.btCopy = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCopy)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(0, 0);
            this.lbText.Name = "lbText";
            this.lbText.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbText.Size = new System.Drawing.Size(310, 62);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "label1";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPlay.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btPlay.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btPlay.IconSize = 23;
            this.btPlay.Location = new System.Drawing.Point(60, 20);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(23, 23);
            this.btPlay.TabIndex = 1;
            this.btPlay.TabStop = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            this.btPlay.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.btPlay.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // btCopy
            // 
            this.btCopy.BackColor = System.Drawing.SystemColors.Control;
            this.btCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCopy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btCopy.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btCopy.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btCopy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCopy.IconSize = 23;
            this.btCopy.Location = new System.Drawing.Point(31, 20);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(23, 23);
            this.btCopy.TabIndex = 2;
            this.btCopy.TabStop = false;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            this.btCopy.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.btCopy.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCopy);
            this.panel1.Controls.Add(this.btPlay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(310, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 62);
            this.panel1.TabIndex = 3;
            // 
            // timeLineItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.panel1);
            this.Name = "timeLineItem";
            this.Size = new System.Drawing.Size(423, 62);
            ((System.ComponentModel.ISupportInitialize)(this.btPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCopy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private FontAwesome.Sharp.IconPictureBox btPlay;
        private FontAwesome.Sharp.IconPictureBox btCopy;
        private System.Windows.Forms.Panel panel1;
    }
}

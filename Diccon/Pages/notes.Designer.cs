namespace Diccon.Pages
{
    partial class notes
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
            this.flowPlayground = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btRefresh = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // flowPlayground
            // 
            this.flowPlayground.AutoScroll = true;
            this.flowPlayground.BackColor = System.Drawing.Color.White;
            this.flowPlayground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPlayground.Location = new System.Drawing.Point(0, 0);
            this.flowPlayground.Name = "flowPlayground";
            this.flowPlayground.Size = new System.Drawing.Size(407, 532);
            this.flowPlayground.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.btRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 38);
            this.panel1.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 27;
            this.iconPictureBox1.Location = new System.Drawing.Point(377, 6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(27, 27);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.White;
            this.btRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btRefresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btRefresh.IconColor = System.Drawing.SystemColors.ControlText;
            this.btRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRefresh.IconSize = 27;
            this.btRefresh.Location = new System.Drawing.Point(12, 6);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(27, 27);
            this.btRefresh.TabIndex = 0;
            this.btRefresh.TabStop = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 570);
            this.Controls.Add(this.flowPlayground);
            this.Controls.Add(this.panel1);
            this.Name = "notes";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.notes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPlayground;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox btRefresh;
    }
}
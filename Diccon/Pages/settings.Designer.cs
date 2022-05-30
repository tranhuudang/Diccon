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
            this.enableFlashClipboard = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enableFlashClipboard
            // 
            this.enableFlashClipboard.Checked = true;
            this.enableFlashClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableFlashClipboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.enableFlashClipboard.Location = new System.Drawing.Point(0, 0);
            this.enableFlashClipboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enableFlashClipboard.Name = "enableFlashClipboard";
            this.enableFlashClipboard.Size = new System.Drawing.Size(313, 29);
            this.enableFlashClipboard.TabIndex = 0;
            this.enableFlashClipboard.Text = "Enable Flash Clipboard";
            this.enableFlashClipboard.UseVisualStyleBackColor = true;
            this.enableFlashClipboard.CheckedChanged += new System.EventHandler(this.enableFlashClipboard_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.enableFlashClipboard);
            this.panel1.Location = new System.Drawing.Point(13, 298);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 78);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instantly look up the meaning of copied word in Clipboard";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 104);
            this.panel2.TabIndex = 2;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(355, 550);
            this.Name = "settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox enableFlashClipboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}
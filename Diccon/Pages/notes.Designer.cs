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
            this.SuspendLayout();
            // 
            // flowPlayground
            // 
            this.flowPlayground.AutoScroll = true;
            this.flowPlayground.BackColor = System.Drawing.Color.White;
            this.flowPlayground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPlayground.Location = new System.Drawing.Point(0, 0);
            this.flowPlayground.Name = "flowPlayground";
            this.flowPlayground.Size = new System.Drawing.Size(407, 570);
            this.flowPlayground.TabIndex = 0;
            // 
            // notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 570);
            this.Controls.Add(this.flowPlayground);
            this.Name = "notes";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.notes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPlayground;
    }
}
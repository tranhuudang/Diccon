namespace Diccon.Pages
{
    partial class UserLongMessage
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
            this.panelNotice = new Diccon.RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNotice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNotice
            // 
            this.panelNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNotice.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelNotice.BorderColor = System.Drawing.Color.White;
            this.panelNotice.Controls.Add(this.label1);
            this.panelNotice.Location = new System.Drawing.Point(51, 4);
            this.panelNotice.Name = "panelNotice";
            this.panelNotice.Radius = 20;
            this.panelNotice.Size = new System.Drawing.Size(271, 163);
            this.panelNotice.TabIndex = 1;
            this.panelNotice.Thickness = 5F;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 134);
            this.label1.TabIndex = 0;
            this.label1.Text = "If you think that we missing translation for a word. We recommend you to report i" +
    "t in this page bellow.";
            // 
            // UserLongMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelNotice);
            this.Name = "UserLongMessage";
            this.Size = new System.Drawing.Size(325, 170);
            this.Load += new System.EventHandler(this.UserLongMessage_Load);
            this.SizeChanged += new System.EventHandler(this.UserLongMessage_SizeChanged);
            this.panelNotice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel panelNotice;
        private System.Windows.Forms.Label label1;
    }
}

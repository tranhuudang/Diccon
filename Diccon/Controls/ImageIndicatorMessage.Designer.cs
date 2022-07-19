namespace Diccon.Pages
{
    partial class ImageIndicatorMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageIndicatorMessage));
            this.examplePixabayLogo = new System.Windows.Forms.PictureBox();
            this.exampleColoredPicturePanel = new Diccon.RoundedPanel();
            this.examplePictureBox = new Diccon.RoundedPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.examplePixabayLogo)).BeginInit();
            this.exampleColoredPicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examplePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // examplePixabayLogo
            // 
            this.examplePixabayLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.examplePixabayLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.examplePixabayLogo.Image = global::Diccon.Properties.Resources.pixabay_logo;
            this.examplePixabayLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.examplePixabayLogo.Location = new System.Drawing.Point(237, 253);
            this.examplePixabayLogo.Name = "examplePixabayLogo";
            this.examplePixabayLogo.Size = new System.Drawing.Size(70, 14);
            this.examplePixabayLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.examplePixabayLogo.TabIndex = 3;
            this.examplePixabayLogo.TabStop = false;
            // 
            // exampleColoredPicturePanel
            // 
            this.exampleColoredPicturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exampleColoredPicturePanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.exampleColoredPicturePanel.BorderColor = System.Drawing.Color.White;
            this.exampleColoredPicturePanel.Controls.Add(this.examplePictureBox);
            this.exampleColoredPicturePanel.Location = new System.Drawing.Point(3, 3);
            this.exampleColoredPicturePanel.Name = "exampleColoredPicturePanel";
            this.exampleColoredPicturePanel.Radius = 20;
            this.exampleColoredPicturePanel.Size = new System.Drawing.Size(313, 248);
            this.exampleColoredPicturePanel.TabIndex = 2;
            this.exampleColoredPicturePanel.Thickness = 5F;
            // 
            // examplePictureBox
            // 
            this.examplePictureBox.BackColor = System.Drawing.Color.White;
            this.examplePictureBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.examplePictureBox.ErrorImage = global::Diccon.Properties.Resources.doubtful;
            this.examplePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("examplePictureBox.Image")));
            this.examplePictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.examplePictureBox.InitialImage = global::Diccon.Properties.Resources.reluctant;
            this.examplePictureBox.Location = new System.Drawing.Point(5, 5);
            this.examplePictureBox.MaximumSize = new System.Drawing.Size(357, 238);
            this.examplePictureBox.Name = "examplePictureBox";
            this.examplePictureBox.Radius = 20;
            this.examplePictureBox.Size = new System.Drawing.Size(303, 238);
            this.examplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.examplePictureBox.TabIndex = 1;
            this.examplePictureBox.TabStop = false;
            this.examplePictureBox.Thickness = 5F;
            // 
            // ImageIndicatorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.examplePixabayLogo);
            this.Controls.Add(this.exampleColoredPicturePanel);
            this.Name = "ImageIndicatorMessage";
            this.Size = new System.Drawing.Size(319, 271);
            this.Load += new System.EventHandler(this.ImageIndicatorMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examplePixabayLogo)).EndInit();
            this.exampleColoredPicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examplePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox examplePixabayLogo;
        private RoundedPanel exampleColoredPicturePanel;
        private RoundedPictureBox examplePictureBox;
    }
}

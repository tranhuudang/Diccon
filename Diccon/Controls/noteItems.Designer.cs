namespace Diccon.Controls
{
    partial class noteItems
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
            this.roundedPanel1 = new Diccon.RoundedPanel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.richContent = new System.Windows.Forms.RichTextBox();
            this.btExpand = new FontAwesome.Sharp.IconPictureBox();
            this.btSave = new FontAwesome.Sharp.IconPictureBox();
            this.btClose = new FontAwesome.Sharp.IconPictureBox();
            this.btDelete = new FontAwesome.Sharp.IconPictureBox();
            this.btMenu = new FontAwesome.Sharp.IconPictureBox();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.btMenu);
            this.roundedPanel1.Controls.Add(this.btDelete);
            this.roundedPanel1.Controls.Add(this.btClose);
            this.roundedPanel1.Controls.Add(this.btSave);
            this.roundedPanel1.Controls.Add(this.btExpand);
            this.roundedPanel1.Controls.Add(this.tbTitle);
            this.roundedPanel1.Controls.Add(this.richContent);
            this.roundedPanel1.Location = new System.Drawing.Point(23, 4);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 20;
            this.roundedPanel1.Size = new System.Drawing.Size(350, 170);
            this.roundedPanel1.TabIndex = 0;
            this.roundedPanel1.Thickness = 5F;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.DimGray;
            this.tbTitle.Location = new System.Drawing.Point(99, 14);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(168, 15);
            this.tbTitle.TabIndex = 8;
            this.tbTitle.Text = "untitled";
            this.tbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richContent
            // 
            this.richContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.richContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richContent.Location = new System.Drawing.Point(8, 40);
            this.richContent.Name = "richContent";
            this.richContent.Size = new System.Drawing.Size(333, 119);
            this.richContent.TabIndex = 4;
            this.richContent.Text = "";
            // 
            // btExpand
            // 
            this.btExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btExpand.ForeColor = System.Drawing.Color.DimGray;
            this.btExpand.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btExpand.IconColor = System.Drawing.Color.DimGray;
            this.btExpand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btExpand.IconSize = 24;
            this.btExpand.Location = new System.Drawing.Point(287, 10);
            this.btExpand.Name = "btExpand";
            this.btExpand.Size = new System.Drawing.Size(24, 24);
            this.btExpand.TabIndex = 10;
            this.btExpand.TabStop = false;
            this.btExpand.Visible = false;
            this.btExpand.Click += new System.EventHandler(this.btExpand_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btSave.ForeColor = System.Drawing.Color.DimGray;
            this.btSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btSave.IconColor = System.Drawing.Color.DimGray;
            this.btSave.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btSave.IconSize = 24;
            this.btSave.Location = new System.Drawing.Point(38, 10);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(24, 24);
            this.btSave.TabIndex = 11;
            this.btSave.TabStop = false;
            this.btSave.Visible = false;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btClose.ForeColor = System.Drawing.Color.DimGray;
            this.btClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btClose.IconColor = System.Drawing.Color.DimGray;
            this.btClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btClose.IconSize = 24;
            this.btClose.Location = new System.Drawing.Point(317, 10);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(24, 24);
            this.btClose.TabIndex = 11;
            this.btClose.TabStop = false;
            this.btClose.Visible = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btDelete.ForeColor = System.Drawing.Color.DimGray;
            this.btDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btDelete.IconColor = System.Drawing.Color.DimGray;
            this.btDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btDelete.IconSize = 24;
            this.btDelete.Location = new System.Drawing.Point(68, 10);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(24, 24);
            this.btDelete.TabIndex = 11;
            this.btDelete.TabStop = false;
            this.btDelete.Visible = false;
            // 
            // btMenu
            // 
            this.btMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btMenu.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.btMenu.IconColor = System.Drawing.SystemColors.ControlText;
            this.btMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btMenu.IconSize = 24;
            this.btMenu.Location = new System.Drawing.Point(8, 10);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(24, 24);
            this.btMenu.TabIndex = 12;
            this.btMenu.TabStop = false;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // noteItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedPanel1);
            this.Name = "noteItems";
            this.Size = new System.Drawing.Size(373, 179);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private FontAwesome.Sharp.IconPictureBox btDelete;
        private FontAwesome.Sharp.IconPictureBox btClose;
        private FontAwesome.Sharp.IconPictureBox btSave;
        private FontAwesome.Sharp.IconPictureBox btExpand;
        private FontAwesome.Sharp.IconPictureBox btMenu;
        public System.Windows.Forms.TextBox tbTitle;
        public System.Windows.Forms.RichTextBox richContent;
    }
}

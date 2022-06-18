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
            this.btMenu = new FontAwesome.Sharp.IconPictureBox();
            this.btDelete = new FontAwesome.Sharp.IconPictureBox();
            this.btSave = new FontAwesome.Sharp.IconPictureBox();
            this.btExpand = new FontAwesome.Sharp.IconPictureBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.richContent = new System.Windows.Forms.RichTextBox();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btExpand)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.btMenu);
            this.roundedPanel1.Controls.Add(this.btDelete);
            this.roundedPanel1.Controls.Add(this.btSave);
            this.roundedPanel1.Controls.Add(this.btExpand);
            this.roundedPanel1.Controls.Add(this.tbTitle);
            this.roundedPanel1.Controls.Add(this.richContent);
            this.roundedPanel1.Location = new System.Drawing.Point(7, 4);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 20;
            this.roundedPanel1.Size = new System.Drawing.Size(322, 170);
            this.roundedPanel1.TabIndex = 0;
            this.roundedPanel1.Thickness = 5F;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // btMenu
            // 
            this.btMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMenu.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
            this.btMenu.IconColor = System.Drawing.Color.White;
            this.btMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btMenu.IconSize = 24;
            this.btMenu.Location = new System.Drawing.Point(289, 12);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(24, 24);
            this.btMenu.TabIndex = 12;
            this.btMenu.TabStop = false;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            this.btMenu.MouseEnter += new System.EventHandler(this.btMenu_MouseEnter);
            this.btMenu.MouseLeave += new System.EventHandler(this.btMenu_MouseLeave);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btDelete.IconColor = System.Drawing.Color.White;
            this.btDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btDelete.IconSize = 24;
            this.btDelete.Location = new System.Drawing.Point(17, 12);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(24, 24);
            this.btDelete.TabIndex = 11;
            this.btDelete.TabStop = false;
            this.btDelete.Visible = false;
            this.btDelete.MouseEnter += new System.EventHandler(this.btMenu_MouseEnter);
            this.btDelete.MouseLeave += new System.EventHandler(this.btMenu_MouseLeave);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btSave.IconColor = System.Drawing.Color.White;
            this.btSave.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btSave.IconSize = 24;
            this.btSave.Location = new System.Drawing.Point(47, 12);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(24, 24);
            this.btSave.TabIndex = 11;
            this.btSave.TabStop = false;
            this.btSave.Visible = false;
            this.btSave.MouseEnter += new System.EventHandler(this.btMenu_MouseEnter);
            this.btSave.MouseLeave += new System.EventHandler(this.btMenu_MouseLeave);
            // 
            // btExpand
            // 
            this.btExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExpand.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btExpand.IconColor = System.Drawing.Color.White;
            this.btExpand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btExpand.IconSize = 24;
            this.btExpand.Location = new System.Drawing.Point(259, 12);
            this.btExpand.Name = "btExpand";
            this.btExpand.Size = new System.Drawing.Size(24, 24);
            this.btExpand.TabIndex = 10;
            this.btExpand.TabStop = false;
            this.btExpand.Visible = false;
            this.btExpand.Click += new System.EventHandler(this.btExpand_Click);
            this.btExpand.MouseEnter += new System.EventHandler(this.btMenu_MouseEnter);
            this.btExpand.MouseLeave += new System.EventHandler(this.btMenu_MouseLeave);
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.White;
            this.tbTitle.Location = new System.Drawing.Point(96, 16);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(168, 15);
            this.tbTitle.TabIndex = 8;
            this.tbTitle.Text = "untitled";
            this.tbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTitle.Visible = false;
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
            this.richContent.Size = new System.Drawing.Size(305, 119);
            this.richContent.TabIndex = 4;
            this.richContent.Text = "";
            // 
            // noteItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedPanel1);
            this.Name = "noteItems";
            this.Size = new System.Drawing.Size(345, 179);
            this.Load += new System.EventHandler(this.noteItems_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btExpand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private FontAwesome.Sharp.IconPictureBox btDelete;
        private FontAwesome.Sharp.IconPictureBox btSave;
        private FontAwesome.Sharp.IconPictureBox btExpand;
        private FontAwesome.Sharp.IconPictureBox btMenu;
        public System.Windows.Forms.TextBox tbTitle;
        public System.Windows.Forms.RichTextBox richContent;
    }
}

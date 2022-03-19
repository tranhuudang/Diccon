namespace Diccon.Pages
{
    partial class timeline
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
            this.panelList = new System.Windows.Forms.Panel();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRefresh = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.listHistory);
            this.panelList.Controls.Add(this.panel2);
            this.panelList.Controls.Add(this.panel1);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(0, 0);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(407, 662);
            this.panelList.TabIndex = 1;
            // 
            // listHistory
            // 
            this.listHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listHistory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHistory.IntegralHeight = false;
            this.listHistory.ItemHeight = 20;
            this.listHistory.Location = new System.Drawing.Point(0, 18);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(407, 606);
            this.listHistory.TabIndex = 0;
            this.listHistory.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listHistory_DrawItem);
            this.listHistory.SelectedIndexChanged += new System.EventHandler(this.listHistory_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 624);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 38);
            this.panel1.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 18);
            this.panel2.TabIndex = 2;
            // 
            // timeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 662);
            this.Controls.Add(this.panelList);
            this.Name = "timeline";
            this.Text = "Timeline";
            this.Load += new System.EventHandler(this.timeline_Load);
            this.Enter += new System.EventHandler(this.timeline_Enter);
            this.panelList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.ListBox listHistory;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btRefresh;
        private System.Windows.Forms.Panel panel2;
    }
}
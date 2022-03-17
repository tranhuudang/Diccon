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
            this.panelTranslate = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelList = new System.Windows.Forms.Panel();
            this.flowList = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTranslate.SuspendLayout();
            this.panelList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTranslate
            // 
            this.panelTranslate.Controls.Add(this.richTextBox1);
            this.panelTranslate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTranslate.Location = new System.Drawing.Point(0, 487);
            this.panelTranslate.Name = "panelTranslate";
            this.panelTranslate.Size = new System.Drawing.Size(407, 175);
            this.panelTranslate.TabIndex = 0;
            this.panelTranslate.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(383, 157);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.flowList);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(0, 0);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(407, 487);
            this.panelList.TabIndex = 1;
            // 
            // flowList
            // 
            this.flowList.AutoScroll = true;
            this.flowList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowList.Location = new System.Drawing.Point(0, 0);
            this.flowList.Name = "flowList";
            this.flowList.Size = new System.Drawing.Size(407, 487);
            this.flowList.TabIndex = 0;
            // 
            // timeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 662);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelTranslate);
            this.Name = "timeline";
            this.Text = "timeline";
            this.Load += new System.EventHandler(this.timeline_Load);
            this.panelTranslate.ResumeLayout(false);
            this.panelList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTranslate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.FlowLayoutPanel flowList;
    }
}
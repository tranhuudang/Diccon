namespace Diccon.Pages
{
    partial class login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btAsk = new Diccon.RoundedLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 20);
            this.textBox2.TabIndex = 0;
            // 
            // btAsk
            // 
            this.btAsk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAsk.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btAsk.BorderColor = System.Drawing.Color.White;
            this.btAsk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAsk.ForeColor = System.Drawing.Color.Black;
            this.btAsk.Location = new System.Drawing.Point(137, 238);
            this.btAsk.Name = "btAsk";
            this.btAsk.Padding = new System.Windows.Forms.Padding(7);
            this.btAsk.Radius = 20;
            this.btAsk.Size = new System.Drawing.Size(65, 34);
            this.btAsk.TabIndex = 10;
            this.btAsk.Text = "Ask";
            this.btAsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btAsk.Thickness = 5F;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(137, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "ZeroClub";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(112, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "Log in";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btAsk);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.MinimumSize = new System.Drawing.Size(355, 550);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private RoundedLabel btAsk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}
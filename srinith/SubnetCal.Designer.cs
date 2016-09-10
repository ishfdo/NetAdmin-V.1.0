namespace srinith
{
    partial class SubnetCal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageIPV4 = new System.Windows.Forms.TabPage();
            this.tabPageIPV6 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageIPV4);
            this.tabControl1.Controls.Add(this.tabPageIPV6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageIPV4
            // 
            this.tabPageIPV4.Location = new System.Drawing.Point(4, 22);
            this.tabPageIPV4.Name = "tabPageIPV4";
            this.tabPageIPV4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIPV4.Size = new System.Drawing.Size(552, 411);
            this.tabPageIPV4.TabIndex = 0;
            this.tabPageIPV4.Text = "IPV4";
            this.tabPageIPV4.UseVisualStyleBackColor = true;
            // 
            // tabPageIPV6
            // 
            this.tabPageIPV6.Location = new System.Drawing.Point(4, 22);
            this.tabPageIPV6.Name = "tabPageIPV6";
            this.tabPageIPV6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIPV6.Size = new System.Drawing.Size(552, 411);
            this.tabPageIPV6.TabIndex = 1;
            this.tabPageIPV6.Text = "tabPage2";
            this.tabPageIPV6.UseVisualStyleBackColor = true;
            // 
            // SubnetCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "SubnetCal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subnet Calulator";
            this.Load += new System.EventHandler(this.SubnetCal_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageIPV4;
        private System.Windows.Forms.TabPage tabPageIPV6;
    }
}
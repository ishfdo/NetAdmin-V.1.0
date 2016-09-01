namespace srinith
{
    partial class UsageMonitor
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
            this.components = new System.ComponentModel.Container();
            this.gbRAMUsage = new System.Windows.Forms.GroupBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbRAMUsage = new System.Windows.Forms.ProgressBar();
            this.gbCPUUsage = new System.Windows.Forms.GroupBox();
            this.pbCPUUsage = new System.Windows.Forms.ProgressBar();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.gbRAMUsage.SuspendLayout();
            this.gbCPUUsage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRAMUsage
            // 
            this.gbRAMUsage.Controls.Add(this.txtRAM);
            this.gbRAMUsage.Controls.Add(this.label1);
            this.gbRAMUsage.Controls.Add(this.pbRAMUsage);
            this.gbRAMUsage.Location = new System.Drawing.Point(12, 12);
            this.gbRAMUsage.Name = "gbRAMUsage";
            this.gbRAMUsage.Size = new System.Drawing.Size(560, 200);
            this.gbRAMUsage.TabIndex = 0;
            this.gbRAMUsage.TabStop = false;
            this.gbRAMUsage.Text = "Ram usage";
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(265, 48);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.ReadOnly = true;
            this.txtRAM.Size = new System.Drawing.Size(100, 20);
            this.txtRAM.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total RAM:";
            // 
            // pbRAMUsage
            // 
            this.pbRAMUsage.Location = new System.Drawing.Point(6, 137);
            this.pbRAMUsage.Name = "pbRAMUsage";
            this.pbRAMUsage.Size = new System.Drawing.Size(548, 57);
            this.pbRAMUsage.TabIndex = 0;
            // 
            // gbCPUUsage
            // 
            this.gbCPUUsage.Controls.Add(this.pbCPUUsage);
            this.gbCPUUsage.Location = new System.Drawing.Point(12, 249);
            this.gbCPUUsage.Name = "gbCPUUsage";
            this.gbCPUUsage.Size = new System.Drawing.Size(560, 200);
            this.gbCPUUsage.TabIndex = 1;
            this.gbCPUUsage.TabStop = false;
            this.gbCPUUsage.Text = "CPU usage";
            // 
            // pbCPUUsage
            // 
            this.pbCPUUsage.Location = new System.Drawing.Point(6, 143);
            this.pbCPUUsage.Name = "pbCPUUsage";
            this.pbCPUUsage.Size = new System.Drawing.Size(548, 57);
            this.pbCPUUsage.TabIndex = 1;
            // 
            // time
            // 
            this.time.Enabled = true;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // UsageMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.gbCPUUsage);
            this.Controls.Add(this.gbRAMUsage);
            this.Name = "UsageMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usage Monitor";
            this.Load += new System.EventHandler(this.UsageMonitor_Load);
            this.gbRAMUsage.ResumeLayout(false);
            this.gbRAMUsage.PerformLayout();
            this.gbCPUUsage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRAMUsage;
        private System.Windows.Forms.GroupBox gbCPUUsage;
        private System.Windows.Forms.ProgressBar pbRAMUsage;
        private System.Windows.Forms.ProgressBar pbCPUUsage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.Timer time;
    }
}
namespace srinith
{
    partial class Hardware_Info
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
            this.tabPageCPU = new System.Windows.Forms.TabPage();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.tabPageMemory = new System.Windows.Forms.TabPage();
            this.txtMemory = new System.Windows.Forms.TextBox();
            this.tabHDD = new System.Windows.Forms.TabPage();
            this.txtHDD = new System.Windows.Forms.TextBox();
            this.tabNetwork = new System.Windows.Forms.TabPage();
            this.txtNetwork = new System.Windows.Forms.TextBox();
            this.tabOS = new System.Windows.Forms.TabPage();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.tabPageCPU.SuspendLayout();
            this.tabPageMemory.SuspendLayout();
            this.tabHDD.SuspendLayout();
            this.tabNetwork.SuspendLayout();
            this.tabOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCPU);
            this.tabControl1.Controls.Add(this.tabPageMemory);
            this.tabControl1.Controls.Add(this.tabHDD);
            this.tabControl1.Controls.Add(this.tabNetwork);
            this.tabControl1.Controls.Add(this.tabOS);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCPU
            // 
            this.tabPageCPU.Controls.Add(this.txtCPU);
            this.tabPageCPU.Location = new System.Drawing.Point(4, 22);
            this.tabPageCPU.Name = "tabPageCPU";
            this.tabPageCPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCPU.Size = new System.Drawing.Size(564, 423);
            this.tabPageCPU.TabIndex = 0;
            this.tabPageCPU.Text = "CPU";
            this.tabPageCPU.UseVisualStyleBackColor = true;
            // 
            // txtCPU
            // 
            this.txtCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPU.Location = new System.Drawing.Point(0, 0);
            this.txtCPU.Multiline = true;
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.ReadOnly = true;
            this.txtCPU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCPU.Size = new System.Drawing.Size(568, 427);
            this.txtCPU.TabIndex = 0;
            // 
            // tabPageMemory
            // 
            this.tabPageMemory.Controls.Add(this.txtMemory);
            this.tabPageMemory.Location = new System.Drawing.Point(4, 22);
            this.tabPageMemory.Name = "tabPageMemory";
            this.tabPageMemory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMemory.Size = new System.Drawing.Size(564, 423);
            this.tabPageMemory.TabIndex = 1;
            this.tabPageMemory.Text = "Memory";
            this.tabPageMemory.UseVisualStyleBackColor = true;
            // 
            // txtMemory
            // 
            this.txtMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemory.Location = new System.Drawing.Point(0, 0);
            this.txtMemory.Multiline = true;
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.ReadOnly = true;
            this.txtMemory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMemory.Size = new System.Drawing.Size(568, 427);
            this.txtMemory.TabIndex = 0;
            // 
            // tabHDD
            // 
            this.tabHDD.Controls.Add(this.txtHDD);
            this.tabHDD.Location = new System.Drawing.Point(4, 22);
            this.tabHDD.Name = "tabHDD";
            this.tabHDD.Size = new System.Drawing.Size(564, 423);
            this.tabHDD.TabIndex = 2;
            this.tabHDD.Text = "HDD";
            this.tabHDD.UseVisualStyleBackColor = true;
            // 
            // txtHDD
            // 
            this.txtHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHDD.Location = new System.Drawing.Point(0, 0);
            this.txtHDD.Multiline = true;
            this.txtHDD.Name = "txtHDD";
            this.txtHDD.ReadOnly = true;
            this.txtHDD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHDD.Size = new System.Drawing.Size(568, 427);
            this.txtHDD.TabIndex = 0;
            // 
            // tabNetwork
            // 
            this.tabNetwork.Controls.Add(this.txtNetwork);
            this.tabNetwork.Location = new System.Drawing.Point(4, 22);
            this.tabNetwork.Name = "tabNetwork";
            this.tabNetwork.Size = new System.Drawing.Size(564, 423);
            this.tabNetwork.TabIndex = 3;
            this.tabNetwork.Text = "Network";
            this.tabNetwork.UseVisualStyleBackColor = true;
            // 
            // txtNetwork
            // 
            this.txtNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetwork.Location = new System.Drawing.Point(0, 0);
            this.txtNetwork.Multiline = true;
            this.txtNetwork.Name = "txtNetwork";
            this.txtNetwork.ReadOnly = true;
            this.txtNetwork.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNetwork.Size = new System.Drawing.Size(568, 427);
            this.txtNetwork.TabIndex = 0;
            // 
            // tabOS
            // 
            this.tabOS.Controls.Add(this.txtOS);
            this.tabOS.Location = new System.Drawing.Point(4, 22);
            this.tabOS.Name = "tabOS";
            this.tabOS.Size = new System.Drawing.Size(564, 423);
            this.tabOS.TabIndex = 4;
            this.tabOS.Text = "OS";
            this.tabOS.UseVisualStyleBackColor = true;
            // 
            // txtOS
            // 
            this.txtOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOS.Location = new System.Drawing.Point(0, 0);
            this.txtOS.Multiline = true;
            this.txtOS.Name = "txtOS";
            this.txtOS.ReadOnly = true;
            this.txtOS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOS.Size = new System.Drawing.Size(568, 427);
            this.txtOS.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Hardware_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "Hardware_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware_Info";
            this.Load += new System.EventHandler(this.Hardware_Info_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCPU.ResumeLayout(false);
            this.tabPageCPU.PerformLayout();
            this.tabPageMemory.ResumeLayout(false);
            this.tabPageMemory.PerformLayout();
            this.tabHDD.ResumeLayout(false);
            this.tabHDD.PerformLayout();
            this.tabNetwork.ResumeLayout(false);
            this.tabNetwork.PerformLayout();
            this.tabOS.ResumeLayout(false);
            this.tabOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCPU;
        private System.Windows.Forms.TabPage tabPageMemory;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.TabPage tabHDD;
        private System.Windows.Forms.TextBox txtHDD;
        private System.Windows.Forms.TabPage tabNetwork;
        private System.Windows.Forms.TabPage tabOS;
        private System.Windows.Forms.TextBox txtNetwork;
        private System.Windows.Forms.TextBox txtOS;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}
namespace srinith
{
    partial class CheckSum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtChecksum = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblMatch = new System.Windows.Forms.Label();
            this.lblMismatch = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCorrectHash = new System.Windows.Forms.Label();
            this.lblEnteredHash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Checksum";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Browse for file";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(221, 130);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(163, 20);
            this.txtFileName.TabIndex = 2;
            // 
            // txtChecksum
            // 
            this.txtChecksum.Location = new System.Drawing.Point(221, 158);
            this.txtChecksum.Name = "txtChecksum";
            this.txtChecksum.Size = new System.Drawing.Size(163, 20);
            this.txtChecksum.TabIndex = 3;
            this.txtChecksum.TextChanged += new System.EventHandler(this.txtChecksum_TextChanged);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(390, 128);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(309, 184);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 1;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.Location = new System.Drawing.Point(142, 315);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(34, 13);
            this.lblMatch.TabIndex = 6;
            this.lblMatch.Text = "HHH";
            // 
            // lblMismatch
            // 
            this.lblMismatch.AutoSize = true;
            this.lblMismatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMismatch.ForeColor = System.Drawing.Color.Red;
            this.lblMismatch.Location = new System.Drawing.Point(142, 315);
            this.lblMismatch.Name = "lblMismatch";
            this.lblMismatch.Size = new System.Drawing.Size(34, 13);
            this.lblMismatch.TabIndex = 7;
            this.lblMismatch.Text = "HHH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Correct Hash:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hash You Entered:";
            // 
            // lblCorrectHash
            // 
            this.lblCorrectHash.AutoSize = true;
            this.lblCorrectHash.Location = new System.Drawing.Point(242, 257);
            this.lblCorrectHash.Name = "lblCorrectHash";
            this.lblCorrectHash.Size = new System.Drawing.Size(35, 13);
            this.lblCorrectHash.TabIndex = 10;
            this.lblCorrectHash.Text = "label5";
            // 
            // lblEnteredHash
            // 
            this.lblEnteredHash.AutoSize = true;
            this.lblEnteredHash.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEnteredHash.Location = new System.Drawing.Point(242, 285);
            this.lblEnteredHash.Name = "lblEnteredHash";
            this.lblEnteredHash.Size = new System.Drawing.Size(35, 13);
            this.lblEnteredHash.TabIndex = 11;
            this.lblEnteredHash.Text = "label6";
            // 
            // CheckSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lblEnteredHash);
            this.Controls.Add(this.lblCorrectHash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMismatch);
            this.Controls.Add(this.lblMatch);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtChecksum);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CheckSum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Sum";
            this.Load += new System.EventHandler(this.CheckSum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtChecksum;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.Label lblMismatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCorrectHash;
        private System.Windows.Forms.Label lblEnteredHash;
    }
}
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtBroadcastIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbClassC = new System.Windows.Forms.RadioButton();
            this.rbClassB = new System.Windows.Forms.RadioButton();
            this.rbClassA = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSubnetMask = new System.Windows.Forms.ComboBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageIPV6 = new System.Windows.Forms.TabPage();
            this.txtSubnetID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubnetBits = new System.Windows.Forms.TextBox();
            this.txtMaskBits = new System.Windows.Forms.TextBox();
            this.txtMaximumSubnets = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtFirstOctetRange = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageIPV4.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabPageIPV4.Controls.Add(this.txtFirstOctetRange);
            this.tabPageIPV4.Controls.Add(this.label9);
            this.tabPageIPV4.Controls.Add(this.txtMaximumSubnets);
            this.tabPageIPV4.Controls.Add(this.txtMaskBits);
            this.tabPageIPV4.Controls.Add(this.txtSubnetBits);
            this.tabPageIPV4.Controls.Add(this.label8);
            this.tabPageIPV4.Controls.Add(this.label7);
            this.tabPageIPV4.Controls.Add(this.label6);
            this.tabPageIPV4.Controls.Add(this.txtSubnetID);
            this.tabPageIPV4.Controls.Add(this.label5);
            this.tabPageIPV4.Controls.Add(this.txtBroadcastIP);
            this.tabPageIPV4.Controls.Add(this.label4);
            this.tabPageIPV4.Controls.Add(this.rbClassC);
            this.tabPageIPV4.Controls.Add(this.rbClassB);
            this.tabPageIPV4.Controls.Add(this.rbClassA);
            this.tabPageIPV4.Controls.Add(this.label3);
            this.tabPageIPV4.Controls.Add(this.cbSubnetMask);
            this.tabPageIPV4.Controls.Add(this.txtIPAddress);
            this.tabPageIPV4.Controls.Add(this.label2);
            this.tabPageIPV4.Controls.Add(this.label1);
            this.tabPageIPV4.Controls.Add(this.groupBox1);
            this.tabPageIPV4.Location = new System.Drawing.Point(4, 22);
            this.tabPageIPV4.Name = "tabPageIPV4";
            this.tabPageIPV4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIPV4.Size = new System.Drawing.Size(552, 411);
            this.tabPageIPV4.TabIndex = 0;
            this.tabPageIPV4.Text = "IPv4";
            this.tabPageIPV4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subnet ID";
            // 
            // txtBroadcastIP
            // 
            this.txtBroadcastIP.Location = new System.Drawing.Point(48, 86);
            this.txtBroadcastIP.Name = "txtBroadcastIP";
            this.txtBroadcastIP.ReadOnly = true;
            this.txtBroadcastIP.Size = new System.Drawing.Size(171, 20);
            this.txtBroadcastIP.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Broadcast IP";
            // 
            // rbClassC
            // 
            this.rbClassC.AutoSize = true;
            this.rbClassC.Enabled = false;
            this.rbClassC.Location = new System.Drawing.Point(187, 37);
            this.rbClassC.Name = "rbClassC";
            this.rbClassC.Size = new System.Drawing.Size(32, 17);
            this.rbClassC.TabIndex = 7;
            this.rbClassC.TabStop = true;
            this.rbClassC.Text = "C";
            this.rbClassC.UseVisualStyleBackColor = true;
            // 
            // rbClassB
            // 
            this.rbClassB.AutoSize = true;
            this.rbClassB.Enabled = false;
            this.rbClassB.Location = new System.Drawing.Point(117, 37);
            this.rbClassB.Name = "rbClassB";
            this.rbClassB.Size = new System.Drawing.Size(32, 17);
            this.rbClassB.TabIndex = 6;
            this.rbClassB.TabStop = true;
            this.rbClassB.Text = "B";
            this.rbClassB.UseVisualStyleBackColor = true;
            // 
            // rbClassA
            // 
            this.rbClassA.AutoSize = true;
            this.rbClassA.Enabled = false;
            this.rbClassA.Location = new System.Drawing.Point(48, 37);
            this.rbClassA.Name = "rbClassA";
            this.rbClassA.Size = new System.Drawing.Size(32, 17);
            this.rbClassA.TabIndex = 5;
            this.rbClassA.TabStop = true;
            this.rbClassA.Text = "A";
            this.rbClassA.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class";
            // 
            // cbSubnetMask
            // 
            this.cbSubnetMask.FormattingEnabled = true;
            this.cbSubnetMask.Items.AddRange(new object[] {
            "255.0.0.0",
            "255.128.0.0",
            "255.192.0.0",
            "255.224.0.0",
            "255.240.0.0",
            "255.248.0.0",
            "255.252.0.0",
            "255.254.0.0",
            "255.255.0.0",
            "255.255.128.0",
            "255.255.192.0",
            "255.255.224.0",
            "255.255.240.0",
            "255.255.248.0",
            "255.255.252.0",
            "255.255.254.0",
            "255.255.255.0",
            "255.255.255.128",
            "255.255.255.192",
            "255.255.255.224",
            "255.255.255.240",
            "255.255.255.248",
            "255.255.255.252"});
            this.cbSubnetMask.Location = new System.Drawing.Point(303, 108);
            this.cbSubnetMask.Name = "cbSubnetMask";
            this.cbSubnetMask.Size = new System.Drawing.Size(171, 21);
            this.cbSubnetMask.TabIndex = 1;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(303, 58);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(171, 20);
            this.txtIPAddress.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subnet Mask";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // tabPageIPV6
            // 
            this.tabPageIPV6.Location = new System.Drawing.Point(4, 22);
            this.tabPageIPV6.Name = "tabPageIPV6";
            this.tabPageIPV6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIPV6.Size = new System.Drawing.Size(552, 411);
            this.tabPageIPV6.TabIndex = 1;
            this.tabPageIPV6.Text = "IPv6";
            this.tabPageIPV6.UseVisualStyleBackColor = true;
            // 
            // txtSubnetID
            // 
            this.txtSubnetID.Location = new System.Drawing.Point(48, 139);
            this.txtSubnetID.Name = "txtSubnetID";
            this.txtSubnetID.ReadOnly = true;
            this.txtSubnetID.Size = new System.Drawing.Size(171, 20);
            this.txtSubnetID.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Subnet Bits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mask Bits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Maximum Subnets";
            // 
            // txtSubnetBits
            // 
            this.txtSubnetBits.Location = new System.Drawing.Point(48, 193);
            this.txtSubnetBits.Name = "txtSubnetBits";
            this.txtSubnetBits.ReadOnly = true;
            this.txtSubnetBits.Size = new System.Drawing.Size(171, 20);
            this.txtSubnetBits.TabIndex = 15;
            // 
            // txtMaskBits
            // 
            this.txtMaskBits.Location = new System.Drawing.Point(48, 243);
            this.txtMaskBits.Name = "txtMaskBits";
            this.txtMaskBits.ReadOnly = true;
            this.txtMaskBits.Size = new System.Drawing.Size(171, 20);
            this.txtMaskBits.TabIndex = 16;
            // 
            // txtMaximumSubnets
            // 
            this.txtMaximumSubnets.Location = new System.Drawing.Point(48, 296);
            this.txtMaximumSubnets.Name = "txtMaximumSubnets";
            this.txtMaximumSubnets.ReadOnly = true;
            this.txtMaximumSubnets.Size = new System.Drawing.Size(171, 20);
            this.txtMaximumSubnets.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Location = new System.Drawing.Point(281, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 161);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(118, 125);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // txtFirstOctetRange
            // 
            this.txtFirstOctetRange.Location = new System.Drawing.Point(48, 348);
            this.txtFirstOctetRange.Name = "txtFirstOctetRange";
            this.txtFirstOctetRange.ReadOnly = true;
            this.txtFirstOctetRange.Size = new System.Drawing.Size(171, 20);
            this.txtFirstOctetRange.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "First Octet Range";
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
            this.tabPageIPV4.ResumeLayout(false);
            this.tabPageIPV4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageIPV4;
        private System.Windows.Forms.TabPage tabPageIPV6;
        private System.Windows.Forms.RadioButton rbClassC;
        private System.Windows.Forms.RadioButton rbClassB;
        private System.Windows.Forms.RadioButton rbClassA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSubnetMask;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBroadcastIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaximumSubnets;
        private System.Windows.Forms.TextBox txtMaskBits;
        private System.Windows.Forms.TextBox txtSubnetBits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubnetID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFirstOctetRange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalculate;
    }
}
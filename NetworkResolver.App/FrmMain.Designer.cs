namespace NetworkResolver
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTurnOn = new System.Windows.Forms.Button();
            this.btnTurnOff = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblProxyEnabled = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProxyAddress = new System.Windows.Forms.Label();
            this.lblRemoteDesktop = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblComputerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogstuff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // btnTurnOn
            // 
            this.btnTurnOn.Location = new System.Drawing.Point(75, 118);
            this.btnTurnOn.Margin = new System.Windows.Forms.Padding(4);
            this.btnTurnOn.Name = "btnTurnOn";
            this.btnTurnOn.Size = new System.Drawing.Size(305, 123);
            this.btnTurnOn.TabIndex = 25;
            this.btnTurnOn.Text = "Turn ON Proxy Settings";
            this.btnTurnOn.UseVisualStyleBackColor = true;
            this.btnTurnOn.Click += new System.EventHandler(this.btnTurnOn_Click);
            // 
            // btnTurnOff
            // 
            this.btnTurnOff.Location = new System.Drawing.Point(449, 118);
            this.btnTurnOff.Margin = new System.Windows.Forms.Padding(4);
            this.btnTurnOff.Name = "btnTurnOff";
            this.btnTurnOff.Size = new System.Drawing.Size(305, 123);
            this.btnTurnOff.TabIndex = 26;
            this.btnTurnOff.Text = "Turn OFF Proxy Settings";
            this.btnTurnOff.UseVisualStyleBackColor = true;
            this.btnTurnOff.Click += new System.EventHandler(this.btnTurnOff_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 461);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 64;
            this.label7.Text = "IP Address:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(463, 410);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(19, 25);
            this.lblUsername.TabIndex = 63;
            this.lblUsername.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 415);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 62;
            this.label10.Text = "Username:";
            // 
            // lblProxyEnabled
            // 
            this.lblProxyEnabled.AutoSize = true;
            this.lblProxyEnabled.Location = new System.Drawing.Point(458, 568);
            this.lblProxyEnabled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProxyEnabled.Name = "lblProxyEnabled";
            this.lblProxyEnabled.Size = new System.Drawing.Size(19, 25);
            this.lblProxyEnabled.TabIndex = 61;
            this.lblProxyEnabled.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 568);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Proxy Enabled";
            // 
            // lblProxyAddress
            // 
            this.lblProxyAddress.AutoSize = true;
            this.lblProxyAddress.Location = new System.Drawing.Point(457, 624);
            this.lblProxyAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProxyAddress.Name = "lblProxyAddress";
            this.lblProxyAddress.Size = new System.Drawing.Size(19, 25);
            this.lblProxyAddress.TabIndex = 59;
            this.lblProxyAddress.Text = "-";
            // 
            // lblRemoteDesktop
            // 
            this.lblRemoteDesktop.AutoSize = true;
            this.lblRemoteDesktop.Location = new System.Drawing.Point(458, 513);
            this.lblRemoteDesktop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemoteDesktop.Name = "lblRemoteDesktop";
            this.lblRemoteDesktop.Size = new System.Drawing.Size(19, 25);
            this.lblRemoteDesktop.TabIndex = 58;
            this.lblRemoteDesktop.Text = "-";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(437, 461);
            this.lblIPAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(19, 25);
            this.lblIPAddress.TabIndex = 56;
            this.lblIPAddress.Text = "-";
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Location = new System.Drawing.Point(458, 370);
            this.lblComputerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(19, 25);
            this.lblComputerName.TabIndex = 55;
            this.lblComputerName.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 513);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Remote Desktop:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 617);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Proxy Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 375);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Computer Name:";
            // 
            // lblLogstuff
            // 
            this.lblLogstuff.AutoSize = true;
            this.lblLogstuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogstuff.Location = new System.Drawing.Point(34, 676);
            this.lblLogstuff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogstuff.Name = "lblLogstuff";
            this.lblLogstuff.Size = new System.Drawing.Size(27, 37);
            this.lblLogstuff.TabIndex = 65;
            this.lblLogstuff.Text = "-";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 826);
            this.Controls.Add(this.lblLogstuff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblProxyEnabled);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProxyAddress);
            this.Controls.Add(this.lblRemoteDesktop);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.lblComputerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTurnOff);
            this.Controls.Add(this.btnTurnOn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(920, 897);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(920, 897);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ProxyResolver";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTurnOn;
        private System.Windows.Forms.Button btnTurnOff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblProxyEnabled;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProxyAddress;
        private System.Windows.Forms.Label lblRemoteDesktop;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblLogstuff;
    }
}


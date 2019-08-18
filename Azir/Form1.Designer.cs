namespace Azir
{
    partial class azir
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sshPORT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sshPASS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sshUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sshHost = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Lhost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lport = new System.Windows.Forms.TextBox();
            this.buttonConnect = new MaterialSkin.Controls.MaterialRaisedButton();
            this.statusLabel = new System.Windows.Forms.Label();
            this.teleLink = new System.Windows.Forms.LinkLabel();
            this.Exit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.about = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sshPORT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.sshPASS);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sshUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sshHost);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 162);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Config";
            // 
            // sshPORT
            // 
            this.sshPORT.Location = new System.Drawing.Point(95, 121);
            this.sshPORT.Name = "sshPORT";
            this.sshPORT.Size = new System.Drawing.Size(190, 23);
            this.sshPORT.TabIndex = 6;
            this.sshPORT.Text = "22";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "PASSWORD";
            // 
            // sshPASS
            // 
            this.sshPASS.Location = new System.Drawing.Point(95, 92);
            this.sshPASS.MaxLength = 3000;
            this.sshPASS.Name = "sshPASS";
            this.sshPASS.PasswordChar = '*';
            this.sshPASS.Size = new System.Drawing.Size(190, 23);
            this.sshPASS.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "USER";
            // 
            // sshUser
            // 
            this.sshUser.Location = new System.Drawing.Point(95, 60);
            this.sshUser.Name = "sshUser";
            this.sshUser.Size = new System.Drawing.Size(190, 23);
            this.sshUser.TabIndex = 2;
            this.sshUser.Text = "root";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // sshHost
            // 
            this.sshHost.Location = new System.Drawing.Point(95, 31);
            this.sshHost.Name = "sshHost";
            this.sshHost.Size = new System.Drawing.Size(190, 23);
            this.sshHost.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Lhost);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Lport);
            this.panel2.Location = new System.Drawing.Point(12, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 100);
            this.panel2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "HOST";
            // 
            // Lhost
            // 
            this.Lhost.Location = new System.Drawing.Point(95, 32);
            this.Lhost.Name = "Lhost";
            this.Lhost.Size = new System.Drawing.Size(190, 23);
            this.Lhost.TabIndex = 10;
            this.Lhost.Text = "localhost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Listen Config";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "PORT";
            // 
            // Lport
            // 
            this.Lport.Location = new System.Drawing.Point(95, 61);
            this.Lport.Name = "Lport";
            this.Lport.Size = new System.Drawing.Size(190, 23);
            this.Lport.TabIndex = 8;
            this.Lport.Text = "1080";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Depth = 0;
            this.buttonConnect.Location = new System.Drawing.Point(221, 373);
            this.buttonConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Primary = true;
            this.buttonConnect.Size = new System.Drawing.Size(114, 47);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(18, 354);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(47, 17);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Status";
            // 
            // teleLink
            // 
            this.teleLink.AutoSize = true;
            this.teleLink.Location = new System.Drawing.Point(20, 373);
            this.teleLink.Name = "teleLink";
            this.teleLink.Size = new System.Drawing.Size(108, 17);
            this.teleLink.TabIndex = 6;
            this.teleLink.TabStop = true;
            this.teleLink.Text = "Set To Telegram";
            this.teleLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Exit
            // 
            this.Exit.Depth = 0;
            this.Exit.Location = new System.Drawing.Point(149, 373);
            this.Exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Exit.Name = "Exit";
            this.Exit.Primary = true;
            this.Exit.Size = new System.Drawing.Size(66, 47);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Location = new System.Drawing.Point(20, 390);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(45, 17);
            this.about.TabIndex = 8;
            this.about.TabStop = true;
            this.about.Text = "About";
            this.about.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // azir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 432);
            this.Controls.Add(this.about);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.teleLink);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.MaximizeBox = false;
            this.Name = "azir";
            this.Text = "Azir/Socks Over Ssh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox sshUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sshHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sshPORT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sshPASS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Lhost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Lport;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRaisedButton buttonConnect;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.LinkLabel teleLink;
        private MaterialSkin.Controls.MaterialRaisedButton Exit;
        private System.Windows.Forms.LinkLabel about;


    }
}


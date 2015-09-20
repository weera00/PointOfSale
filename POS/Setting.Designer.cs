namespace POS
{
    partial class Setting
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
            this.lblDbIP = new System.Windows.Forms.Label();
            this.lblDbUser = new System.Windows.Forms.Label();
            this.lblDbPass = new System.Windows.Forms.Label();
            this.lblDbPort = new System.Windows.Forms.Label();
            this.txtDbHost = new System.Windows.Forms.TextBox();
            this.txtDbUser = new System.Windows.Forms.TextBox();
            this.txtDbPass = new System.Windows.Forms.TextBox();
            this.txtDbPort = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToDefualtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDbIP
            // 
            this.lblDbIP.AutoSize = true;
            this.lblDbIP.Location = new System.Drawing.Point(52, 75);
            this.lblDbIP.Name = "lblDbIP";
            this.lblDbIP.Size = new System.Drawing.Size(17, 13);
            this.lblDbIP.TabIndex = 0;
            this.lblDbIP.Text = "IP";
            // 
            // lblDbUser
            // 
            this.lblDbUser.AutoSize = true;
            this.lblDbUser.Location = new System.Drawing.Point(52, 181);
            this.lblDbUser.Name = "lblDbUser";
            this.lblDbUser.Size = new System.Drawing.Size(37, 13);
            this.lblDbUser.TabIndex = 1;
            this.lblDbUser.Text = "USER";
            // 
            // lblDbPass
            // 
            this.lblDbPass.AutoSize = true;
            this.lblDbPass.Location = new System.Drawing.Point(52, 223);
            this.lblDbPass.Name = "lblDbPass";
            this.lblDbPass.Size = new System.Drawing.Size(70, 13);
            this.lblDbPass.TabIndex = 2;
            this.lblDbPass.Text = "PASSWORD";
            // 
            // lblDbPort
            // 
            this.lblDbPort.AutoSize = true;
            this.lblDbPort.Location = new System.Drawing.Point(52, 108);
            this.lblDbPort.Name = "lblDbPort";
            this.lblDbPort.Size = new System.Drawing.Size(37, 13);
            this.lblDbPort.TabIndex = 3;
            this.lblDbPort.Text = "PORT";
            // 
            // txtDbHost
            // 
            this.txtDbHost.Location = new System.Drawing.Point(128, 72);
            this.txtDbHost.Name = "txtDbHost";
            this.txtDbHost.Size = new System.Drawing.Size(240, 20);
            this.txtDbHost.TabIndex = 4;
            // 
            // txtDbUser
            // 
            this.txtDbUser.Location = new System.Drawing.Point(128, 178);
            this.txtDbUser.Name = "txtDbUser";
            this.txtDbUser.Size = new System.Drawing.Size(240, 20);
            this.txtDbUser.TabIndex = 5;
            // 
            // txtDbPass
            // 
            this.txtDbPass.Location = new System.Drawing.Point(128, 220);
            this.txtDbPass.Name = "txtDbPass";
            this.txtDbPass.Size = new System.Drawing.Size(240, 20);
            this.txtDbPass.TabIndex = 6;
            // 
            // txtDbPort
            // 
            this.txtDbPort.Location = new System.Drawing.Point(128, 105);
            this.txtDbPort.Name = "txtDbPort";
            this.txtDbPort.Size = new System.Drawing.Size(100, 20);
            this.txtDbPort.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.cancleToolStripMenuItem,
            this.resetToDefualtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(419, 56);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::POS.Properties.Resources.accept;
            this.saveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(95, 52);
            this.saveToolStripMenuItem.Text = "บันทึก";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // cancleToolStripMenuItem
            // 
            this.cancleToolStripMenuItem.Image = global::POS.Properties.Resources.delete;
            this.cancleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancleToolStripMenuItem.Name = "cancleToolStripMenuItem";
            this.cancleToolStripMenuItem.Size = new System.Drawing.Size(96, 52);
            this.cancleToolStripMenuItem.Text = "ยกเลิก";
            this.cancleToolStripMenuItem.Click += new System.EventHandler(this.cancleToolStripMenuItem_Click);
            // 
            // resetToDefualtToolStripMenuItem
            // 
            this.resetToDefualtToolStripMenuItem.Image = global::POS.Properties.Resources.process;
            this.resetToDefualtToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.resetToDefualtToolStripMenuItem.Name = "resetToDefualtToolStripMenuItem";
            this.resetToDefualtToolStripMenuItem.Size = new System.Drawing.Size(122, 52);
            this.resetToDefualtToolStripMenuItem.Text = "คืนค่าเริ่มต้น";
            this.resetToDefualtToolStripMenuItem.Click += new System.EventHandler(this.resetToDefualtToolStripMenuItem_Click);
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(128, 141);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(240, 20);
            this.txtDbName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ชื่อฐานข้อมูล";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDbName);
            this.Controls.Add(this.txtDbPort);
            this.Controls.Add(this.txtDbPass);
            this.Controls.Add(this.txtDbUser);
            this.Controls.Add(this.txtDbHost);
            this.Controls.Add(this.lblDbPort);
            this.Controls.Add(this.lblDbPass);
            this.Controls.Add(this.lblDbUser);
            this.Controls.Add(this.lblDbIP);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Setting";
            this.Text = "Setting";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDbIP;
        private System.Windows.Forms.Label lblDbUser;
        private System.Windows.Forms.Label lblDbPass;
        private System.Windows.Forms.Label lblDbPort;
        private System.Windows.Forms.TextBox txtDbHost;
        private System.Windows.Forms.TextBox txtDbUser;
        private System.Windows.Forms.TextBox txtDbPass;
        private System.Windows.Forms.TextBox txtDbPort;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToDefualtToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Label label1;
    }
}
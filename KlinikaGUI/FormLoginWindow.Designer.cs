namespace KlinikaGUI
{
    partial class FormLoginWindow
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Login = new System.Windows.Forms.GroupBox();
            this.LabelPass = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.ButtLogin = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 280);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(474, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.OrangeRed;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Visible = false;
            // 
            // Login
            // 
            this.Login.Controls.Add(this.LabelPass);
            this.Login.Controls.Add(this.LabelUser);
            this.Login.Controls.Add(this.ButtLogin);
            this.Login.Controls.Add(this.PassBox);
            this.Login.Controls.Add(this.UserBox);
            this.Login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Login.Location = new System.Drawing.Point(0, 168);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(474, 112);
            this.Login.TabIndex = 7;
            this.Login.TabStop = false;
            // 
            // LabelPass
            // 
            this.LabelPass.AutoSize = true;
            this.LabelPass.Location = new System.Drawing.Point(29, 48);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(59, 13);
            this.LabelPass.TabIndex = 4;
            this.LabelPass.Text = "Password: ";
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Location = new System.Drawing.Point(27, 22);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(61, 13);
            this.LabelUser.TabIndex = 1;
            this.LabelUser.Text = "Username: ";
            // 
            // ButtLogin
            // 
            this.ButtLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtLogin.Location = new System.Drawing.Point(334, 71);
            this.ButtLogin.Name = "ButtLogin";
            this.ButtLogin.Size = new System.Drawing.Size(102, 23);
            this.ButtLogin.TabIndex = 2;
            this.ButtLogin.Text = "Login";
            this.ButtLogin.UseVisualStyleBackColor = true;
            this.ButtLogin.Click += new System.EventHandler(this.ButtLogin_Click);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(94, 45);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(342, 20);
            this.PassBox.TabIndex = 1;
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(94, 19);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(342, 20);
            this.UserBox.TabIndex = 0;
            // 
            // FormLoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 302);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.statusStrip1);
            this.MaximumSize = new System.Drawing.Size(490, 341);
            this.MinimumSize = new System.Drawing.Size(490, 341);
            this.Name = "FormLoginWindow";
            this.Text = "RPR Klinika";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Button ButtLogin;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox UserBox;
    }
}


namespace StudentDashboard.GUI
{
    partial class AccountInfo
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
            tbUserName = new TextBox();
            tbEmail = new TextBox();
            tbCreateAT = new TextBox();
            btLogout = new Button();
            btChangePassword = new Button();
            btChangeInfo = new Button();
            SuspendLayout();
            // 
            // tbUserName
            // 
            tbUserName.Font = new Font("Segoe UI", 18F);
            tbUserName.ForeColor = Color.Aqua;
            tbUserName.Location = new Point(164, 247);
            tbUserName.Margin = new Padding(2, 2, 2, 2);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(445, 39);
            tbUserName.TabIndex = 1;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 18F);
            tbEmail.ForeColor = Color.Cyan;
            tbEmail.Location = new Point(164, 335);
            tbEmail.Margin = new Padding(2, 2, 2, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(445, 39);
            tbEmail.TabIndex = 3;
            // 
            // tbCreateAT
            // 
            tbCreateAT.Font = new Font("Segoe UI", 18F);
            tbCreateAT.ForeColor = Color.Cyan;
            tbCreateAT.Location = new Point(164, 443);
            tbCreateAT.Margin = new Padding(2, 2, 2, 2);
            tbCreateAT.Name = "tbCreateAT";
            tbCreateAT.Size = new Size(445, 39);
            tbCreateAT.TabIndex = 5;
            // 
            // btLogout
            // 
            btLogout.BackColor = SystemColors.ButtonFace;
            btLogout.Font = new Font("Segoe UI", 15F);
            btLogout.ForeColor = Color.FromArgb(0, 188, 212);
            btLogout.Location = new Point(627, 520);
            btLogout.Margin = new Padding(2, 2, 2, 2);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(134, 46);
            btLogout.TabIndex = 6;
            btLogout.Text = "Đăng xuất";
            btLogout.UseVisualStyleBackColor = false;
            btLogout.Click += btLogout_Click;
            // 
            // btChangePassword
            // 
            btChangePassword.BackColor = Color.FromArgb(182, 204, 254);
            btChangePassword.FlatAppearance.BorderSize = 0;
            btChangePassword.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btChangePassword.ForeColor = Color.FromArgb(13, 71, 161);
            btChangePassword.Location = new Point(429, 520);
            btChangePassword.Margin = new Padding(2, 2, 2, 2);
            btChangePassword.Name = "btChangePassword";
            btChangePassword.Size = new Size(164, 46);
            btChangePassword.TabIndex = 7;
            btChangePassword.Text = "Đổi mật khẩu";
            btChangePassword.UseVisualStyleBackColor = false;
            btChangePassword.Click += btChangePassword_Click;
            // 
            // btChangeInfo
            // 
            btChangeInfo.BackColor = Color.FromArgb(160, 132, 220);
            btChangeInfo.FlatAppearance.BorderSize = 0;
            btChangeInfo.FlatStyle = FlatStyle.Popup;
            btChangeInfo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btChangeInfo.ForeColor = Color.White;
            btChangeInfo.Location = new Point(164, 520);
            btChangeInfo.Margin = new Padding(2, 2, 2, 2);
            btChangeInfo.Name = "btChangeInfo";
            btChangeInfo.Size = new Size(235, 46);
            btChangeInfo.TabIndex = 8;
            btChangeInfo.Text = "Đổi thông tin cá nhân";
            btChangeInfo.UseVisualStyleBackColor = false;
            btChangeInfo.Click += btChangeInfo_Click;
            // 
            // AccountInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Your_paragraph_text;
            ClientSize = new Size(1326, 637);
            Controls.Add(btChangeInfo);
            Controls.Add(btChangePassword);
            Controls.Add(btLogout);
            Controls.Add(tbCreateAT);
            Controls.Add(tbEmail);
            Controls.Add(tbUserName);
            ForeColor = Color.Azure;
            Margin = new Padding(2, 2, 2, 2);
            Name = "AccountInfo";
            Text = "Thông tin tài khoản";
            Load += AccountInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbUserName;
        private TextBox tbEmail;
        private TextBox tbCreateAT;
        private Button btLogout;
        private Button btChangePassword;
        private Button btChangeInfo;
    }
}
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
            btHome = new Button();
            SuspendLayout();
            // 
            // tbUserName
            // 
            tbUserName.Font = new Font("Segoe UI", 18F);
            tbUserName.ForeColor = Color.Aqua;
            tbUserName.Location = new Point(412, 178);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(634, 55);
            tbUserName.TabIndex = 1;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 18F);
            tbEmail.ForeColor = Color.Cyan;
            tbEmail.Location = new Point(412, 278);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(634, 55);
            tbEmail.TabIndex = 3;
            // 
            // tbCreateAT
            // 
            tbCreateAT.Font = new Font("Segoe UI", 18F);
            tbCreateAT.ForeColor = Color.Cyan;
            tbCreateAT.Location = new Point(412, 362);
            tbCreateAT.Name = "tbCreateAT";
            tbCreateAT.Size = new Size(634, 55);
            tbCreateAT.TabIndex = 5;
            // 
            // btLogout
            // 
            btLogout.BackColor = SystemColors.ButtonFace;
            btLogout.Font = new Font("Segoe UI", 15F);
            btLogout.ForeColor = Color.FromArgb(0, 188, 212);
            btLogout.Location = new Point(871, 524);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(191, 77);
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
            btChangePassword.Location = new Point(534, 524);
            btChangePassword.Name = "btChangePassword";
            btChangePassword.Size = new Size(234, 77);
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
            btChangeInfo.Location = new Point(121, 524);
            btChangeInfo.Name = "btChangeInfo";
            btChangeInfo.Size = new Size(336, 77);
            btChangeInfo.TabIndex = 8;
            btChangeInfo.Text = "Đổi thông tin cá nhân";
            btChangeInfo.UseVisualStyleBackColor = false;
            btChangeInfo.Click += btChangeInfo_Click;
            // 
            // btHome
            // 
            btHome.AutoSize = true;
            btHome.FlatAppearance.BorderSize = 0;
            btHome.FlatStyle = FlatStyle.Flat;
            btHome.Font = new Font("Segoe UI", 12F);
            btHome.ForeColor = SystemColors.Desktop;
            btHome.Image = Properties.Resources.icons8_home_24;
            btHome.Location = new Point(1093, 14);
            btHome.Margin = new Padding(4, 5, 4, 5);
            btHome.Name = "btHome";
            btHome.Size = new Size(118, 70);
            btHome.TabIndex = 9;
            btHome.UseVisualStyleBackColor = true;
            btHome.Click += btHome_Click;
            // 
            // AccountInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Your_paragraph_text;
            ClientSize = new Size(1224, 659);
            Controls.Add(btHome);
            Controls.Add(btChangeInfo);
            Controls.Add(btChangePassword);
            Controls.Add(btLogout);
            Controls.Add(tbCreateAT);
            Controls.Add(tbEmail);
            Controls.Add(tbUserName);
            ForeColor = Color.Azure;
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
        private Button btHome;
    }
}
using Guna.UI2.WinForms;

namespace StudentDashboard.GUI
{
    partial class ChangeInfo
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
            lbUserName = new Label();
            gunaTbUserName = new Guna2TextBox();
            lbPassword = new Label();
            gunaTbPassword = new Guna2TextBox();
            gunaBtSave = new Guna2Button();
            SuspendLayout();
            // 
            // Form background
            // 
            this.BackColor = ColorTranslator.FromHtml("#f5f6fa");
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserName.ForeColor = ColorTranslator.FromHtml("#222f3e");
            lbUserName.Location = new Point(230, 100);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(133, 28);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "Tên đăng nhập:";
            // 
            // gunaTbUserName
            // 
            gunaTbUserName.BorderRadius = 10;
            gunaTbUserName.BorderColor = Color.FromArgb(200, 220, 255);
            gunaTbUserName.FillColor = Color.FromArgb(245, 247, 250);
            gunaTbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gunaTbUserName.ForeColor = Color.FromArgb(60, 60, 60);
            gunaTbUserName.Location = new Point(390, 97);
            gunaTbUserName.Name = "gunaTbUserName";
            gunaTbUserName.Size = new Size(225, 38);
            gunaTbUserName.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPassword.ForeColor = ColorTranslator.FromHtml("#222f3e");
            lbPassword.Location = new Point(230, 180);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(90, 28);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Mật khẩu:";
            // 
            // gunaTbPassword
            // 
            gunaTbPassword.BorderRadius = 10;
            gunaTbPassword.BorderColor = Color.FromArgb(200, 220, 255);
            gunaTbPassword.FillColor = Color.FromArgb(245, 247, 250);
            gunaTbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gunaTbPassword.ForeColor = Color.FromArgb(60, 60, 60);
            gunaTbPassword.Location = new Point(390, 177);
            gunaTbPassword.Name = "gunaTbPassword";
            gunaTbPassword.Size = new Size(225, 38);
            gunaTbPassword.TabIndex = 5;
            gunaTbPassword.PasswordChar = '*';
            // 
            // gunaBtSave
            // 
            gunaBtSave.BorderRadius = 15;
            gunaBtSave.FillColor = Color.FromArgb(60, 130, 246);
            gunaBtSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gunaBtSave.ForeColor = Color.White;
            gunaBtSave.Location = new Point(340, 260);
            gunaBtSave.Name = "gunaBtSave";
            gunaBtSave.Size = new Size(180, 45);
            gunaBtSave.TabIndex = 6;
            gunaBtSave.Text = "Lưu";
            gunaBtSave.Click += btSave_Click;
            // 
            // ChangeInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(gunaBtSave);
            Controls.Add(gunaTbPassword);
            Controls.Add(lbPassword);
            Controls.Add(gunaTbUserName);
            Controls.Add(lbUserName);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ChangeInfo";
            Text = "Đổi thông tin cá nhân";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserName;
        private Guna2TextBox gunaTbUserName;
        private Label lbPassword;
        private Guna2TextBox gunaTbPassword;
        private Guna2Button gunaBtSave;
    }
}
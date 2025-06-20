using Guna.UI2.WinForms;

namespace StudentDashboard.GUI
{
    partial class ChangePassword
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
            lbPassword = new Label();
            gunaTbPassword = new Guna2TextBox();
            lbNewPassword = new Label();
            gunaTbNewPassword = new Guna2TextBox();
            lbConfirmPassword = new Label();
            gunaTbConfirmPassword = new Guna2TextBox();
            gunaBtSave = new Guna2Button();
            SuspendLayout();
            // 
            // label width và vị trí
            int labelWidth = 250;
            int labelX = 110;
            int textboxX = labelX + labelWidth + 20;
            int textboxWidth = 270;
            int rowHeight = 60;
            int startY = 110;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = false;
            lbPassword.TextAlign = ContentAlignment.MiddleRight;
            lbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPassword.ForeColor = Color.FromArgb(60, 130, 246);
            lbPassword.Location = new Point(labelX, startY);
            lbPassword.Size = new Size(labelWidth, 38);
            lbPassword.Name = "lbPassword";
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Mật khẩu hiện tại:";
            // 
            // gunaTbPassword
            // 
            gunaTbPassword.BorderRadius = 10;
            gunaTbPassword.BorderColor = Color.FromArgb(200, 220, 255);
            gunaTbPassword.FillColor = Color.FromArgb(245, 247, 250);
            gunaTbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gunaTbPassword.ForeColor = Color.FromArgb(60, 60, 60);
            gunaTbPassword.Location = new Point(textboxX, startY);
            gunaTbPassword.Size = new Size(textboxWidth, 38);
            gunaTbPassword.TabIndex = 1;
            gunaTbPassword.PasswordChar = '*';
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = false;
            lbNewPassword.TextAlign = ContentAlignment.MiddleRight;
            lbNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNewPassword.ForeColor = Color.FromArgb(60, 130, 246);
            lbNewPassword.Location = new Point(labelX, startY + rowHeight);
            lbNewPassword.Size = new Size(labelWidth, 38);
            lbNewPassword.Name = "lbNewPassword";
            lbNewPassword.TabIndex = 2;
            lbNewPassword.Text = "Mật khẩu mới:";
            // 
            // gunaTbNewPassword
            // 
            gunaTbNewPassword.BorderRadius = 10;
            gunaTbNewPassword.BorderColor = Color.FromArgb(200, 220, 255);
            gunaTbNewPassword.FillColor = Color.FromArgb(245, 247, 250);
            gunaTbNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gunaTbNewPassword.ForeColor = Color.FromArgb(60, 60, 60);
            gunaTbNewPassword.Location = new Point(textboxX, startY + rowHeight);
            gunaTbNewPassword.Size = new Size(textboxWidth, 38);
            gunaTbNewPassword.TabIndex = 3;
            gunaTbNewPassword.PasswordChar = '*';
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.AutoSize = false;
            lbConfirmPassword.TextAlign = ContentAlignment.MiddleRight;
            lbConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbConfirmPassword.ForeColor = Color.FromArgb(60, 130, 246);
            lbConfirmPassword.Location = new Point(labelX, startY + rowHeight * 2);
            lbConfirmPassword.Size = new Size(labelWidth, 38);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.TabIndex = 4;
            lbConfirmPassword.Text = "Xác nhận mật khẩu mới:";
            // 
            // gunaTbConfirmPassword
            // 
            gunaTbConfirmPassword.BorderRadius = 10;
            gunaTbConfirmPassword.BorderColor = Color.FromArgb(200, 220, 255);
            gunaTbConfirmPassword.FillColor = Color.FromArgb(245, 247, 250);
            gunaTbConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gunaTbConfirmPassword.ForeColor = Color.FromArgb(60, 60, 60);
            gunaTbConfirmPassword.Location = new Point(textboxX, startY + rowHeight * 2);
            gunaTbConfirmPassword.Size = new Size(textboxWidth, 38);
            gunaTbConfirmPassword.TabIndex = 5;
            gunaTbConfirmPassword.PasswordChar = '*';
            // 
            // gunaBtSave
            // 
            gunaBtSave.BorderRadius = 15;
            gunaBtSave.FillColor = Color.FromArgb(60, 130, 246);
            gunaBtSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gunaBtSave.ForeColor = Color.White;
            gunaBtSave.Location = new Point((848-180)/2, startY + rowHeight * 3 + 50);
            gunaBtSave.Name = "gunaBtSave";
            gunaBtSave.Size = new Size(180, 45);
            gunaBtSave.TabIndex = 6;
            gunaBtSave.Text = "Lưu";
            gunaBtSave.Click += btSave_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 240, 255);
            ClientSize = new Size(848, 520);
            Controls.Add(gunaBtSave);
            Controls.Add(gunaTbConfirmPassword);
            Controls.Add(lbConfirmPassword);
            Controls.Add(gunaTbNewPassword);
            Controls.Add(lbNewPassword);
            Controls.Add(gunaTbPassword);
            Controls.Add(lbPassword);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ChangePassword";
            Text = "Đổi mật khẩu";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPassword;
        private Guna2TextBox gunaTbPassword;
        private Label lbNewPassword;
        private Guna2TextBox gunaTbNewPassword;
        private Label lbConfirmPassword;
        private Guna2TextBox gunaTbConfirmPassword;
        private Guna2Button gunaBtSave;
    }
}
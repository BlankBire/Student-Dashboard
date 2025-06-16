using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

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
            lblTitle = new Label();
            lblUserName = new Label();
            lblEmail = new Label();
            lblCreateAt = new Label();
            tbUserName = new Guna2TextBox();
            tbEmail = new Guna2TextBox();
            tbCreateAT = new Guna2TextBox();
            btLogout = new Guna2Button();
            btChangePassword = new Guna2Button();
            btChangeInfo = new Guna2Button();
            btHome = new Guna2Button();
            iconUser = new PictureBox();
            iconMail = new PictureBox();
            iconCalendar = new PictureBox();
            SuspendLayout();

            int formWidth = 1224;
            int formHeight = 659;
            int groupWidth = 500;
            int leftX = (formWidth - groupWidth) / 2;
            int blockHeight = 70; // icon+label+textbox
            int blockSpacing = 35;
            int numBlocks = 3;
            int totalInfoHeight = numBlocks * blockHeight + (numBlocks - 1) * blockSpacing;
            int topY = (formHeight - totalInfoHeight - 120) / 2; // 120 là title + nút

            // btHome (icon home, góc phải, căn giữa icon)
            btHome.Text = "";
            btHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btHome.FillColor = Color.FromArgb(60, 130, 246);
            btHome.BorderRadius = 18;
            btHome.ForeColor = Color.White;
            btHome.Size = new Size(48, 48);
            btHome.Location = new Point(formWidth - 70, 24);
            btHome.Image = Image.FromFile("resources/icons8-home-24.png");
            btHome.ImageAlign = HorizontalAlignment.Center;
            btHome.ImageSize = new Size(28, 28);
            btHome.HoverState.FillColor = Color.FromArgb(80, 150, 255);
            btHome.HoverState.ForeColor = Color.White;
            btHome.Click += btHome_Click;

            // lblTitle
            lblTitle.Text = "Thông tin tài khoản";
            lblTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(94, 148, 255);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(leftX + (groupWidth - lblTitle.PreferredWidth) / 2, topY - 70);

            // Block 1: UserName
            int block1Y = topY + 60;
            iconUser.Image = Image.FromFile("resources/person.png");
            iconUser.SizeMode = PictureBoxSizeMode.Zoom;
            iconUser.Size = new Size(24, 24);
            iconUser.Location = new Point(leftX, block1Y);
            lblUserName.Text = "Tên đăng nhập";
            lblUserName.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblUserName.ForeColor = Color.FromArgb(60, 130, 246);
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(leftX + 32, block1Y + 2);
            tbUserName.Font = new Font("Segoe UI", 11F);
            tbUserName.PlaceholderText = "";
            tbUserName.ReadOnly = true;
            tbUserName.BorderRadius = 10;
            tbUserName.BorderColor = Color.FromArgb(200, 220, 255);
            tbUserName.FillColor = Color.FromArgb(245, 247, 250);
            tbUserName.Location = new Point(leftX, block1Y + 28);
            tbUserName.Size = new Size(groupWidth, 38);

            // Block 2: Email
            int block2Y = block1Y + blockHeight + blockSpacing;
            iconMail.Image = Image.FromFile("resources/mail.png");
            iconMail.SizeMode = PictureBoxSizeMode.Zoom;
            iconMail.Size = new Size(24, 24);
            iconMail.Location = new Point(leftX, block2Y);
            lblEmail.Text = "Email";
            lblEmail.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(60, 130, 246);
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(leftX + 32, block2Y + 2);
            tbEmail.Font = new Font("Segoe UI", 11F);
            tbEmail.PlaceholderText = "";
            tbEmail.ReadOnly = true;
            tbEmail.BorderRadius = 10;
            tbEmail.BorderColor = Color.FromArgb(200, 220, 255);
            tbEmail.FillColor = Color.FromArgb(245, 247, 250);
            tbEmail.Location = new Point(leftX, block2Y + 28);
            tbEmail.Size = new Size(groupWidth, 38);

            // Block 3: CreateAt
            int block3Y = block2Y + blockHeight + blockSpacing;
            iconCalendar.Image = Image.FromFile("resources/calendar.png");
            iconCalendar.SizeMode = PictureBoxSizeMode.Zoom;
            iconCalendar.Size = new Size(24, 24);
            iconCalendar.Location = new Point(leftX, block3Y);
            lblCreateAt.Text = "Ngày tạo tài khoản";
            lblCreateAt.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblCreateAt.ForeColor = Color.FromArgb(60, 130, 246);
            lblCreateAt.AutoSize = true;
            lblCreateAt.Location = new Point(leftX + 32, block3Y + 2);
            tbCreateAT.Font = new Font("Segoe UI", 11F);
            tbCreateAT.PlaceholderText = "";
            tbCreateAT.ReadOnly = true;
            tbCreateAT.BorderRadius = 10;
            tbCreateAT.BorderColor = Color.FromArgb(200, 220, 255);
            tbCreateAT.FillColor = Color.FromArgb(245, 247, 250);
            tbCreateAT.Location = new Point(leftX, block3Y + 28);
            tbCreateAT.Size = new Size(groupWidth, 38);

            // Các nút căn giữa, ngay dưới cụm thông tin
            int buttonWidth = 160;
            int buttonHeight = 38;
            int buttonSpacing = 40;
            int totalButtonWidth = buttonWidth * 3 + buttonSpacing * 2;
            int buttonStartX = leftX + (groupWidth - totalButtonWidth) / 2;
            int buttonY = block3Y + blockHeight + 40;

            btChangeInfo.Text = "Đổi thông tin cá nhân";
            btChangeInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btChangeInfo.FillColor = Color.FromArgb(94, 148, 255);
            btChangeInfo.BorderRadius = 8;
            btChangeInfo.ForeColor = Color.White;
            btChangeInfo.Size = new Size(buttonWidth, buttonHeight);
            btChangeInfo.Location = new Point(buttonStartX, buttonY);
            btChangeInfo.Click += btChangeInfo_Click;

            btChangePassword.Text = "Đổi mật khẩu";
            btChangePassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btChangePassword.FillColor = Color.FromArgb(94, 148, 255);
            btChangePassword.BorderRadius = 8;
            btChangePassword.ForeColor = Color.White;
            btChangePassword.Size = new Size(buttonWidth, buttonHeight);
            btChangePassword.Location = new Point(buttonStartX + buttonWidth + buttonSpacing, buttonY);
            btChangePassword.Click += btChangePassword_Click;

            btLogout.Text = "Đăng xuất";
            btLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btLogout.FillColor = Color.FromArgb(220, 38, 38);
            btLogout.BorderRadius = 8;
            btLogout.ForeColor = Color.White;
            btLogout.Size = new Size(buttonWidth, buttonHeight);
            btLogout.Location = new Point(buttonStartX + (buttonWidth + buttonSpacing) * 2, buttonY);
            btLogout.Click += btLogout_Click;

            // AccountInfo
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 240, 255);
            ClientSize = new Size(1224, 659);
            Controls.Add(btHome);
            Controls.Add(lblTitle);
            Controls.Add(iconUser);
            Controls.Add(lblUserName);
            Controls.Add(tbUserName);
            Controls.Add(iconMail);
            Controls.Add(lblEmail);
            Controls.Add(tbEmail);
            Controls.Add(iconCalendar);
            Controls.Add(lblCreateAt);
            Controls.Add(tbCreateAT);
            Controls.Add(btChangeInfo);
            Controls.Add(btChangePassword);
            Controls.Add(btLogout);
            Name = "AccountInfo";
            Text = "Thông tin tài khoản";
            Load += AccountInfo_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        private Label lblUserName;
        private Label lblEmail;
        private Label lblCreateAt;
        private Guna2TextBox tbUserName;
        private Guna2TextBox tbEmail;
        private Guna2TextBox tbCreateAT;
        private Guna2Button btLogout;
        private Guna2Button btChangePassword;
        private Guna2Button btChangeInfo;
        private Guna2Button btHome;
        private PictureBox iconUser;
        private PictureBox iconMail;
        private PictureBox iconCalendar;
    }
}
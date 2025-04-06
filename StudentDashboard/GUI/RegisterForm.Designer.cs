namespace StudentDashboard.GUI
{
    partial class RegisterForm
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
            tbUserName = new TextBox();
            lbEmail = new Label();
            tbEmail = new TextBox();
            lbPassword = new Label();
            tbPassword = new TextBox();
            lbTitle = new Label();
            btRegister = new Button();
            btBack = new Button();
            lbConfirmPassword = new Label();
            tbConfirmPassword = new TextBox();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbUserName.Location = new Point(532, 309);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(212, 40);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "Tên đăng nhập:";
            lbUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(734, 315);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(659, 31);
            tbUserName.TabIndex = 1;
            // 
            // lbEmail
            // 
            lbEmail.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbEmail.Location = new Point(634, 443);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(94, 38);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email:";
            lbEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(734, 448);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(659, 31);
            tbEmail.TabIndex = 3;
            // 
            // lbPassword
            // 
            lbPassword.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbPassword.Location = new Point(595, 594);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(133, 38);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Mật khẩu:";
            lbPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(734, 599);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(659, 31);
            tbPassword.TabIndex = 5;
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbTitle.Location = new Point(734, 126);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(386, 57);
            lbTitle.TabIndex = 6;
            lbTitle.Text = "Đăng kí tài khoản";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btRegister
            // 
            btRegister.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btRegister.Location = new Point(634, 931);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(208, 76);
            btRegister.TabIndex = 7;
            btRegister.Text = "Đăng kí";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += btRegister_Click;
            // 
            // btBack
            // 
            btBack.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btBack.Location = new Point(1062, 931);
            btBack.Name = "btBack";
            btBack.Size = new Size(208, 76);
            btBack.TabIndex = 8;
            btBack.Text = "Quay lại";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbConfirmPassword.Location = new Point(499, 759);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.Size = new Size(229, 38);
            lbConfirmPassword.TabIndex = 9;
            lbConfirmPassword.Text = "Nhập lại mật khẩu:";
            lbConfirmPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(734, 764);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(659, 31);
            tbConfirmPassword.TabIndex = 10;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1887, 1146);
            Controls.Add(tbConfirmPassword);
            Controls.Add(lbConfirmPassword);
            Controls.Add(btBack);
            Controls.Add(btRegister);
            Controls.Add(lbTitle);
            Controls.Add(tbPassword);
            Controls.Add(lbPassword);
            Controls.Add(tbEmail);
            Controls.Add(lbEmail);
            Controls.Add(tbUserName);
            Controls.Add(lbUserName);
            Name = "RegisterForm";
            Text = "Đăng kí";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserName;
        private TextBox tbUserName;
        private Label lbEmail;
        private TextBox tbEmail;
        private Label lbPassword;
        private TextBox tbPassword;
        private Label lbTitle;
        private Button btRegister;
        private Button btBack;
        private Label lbConfirmPassword;
        private TextBox tbConfirmPassword;
    }
}
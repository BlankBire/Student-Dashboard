namespace StudentDashboard.GUI
{
    partial class LoginForm
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
            lbTitle = new Label();
            lbUserName = new Label();
            tbUserName = new TextBox();
            lbPassword = new Label();
            tbPassword = new TextBox();
            btLogin = new Button();
            btBack = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbTitle.Location = new Point(658, 161);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(489, 62);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Đăng nhập tài khoản";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbUserName.Location = new Point(555, 435);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(193, 29);
            lbUserName.TabIndex = 1;
            lbUserName.Text = "Tên đăng nhập:";
            lbUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(754, 433);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(524, 31);
            tbUserName.TabIndex = 2;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbPassword.Location = new Point(623, 555);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(125, 29);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Mật khẩu:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(754, 553);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(524, 31);
            tbPassword.TabIndex = 4;
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btLogin.Location = new Point(563, 753);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(213, 91);
            btLogin.TabIndex = 5;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // btBack
            // 
            btBack.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btBack.Location = new Point(1207, 753);
            btBack.Name = "btBack";
            btBack.Size = new Size(213, 91);
            btBack.TabIndex = 6;
            btBack.Text = "Quay lại";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1895, 1146);
            Controls.Add(btBack);
            Controls.Add(btLogin);
            Controls.Add(tbPassword);
            Controls.Add(lbPassword);
            Controls.Add(tbUserName);
            Controls.Add(lbUserName);
            Controls.Add(lbTitle);
            Name = "LoginForm";
            Text = "Log in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbUserName;
        private TextBox tbUserName;
        private Label lbPassword;
        private TextBox tbPassword;
        private Button btLogin;
        private Button btBack;
    }
}
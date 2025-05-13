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
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            btLogin = new Button();
            btBack = new Button();
            pbAvatar = new PictureBox();
            pnUserName = new Panel();
            pnPassword = new Panel();
            pbUserName = new PictureBox();
            pbPassword = new PictureBox();
            lbYetAccount = new Label();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbTitle.ForeColor = Color.FromArgb(0, 117, 214);
            lbTitle.Location = new Point(248, 182);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(489, 62);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Đăng nhập";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbUserName
            // 
            tbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbUserName.ForeColor = Color.FromArgb(0, 117, 214);
            tbUserName.Location = new Point(347, 286);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(302, 39);
            tbUserName.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbPassword.ForeColor = Color.FromArgb(0, 117, 214);
            tbPassword.Location = new Point(347, 413);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(302, 39);
            tbPassword.TabIndex = 4;
            // 
            // btLogin
            // 
            btLogin.AllowDrop = true;
            btLogin.BackColor = SystemColors.Highlight;
            btLogin.FlatStyle = FlatStyle.Flat;
            btLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btLogin.ForeColor = Color.WhiteSmoke;
            btLogin.Location = new Point(318, 530);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(361, 44);
            btLogin.TabIndex = 5;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // btBack
            // 
            btBack.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btBack.Location = new Point(514, 646);
            btBack.Name = "btBack";
            btBack.Size = new Size(147, 42);
            btBack.TabIndex = 6;
            btBack.Text = "Quay lại";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // pbAvatar
            // 
            pbAvatar.BackColor = Color.Transparent;
            pbAvatar.Image = Properties.Resources.uit_logo1;
            pbAvatar.Location = new Point(399, 60);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(158, 97);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 15;
            pbAvatar.TabStop = false;
            // 
            // pnUserName
            // 
            pnUserName.BackColor = Color.RoyalBlue;
            pnUserName.Location = new Point(347, 324);
            pnUserName.Name = "pnUserName";
            pnUserName.Size = new Size(300, 1);
            pnUserName.TabIndex = 17;
            // 
            // pnPassword
            // 
            pnPassword.BackColor = Color.RoyalBlue;
            pnPassword.Location = new Point(347, 451);
            pnPassword.Name = "pnPassword";
            pnPassword.Size = new Size(300, 1);
            pnPassword.TabIndex = 18;
            // 
            // pbUserName
            // 
            pbUserName.Image = Properties.Resources.person;
            pbUserName.Location = new Point(307, 286);
            pbUserName.Name = "pbUserName";
            pbUserName.Size = new Size(25, 25);
            pbUserName.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUserName.TabIndex = 19;
            pbUserName.TabStop = false;
            // 
            // pbPassword
            // 
            pbPassword.Image = Properties.Resources.password;
            pbPassword.Location = new Point(307, 413);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(25, 25);
            pbPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPassword.TabIndex = 21;
            pbPassword.TabStop = false;
            // 
            // lbYetAccount
            // 
            lbYetAccount.AutoSize = true;
            lbYetAccount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbYetAccount.Location = new Point(338, 656);
            lbYetAccount.Name = "lbYetAccount";
            lbYetAccount.Size = new Size(163, 25);
            lbYetAccount.TabIndex = 22;
            lbYetAccount.Text = "Chưa có tài khoản?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 813);
            Controls.Add(lbYetAccount);
            Controls.Add(pbPassword);
            Controls.Add(pbUserName);
            Controls.Add(pnPassword);
            Controls.Add(pnUserName);
            Controls.Add(pbAvatar);
            Controls.Add(btBack);
            Controls.Add(btLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(lbTitle);
            Name = "LoginForm";
            Text = "Đăng nhập";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Button btLogin;
        private Button btBack;
        private PictureBox pbAvatar;
        private Panel pnUserName;
        private Panel pnPassword;
        private PictureBox pbUserName;
        private PictureBox pbPassword;
        private Label lbYetAccount;
    }
}
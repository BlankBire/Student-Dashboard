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
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbTitle.ForeColor = Color.FromArgb(0, 117, 214);
            lbTitle.Location = new Point(710, 187);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(393, 63);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Đăng nhập";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbUserName
            // 
            tbUserName.BorderStyle = BorderStyle.None;
            tbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbUserName.ForeColor = Color.DarkGray;
            tbUserName.Location = new Point(801, 293);
            tbUserName.Margin = new Padding(2, 3, 2, 3);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(243, 27);
            tbUserName.TabIndex = 2;
            tbUserName.Text = "Username";
            tbUserName.TextChanged += tbUserName_TextChanged;
            tbUserName.Enter += tbUserName_Enter;
            tbUserName.Leave += tbUserName_Leave;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbPassword.ForeColor = Color.DarkGray;
            tbPassword.Location = new Point(801, 396);
            tbPassword.Margin = new Padding(2, 3, 2, 3);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(251, 27);
            tbPassword.TabIndex = 4;
            tbPassword.Text = "Password";
            tbPassword.TextChanged += tbPassword_TextChanged;
            tbPassword.Enter += tbPassword_Enter;
            tbPassword.Leave += tbPassword_Leave;
            // 
            // btLogin
            // 
            btLogin.AllowDrop = true;
            btLogin.BackColor = SystemColors.Highlight;
            btLogin.FlatStyle = FlatStyle.Flat;
            btLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btLogin.ForeColor = Color.WhiteSmoke;
            btLogin.Location = new Point(773, 495);
            btLogin.Margin = new Padding(2, 3, 2, 3);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(298, 52);
            btLogin.TabIndex = 5;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // btBack
            // 
            btBack.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btBack.Location = new Point(935, 587);
            btBack.Margin = new Padding(2, 3, 2, 3);
            btBack.Name = "btBack";
            btBack.Size = new Size(126, 37);
            btBack.TabIndex = 6;
            btBack.Text = "Quay lại";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // pbAvatar
            // 
            pbAvatar.BackColor = Color.Transparent;
            pbAvatar.Image = Properties.Resources.uit_logo1;
            pbAvatar.Location = new Point(840, 56);
            pbAvatar.Margin = new Padding(2, 3, 2, 3);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(159, 105);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 15;
            pbAvatar.TabStop = false;
            // 
            // pnUserName
            // 
            pnUserName.BackColor = Color.RoyalBlue;
            pnUserName.Location = new Point(801, 328);
            pnUserName.Margin = new Padding(2, 3, 2, 3);
            pnUserName.Name = "pnUserName";
            pnUserName.Size = new Size(240, 1);
            pnUserName.TabIndex = 17;
            // 
            // pnPassword
            // 
            pnPassword.BackColor = Color.RoyalBlue;
            pnPassword.Location = new Point(801, 431);
            pnPassword.Margin = new Padding(2, 3, 2, 3);
            pnPassword.Name = "pnPassword";
            pnPassword.Size = new Size(240, 1);
            pnPassword.TabIndex = 18;
            // 
            // pbUserName
            // 
            pbUserName.Image = Properties.Resources.person;
            pbUserName.Location = new Point(761, 296);
            pbUserName.Margin = new Padding(2, 3, 2, 3);
            pbUserName.Name = "pbUserName";
            pbUserName.Size = new Size(29, 33);
            pbUserName.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUserName.TabIndex = 19;
            pbUserName.TabStop = false;
            // 
            // pbPassword
            // 
            pbPassword.Image = Properties.Resources.password;
            pbPassword.Location = new Point(761, 399);
            pbPassword.Margin = new Padding(2, 3, 2, 3);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(29, 33);
            pbPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPassword.TabIndex = 21;
            pbPassword.TabStop = false;
            // 
            // lbYetAccount
            // 
            lbYetAccount.AutoSize = true;
            lbYetAccount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbYetAccount.Location = new Point(794, 595);
            lbYetAccount.Margin = new Padding(2, 0, 2, 0);
            lbYetAccount.Name = "lbYetAccount";
            lbYetAccount.Size = new Size(135, 20);
            lbYetAccount.TabIndex = 22;
            lbYetAccount.Text = "Chưa có tài khoản?";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.welcome;
            pictureBox2.Location = new Point(-5, -431);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(691, 1697);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1157, 879);
            Controls.Add(pictureBox2);
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
            Margin = new Padding(2, 3, 2, 3);
            Name = "LoginForm";
            Text = "Đăng nhập";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
    }
}
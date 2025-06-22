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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            tbUserName = new TextBox();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            lbTitle = new Label();
            btRegister = new Button();
            btBack = new Button();
            tbConfirmPassword = new TextBox();
            lbAlreadyAccount = new Label();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            pbAvatar = new PictureBox();
            pbUserName = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pbPassword = new PictureBox();
            pbEmail = new PictureBox();
            pbConfirmPassword = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tbUserName
            // 
            tbUserName.BorderStyle = BorderStyle.None;
            tbUserName.Font = new Font("Segoe UI", 13F);
            tbUserName.ForeColor = Color.DarkGray;
            tbUserName.Location = new Point(681, 221);
            tbUserName.Margin = new Padding(2);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(302, 29);
            tbUserName.TabIndex = 1;
            tbUserName.Text = " Username ";
            tbUserName.TextChanged += tbUserName_TextChanged;
            tbUserName.Enter += tbUserName_Enter;
            tbUserName.Leave += tbUserName_Leave;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Segoe UI", 13F);
            tbEmail.ForeColor = Color.DarkGray;
            tbEmail.Location = new Point(683, 299);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(298, 29);
            tbEmail.TabIndex = 3;
            tbEmail.Text = "Email ";
            tbEmail.TextChanged += tbEmail_TextChanged;
            tbEmail.Enter += tbEmail_Enter;
            tbEmail.Leave += tbEmail_Leave;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 13F);
            tbPassword.ForeColor = Color.DarkGray;
            tbPassword.Location = new Point(683, 379);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(302, 29);
            tbPassword.TabIndex = 5;
            tbPassword.Text = "Password";
            tbPassword.TextChanged += tbPassword_TextChanged_1;
            tbPassword.Enter += tbPassword_Enter;
            tbPassword.Leave += tbPassword_Leave;
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.FromArgb(0, 117, 214);
            lbTitle.Location = new Point(695, 136);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.RightToLeft = RightToLeft.Yes;
            lbTitle.Size = new Size(265, 67);
            lbTitle.TabIndex = 6;
            lbTitle.Text = "Đăng kí";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            lbTitle.Click += lbTitle_Click;
            // 
            // btRegister
            // 
            btRegister.AllowDrop = true;
            btRegister.BackColor = SystemColors.Highlight;
            btRegister.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btRegister.FlatAppearance.BorderSize = 0;
            btRegister.FlatStyle = FlatStyle.Flat;
            btRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btRegister.ForeColor = Color.WhiteSmoke;
            btRegister.Location = new Point(642, 549);
            btRegister.Margin = new Padding(2);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(361, 44);
            btRegister.TabIndex = 7;
            btRegister.Text = "Đăng kí";
            btRegister.UseMnemonic = false;
            btRegister.UseVisualStyleBackColor = false;
            btRegister.Click += btRegister_Click;
            // 
            // btBack
            // 
            btBack.BackColor = SystemColors.HighlightText;
            btBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btBack.Location = new Point(860, 609);
            btBack.Margin = new Padding(2);
            btBack.Name = "btBack";
            btBack.Size = new Size(143, 39);
            btBack.TabIndex = 8;
            btBack.Text = "Quay lại";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.BorderStyle = BorderStyle.None;
            tbConfirmPassword.Font = new Font("Segoe UI", 13F);
            tbConfirmPassword.ForeColor = Color.DarkGray;
            tbConfirmPassword.Location = new Point(681, 465);
            tbConfirmPassword.Margin = new Padding(2);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(302, 29);
            tbConfirmPassword.TabIndex = 10;
            tbConfirmPassword.Text = "Confirm Password";
            tbConfirmPassword.TextChanged += tbConfirmPassword_TextChanged;
            tbConfirmPassword.Enter += tbConfirmPassword_Enter;
            tbConfirmPassword.Leave += tbConfirmPassword_Leave;
            // 
            // lbAlreadyAccount
            // 
            lbAlreadyAccount.AutoSize = true;
            lbAlreadyAccount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAlreadyAccount.Location = new Point(287, 699);
            lbAlreadyAccount.Name = "lbAlreadyAccount";
            lbAlreadyAccount.Size = new Size(120, 20);
            lbAlreadyAccount.TabIndex = 11;
            lbAlreadyAccount.Text = "Đã có tài khoản?";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(0, 0);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(55, 60);
            guna2CirclePictureBox1.TabIndex = 12;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // pbAvatar
            // 
            pbAvatar.Image = Properties.Resources.uit_logo1;
            pbAvatar.Location = new Point(748, 24);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(158, 97);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 14;
            pbAvatar.TabStop = false;
            pbAvatar.Click += pictureBox1_Click_1;
            // 
            // pbUserName
            // 
            pbUserName.Image = Properties.Resources.person;
            pbUserName.Location = new Point(642, 221);
            pbUserName.Name = "pbUserName";
            pbUserName.Size = new Size(25, 25);
            pbUserName.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUserName.TabIndex = 15;
            pbUserName.TabStop = false;
            pbUserName.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Location = new Point(683, 251);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(683, 332);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 1);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Location = new Point(681, 418);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 1);
            panel3.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.Location = new Point(681, 503);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 1);
            panel4.TabIndex = 19;
            // 
            // pbPassword
            // 
            pbPassword.Image = Properties.Resources.password;
            pbPassword.Location = new Point(642, 379);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(25, 25);
            pbPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPassword.TabIndex = 20;
            pbPassword.TabStop = false;
            // 
            // pbEmail
            // 
            pbEmail.Image = (Image)resources.GetObject("pbEmail.Image");
            pbEmail.Location = new Point(642, 299);
            pbEmail.Name = "pbEmail";
            pbEmail.Size = new Size(25, 25);
            pbEmail.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEmail.TabIndex = 21;
            pbEmail.TabStop = false;
            // 
            // pbConfirmPassword
            // 
            pbConfirmPassword.Image = Properties.Resources.password;
            pbConfirmPassword.Location = new Point(642, 464);
            pbConfirmPassword.Name = "pbConfirmPassword";
            pbConfirmPassword.Size = new Size(25, 25);
            pbConfirmPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pbConfirmPassword.TabIndex = 22;
            pbConfirmPassword.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.welcome;
            pictureBox2.Location = new Point(0, -281);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(605, 1273);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1128, 761);
            Controls.Add(pictureBox2);
            Controls.Add(pbConfirmPassword);
            Controls.Add(pbEmail);
            Controls.Add(pbPassword);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pbUserName);
            Controls.Add(pbAvatar);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(lbAlreadyAccount);
            Controls.Add(tbConfirmPassword);
            Controls.Add(btBack);
            Controls.Add(btRegister);
            Controls.Add(lbTitle);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(tbUserName);
            Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            Name = "RegisterForm";
            Text = "Đăng kí";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbUserName;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Label lbTitle;
        private Button btRegister;
        private Button btBack;
        private TextBox tbConfirmPassword;
        private Label lbAlreadyAccount;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private PictureBox pbAvatar;
        private PictureBox pbUserName;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pbPassword;
        private PictureBox pbEmail;
        private PictureBox pbConfirmPassword;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
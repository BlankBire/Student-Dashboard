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
            label1 = new Label();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // tbUserName
            // 
            tbUserName.BorderStyle = BorderStyle.None;
            tbUserName.Font = new Font("Segoe UI", 13F);
            tbUserName.ForeColor = Color.FromArgb(0, 117, 214);
            tbUserName.Location = new Point(137, 237);
            tbUserName.Margin = new Padding(2);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(302, 24);
            tbUserName.TabIndex = 1;
            tbUserName.TextChanged += tbUserName_TextChanged;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Segoe UI", 13F);
            tbEmail.ForeColor = Color.FromArgb(0, 117, 214);
            tbEmail.Location = new Point(137, 315);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(298, 24);
            tbEmail.TabIndex = 3;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 15F);
            tbPassword.ForeColor = Color.FromArgb(0, 117, 214);
            tbPassword.Location = new Point(135, 395);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(302, 27);
            tbPassword.TabIndex = 5;
            tbPassword.TextChanged += tbPassword_TextChanged_1;
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.FromArgb(0, 117, 214);
            lbTitle.Location = new Point(136, 152);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.RightToLeft = RightToLeft.Yes;
            lbTitle.Size = new Size(237, 54);
            lbTitle.TabIndex = 6;
            lbTitle.Text = "Đăng ký ";
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
            btRegister.Location = new Point(88, 513);
            btRegister.Margin = new Padding(2);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(361, 34);
            btRegister.TabIndex = 7;
            btRegister.Text = "Đăng kí";
            btRegister.UseMnemonic = false;
            btRegister.UseVisualStyleBackColor = false;
            btRegister.Click += btRegister_Click;
            // 
            // btBack
            // 
            btBack.BackColor = SystemColors.HighlightText;
            btBack.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btBack.Location = new Point(312, 566);
            btBack.Margin = new Padding(2);
            btBack.Name = "btBack";
            btBack.Size = new Size(123, 27);
            btBack.TabIndex = 8;
            btBack.Text = "Quay lại";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.BorderStyle = BorderStyle.None;
            tbConfirmPassword.Font = new Font("Segoe UI", 15F);
            tbConfirmPassword.ForeColor = Color.FromArgb(0, 117, 214);
            tbConfirmPassword.Location = new Point(137, 463);
            tbConfirmPassword.Margin = new Padding(2);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(302, 27);
            tbConfirmPassword.TabIndex = 10;
            tbConfirmPassword.TextChanged += tbConfirmPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 573);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 11;
            label1.Text = "Already have an account ?";
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.uit_logo1;
            pictureBox1.Location = new Point(182, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.person;
            pictureBox2.Location = new Point(88, 237);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Location = new Point(137, 267);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(135, 346);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 1);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Location = new Point(137, 426);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 1);
            panel3.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.Location = new Point(137, 493);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 1);
            panel4.TabIndex = 19;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password;
            pictureBox3.Location = new Point(88, 395);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(88, 315);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.password;
            pictureBox5.Location = new Point(88, 463);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(590, 705);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(label1);
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
            Text = "t";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private Label label1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
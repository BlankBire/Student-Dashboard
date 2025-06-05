namespace StudentDashboard.GUI
{
    partial class MainForm
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse();
            this.guna2BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BtnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabelTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBoxLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            // Thêm các control cho thanh điều hướng custom
            this.pnTitleBar = new Panel();
            this.lbFormTitle = new Label();
            this.btnMinimize = new Button();
            this.btnMaximize = new Button();
            this.btnClose = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxLogo)).BeginInit();
            this.pnTitleBar.SuspendLayout();
            this.SuspendLayout();

            // 
            // Thanh tiêu đề custom
            // 
            this.pnTitleBar.BackColor = Color.FromArgb(255, 245, 238);
            this.pnTitleBar.Controls.Add(this.btnClose);
            this.pnTitleBar.Controls.Add(this.btnMaximize);
            this.pnTitleBar.Controls.Add(this.btnMinimize);
            this.pnTitleBar.Controls.Add(this.lbFormTitle);
            this.pnTitleBar.Dock = DockStyle.Top;
            this.pnTitleBar.Location = new Point(0, 0);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new Size(1000, 40);
            this.pnTitleBar.TabIndex = 0;
            this.pnTitleBar.MouseDown += new MouseEventHandler(this.pnTitleBar_MouseDown);

            // 
            // Tiêu đề form
            // 
            this.lbFormTitle.AutoSize = true;
            //this.lbFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            //this.lbFormTitle.ForeColor = Color.White;
            this.lbFormTitle.Location = new Point(12, 10);
            this.lbFormTitle.Name = "lbFormTitle";
            this.lbFormTitle.Size = new Size(150, 21);
            this.lbFormTitle.TabIndex = 0;
            this.lbFormTitle.Text = "Student Dashboard";

            // 
            // Nút đóng
            // 
            this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnClose.BackColor = Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnClose.ForeColor = Color.Black;
            this.btnClose.Location = new Point(960, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(40, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // 
            // Nút phóng to/thu nhỏ
            // 
            this.btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnMaximize.BackColor = Color.Transparent;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            this.btnMaximize.FlatStyle = FlatStyle.Flat;
            this.btnMaximize.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnMaximize.ForeColor = Color.Black;
            this.btnMaximize.Location = new Point(920, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new Size(40, 40);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Text = "□";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new EventHandler(this.btnMaximize_Click);

            // 
            // Nút thu nhỏ
            // 
            this.btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnMinimize.BackColor = Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            this.btnMinimize.FlatStyle = FlatStyle.Flat;
            this.btnMinimize.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnMinimize.ForeColor = Color.Black;
            this.btnMinimize.Location = new Point(880, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new Size(40, 40);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "─";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new EventHandler(this.btnMinimize_Click);

            // 
            // guna2Elipse1 - Bo góc cho form
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;

            // 
            // Logo
            // 
            this.guna2CirclePictureBoxLogo.Image = Properties.Resources.uit_logo1;
            this.guna2CirclePictureBoxLogo.Location = new Point((this.ClientSize.Width - 120) / 2, 80);
            this.guna2CirclePictureBoxLogo.Size = new Size(120, 120);
            this.guna2CirclePictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBoxLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;

            // 
            // Tiêu đề chính
            // 
            this.guna2HtmlLabelTitle.BackColor = Color.Transparent;
            this.guna2HtmlLabelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.guna2HtmlLabelTitle.ForeColor = Color.FromArgb(0, 117, 214);
            this.guna2HtmlLabelTitle.Location = new Point((this.ClientSize.Width - 600) / 2, 220);
            this.guna2HtmlLabelTitle.Size = new Size(600, 60);
            this.guna2HtmlLabelTitle.Text = "Chào mừng bạn đến với Student Dashboard!";
            this.guna2HtmlLabelTitle.TextAlignment = ContentAlignment.MiddleCenter;

            // 
            // Nút đăng nhập
            // 
            this.guna2BtnLogin.BorderRadius = 20;
            this.guna2BtnLogin.FillColor = Color.FromArgb(0, 117, 214);
            this.guna2BtnLogin.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.guna2BtnLogin.ForeColor = Color.White;
            this.guna2BtnLogin.Size = new Size(320, 60);
            this.guna2BtnLogin.Location = new Point((this.ClientSize.Width - 320) / 2, 320);
            this.guna2BtnLogin.Text = "Đăng nhập";
            this.guna2BtnLogin.Click += new EventHandler(this.btLogin_Click);

            // 
            // Nút đăng ký
            // 
            this.guna2BtnRegister.BorderRadius = 20;
            this.guna2BtnRegister.FillColor = Color.LightGray;
            this.guna2BtnRegister.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.guna2BtnRegister.ForeColor = Color.FromArgb(0, 117, 214);
            this.guna2BtnRegister.Size = new Size(320, 60);
            this.guna2BtnRegister.Location = new Point((this.ClientSize.Width - 320) / 2, 400);
            this.guna2BtnRegister.Text = "Đăng ký";
            this.guna2BtnRegister.Click += new EventHandler(this.btRegister_Click);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1000, 650);
            this.Controls.Add(this.pnTitleBar);
            this.Controls.Add(this.guna2CirclePictureBoxLogo);
            this.Controls.Add(this.guna2HtmlLabelTitle);
            this.Controls.Add(this.guna2BtnLogin);
            this.Controls.Add(this.guna2BtnRegister);
            this.FormBorderStyle = FormBorderStyle.None; // Bỏ thanh tiêu đề mặc định
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Student Dashboard";

            this.pnTitleBar.ResumeLayout(false);
            this.pnTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Panel pnTitleBar;
        private Label lbFormTitle;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2BtnLogin;
        private Guna.UI2.WinForms.Guna2Button guna2BtnRegister;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelTitle;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxLogo;
    }
}
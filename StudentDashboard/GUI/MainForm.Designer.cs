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
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2CirclePictureBoxLogo
            // 
            this.guna2CirclePictureBoxLogo.Image = Properties.Resources.uit_logo1; // Đổi thành logo của bạn
            this.guna2CirclePictureBoxLogo.Location = new Point((this.ClientSize.Width - 120) / 2, 40);
            this.guna2CirclePictureBoxLogo.Size = new Size(120, 120);
            this.guna2CirclePictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBoxLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            // 
            // guna2HtmlLabelTitle
            // 
            this.guna2HtmlLabelTitle.BackColor = Color.Transparent;
            this.guna2HtmlLabelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            this.guna2HtmlLabelTitle.ForeColor = Color.FromArgb(0, 117, 214);
            this.guna2HtmlLabelTitle.Location = new Point((this.ClientSize.Width - 600) / 2, 180);
            this.guna2HtmlLabelTitle.Size = new Size(600, 60);
            this.guna2HtmlLabelTitle.Text = "Chào mừng bạn đến với Student Dashboard!";
            this.guna2HtmlLabelTitle.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2BtnLogin
            // 
            this.guna2BtnLogin.BorderRadius = 20;
            this.guna2BtnLogin.FillColor = Color.FromArgb(0, 117, 214);
            this.guna2BtnLogin.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            this.guna2BtnLogin.ForeColor = Color.White;
            this.guna2BtnLogin.Size = new Size(320, 60);
            this.guna2BtnLogin.Location = new Point((this.ClientSize.Width - 320) / 2, 280);
            this.guna2BtnLogin.Text = "Đăng nhập";
            this.guna2BtnLogin.Click += new EventHandler(this.btLogin_Click);
            // 
            // guna2BtnRegister
            // 
            this.guna2BtnRegister.BorderRadius = 20;
            this.guna2BtnRegister.FillColor = Color.LightGray;
            this.guna2BtnRegister.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            this.guna2BtnRegister.ForeColor = Color.FromArgb(0, 117, 214);
            this.guna2BtnRegister.Size = new Size(320, 60);
            this.guna2BtnRegister.Location = new Point((this.ClientSize.Width - 320) / 2, 360);
            this.guna2BtnRegister.Text = "Đăng ký";
            this.guna2BtnRegister.Click += new EventHandler(this.btRegister_Click);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1000, 650);
            this.Controls.Add(this.guna2CirclePictureBoxLogo);
            this.Controls.Add(this.guna2HtmlLabelTitle);
            this.Controls.Add(this.guna2BtnLogin);
            this.Controls.Add(this.guna2BtnRegister);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Name = "MainForm";
            //this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Student Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2BtnLogin;
        private Guna.UI2.WinForms.Guna2Button guna2BtnRegister;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelTitle;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxLogo;
    }
}
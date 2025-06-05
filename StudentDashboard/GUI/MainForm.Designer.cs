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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            guna2BtnRegister = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabelTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnTitleBar = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            lbFormTitle = new Label();
            pictureBox1 = new PictureBox();
            pnTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2BtnLogin
            // 
            guna2BtnLogin.BorderRadius = 20;
            guna2BtnLogin.CustomizableEdges = customizableEdges1;
            guna2BtnLogin.FillColor = Color.FromArgb(0, 117, 214);
            guna2BtnLogin.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            guna2BtnLogin.ForeColor = Color.White;
            guna2BtnLogin.Location = new Point(334, 333);
            guna2BtnLogin.Name = "guna2BtnLogin";
            guna2BtnLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2BtnLogin.Size = new Size(320, 60);
            guna2BtnLogin.TabIndex = 3;
            guna2BtnLogin.Text = "Đăng nhập";
            guna2BtnLogin.Click += btLogin_Click;
            guna2BtnLogin.Parent = pictureBox1;
            guna2BtnLogin.FillColor = Color.FromArgb(200, 0, 117, 214);
            guna2BtnLogin.ShadowDecoration.Enabled = false;
            guna2BtnLogin.BackColor = Color.Transparent;
            // 
            // guna2BtnRegister
            // 
            guna2BtnRegister.BorderRadius = 20;
            guna2BtnRegister.CustomizableEdges = customizableEdges3;
            guna2BtnRegister.FillColor = Color.LightGray;
            guna2BtnRegister.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            guna2BtnRegister.ForeColor = Color.FromArgb(0, 117, 214);
            guna2BtnRegister.Location = new Point(334, 478);
            guna2BtnRegister.Name = "guna2BtnRegister";
            guna2BtnRegister.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2BtnRegister.Size = new Size(320, 60);
            guna2BtnRegister.TabIndex = 4;
            guna2BtnRegister.Text = "Đăng ký";
            guna2BtnRegister.Click += btRegister_Click;
            guna2BtnRegister.Parent = pictureBox1;
            guna2BtnRegister.FillColor = Color.FromArgb(200, 255, 255, 255);
            guna2BtnRegister.ShadowDecoration.Enabled = false;
            guna2BtnRegister.BackColor = Color.Transparent;
            // 
            // guna2HtmlLabelTitle
            // 
            guna2HtmlLabelTitle.AutoSize = false;
            guna2HtmlLabelTitle.BackColor = Color.Transparent;
            guna2HtmlLabelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            guna2HtmlLabelTitle.ForeColor = Color.FromArgb(0, 117, 214);
            guna2HtmlLabelTitle.Location = new Point(16, 165);
            guna2HtmlLabelTitle.Name = "guna2HtmlLabelTitle";
            guna2HtmlLabelTitle.Size = new Size(981, 72);
            guna2HtmlLabelTitle.TabIndex = 2;
            guna2HtmlLabelTitle.Text = "Chào mừng bạn đến với Student Dashboard!";
            guna2HtmlLabelTitle.TextAlignment = ContentAlignment.MiddleCenter;
            guna2HtmlLabelTitle.Parent = pictureBox1;
            // 
            // pnTitleBar
            // 
            pnTitleBar.BackColor = Color.FromArgb(255, 245, 238);
            pnTitleBar.Controls.Add(btnClose);
            pnTitleBar.Controls.Add(btnMaximize);
            pnTitleBar.Controls.Add(btnMinimize);
            pnTitleBar.Controls.Add(lbFormTitle);
            pnTitleBar.Dock = DockStyle.Top;
            pnTitleBar.Location = new Point(0, 0);
            pnTitleBar.Name = "pnTitleBar";
            pnTitleBar.Size = new Size(1009, 40);
            pnTitleBar.TabIndex = 0;
            pnTitleBar.MouseDown += pnTitleBar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(969, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMaximize.ForeColor = Color.Black;
            btnMaximize.Location = new Point(929, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(40, 40);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "□";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.Black;
            btnMinimize.Location = new Point(889, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 40);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "─";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // lbFormTitle
            // 
            lbFormTitle.AutoSize = true;
            lbFormTitle.Location = new Point(12, 10);
            lbFormTitle.Name = "lbFormTitle";
            lbFormTitle.Size = new Size(166, 25);
            lbFormTitle.TabIndex = 0;
            lbFormTitle.Text = "Student Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1009, 640);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1009, 674);
            Controls.Add(pictureBox1);
            Controls.Add(pnTitleBar);
            //Controls.Add(guna2HtmlLabelTitle);
            //Controls.Add(guna2BtnLogin);
            //Controls.Add(guna2BtnRegister);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Dashboard";
            pnTitleBar.ResumeLayout(false);
            pnTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private PictureBox pictureBox1;
    }
}
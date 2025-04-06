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
            btLogin = new Button();
            btRegister = new Button();
            lbTitle = new Label();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btLogin.Location = new Point(762, 396);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(257, 85);
            btLogin.TabIndex = 1;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // btRegister
            // 
            btRegister.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btRegister.Location = new Point(762, 617);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(257, 85);
            btRegister.TabIndex = 2;
            btRegister.Text = "Đăng kí";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += btRegister_Click;
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbTitle.Location = new Point(425, 149);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(1028, 65);
            lbTitle.TabIndex = 3;
            lbTitle.Text = "Chào mừng bạn đến với Student Dashboard!";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1895, 1146);
            Controls.Add(lbTitle);
            Controls.Add(btRegister);
            Controls.Add(btLogin);
            Name = "MainForm";
            Text = "Student Dashboard";
            Load += MainForm_Load;
            ResumeLayout(false);
        } 

        #endregion
        private Button btLogin;
        private Button btRegister;
        private Label lbTitle;
    }
} 
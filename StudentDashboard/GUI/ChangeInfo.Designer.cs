namespace StudentDashboard.GUI
{
    partial class ChangeInfo
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
            lbPassword = new Label();
            tbPassword = new TextBox();
            btSave = new Button();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(195, 100);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(133, 25);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "Tên đăng nhập:";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(334, 97);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(225, 31);
            tbUserName.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(238, 206);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(90, 25);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Mật khẩu:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(334, 200);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(225, 31);
            tbPassword.TabIndex = 5;
            // 
            // btSave
            // 
            btSave.Location = new Point(306, 316);
            btSave.Name = "btSave";
            btSave.Size = new Size(112, 34);
            btSave.TabIndex = 6;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // ChangeInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 421);
            Controls.Add(btSave);
            Controls.Add(tbPassword);
            Controls.Add(lbPassword);
            Controls.Add(tbUserName);
            Controls.Add(lbUserName);
            Name = "ChangeInfo";
            Text = "Đổi thông tin cá nhân";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserName;
        private TextBox tbUserName;
        private Label lbPassword;
        private TextBox tbPassword;
        private Button btSave;
    }
}
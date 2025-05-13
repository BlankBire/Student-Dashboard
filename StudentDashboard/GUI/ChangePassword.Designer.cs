namespace StudentDashboard.GUI
{
    partial class ChangePassword
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
            lbPassword = new Label();
            tbPassword = new TextBox();
            lbNewPassword = new Label();
            tbNewPassword = new TextBox();
            lbConfirmPassword = new Label();
            tbConfirmPassword = new TextBox();
            btSave = new Button();
            SuspendLayout();
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(210, 131);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(152, 25);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Mật khẩu hiện tại:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(368, 128);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(199, 31);
            tbPassword.TabIndex = 1;
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.Location = new Point(236, 222);
            lbNewPassword.Name = "lbNewPassword";
            lbNewPassword.Size = new Size(126, 25);
            lbNewPassword.TabIndex = 2;
            lbNewPassword.Text = "Mật khẩu mới:";
            // 
            // tbNewPassword
            // 
            tbNewPassword.Location = new Point(368, 216);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Size = new Size(199, 31);
            tbNewPassword.TabIndex = 3;
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.AutoSize = true;
            lbConfirmPassword.Location = new Point(159, 315);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.Size = new Size(203, 25);
            lbConfirmPassword.TabIndex = 4;
            lbConfirmPassword.Text = "Xác nhận mật khẩu mới:";
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(368, 309);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(199, 31);
            tbConfirmPassword.TabIndex = 5;
            // 
            // btSave
            // 
            btSave.Location = new Point(337, 449);
            btSave.Name = "btSave";
            btSave.Size = new Size(112, 34);
            btSave.TabIndex = 6;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 598);
            Controls.Add(btSave);
            Controls.Add(tbConfirmPassword);
            Controls.Add(lbConfirmPassword);
            Controls.Add(tbNewPassword);
            Controls.Add(lbNewPassword);
            Controls.Add(tbPassword);
            Controls.Add(lbPassword);
            Name = "ChangePassword";
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPassword;
        private TextBox tbPassword;
        private Label lbNewPassword;
        private TextBox tbNewPassword;
        private Label lbConfirmPassword;
        private TextBox tbConfirmPassword;
        private Button btSave;
    }
}
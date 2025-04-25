namespace StudentDashboard.GUI
{
    partial class AccountInfo
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
            lbEmail = new Label();
            tbEmail = new TextBox();
            lbCreateAT = new Label();
            tbCreateAT = new TextBox();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbUserName.Location = new Point(607, 248);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(193, 29);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "Tên đăng nhập:";
            lbUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(806, 246);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(447, 31);
            tbUserName.TabIndex = 1;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbEmail.Location = new Point(716, 364);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(84, 29);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email:";
            lbEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(806, 364);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(447, 31);
            tbEmail.TabIndex = 3;
            // 
            // lbCreateAT
            // 
            lbCreateAT.AutoSize = true;
            lbCreateAT.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbCreateAT.Location = new Point(616, 493);
            lbCreateAT.Name = "lbCreateAT";
            lbCreateAT.Size = new Size(184, 29);
            lbCreateAT.TabIndex = 4;
            lbCreateAT.Text = "Ngày tham gia:";
            lbCreateAT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbCreateAT
            // 
            tbCreateAT.Location = new Point(806, 491);
            tbCreateAT.Name = "tbCreateAT";
            tbCreateAT.Size = new Size(447, 31);
            tbCreateAT.TabIndex = 5;
            // 
            // AccountInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1895, 1146);
            Controls.Add(tbCreateAT);
            Controls.Add(lbCreateAT);
            Controls.Add(tbEmail);
            Controls.Add(lbEmail);
            Controls.Add(tbUserName);
            Controls.Add(lbUserName);
            Name = "AccountInfo";
            Text = "Account info";
            Load += AccountInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserName;
        private TextBox tbUserName;
        private Label lbEmail;
        private TextBox tbEmail;
        private Label lbCreateAT;
        private TextBox tbCreateAT;
    }
}
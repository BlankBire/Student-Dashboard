namespace StudentDashboard.GUI
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSchedule;

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
            btnSchedule = new Button();
            btnChat = new Button();
            SuspendLayout();
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(34, 128);
            btnSchedule.Margin = new Padding(2, 2, 2, 2);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(160, 40);
            btnSchedule.TabIndex = 0;
            btnSchedule.Text = "Lập thời khóa biểu";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnChat
            // 
            btnChat.Location = new Point(34, 192);
            btnChat.Name = "btnChat";
            btnChat.Size = new Size(160, 37);
            btnChat.TabIndex = 1;
            btnChat.Text = "Chat";
            btnChat.UseVisualStyleBackColor = true;
            btnChat.Click += btnChat_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 844);
            Controls.Add(btnChat);
            Controls.Add(btnSchedule);
            Margin = new Padding(2, 2, 2, 2);
            Name = "HomePage";
            Text = "Trang chủ";
            Load += HomePage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnChat;
    }
}
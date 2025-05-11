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
            SuspendLayout();
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(42, 160);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(200, 50);
            btnSchedule.TabIndex = 0;
            btnSchedule.Text = "Lập thời khóa biểu";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1895, 1146);
            Controls.Add(btnSchedule);
            Name = "HomePage";
            Text = "Trang chủ";
            Load += HomePage_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
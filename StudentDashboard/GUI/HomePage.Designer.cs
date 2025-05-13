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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSchedule = new Button();
            btnChat = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btAccount = new Button();
            btHome = new Button();
            pictureBox2 = new PictureBox();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            panel3 = new Panel();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            panel4 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            textBox10 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            guna2GradientPanel1.SuspendLayout();
            guna2GradientPanel2.SuspendLayout();
            guna2GradientPanel3.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // btnSchedule
            // 
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Segoe UI", 12F);
            btnSchedule.ForeColor = SystemColors.Desktop;
            btnSchedule.Image = Properties.Resources.icons8_schedule_24;
            btnSchedule.Location = new Point(-119, 140);
            btnSchedule.Margin = new Padding(2);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(286, 67);
            btnSchedule.TabIndex = 0;
            btnSchedule.Text = "                                   Thời khóa biểu";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnChat
            // 
            btnChat.FlatAppearance.BorderSize = 0;
            btnChat.FlatStyle = FlatStyle.Flat;
            btnChat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnChat.ForeColor = SystemColors.Desktop;
            btnChat.Image = Properties.Resources.icons8_chat_24;
            btnChat.Location = new Point(-86, 85);
            btnChat.Margin = new Padding(3, 2, 3, 2);
            btnChat.Name = "btnChat";
            btnChat.Size = new Size(249, 33);
            btnChat.TabIndex = 1;
            btnChat.Text = "                  Chat";
            btnChat.UseVisualStyleBackColor = true;
            btnChat.Click += btnChat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btHome);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btAccount);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Snow;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 67);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnSchedule);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnChat);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.MintCream;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(169, 597);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.uit_logo1;
            pictureBox1.Location = new Point(-2, -44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.Desktop;
            button1.Image = Properties.Resources.icons8_home_24;
            button1.Location = new Point(-92, 14);
            button1.Name = "button1";
            button1.Size = new Size(255, 38);
            button1.TabIndex = 5;
            button1.Text = "                            Trang chủ ";
            button1.UseVisualStyleBackColor = true;
            // 
            // btAccount
            // 
            btAccount.FlatAppearance.BorderSize = 0;
            btAccount.FlatStyle = FlatStyle.Flat;
            btAccount.ForeColor = Color.Black;
            btAccount.Image = Properties.Resources.icons8_account_24;
            btAccount.Location = new Point(1124, 35);
            btAccount.Margin = new Padding(2);
            btAccount.Name = "btAccount";
            btAccount.Size = new Size(84, 32);
            btAccount.TabIndex = 4;
            btAccount.UseVisualStyleBackColor = true;
            // 
            // btHome
            // 
            btHome.FlatAppearance.BorderSize = 0;
            btHome.FlatStyle = FlatStyle.Flat;
            btHome.ForeColor = Color.Black;
            btHome.Location = new Point(965, 35);
            btHome.Margin = new Padding(2);
            btHome.Name = "btHome";
            btHome.Size = new Size(137, 32);
            btHome.TabIndex = 4;
            btHome.Text = "Home";
            btHome.UseVisualStyleBackColor = true;
            btHome.Click += btHome_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_notification_24;
            pictureBox2.Location = new Point(1107, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel3
            // 
            panel3.Controls.Add(guna2GradientPanel3);
            panel3.Controls.Add(guna2GradientPanel2);
            panel3.Controls.Add(guna2GradientPanel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(169, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(1062, 241);
            panel3.TabIndex = 6;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BorderRadius = 20;
            guna2GradientPanel1.Controls.Add(textBox3);
            guna2GradientPanel1.Controls.Add(textBox2);
            guna2GradientPanel1.Controls.Add(textBox1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges13;
            guna2GradientPanel1.FillColor = Color.FromArgb(64, 169, 190);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(64, 169, 190);
            guna2GradientPanel1.Location = new Point(25, 30);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2GradientPanel1.Size = new Size(309, 183);
            guna2GradientPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 169, 190);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sitka Banner", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.MenuBar;
            textBox1.Location = new Point(3, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 51);
            textBox1.TabIndex = 0;
            textBox1.Text = "NEW MESSAGES";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(64, 169, 190);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Sitka Banner", 45F);
            textBox2.ForeColor = SystemColors.MenuBar;
            textBox2.Location = new Point(0, 70);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(123, 102);
            textBox2.TabIndex = 7;
            textBox2.Text = "20";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(64, 169, 190);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Sitka Banner", 15F);
            textBox3.ForeColor = SystemColors.MenuBar;
            textBox3.Location = new Point(114, 95);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 62);
            textBox3.TabIndex = 8;
            textBox3.Text = "Bạn có 20 tin nhắn chưa đọc";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // guna2GradientPanel2
            // 
            guna2GradientPanel2.BorderRadius = 20;
            guna2GradientPanel2.Controls.Add(textBox4);
            guna2GradientPanel2.Controls.Add(textBox5);
            guna2GradientPanel2.Controls.Add(textBox6);
            guna2GradientPanel2.CustomizableEdges = customizableEdges15;
            guna2GradientPanel2.FillColor = Color.FromArgb(64, 169, 190);
            guna2GradientPanel2.FillColor2 = Color.FromArgb(64, 169, 190);
            guna2GradientPanel2.Location = new Point(372, 30);
            guna2GradientPanel2.Name = "guna2GradientPanel2";
            guna2GradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2GradientPanel2.Size = new Size(302, 183);
            guna2GradientPanel2.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(64, 169, 190);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Sitka Banner", 15F);
            textBox4.ForeColor = SystemColors.MenuBar;
            textBox4.Location = new Point(108, 95);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 62);
            textBox4.TabIndex = 8;
            textBox4.Text = "2 blogs đang chờ bạn khám phá!";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(64, 169, 190);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Sitka Banner", 45F);
            textBox5.ForeColor = SystemColors.MenuBar;
            textBox5.Location = new Point(0, 70);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(123, 102);
            textBox5.TabIndex = 7;
            textBox5.Text = "2";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(64, 169, 190);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Sitka Banner", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.ForeColor = SystemColors.MenuBar;
            textBox6.Location = new Point(3, 13);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(317, 51);
            textBox6.TabIndex = 0;
            textBox6.Text = "NEW BLOGS";
            textBox6.TextChanged += textBox6_TextChanged_1;
            // 
            // guna2GradientPanel3
            // 
            guna2GradientPanel3.BorderRadius = 20;
            guna2GradientPanel3.Controls.Add(textBox7);
            guna2GradientPanel3.Controls.Add(textBox8);
            guna2GradientPanel3.Controls.Add(textBox9);
            guna2GradientPanel3.CustomizableEdges = customizableEdges17;
            guna2GradientPanel3.FillColor = Color.FromArgb(64, 169, 190);
            guna2GradientPanel3.FillColor2 = Color.FromArgb(64, 169, 190);
            guna2GradientPanel3.Location = new Point(717, 30);
            guna2GradientPanel3.Name = "guna2GradientPanel3";
            guna2GradientPanel3.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2GradientPanel3.Size = new Size(299, 183);
            guna2GradientPanel3.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(64, 169, 190);
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Sitka Banner", 15F);
            textBox7.ForeColor = SystemColors.MenuBar;
            textBox7.Location = new Point(108, 95);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(191, 62);
            textBox7.TabIndex = 8;
            textBox7.Text = "Hãy nhớ hoàn thành bài tập nhé !";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(64, 169, 190);
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Sitka Banner", 45F);
            textBox8.ForeColor = SystemColors.MenuBar;
            textBox8.Location = new Point(0, 70);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(123, 102);
            textBox8.TabIndex = 7;
            textBox8.Text = "20";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(64, 169, 190);
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Sitka Banner", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.ForeColor = SystemColors.MenuBar;
            textBox9.Location = new Point(3, 13);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(317, 51);
            textBox9.TabIndex = 0;
            textBox9.Text = "NEW HOMEWORK";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(169, 308);
            panel4.Name = "panel4";
            panel4.Size = new Size(1062, 356);
            panel4.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Location = new Point(892, 20);
            panel6.Name = "panel6";
            panel6.Size = new Size(145, 333);
            panel6.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(textBox10);
            panel7.Location = new Point(28, 20);
            panel7.Name = "panel7";
            panel7.Size = new Size(846, 333);
            panel7.TabIndex = 1;
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(19, 20);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(390, 36);
            textBox10.TabIndex = 0;
            textBox10.Text = "Homework finished freqency ";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1231, 664);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "HomePage";
            Text = "Trang chủ";
            Load += HomePage_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            guna2GradientPanel2.ResumeLayout(false);
            guna2GradientPanel2.PerformLayout();
            guna2GradientPanel3.ResumeLayout(false);
            guna2GradientPanel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnChat;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button btAccount;
        private Button btHome;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Panel panel4;
        private Panel panel7;
        private TextBox textBox10;
        private Panel panel6;
    }
}
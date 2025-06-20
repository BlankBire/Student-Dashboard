namespace StudentDashboard.GUI
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSchedule;
        private Button btnForum;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSchedule = new Button();
            btnChat = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btAccount = new Button();
            panel2 = new Panel();
            btHome = new Button();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            panel3 = new Panel();
            guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel4 = new Panel();
            panel7 = new Panel();
            textBox10 = new TextBox();
            panel6 = new Panel();
            this.btnForum = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            guna2GradientPanel3.SuspendLayout();
            guna2GradientPanel2.SuspendLayout();
            guna2GradientPanel1.SuspendLayout();
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
            btnSchedule.Location = new Point(-168, 225);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(409, 112);
            btnSchedule.TabIndex = 0;
            btnSchedule.Text = "                                Thời khóa biểu";
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
            btnChat.Location = new Point(-117, 138);
            btnChat.Margin = new Padding(4, 3, 4, 3);
            btnChat.Name = "btnChat";
            btnChat.Size = new Size(356, 55);
            btnChat.TabIndex = 1;
            btnChat.Text = "                  Chat";
            btnChat.UseVisualStyleBackColor = true;
            btnChat.Click += btnChat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btAccount);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Snow;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1759, 112);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_notification_24;
            pictureBox2.Location = new Point(1581, 63);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.uit_logo1;
            pictureBox1.Location = new Point(-5, -73);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btAccount
            // 
            btAccount.FlatAppearance.BorderSize = 0;
            btAccount.FlatStyle = FlatStyle.Flat;
            btAccount.ForeColor = Color.Black;
            btAccount.Image = Properties.Resources.icons8_account_24;
            btAccount.Location = new Point(1624, 56);
            btAccount.Name = "btAccount";
            btAccount.Size = new Size(120, 53);
            btAccount.TabIndex = 4;
            btAccount.UseVisualStyleBackColor = true;
            btAccount.Click += btAccount_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnSchedule);
            panel2.Controls.Add(btnForum);
            panel2.Controls.Add(btHome);
            panel2.Controls.Add(btnChat);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.MintCream;
            panel2.Location = new Point(0, 112);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(241, 995);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // btHome
            // 
            btHome.AutoSize = true;
            btHome.FlatAppearance.BorderSize = 0;
            btHome.FlatStyle = FlatStyle.Flat;
            btHome.Font = new Font("Segoe UI", 12F);
            btHome.ForeColor = SystemColors.Desktop;
            btHome.Image = Properties.Resources.icons8_home_24;
            btHome.Location = new Point(-170, 17);
            btHome.Margin = new Padding(4, 5, 4, 5);
            btHome.Name = "btHome";
            btHome.Size = new Size(433, 70);
            btHome.TabIndex = 5;
            btHome.Text = "                            Trang chủ ";
            btHome.UseVisualStyleBackColor = true;
            btHome.Click += btHome_Click;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(24, 24);
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
            panel3.Location = new Point(241, 112);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1518, 402);
            panel3.TabIndex = 6;
            // 
            // guna2GradientPanel3
            // 
            guna2GradientPanel3.BorderRadius = 20;
            guna2GradientPanel3.Controls.Add(textBox7);
            guna2GradientPanel3.Controls.Add(textBox8);
            guna2GradientPanel3.Controls.Add(textBox9);
            guna2GradientPanel3.CustomizableEdges = customizableEdges1;
            guna2GradientPanel3.FillColor = Color.FromArgb(64, 169, 190);
            guna2GradientPanel3.FillColor2 = Color.FromArgb(64, 169, 190);
            guna2GradientPanel3.Location = new Point(1024, 50);
            guna2GradientPanel3.Margin = new Padding(4, 5, 4, 5);
            guna2GradientPanel3.Name = "guna2GradientPanel3";
            guna2GradientPanel3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel3.Size = new Size(457, 305);
            guna2GradientPanel3.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(64, 169, 190);
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Sitka Banner", 15F);
            textBox7.ForeColor = SystemColors.MenuBar;
            textBox7.Location = new Point(154, 158);
            textBox7.Margin = new Padding(4, 5, 4, 5);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(273, 103);
            textBox7.TabIndex = 8;
            textBox7.Text = "Hãy nhớ hoàn thành bài tập nhé !";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(64, 169, 190);
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Sitka Banner", 45F);
            textBox8.ForeColor = SystemColors.MenuBar;
            textBox8.Location = new Point(0, 117);
            textBox8.Margin = new Padding(4, 5, 4, 5);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(176, 170);
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
            textBox9.Location = new Point(4, 22);
            textBox9.Margin = new Padding(4, 5, 4, 5);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(453, 76);
            textBox9.TabIndex = 0;
            textBox9.Text = "NEW HOMEWORK";
            // 
            // guna2GradientPanel2
            // 
            guna2GradientPanel2.BorderRadius = 20;
            guna2GradientPanel2.Controls.Add(textBox4);
            guna2GradientPanel2.Controls.Add(textBox5);
            guna2GradientPanel2.Controls.Add(textBox6);
            guna2GradientPanel2.CustomizableEdges = customizableEdges3;
            guna2GradientPanel2.FillColor = Color.FromArgb(64, 169, 190);
            guna2GradientPanel2.FillColor2 = Color.FromArgb(64, 169, 190);
            guna2GradientPanel2.Location = new Point(531, 50);
            guna2GradientPanel2.Margin = new Padding(4, 5, 4, 5);
            guna2GradientPanel2.Name = "guna2GradientPanel2";
            guna2GradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientPanel2.Size = new Size(431, 305);
            guna2GradientPanel2.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(64, 169, 190);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Sitka Banner", 15F);
            textBox4.ForeColor = SystemColors.MenuBar;
            textBox4.Location = new Point(154, 158);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(273, 103);
            textBox4.TabIndex = 8;
            textBox4.Text = "2 blogs đang chờ bạn khám phá!";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(64, 169, 190);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Sitka Banner", 45F);
            textBox5.ForeColor = SystemColors.MenuBar;
            textBox5.Location = new Point(0, 117);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(176, 170);
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
            textBox6.Location = new Point(4, 22);
            textBox6.Margin = new Padding(4, 5, 4, 5);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(453, 76);
            textBox6.TabIndex = 0;
            textBox6.Text = "NEW BLOGS";
            textBox6.TextChanged += textBox6_TextChanged_1;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BorderRadius = 20;
            guna2GradientPanel1.Controls.Add(textBox3);
            guna2GradientPanel1.Controls.Add(textBox2);
            guna2GradientPanel1.Controls.Add(textBox1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges5;
            guna2GradientPanel1.FillColor = Color.FromArgb(64, 169, 190);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(64, 169, 190);
            guna2GradientPanel1.Location = new Point(36, 50);
            guna2GradientPanel1.Margin = new Padding(4, 5, 4, 5);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GradientPanel1.Size = new Size(441, 305);
            guna2GradientPanel1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(64, 169, 190);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Sitka Banner", 15F);
            textBox3.ForeColor = SystemColors.MenuBar;
            textBox3.Location = new Point(163, 158);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(273, 103);
            textBox3.TabIndex = 8;
            textBox3.Text = "Bạn có 20 tin nhắn chưa đọc";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(64, 169, 190);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Sitka Banner", 45F);
            textBox2.ForeColor = SystemColors.MenuBar;
            textBox2.Location = new Point(0, 117);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 170);
            textBox2.TabIndex = 7;
            textBox2.Text = "20";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 169, 190);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sitka Banner", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.MenuBar;
            textBox1.Location = new Point(4, 22);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(453, 76);
            textBox1.TabIndex = 0;
            textBox1.Text = "NEW MESSAGES";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(241, 514);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1518, 593);
            panel4.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Controls.Add(textBox10);
            panel7.Location = new Point(40, 33);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(1209, 555);
            panel7.TabIndex = 1;
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(27, 33);
            textBox10.Margin = new Padding(4, 5, 4, 5);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(557, 54);
            textBox10.TabIndex = 0;
            textBox10.Text = "Homework finished freqency ";
            // 
            // panel6
            // 
            panel6.Location = new Point(1274, 33);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(207, 555);
            panel6.TabIndex = 0;
            // 
            // btnForum
            // 
            this.btnForum.FlatAppearance.BorderSize = 0;
            this.btnForum.FlatStyle = FlatStyle.Flat;
            this.btnForum.Font = new Font("Segoe UI", 12F);
            this.btnForum.ForeColor = SystemColors.Desktop;
            this.btnForum.Image = Properties.Resources.icons8_chat_24;
            this.btnForum.Location = new Point(-168, 337);
            this.btnForum.Name = "btnForum";
            this.btnForum.Size = new Size(409, 70);
            this.btnForum.TabIndex = 11;
            this.btnForum.Text = "                 Diễn đàn";
            this.btnForum.UseVisualStyleBackColor = true;
            this.btnForum.Click += new System.EventHandler(this.btnForum_Click);
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1759, 1107);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HomePage";
            Text = "Trang chủ";
            Load += HomePage_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            guna2GradientPanel3.ResumeLayout(false);
            guna2GradientPanel3.PerformLayout();
            guna2GradientPanel2.ResumeLayout(false);
            guna2GradientPanel2.PerformLayout();
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
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
namespace StudentDashboard.GUI
{
    partial class ChatForm
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
            panelChat = new Panel();
            textBox1 = new TextBox();
            btnSend = new Button();
            listUsers = new ListBox();
            panelInput = new Panel();
            SuspendLayout();

            // listUsers
            listUsers.Dock = DockStyle.Left;
            listUsers.Width = 200;
            listUsers.SelectedIndexChanged += listUsers_SelectedIndexChanged;

            // panelChat
            panelChat.Dock = DockStyle.None;
            panelChat.AutoScroll = true;
            panelChat.Padding = new Padding(10, 10, 10, 10);
            panelChat.BackColor = Color.LightYellow;
            panelChat.Location = new Point(listUsers.Width, 0);
            panelChat.Width = 500;
            panelChat.Height = this.ClientSize.Height - panelInput.Height;
            panelChat.HorizontalScroll.Enabled = false;
            panelChat.HorizontalScroll.Visible = false;

            // panelInput (panel chứa thanh nhập và nút gửi)
            panelInput.Dock = DockStyle.Bottom;
            panelInput.Height = 40;
            panelInput.Padding = new Padding(10, 5, 10, 5);
            panelInput.Width = this.ClientSize.Width;
            panelInput.Controls.Add(textBox1);
            panelInput.Controls.Add(btnSend);

            // textBox1
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.Location = new Point(0, 5);
            textBox1.Width = 800;
            textBox1.Height = 30;

            // btnSend
            btnSend.Text = "Gửi";
            btnSend.Width = 80;
            btnSend.Height = 30;
            btnSend.Location = new Point(textBox1.Right + 10, 5);
            btnSend.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            btnSend.Click += btnSend_Click;

            // ChatForm
            this.Size = new Size(1000, 600);
            this.Text = "Chat";
            this.Resize += ChatForm_Resize;
            
            Controls.Add(panelChat);    // Add panelChat sau nữa
            Controls.Add(panelInput);
            Controls.Add(listUsers);    // Add listUsers cuối cùng (Dock Left)

            ResumeLayout(false);
            PerformLayout();
        }
        private void ChatForm_Resize(object sender, EventArgs e)
        {
            // Đảm bảo panelInput đã cập nhật vị trí và kích thước
            // panelInput.Top = this.ClientSize.Height - panelInput.Height;
            // panelInput.Left = 0;
            // panelInput.Width = this.ClientSize.Width;

            // listUsers luôn bên trái
            // listUsers.Left = 0;
            // listUsers.Top = 0;
            // listUsers.Height = this.ClientSize.Height;

            // panelChat fill vùng còn lại
            panelChat.Left = listUsers.Width;
            panelChat.Top = 0;
            panelChat.Width = this.ClientSize.Width - listUsers.Width;
            panelChat.Height = this.ClientSize.Height - panelInput.Height;
        }

        #endregion

        private Panel panelChat;
        private TextBox textBox1;
        private Button btnSend;
        private ComboBox comboRecipient;
        private ListBox listUsers;
        private Panel panelInput;
    }
}
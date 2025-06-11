using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

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
            panelChat = new Guna2Panel();
            textBox1 = new Guna2TextBox();
            btnSend = new Guna2Button();
            listUsers = new ListBox();
            panelInput = new Guna2Panel();
            panelUsers = new Guna2Panel();
            
            SuspendLayout();

            // panelUsers
            panelUsers.Dock = DockStyle.Left;
            panelUsers.Width = 250;
            panelUsers.FillColor = Color.FromArgb(214, 230, 255);
            panelUsers.BorderRadius = 0;
            panelUsers.Controls.Add(listUsers);

            // listUsers
            listUsers.Dock = DockStyle.Fill;
            listUsers.Font = new Font("Segoe UI", 10);
            listUsers.BackColor = Color.FromArgb(214, 230, 255);
            listUsers.BorderStyle = BorderStyle.None;
            listUsers.ItemHeight = 40;
            listUsers.IntegralHeight = false;
            listUsers.DrawMode = DrawMode.OwnerDrawFixed;
            listUsers.DrawItem += ListUsers_DrawItem;
            listUsers.SelectedIndexChanged += listUsers_SelectedIndexChanged;

            // panelChat
            panelChat.Dock = DockStyle.Fill;
            panelChat.AutoScroll = true;
            panelChat.Padding = new Padding(20);
            panelChat.FillColor = Color.White;
            panelChat.BorderRadius = 0;

            // panelInput
            panelInput.Dock = DockStyle.Bottom;
            panelInput.Height = 70;
            panelInput.FillColor = Color.FromArgb(240, 240, 240);
            panelInput.BorderRadius = 0;
            panelInput.Controls.Add(textBox1);
            panelInput.Controls.Add(btnSend);

            // textBox1
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.Location = new Point(20, 15);
            textBox1.Width = panelInput.Width - 120;
            textBox1.Height = 40;
            textBox1.BorderRadius = 20;
            textBox1.FillColor = Color.White;
            textBox1.BorderColor = Color.FromArgb(200, 200, 200);
            textBox1.Font = new Font("Segoe UI", 10);
            textBox1.PlaceholderText = "Nhập tin nhắn...";
            textBox1.TextChanged += textBox1_TextChanged;

            // btnSend
            btnSend.Text = "Gửi";
            btnSend.Width = 80;
            btnSend.Height = 40;
            btnSend.Location = new Point(textBox1.Right + 10, 15);
            btnSend.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            btnSend.BorderRadius = 20;
            btnSend.FillColor = Color.FromArgb(94, 148, 255);
            btnSend.ForeColor = Color.White;
            btnSend.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnSend.Click += btnSend_Click;

            // ChatForm
            this.Size = new Size(1000, 600);
            this.Text = "Chat";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Resize += ChatForm_Resize;
            
            Controls.Add(panelChat);
            Controls.Add(panelInput);
            Controls.Add(panelUsers);

            ResumeLayout(false);
            PerformLayout();
        }

        private void ChatForm_Resize(object sender, EventArgs e)
        {
            panelChat.Left = panelUsers.Width;
            panelChat.Top = 0;
            panelChat.Width = this.ClientSize.Width - panelUsers.Width;
            panelChat.Height = this.ClientSize.Height - panelInput.Height;
        }

        #endregion

        private Guna2Panel panelChat;
        private Guna2TextBox textBox1;
        private Guna2Button btnSend;
        private ListBox listUsers;
        private Guna2Panel panelInput;
        private Guna2Panel panelUsers;
    }
}
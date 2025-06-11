using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Guna.UI2.WinForms;

namespace StudentDashboard.GUI
{
    public partial class ChatForm : Form
    {
        TcpClient client;
        NetworkStream stream;
        String username;
        private string currentRecipient = null;
        private int hoveredUserIndex = -1;

        public ChatForm(string username)
        {
            InitializeComponent();
            this.username = username;
            ConnectToServer();
            LoadUserList();
            panelChat.Resize += panelChat_Resize;
            ChatForm_Resize(this, EventArgs.Empty);
            listUsers.MouseMove += ListUsers_MouseMove;
            listUsers.MouseLeave += ListUsers_MouseLeave;
        }

        private void panelChat_Resize(object sender, EventArgs e)
        {
            int minWidth = 200;
            int rowWidth = Math.Max(panelChat.ClientSize.Width - 40, minWidth);
            int bubbleWidth = Math.Max(rowWidth - 80, 100);

            foreach (Control row in panelChat.Controls)
            {
                if (row is Guna2Panel table)
                {
                    table.Width = rowWidth;
                    foreach (Control ctrl in table.Controls)
                    {
                        if (ctrl is Guna2Panel bubble)
                        {
                            bubble.MaximumSize = new Size(bubbleWidth, 0);
                        }
                    }
                }
            }
        }

        private void LoadUserList()
        {
            string connectionString = "server=localhost;user=root;database=studentdashboard;port=3306;password=root;";
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT user_name FROM users WHERE user_name != @me";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@me", this.username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        listUsers.Items.Clear();
                        while (reader.Read())
                        {
                            listUsers.Items.Add(reader.GetString("user_name"));
                        }
                    }
                }
            }
        }

        private void AddChatBubble(string sender, string message, string time, bool isMine)
        {
            var rowWidth = Math.Max(panelChat.ClientSize.Width - 40, 200);
            var bubbleWidth = Math.Max(rowWidth - 80, 100);

            var bubble = new Guna2Panel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                FillColor = isMine ? Color.FromArgb(94, 148, 255) : Color.FromArgb(240, 240, 240),
                Padding = new Padding(15),
                MaximumSize = new Size(bubbleWidth, 0),
                BorderRadius = 15,
                Margin = new Padding(0, 5, 0, 5)
            };

            var layout = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                BackColor = Color.Transparent,
            };

            var lblSender = new Guna2HtmlLabel
            {
                Text = sender,
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = isMine ? Color.White : Color.FromArgb(64, 64, 64),
                AutoSize = true,
                MaximumSize = new Size(bubbleWidth - 30, 0),
                Margin = new Padding(0, 0, 0, 2)
            };

            var lblMsg = new Guna2HtmlLabel
            {
                Text = message,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = isMine ? Color.White : Color.FromArgb(64, 64, 64),
                AutoSize = true,
                MaximumSize = new Size(bubbleWidth - 30, 0),
                Margin = new Padding(0, 0, 0, 2)
            };

            var lblTime = new Guna2HtmlLabel
            {
                Text = time,
                Font = new Font("Segoe UI", 7, FontStyle.Italic),
                ForeColor = isMine ? Color.FromArgb(200, 200, 200) : Color.FromArgb(128, 128, 128),
                AutoSize = true,
                MaximumSize = new Size(bubbleWidth - 30, 0),
                Margin = new Padding(0, 0, 0, 0)
            };

            layout.Controls.Add(lblSender, 0, 0);
            layout.Controls.Add(lblMsg, 0, 1);
            layout.Controls.Add(lblTime, 0, 2);
            bubble.Controls.Add(layout);

            var container = new Guna2Panel
            {
                AutoSize = true,
                Dock = DockStyle.Top,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Width = panelChat.ClientSize.Width - 40,
                BackColor = Color.Transparent,
                Margin = new Padding(0, 5, 0, 5)
            };

            if (isMine)
            {
                bubble.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                bubble.Left = container.Width - bubble.Width - 10;
                container.Controls.Add(bubble);
            }
            else
            {
                bubble.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                bubble.Left = 10;
                container.Controls.Add(bubble);
            }

            panelChat.Controls.Add(container);
            container.BringToFront();

            this.BeginInvoke((MethodInvoker)(() =>
            {
                panelChat.AutoScrollPosition = new Point(0, panelChat.VerticalScroll.Maximum);
                panelChat.PerformLayout();
            }));
        }

        private void ConnectToServer()
        {
            try
            {
                client = new TcpClient("127.0.0.1", 8000);
                stream = client.GetStream();

                byte[] userBytes = Encoding.UTF8.GetBytes(username);
                stream.Write(userBytes, 0, userBytes.Length);

                Thread thread = new Thread(ReceiveMessages);
                thread.IsBackground = true;
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến máy chủ: " + ex.Message);
                this.Close();
            }
        }

        private void ReceiveMessages()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) continue;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    string time = DateTime.Now.ToString("HH:mm");
                    string[] parts = message.Split(new[] { '|' }, 2);
                    string sender = parts.Length > 1 ? parts[0] : "Người gửi";
                    string content = parts.Length > 1 ? parts[1].Trim() : message;

                    if (!sender.Equals(this.username, StringComparison.OrdinalIgnoreCase))
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            AddChatBubble(sender, content, time, false);
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nhận tin nhắn: " + ex.Message);
                    break;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(message) && !string.IsNullOrEmpty(currentRecipient))
            {
                try
                {
                    string fullMessage = $"{currentRecipient}|{message}";
                    byte[] buffer = Encoding.UTF8.GetBytes(fullMessage);
                    stream.Write(buffer, 0, buffer.Length);
                    AddChatBubble(this.username, message, DateTime.Now.ToString("HH:mm"), true);
                    textBox1.Clear();
                    SaveMessageToDatabase(this.username, currentRecipient, message);
                    LoadMessageHistory(this.username, currentRecipient);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi gửi tin nhắn: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tin nhắn và chọn người nhận.");
            }
        }

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUsers.SelectedItem != null)
            {
                currentRecipient = listUsers.SelectedItem.ToString();
                Task.Delay(10).ContinueWith(_ =>
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        LoadMessageHistory(this.username, currentRecipient);
                    }));
                });
            }
        }

        private int GetUserId(string username)
        {
            string connectionString = "server=localhost;user=root;database=studentdashboard;port=3306;password=root;";
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT user_id FROM users WHERE user_name = @username LIMIT 1";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    var result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Không tìm thấy user: " + username);
                        return -1;
                    }
                    return Convert.ToInt32(result);
                }
            }
        }

        private void SaveMessageToDatabase(string senderUsername, string receiverUsername, string content)
        {
            string connectionString = "server=localhost;user=root;database=studentdashboard;port=3306;password=root;";
            int senderId = GetUserId(senderUsername);
            int receiverId = GetUserId(receiverUsername);

            if (senderId == -1 || receiverId == -1) return;

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO messages (sender_id, receiver_id, content) VALUES (@sid, @rid, @content)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sid", senderId);
                    cmd.Parameters.AddWithValue("@rid", receiverId);
                    cmd.Parameters.AddWithValue("@content", content);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadMessageHistory(string user1, string user2)
        {
            try
            {
                panelChat.Controls.Clear();
                string connectionString = "server=localhost;user=root;database=studentdashboard;port=3306;password=root;";
                int id1 = GetUserId(user1);
                int id2 = GetUserId(user2);

                if (id1 == -1 || id2 == -1)
                {
                    MessageBox.Show("Không thể tìm thấy thông tin người dùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT sender_id, content, sent_at 
                                   FROM messages 
                                   WHERE (sender_id = @id1 AND receiver_id = @id2)
                                      OR (sender_id = @id2 AND receiver_id = @id1)
                                   ORDER BY sent_at ASC";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id1", id1);
                        cmd.Parameters.AddWithValue("@id2", id2);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int senderId = reader.GetInt32("sender_id");
                                string senderName = senderId == id1 ? user1 : user2;
                                string content = reader.GetString("content");
                                string time = reader.GetDateTime("sent_at").ToString("HH:mm");
                                bool isMine = senderId == id1;
                                AddChatBubble(senderName, content, time, isMine);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải lịch sử tin nhắn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.PlaceholderText = "Nhập tin nhắn...";
            }
        }

        private void ListUsers_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listUsers.IndexFromPoint(e.Location);
            if (index != hoveredUserIndex)
            {
                hoveredUserIndex = index;
                listUsers.Invalidate();
            }
        }

        private void ListUsers_MouseLeave(object sender, EventArgs e)
        {
            hoveredUserIndex = -1;
            listUsers.Invalidate();
        }

        private void ListUsers_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            bool isHovered = (e.Index == hoveredUserIndex);

            Color bgColor = Color.FromArgb(214, 230, 255);
            Color selectedColor = Color.FromArgb(163, 200, 255);
            Color hoverColor = Color.FromArgb(200, 220, 255);
            int radius = 10;
            Rectangle rect = new Rectangle(e.Bounds.X + 4, e.Bounds.Y + 2, e.Bounds.Width - 8, e.Bounds.Height - 4);

            using (var path = RoundedRect(rect, radius))
            using (var brush = new SolidBrush(bgColor))
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillPath(brush, path);
            }

            if (isSelected || isHovered)
            {
                Color overlay = isSelected ? selectedColor : hoverColor;
                using (var path = RoundedRect(rect, radius))
                using (var brush = new SolidBrush(overlay))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }

            string username = listUsers.Items[e.Index].ToString();
            using (var font = new Font("Segoe UI", 10, isSelected ? FontStyle.Bold : FontStyle.Regular))
            using (var brush = new SolidBrush(Color.FromArgb(64, 64, 64)))
            {
                e.Graphics.DrawString(username, font, brush, rect.X + 12, rect.Y + 10);
            }

            if (e.Index < listUsers.Items.Count - 1)
            {
                using (var pen = new Pen(Color.FromArgb(200, 210, 230)))
                {
                    int y = e.Bounds.Bottom - 1;
                    e.Graphics.DrawLine(pen, rect.X, y, rect.Right, y);
                }
            }

            e.DrawFocusRectangle();
        }

        private System.Drawing.Drawing2D.GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}


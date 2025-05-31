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


namespace StudentDashboard.GUI
{
    public partial class ChatForm : Form
    {
        TcpClient client;
        NetworkStream stream;
        String username;
        private string currentRecipient = null;

        public ChatForm(string username)
        {
            InitializeComponent();
            this.username = username;
            ConnectToServer();
            LoadUserList();
            panelChat.Resize += panelChat_Resize;
            ChatForm_Resize(this, EventArgs.Empty);
        }

        private void panelChat_Resize(object sender, EventArgs e)
        {
            int minWidth = 200;
            int rowWidth = Math.Max(panelChat.ClientSize.Width - 20, minWidth);
            int bubbleWidth = Math.Max(rowWidth - 60, 100);

            foreach (Control row in panelChat.Controls)
            {
                if (row is TableLayoutPanel table)
                {
                    table.Width = rowWidth;
                    foreach (Control ctrl in table.Controls)
                    {
                        if (ctrl is Panel bubble)
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
            var rowWidth = Math.Max(panelChat.ClientSize.Width - 20, 200);
            var bubbleWidth = Math.Max(rowWidth - 60, 100);

            var bubble = new Panel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                BackColor = isMine ? Color.LightSkyBlue : Color.LightGray,
                Padding = new Padding(10),
                MaximumSize = new Size(bubbleWidth, 0),
                BorderStyle = BorderStyle.FixedSingle,
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

            var lblSender = new Label
            {
                Text = sender,
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.DimGray,
                AutoSize = true,
                MaximumSize = new Size(bubbleWidth - 20, 0),
                Margin = new Padding(0, 0, 0, 2)
            };

            var lblMsg = new Label
            {
                Text = message,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                AutoSize = true,
                MaximumSize = new Size(bubbleWidth - 20, 0),
                Margin = new Padding(0, 0, 0, 2)
            };

            var lblTime = new Label
            {
                Text = time,
                Font = new Font("Segoe UI", 7, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true,
                MaximumSize = new Size(bubbleWidth - 20, 0),
                Margin = new Padding(0, 0, 0, 0)
            };

            layout.Controls.Add(lblSender, 0, 0);
            layout.Controls.Add(lblMsg, 0, 1);
            layout.Controls.Add(lblTime, 0, 2);
            bubble.Controls.Add(layout);

            var container = new Panel
            {
                AutoSize = true,
                Dock = DockStyle.Top,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Width = panelChat.ClientSize.Width - 20,
                BackColor = Color.Transparent,
                Margin = new Padding(0, 5, 0, 5)
            };

            // Căn phải/trái cho bubble
            if (isMine)
            {
                bubble.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                bubble.Left = container.Width - bubble.Width - 10;
                container.Controls.Add(bubble);
            }
            else
            {
                bubble.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                bubble.Left = 0;
                container.Controls.Add(bubble);
            }

            // Thêm container và đưa xuống dưới cùng
            panelChat.Controls.Add(container);
            container.BringToFront(); // Tin nhắn mới nhất ở dưới cùng

            // Cuộn xuống dưới cùng
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

                // GỬI USERNAME NGAY SAU KHI KẾT NỐI
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
                    if (bytesRead == 0) continue; // Connection closed

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

        private void comboRecipient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUser = comboRecipient.SelectedItem.ToString();
            LoadMessageHistory(this.username, selectedUser);
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
                // Delay 10ms để form layout xong
                Task.Delay(10).ContinueWith(_ =>
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        LoadMessageHistory(this.username, currentRecipient);
                    }));
                });
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

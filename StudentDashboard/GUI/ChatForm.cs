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
        public ChatForm(string username)
        {
            InitializeComponent();
            this.username = username;
            this.comboRecipient.SelectedIndexChanged += new System.EventHandler(this.comboRecipient_SelectedIndexChanged);
            ConnectToServer();
            comboRecipient.Items.Add("locac77");
            comboRecipient.Items.Add("buhlmao");
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
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    string time = DateTime.Now.ToString("HH:mm");
                    listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add($"{time} {message}")));
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
            string connectionString = "server=localhost;user=root;database=studentdashboard;port=3306;password=;";
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT user_id FROM users WHERE user_name = @username LIMIT 1";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }
        private void SaveMessageToDatabase(string senderUsername, string receiverUsername, string content)
        {
            string connectionString = "server=localhost;user=root;database=studentdashboard;port=3306;password=;";
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
            string connectionString = "server=localhost;user=root;database=studentdashboard;port=3306;password=;";
            int id1 = GetUserId(user1);
            int id2 = GetUserId(user2);
            if (id1 == -1 || id2 == -1) return;

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
                            listBox1.Items.Add($"{time} {senderName}: {content}");
                        }
                    }
                }
            }
        }

        private void comboRecipient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUser = comboRecipient.SelectedItem.ToString();
            LoadMessageHistory(this.username, selectedUser);
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            string recipient = comboRecipient.Text.Trim();
            string message = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(message) && !string.IsNullOrEmpty(recipient))
            {
                string fullMessage = $"{recipient}|{message}";
                byte[] buffer = Encoding.UTF8.GetBytes(fullMessage);
                stream.Write(buffer, 0, buffer.Length);
                listBox1.Items.Add($"Tới {recipient}: {message}");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tin nhắn và chọn người nhận.");
            }
            SaveMessageToDatabase(this.username, recipient, message);
        }
    }
}

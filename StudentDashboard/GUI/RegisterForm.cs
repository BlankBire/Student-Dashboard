using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StudentDashboard.DAL;
using StudentDashboard.Utils;

namespace StudentDashboard.GUI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
            tbConfirmPassword.PasswordChar = '*'; 
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            string confirmPassword = tbConfirmPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hashedPassword = HashHelper.HashPassword(password);
            string connectionString = DatabaseHelper.GetConnectionString(); // Lấy chuỗi kết nối từ App.config
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Check if username or email already exists
                string checkQuery = "SELECT COUNT(*) FROM users WHERE user_name = @username OR user_email = @mail";
                using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@username", username);
                    checkCommand.Parameters.AddWithValue("@mail", email);

                    int userCount = Convert.ToInt32(checkCommand.ExecuteScalar());
                    if (userCount > 0)
                    {
                        MessageBox.Show("Tên người dùng hoặc email đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Insert new user
                string query = "INSERT INTO users (user_name, user_email, user_password, user_role, user_created_at) VALUES (@username, @mail, @password, 'user', NOW())";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@mail", email);
                    command.Parameters.AddWithValue("@password", hashedPassword);

                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class LoginForm : Form
    { 
        public LoginForm()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connectionString = DatabaseHelper.GetConnectionString(); // Lấy chuỗi kết nối từ App.config
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Check if username exists
                string checkUserQuery = "SELECT user_password FROM users WHERE user_name = @username";
                using (MySqlCommand checkUserCommand = new MySqlCommand(checkUserQuery, connection))
                {
                    checkUserCommand.Parameters.AddWithValue("@username", username);

                    object result = checkUserCommand.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string storedHashedPassword = result.ToString();
                    if (!HashHelper.VerifyPassword(password, storedHashedPassword))
                    {
                        MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
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
using StudentDashboard.Models;
using StudentDashboard.GUI;

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

            string connectionString = DatabaseHelper.GetConnectionString();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string checkUserQuery = "SELECT * FROM users WHERE user_name = @username";
                using (MySqlCommand command = new MySqlCommand(checkUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        reader.Read();
                        string storedHashedPassword = reader["user_password"].ToString();

                        if (!HashHelper.VerifyPassword(password, storedHashedPassword))
                        {
                            MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Tạo đối tượng currentUser
                        UserModel currentUser = new UserModel
                        {
                            UserID = Convert.ToInt32(reader["user_id"]),
                            UserName = reader["user_name"].ToString(),
                            Email = reader["user_email"].ToString(),
                            CreatedAt = Convert.ToDateTime(reader["user_created_at"])
                        };

                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        HomePage homePage = new HomePage(currentUser);
                        homePage.ShowDialog();
                        this.Show();
                    }
                }
            }
        }


        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
} 
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
using System.Drawing.Drawing2D;

namespace StudentDashboard.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
            this.Load += LoginForm_Load;
            tbUserName.Enter += tbUserName_Enter;
            tbUserName.Leave += tbUserName_Leave;

            tbPassword.Enter += tbPassword_Enter;
            tbPassword.Leave += tbPassword_Leave;

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
                            UserID = Convert.ToInt32(reader[" user_id"]),
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
        Color placeholderColor = Color.Gray;
        Color activeTextColor = Color.FromArgb(0,117,214);
        private void LoginForm_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // độ cong góc
            Rectangle rect = btLogin.ClientRectangle;
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            btLogin.Region = new Region(path);

            tbUserName.Text = "Username";
            tbUserName.ForeColor = placeholderColor;

            tbPassword.Text = "Password";
            tbPassword.ForeColor = placeholderColor;
            tbPassword.UseSystemPasswordChar = false;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tbUserName_Enter(object sender, EventArgs e)
        {
            if (tbUserName.Text == "Username")
            {
                tbUserName.Text = "";
                tbUserName.ForeColor = activeTextColor;
            }
        }

        private void tbUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUserName.Text))
            {
                tbUserName.Text = "Username";
                tbUserName.ForeColor = placeholderColor;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = activeTextColor;
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                tbPassword.UseSystemPasswordChar = false;
                tbPassword.Text = "Password";
                tbPassword.ForeColor = placeholderColor;
            }
        }
    }
} 
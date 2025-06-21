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
using System.Drawing.Drawing2D;


namespace StudentDashboard.GUI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
            tbConfirmPassword.PasswordChar = '*';
            this.Load += RegisterForm_Load;
        }

        Color placeholderColor = Color.Gray;
        Color activeTextColor = Color.FromArgb(0, 120, 215); // Xanh dương
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Bo góc cho nút btRegister
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // độ cong góc
            Rectangle rect = btRegister.ClientRectangle;
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            btRegister.Region = new Region(path);

            tbUserName.Text = "Username";
            tbUserName.ForeColor = placeholderColor;

            tbPassword.Text = "Password";
            tbPassword.ForeColor = placeholderColor;
            tbPassword.UseSystemPasswordChar = false;

            tbEmail.Text = "Email";
            tbEmail.ForeColor = placeholderColor;

            tbConfirmPassword.Text = "Confirm Password";
            tbConfirmPassword.ForeColor = placeholderColor;
            tbConfirmPassword.UseSystemPasswordChar = false;
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
            // Đăng nhập ngay sau khi đăng ký thành công
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbUserName_Click(object sender, EventArgs e)
        {

        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged_1(object sender, EventArgs e)
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

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Email")
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = activeTextColor;
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                tbEmail.Text = "Email";
                tbEmail.ForeColor = placeholderColor;
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

        private void tbConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (tbConfirmPassword.Text == "Confirm Password")
            {
                tbConfirmPassword.Text = "";
                tbConfirmPassword.ForeColor = activeTextColor;
                tbConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbConfirmPassword.Text))
            {
                tbConfirmPassword.UseSystemPasswordChar = false;
                tbConfirmPassword.Text = "Confirm Password";
                tbConfirmPassword.ForeColor = placeholderColor;
            }
        }
    }
} 
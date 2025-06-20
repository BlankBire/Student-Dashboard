using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentDashboard.DAL;
using StudentDashboard.Models;
using StudentDashboard.Utils;

namespace StudentDashboard.GUI
{
    public partial class ChangePassword : Form
    {
        private UserModel _currentUser;
        public ChangePassword(UserModel currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            gunaTbPassword.PasswordChar = '*';
            gunaTbNewPassword.PasswordChar = '*';
            gunaTbConfirmPassword.PasswordChar = '*';
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string oldPassword = gunaTbPassword.Text.Trim();
            string newPassword = gunaTbNewPassword.Text.Trim();
            string confirmPassword = gunaTbConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserRepository userRepo = new UserRepository();
            User dbUser = userRepo.GetUserById(_currentUser.UserID);

            if (dbUser == null)
            {
                MessageBox.Show("Không tìm thấy người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // So sánh mật khẩu cũ nhập vào với hash trong DB
            bool isOldPasswordCorrect = HashHelper.VerifyPassword(oldPassword, dbUser.user_password);
            if (!isOldPasswordCorrect)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hash mật khẩu mới
            string hashedNewPassword = HashHelper.HashPassword(newPassword);
            bool updated = userRepo.UpdatePassword(_currentUser.UserID, hashedNewPassword);

            if (updated)
            {
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

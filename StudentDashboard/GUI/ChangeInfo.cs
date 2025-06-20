using StudentDashboard.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentDashboard.Utils;
using StudentDashboard.DAL;

namespace StudentDashboard.GUI
{
    public partial class ChangeInfo : Form
    {
        private UserModel _currentUser;
        public ChangeInfo(UserModel currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            gunaTbPassword.PasswordChar = '*';
            gunaTbUserName.Text = _currentUser.UserName;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string newUserName = gunaTbUserName.Text.Trim();
            string password = gunaTbPassword.Text;

            if (string.IsNullOrEmpty(newUserName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin người dùng gốc từ DB
            UserRepository repo = new UserRepository();
            var userFromDb = repo.GetUserById(_currentUser.UserID);
            if (userFromDb == null)
            {
                MessageBox.Show("Không tìm thấy người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xác minh mật khẩu hiện tại
            if (!HashHelper.VerifyPassword(password, userFromDb.user_password))
            {
                MessageBox.Show("Mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật tên và email
            bool success = repo.UpdateUserInfo(_currentUser.UserID, newUserName);
            if (success)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _currentUser.UserName = newUserName;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra khi cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

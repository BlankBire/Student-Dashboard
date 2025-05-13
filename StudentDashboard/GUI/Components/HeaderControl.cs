using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentDashboard.GUI;
using StudentDashboard.Models;

namespace StudentDashboard.GUI.Components
{
    public partial class HeaderControl : UserControl
    {
        private UserModel _currentUser;
        public HeaderControl(UserModel currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void btAccount_Click(object sender, EventArgs e)
        {
            // Tìm form cha (HomePage)
            Form parentForm = this.FindForm();
            parentForm.Hide(); // Ẩn form cha
            // Mở AccountInfo 
            AccountInfo accountInfo = new AccountInfo(_currentUser);
            accountInfo.ShowDialog();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            parentForm.Hide(); // Ẩn form cha
            // Tạo lại form HomePage
            HomePage homePage = new HomePage(_currentUser);
            homePage.ShowDialog(); // mở trang chủ mới
        }

        private void HeaderControl_Load(object sender, EventArgs e)
        {

        }

        private void ptbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}

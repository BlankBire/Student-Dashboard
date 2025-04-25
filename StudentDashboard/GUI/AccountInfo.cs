using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentDashboard.GUI.Components;
using StudentDashboard.Models;

namespace StudentDashboard.GUI
{
    public partial class AccountInfo : Form
    {
        private UserModel _currentUser;

        // Constructor nhận đối tượng UserModel
        public AccountInfo(UserModel currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            HeaderControl header = new HeaderControl(_currentUser);
            header.Dock = DockStyle.Top;
            this.Controls.Add(header);
        }

        private void AccountInfo_Load(object sender, EventArgs e)
        {
            tbUserName.Enabled = false;
            tbEmail.Enabled = false;
            tbCreateAT.Enabled = false;
            // Hiển thị thông tin người dùng 
            tbUserName.Text = _currentUser.UserName;
            tbEmail.Text = _currentUser.Email;
            tbCreateAT.Text = _currentUser.CreatedAt.ToString("dd/MM/yyyy");
        }
    }
}

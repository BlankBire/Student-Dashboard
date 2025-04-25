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
            AccountInfo accountInfo = new AccountInfo(_currentUser);
            accountInfo.ShowDialog();
        }
    }
}

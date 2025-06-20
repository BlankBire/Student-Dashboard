using System;
using System.Windows.Forms;
using StudentDashboard.Models;

namespace StudentDashboard.GUI
{
    public partial class ForumForm : Form
    {
        private UserModel _currentUser;
        public ForumForm(UserModel currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }
    }
} 
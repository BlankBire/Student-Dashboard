using StudentDashboard.GUI.Components;
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

namespace StudentDashboard.GUI
{
    public partial class HomePage : Form
    {
        private UserModel _currentUser;
        public HomePage(UserModel user)
        {
            InitializeComponent();
            _currentUser = user;
            HeaderControl header = new HeaderControl(_currentUser);
            header.Dock = DockStyle.Top;
            this.Controls.Add(header);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}

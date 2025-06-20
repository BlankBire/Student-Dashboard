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
        public HomePage(UserModel currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            //HeaderControl header = new HeaderControl(_currentUser);
            //header.Dock = DockStyle.Top;
            //this.Controls.Add(header);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            var scheduleForm = new ScheduleForm(_currentUser.UserID);
            scheduleForm.ShowDialog();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm(_currentUser.UserName);
            chatForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btHome_Click_1(object sender, EventArgs e)
        {

        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage(_currentUser);
            homePage.ShowDialog();
        }

        private void btAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountInfo accountInfo = new AccountInfo(_currentUser);
            accountInfo.ShowDialog();
        }

        private void btnForum_Click(object sender, EventArgs e)
        {
            ForumForm forumForm = new ForumForm(_currentUser);
            forumForm.ShowDialog();
        }
    }
}

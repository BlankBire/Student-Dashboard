using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace StudentDashboard.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Căn giữa các control
            guna2CirclePictureBoxLogo.Location = new Point((this.ClientSize.Width - guna2CirclePictureBoxLogo.Width) / 2, 40);
            guna2HtmlLabelTitle.Location = new Point((this.ClientSize.Width - guna2HtmlLabelTitle.Width) / 2, 180);
            guna2BtnLogin.Location = new Point((this.ClientSize.Width - guna2BtnLogin.Width) / 2, 280);
            guna2BtnRegister.Location = new Point((this.ClientSize.Width - guna2BtnRegister.Width) / 2, 360);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Show();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(); 
            loginForm.ShowDialog();
            this.Show();
        }
    }
}
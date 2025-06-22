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
using System.Runtime.InteropServices;

namespace StudentDashboard.GUI
{
    public partial class MainForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            guna2BtnLogin.Anchor = AnchorStyles.None;
            guna2BtnRegister.Anchor = AnchorStyles.None;
            guna2HtmlLabelTitle.Anchor = AnchorStyles.None;
            CenterControls(); // Định vị lại các nút và tiêu đề khi form được tải

        }
        // Xử lý kéo form
        private void pnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Đóng form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Thu nhỏ form
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Phóng to/thu nhỏ form
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.Text = "❐"; // Icon restore
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.Text = "□"; // Icon maximize
            }
        }

        //Định vị lại nút giữa màn hình
        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;
            guna2BtnLogin.Left = centerX - guna2BtnLogin.Width / 2;
            guna2BtnRegister.Left = centerX - guna2BtnRegister.Width / 2;
            guna2HtmlLabelTitle.Left = centerX - guna2HtmlLabelTitle.Width / 2;
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
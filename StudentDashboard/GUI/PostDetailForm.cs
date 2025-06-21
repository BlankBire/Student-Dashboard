using Guna.UI2.WinForms;
using StudentDashboard.Models;
using System.Windows.Forms;
using System.Drawing;

namespace StudentDashboard.GUI
{
    public partial class PostDetailForm : Form
    {
        private ForumPost _post;
        private UserModel _currentUser;

        public PostDetailForm(ForumPost post, UserModel currentUser)
        {
            _post = post;
            _currentUser = currentUser;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Chi tiết bài viết";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;

            var lblTitle = new Guna2HtmlLabel
            {
                Text = _post.title,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                Dock = DockStyle.Top,
                Padding = new Padding(20),
                BackColor = Color.FromArgb(242, 245, 250),
                Height = 80
            };

            var txtContent = new Guna2TextBox
            {
                Text = _post.content,
                Dock = DockStyle.Fill,
                Multiline = true,
                ReadOnly = true,
                Font = new Font("Segoe UI", 11F),
                BorderThickness = 0,
                ScrollBars = ScrollBars.Vertical
            };

            var pnlMain = new Panel { Dock = DockStyle.Fill, Padding = new Padding(20) };
            pnlMain.Controls.Add(txtContent);

            this.Controls.Add(pnlMain);
            this.Controls.Add(lblTitle);
        }
    }
} 
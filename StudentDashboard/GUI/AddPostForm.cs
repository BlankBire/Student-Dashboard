using Guna.UI2.WinForms;
using StudentDashboard.Models;
using StudentDashboard.DAL;
using System;
using System.Windows.Forms;

namespace StudentDashboard.GUI
{
    public partial class AddPostForm : Form
    {
        private UserModel _currentUser;
        private ForumPostDAL _forumPostDAL = new ForumPostDAL();
        private Guna2TextBox tbTitle;
        private Guna2TextBox tbContent;
        private Guna2Button btnSave;
        public AddPostForm(UserModel currentUser)
        {
            _currentUser = currentUser;
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.Text = "Thêm bài viết mới";
            this.Size = new System.Drawing.Size(480, 460);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            Guna2HtmlLabel lblTitle = new Guna2HtmlLabel { Text = "Tiêu đề:", Left = 20, Top = 20, Width = 100, Font = new System.Drawing.Font("Segoe UI", 10F) };
            tbTitle = new Guna2TextBox { Left = 20, Top = 45, Width = 420, Font = new System.Drawing.Font("Segoe UI", 10F) };
            Guna2HtmlLabel lblContent = new Guna2HtmlLabel { Text = "Nội dung:", Left = 20, Top = 105, Width = 100, Font = new System.Drawing.Font("Segoe UI", 10F) };
            tbContent = new Guna2TextBox
            {
                Left = 20,
                Top = 130,
                Width = 420,
                Height = 180,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Font = new System.Drawing.Font("Segoe UI", 10F),
                AcceptsReturn = true,
                MaxLength = 0
            };
            
            btnSave = new Guna2Button 
            { 
                Text = "Lưu", 
                Left = (this.ClientSize.Width - 120) / 2, 
                Top = 350, 
                Width = 120,
                Height = 40,
                BorderRadius = 15,
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold),
                FillColor = System.Drawing.Color.FromArgb(94, 148, 255),
                ForeColor = System.Drawing.Color.White
            };
            btnSave.Click += BtnSave_Click;

            this.Controls.Add(lblTitle);
            this.Controls.Add(tbTitle);
            this.Controls.Add(lblContent);
            this.Controls.Add(tbContent);
            this.Controls.Add(btnSave);
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text.Trim();
            string content = tbContent.Text.Trim();
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tiêu đề và nội dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var post = new ForumPost
            {
                user_id = _currentUser.UserID,
                title = title,
                content = content
            };
            if (_forumPostDAL.AddPost(post))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm bài viết thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 
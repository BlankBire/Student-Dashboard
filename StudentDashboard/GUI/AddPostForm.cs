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
        private TextBox tbTitle;
        private TextBox tbContent;
        private Button btnSave;
        public AddPostForm(UserModel currentUser)
        {
            _currentUser = currentUser;
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.Text = "Thêm bài viết mới";
            this.Size = new System.Drawing.Size(400, 350);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            Label lblTitle = new Label { Text = "Tiêu đề:", Left = 20, Top = 20, Width = 60 };
            tbTitle = new TextBox { Left = 90, Top = 18, Width = 270 };
            Label lblContent = new Label { Text = "Nội dung:", Left = 20, Top = 60, Width = 70 };
            tbContent = new TextBox { Left = 20, Top = 90, Width = 340, Height = 140, Multiline = true, ScrollBars = ScrollBars.Vertical };
            btnSave = new Button { Text = "Lưu", Left = 140, Top = 250, Width = 100 };
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
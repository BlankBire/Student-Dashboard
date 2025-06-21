using System;
using System.Windows.Forms;
using StudentDashboard.Models;
using StudentDashboard.DAL;
using System.Collections.Generic;

namespace StudentDashboard.GUI
{
    public partial class ForumForm : Form
    {
        private UserModel _currentUser;
        private ForumPostDAL _forumPostDAL = new ForumPostDAL();
        private UserRepository _userRepo = new UserRepository();
        public ForumForm(UserModel currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            LoadPosts();
            btnAddPost.Click += btnAddPost_Click;
        }

        private void LoadPosts()
        {
            var posts = _forumPostDAL.GetAllPosts();
            var table = new System.Data.DataTable();
            table.Columns.Add("Tiêu đề");
            table.Columns.Add("Người đăng");
            table.Columns.Add("Ngày đăng");
            foreach (var post in posts)
            {
                var user = _userRepo.GetUserById(post.user_id);
                string userName = user != null ? user.user_name : "[Ẩn danh]";
                table.Rows.Add(post.title, userName, post.created_at.ToString("dd/MM/yyyy HH:mm"));
            }
            dgvPosts.DataSource = table;
        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddPostForm(_currentUser))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPosts();
                }
            }
        }
    }
} 
using System;
using System.Windows.Forms;
using StudentDashboard.Models;
using StudentDashboard.DAL;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace StudentDashboard.GUI
{
    public partial class ForumForm : Form
    {
        private UserModel _currentUser;
        private ForumPostDAL _forumPostDAL = new ForumPostDAL();
        private UserRepository _userRepo = new UserRepository();
        private List<ForumPost> _posts;
        private List<ForumPostViewModel> _postViewModels;

        public ForumForm(UserModel currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            SetupDataGridView();
            LoadPosts();
            btnAddPost.Click += btnAddPost_Click;
            dgvPosts.CellDoubleClick += dgvPosts_CellDoubleClick;
        }

        private void SetupDataGridView()
        {
            dgvPosts.AutoGenerateColumns = false;
            dgvPosts.Columns.Clear();

            dgvPosts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tiêu đề", DataPropertyName = "title", Width = 400 });
            dgvPosts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Người đăng", DataPropertyName = "user_name", Width = 150 });
            dgvPosts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày đăng", DataPropertyName = "created_at", DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" } });
        }

        private void LoadPosts()
        {
            _posts = _forumPostDAL.GetAllPosts();
            _postViewModels = _posts.Select(p => new ForumPostViewModel
            {
                post_id = p.post_id,
                user_id = p.user_id,
                title = p.title,
                content = p.content,
                created_at = p.created_at,
                user_name = _userRepo.GetUserById(p.user_id)?.user_name ?? "[Ẩn danh]"
            }).ToList();
            dgvPosts.DataSource = _postViewModels;
        }

        private void dgvPosts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedPost = _posts[e.RowIndex];
                using (var detailForm = new PostDetailForm(selectedPost, _currentUser))
                {
                    detailForm.ShowDialog();
                }
            }
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
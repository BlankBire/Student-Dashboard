using Guna.UI2.WinForms;
using StudentDashboard.Models;
using System.Windows.Forms;
using System.Drawing;
using StudentDashboard.DAL;
using System.Collections.Generic;

namespace StudentDashboard.GUI
{
    public partial class PostDetailForm : Form
    {
        private ForumPost _post;
        private UserModel _currentUser;
        private FlowLayoutPanel pnlComments;
        private Guna2TextBox txtNewComment;
        private Guna2Button btnSendComment;
        private ForumCommentDAL _commentDAL = new ForumCommentDAL();
        private UserRepository _userRepo = new UserRepository();

        public PostDetailForm(ForumPost post, UserModel currentUser)
        {
            _post = post;
            _currentUser = currentUser;
            InitializeComponent();
            btnSendComment.Click += BtnSendComment_Click;
            this.Load += PostDetailForm_Load;
        }

        private void PostDetailForm_Load(object sender, System.EventArgs e)
        {
            LoadComments();
        }

        private void LoadComments()
        {
            pnlComments.Controls.Clear();
            List<ForumComment> comments = _commentDAL.GetCommentsByPostId(_post.post_id);

            if (comments.Count == 0)
            {
                var noCommentLabel = new Guna2HtmlLabel
                {
                    Text = "Chưa có bình luận nào.",
                    Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Margin = new Padding(10)
                };
                pnlComments.Controls.Add(noCommentLabel);
                return;
            }

            foreach (var comment in comments)
            {
                var user = _userRepo.GetUserById(comment.user_id);
                string userName = user != null ? user.user_name : "[Ẩn danh]";

                var lblAuthor = new Guna2HtmlLabel
                {
                    Text = $"<b>{userName}</b> <span style='color:gray;'>- {comment.created_at:dd/MM/yyyy HH:mm}</span>",
                    Font = new Font("Segoe UI", 9F),
                    AutoSize = true,
                    BackColor = Color.Transparent,
                    Margin = new Padding(5, 5, 5, 0)
                };

                var lblContent = new Guna2HtmlLabel
                {
                    Text = comment.content,
                    Font = new Font("Segoe UI", 10F),
                    AutoSize = true,
                    BackColor = Color.Transparent,
                    Margin = new Padding(5, 0, 5, 5),
                    MaximumSize = new Size(pnlComments.ClientSize.Width - 30, 0)
                };
                
                var separator = new Guna2Separator
                {
                    Height = 2,
                    Margin = new Padding(5, 5, 5, 10),
                    Width = pnlComments.ClientSize.Width - 10
                };

                pnlComments.Controls.Add(lblAuthor);
                pnlComments.Controls.Add(lblContent);
                pnlComments.Controls.Add(separator);
            }
        }

        private void BtnSendComment_Click(object sender, System.EventArgs e)
        {
            string content = txtNewComment.Text.Trim();
            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Vui lòng nhập nội dung bình luận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newComment = new ForumComment
            {
                post_id = _post.post_id,
                user_id = _currentUser.UserID,
                content = content
            };

            if (_commentDAL.AddComment(newComment))
            {
                txtNewComment.Clear();
                LoadComments(); // Tải lại danh sách bình luận
            }
            else
            {
                MessageBox.Show("Gửi bình luận thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.Text = "Chi tiết bài viết";
            this.Size = new Size(800, 700);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;

            // Panel chứa toàn bộ nội dung
            var mainContainer = new Panel { Dock = DockStyle.Fill };

            // -- Phần tiêu đề --
            var lblTitle = new Guna2HtmlLabel
            {
                Text = _post.title,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                Dock = DockStyle.Top,
                Padding = new Padding(20),
                BackColor = Color.FromArgb(242, 245, 250),
                Height = 80
            };

            // -- Phần nội dung bài viết --
            var txtContent = new Guna2TextBox
            {
                Text = _post.content,
                Multiline = true,
                ReadOnly = true,
                Font = new Font("Segoe UI", 11F),
                BorderThickness = 0,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Top,
                Height = 200, // Giới hạn chiều cao để có không gian cho bình luận
                Margin = new Padding(20)
            };

            // -- Phần bình luận --
            var pnlCommentSection = new Panel { Dock = DockStyle.Fill, Padding = new Padding(20, 0, 20, 20) };

            pnlComments = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(5),
                BackColor = Color.FromArgb(248, 249, 250)
            };

            // -- Phần nhập bình luận mới --
            var pnlAddComment = new Panel { Dock = DockStyle.Bottom, Height = 60, Padding = new Padding(0, 10, 0, 10) };

            btnSendComment = new Guna2Button
            {
                Text = "Gửi",
                Dock = DockStyle.Right,
                Width = 90,
                Height = 40,
                BorderRadius = 5
            };

            txtNewComment = new Guna2TextBox
            {
                PlaceholderText = "Viết bình luận...",
                Dock = DockStyle.Fill,
                Height = 40,
                BorderRadius = 5
            };

            pnlAddComment.Controls.Add(txtNewComment);
            pnlAddComment.Controls.Add(btnSendComment);

            pnlCommentSection.Controls.Add(pnlComments);
            pnlCommentSection.Controls.Add(pnlAddComment);

            mainContainer.Controls.Add(pnlCommentSection);
            mainContainer.Controls.Add(txtContent);

            this.Controls.Add(mainContainer);
            this.Controls.Add(lblTitle);
        }
    }
}
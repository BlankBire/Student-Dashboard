using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;

namespace StudentDashboard.GUI
{
    partial class ForumForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvPosts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelDetail = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddPost = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.panelComments = new System.Windows.Forms.FlowLayoutPanel();
            this.lblComments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPosts
            // 
            this.dgvPosts.AllowUserToAddRows = false;
            this.dgvPosts.AllowUserToDeleteRows = false;
            this.dgvPosts.AllowUserToResizeRows = false;
            this.dgvPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosts.BackgroundColor = System.Drawing.Color.FromArgb(230, 240, 255);
            this.dgvPosts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPosts.ColumnHeadersHeight = 40;
            this.dgvPosts.Location = new System.Drawing.Point(20, 70);
            this.dgvPosts.Name = "dgvPosts";
            this.dgvPosts.ReadOnly = true;
            this.dgvPosts.RowHeadersVisible = false;
            this.dgvPosts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosts.Size = new System.Drawing.Size(350, 500);
            this.dgvPosts.TabIndex = 0;
            // 
            // btnAddPost
            // 
            this.btnAddPost.Text = "Thêm bài viết mới";
            this.btnAddPost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddPost.FillColor = System.Drawing.Color.FromArgb(60, 130, 246);
            this.btnAddPost.ForeColor = System.Drawing.Color.White;
            this.btnAddPost.BorderRadius = 10;
            this.btnAddPost.Size = new System.Drawing.Size(180, 40);
            this.btnAddPost.Location = new System.Drawing.Point(20, 20);
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.White;
            this.panelDetail.BorderRadius = 15;
            this.panelDetail.Location = new System.Drawing.Point(390, 20);
            this.panelDetail.Size = new System.Drawing.Size(500, 550);
            this.panelDetail.Controls.Add(this.lblTitle);
            this.panelDetail.Controls.Add(this.lblContent);
            this.panelDetail.Controls.Add(this.lblComments);
            this.panelDetail.Controls.Add(this.panelComments);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(60, 130, 246);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Size = new System.Drawing.Size(460, 30);
            this.lblTitle.Text = "Tiêu đề bài viết";
            // 
            // lblContent
            // 
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblContent.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblContent.Location = new System.Drawing.Point(20, 60);
            this.lblContent.Size = new System.Drawing.Size(460, 120);
            this.lblContent.Text = "Nội dung bài viết sẽ hiển thị ở đây.";
            this.lblContent.AutoEllipsis = true;
            // 
            // lblComments
            // 
            this.lblComments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblComments.ForeColor = System.Drawing.Color.FromArgb(60, 130, 246);
            this.lblComments.Location = new System.Drawing.Point(20, 190);
            this.lblComments.Size = new System.Drawing.Size(200, 25);
            this.lblComments.Text = "Bình luận";
            // 
            // panelComments
            // 
            this.panelComments.Location = new System.Drawing.Point(20, 220);
            this.panelComments.Size = new System.Drawing.Size(460, 300);
            this.panelComments.AutoScroll = true;
            this.panelComments.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            // 
            // ForumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(230, 240, 255);
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.dgvPosts);
            this.Controls.Add(this.panelDetail);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diễn đàn sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvPosts;
        private Guna.UI2.WinForms.Guna2Panel panelDetail;
        private Guna.UI2.WinForms.Guna2Button btnAddPost;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.FlowLayoutPanel panelComments;
        private System.Windows.Forms.Label lblComments;
    }
} 
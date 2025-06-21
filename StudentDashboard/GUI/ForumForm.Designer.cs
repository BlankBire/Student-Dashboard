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
            this.btnAddPost = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPosts
            // 
            this.dgvPosts.AllowUserToAddRows = false;
            this.dgvPosts.AllowUserToDeleteRows = false;
            this.dgvPosts.AllowUserToResizeRows = false;
            this.dgvPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosts.BackgroundColor = System.Drawing.Color.White;
            this.dgvPosts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPosts.ColumnHeadersHeight = 40;
            this.dgvPosts.Location = new System.Drawing.Point(20, 70);
            this.dgvPosts.Name = "dgvPosts";
            this.dgvPosts.ReadOnly = true;
            this.dgvPosts.RowHeadersVisible = false;
            this.dgvPosts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosts.Size = new System.Drawing.Size(880, 510);
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
            // ForumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.dgvPosts);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "ForumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diễn đàn sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvPosts;
        private Guna.UI2.WinForms.Guna2Button btnAddPost;
    }
} 
using MySql.Data.MySqlClient;
using StudentDashboard.Models;
using System;
using System.Collections.Generic;

namespace StudentDashboard.DAL
{
    public class ForumCommentDAL
    {
        public List<ForumComment> GetCommentsByPostId(int postId)
        {
            var comments = new List<ForumComment>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT comment_id, post_id, user_id, content, created_at FROM forumcomments WHERE post_id = @postId ORDER BY created_at ASC";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@postId", postId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comments.Add(new ForumComment
                            {
                                comment_id = reader.GetInt32("comment_id"),
                                post_id = reader.GetInt32("post_id"),
                                user_id = reader.GetInt32("user_id"),
                                content = reader.GetString("content"),
                                created_at = reader.GetDateTime("created_at")
                            });
                        }
                    }
                }
            }
            return comments;
        }

        public bool AddComment(ForumComment comment)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO forumcomments (post_id, user_id, content) VALUES (@postId, @userId, @content)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@postId", comment.post_id);
                    command.Parameters.AddWithValue("@userId", comment.user_id);
                    command.Parameters.AddWithValue("@content", comment.content);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
} 
using StudentDashboard.Models;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace StudentDashboard.DAL
{
    public class ForumPostDAL
    {
        public List<ForumPost> GetAllPosts()
        {
            List<ForumPost> posts = new List<ForumPost>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT post_id, user_id, title, content, created_at FROM forumposts ORDER BY created_at DESC";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            posts.Add(new ForumPost
                            {
                                post_id = reader.GetInt32(0),
                                user_id = reader.GetInt32(1),
                                title = reader.GetString(2),
                                content = reader.GetString(3),
                                created_at = reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4)
                            });
                        }
                    }
                }
            }
            return posts;
        }

        public bool AddPost(ForumPost post)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO forumposts (user_id, title, content) VALUES (@user_id, @title, @content)";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", post.user_id);
                    cmd.Parameters.AddWithValue("@title", post.title);
                    cmd.Parameters.AddWithValue("@content", post.content);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
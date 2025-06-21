using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDashboard.Models;

namespace StudentDashboard.DAL
{
    class UserRepository
    {
        public User GetUserById(int userId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM users WHERE user_id = @userId";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                user_id = Convert.ToInt32(reader["user_id"]),
                                user_name = reader["user_name"].ToString(),
                                user_email = reader["user_email"].ToString(),
                                user_password = reader["user_password"].ToString(),
                                user_role = reader["user_role"].ToString(),
                                user_created_at = Convert.ToDateTime(reader["user_created_at"])
                            };
                        }
                    }
                }
            }
            return null;
        }
        public bool UpdatePassword(int userId, string newPassword)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "UPDATE users SET user_password = @password WHERE user_id = @userId";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@password", newPassword);
                    command.Parameters.AddWithValue("@userId", userId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool UpdateUserInfo(int userId, string newUserName)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "UPDATE users SET user_name = @name WHERE user_id = @id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", newUserName);
                    command.Parameters.AddWithValue("@id", userId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
} 
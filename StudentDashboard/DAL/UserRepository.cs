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
            MySqlConnection connection = DatabaseHelper.GetConnection();
            if (connection != null)
            {
                try
                {
                    string query = "SELECT * FROM users WHERE user_id = @userId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        User user = new User
                        {
                            user_id = Convert.ToInt32(reader["user_id"]),
                            user_name = reader["user_name"].ToString(),
                            user_email = reader["user_email"].ToString(),
                            user_password = reader["user_password"].ToString(),
                            user_role = reader["user_role"].ToString(),
                            user_created_at = Convert.ToDateTime(reader["user_created_at"])
                        };
                        return user;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi truy vấn: " + ex.Message);
                }
                finally
                {
                    DatabaseHelper.CloseConnection(connection);
                }
            }
            return null;
        }
    }
}

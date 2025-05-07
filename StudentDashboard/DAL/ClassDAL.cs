using System.Collections.Generic;
using MySql.Data.MySqlClient;
using StudentDashboard.Models;

namespace StudentDashboard.DAL
{
    public class ClassDAL
    {
        private string connectionString;

        public ClassDAL()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        }

        public List<ClassModel> GetAllClasses()
        {
            List<ClassModel> classes = new List<ClassModel>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM classes";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            classes.Add(new ClassModel
                            {
                                class_id = reader.GetInt32("class_id"),
                                class_name = reader.GetString("class_name")
                            });
                        }
                    }
                }
            }
            return classes;
        }
    }
} 
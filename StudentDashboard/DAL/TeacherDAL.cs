using System.Collections.Generic;
using MySql.Data.MySqlClient;
using StudentDashboard.Models;

namespace StudentDashboard.DAL
{
    public class TeacherDAL
    {
        private string connectionString;

        public TeacherDAL()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        }

        public List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM teachers";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teachers.Add(new Teacher
                            {
                                teacher_id = reader.GetInt32("teacher_id"),
                                teacher_name = reader.GetString("teacher_name")
                            });
                        }
                    }
                }
            }
            return teachers;
        }
    }
} 
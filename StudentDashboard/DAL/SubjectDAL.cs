using System.Collections.Generic;
using MySql.Data.MySqlClient;
using StudentDashboard.Models;

namespace StudentDashboard.DAL
{
    public class SubjectDAL
    {
        private string connectionString;

        public SubjectDAL()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        }

        public List<Subject> GetAllSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM subjects";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjects.Add(new Subject
                            {
                                subject_id = reader.GetInt32("subject_id"),
                                subject_name = reader.GetString("subject_name")
                            });
                        }
                    }
                }
            }
            return subjects;
        }
    }
} 
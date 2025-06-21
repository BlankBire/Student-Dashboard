using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using StudentDashboard.Models;

namespace StudentDashboard.DAL
{
    internal class SchedulesRepository
    {
        public static void AddSchedule(Schedule s)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO schedules (user_id, title, description, date, time, create_at) VALUES (@user_id, @title, @description, @date, @time, @create_at)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user_id", s.user_id);
                cmd.Parameters.AddWithValue("@title", s.title);
                cmd.Parameters.AddWithValue("@description", s.description);
                cmd.Parameters.AddWithValue("@date", s.date);
                cmd.Parameters.AddWithValue("@time", s.time);
                cmd.Parameters.AddWithValue("@create_at", DateTime.Now);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Schedule> GetSchedulesByUserId(int userId)
        {
            List<Schedule> schedules = new List<Schedule>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM schedules WHERE user_id = @user_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user_id", userId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Schedule schedule = new Schedule
                        {
                            schedule_id = Convert.ToInt32(reader["schedule_id"]),
                            user_id = Convert.ToInt32(reader["user_id"]),
                            title = reader["title"].ToString(),
                            description = reader["description"].ToString(),
                            date = Convert.ToDateTime(reader["date"]),
                            time = TimeSpan.Parse(reader["time"].ToString()),
                            create_at = Convert.ToDateTime(reader["create_at"])
                        };
                        schedules.Add(schedule);
                    }
                }
            }

            return schedules;
        }
    }

}

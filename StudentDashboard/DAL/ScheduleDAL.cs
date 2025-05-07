using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using StudentDashboard.Models;

namespace StudentDashboard.DAL
{
    public class ScheduleDAL
    {
        private string connectionString;

        public ScheduleDAL()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        }

        public List<Schedule> GetAllSchedules()
        {
            List<Schedule> schedules = new List<Schedule>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM schedules";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            schedules.Add(MapReaderToSchedule(reader));
                        }
                    }
                }
            }
            return schedules;
        }

        public Schedule GetScheduleById(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM schedules WHERE schedule_id = @schedule_id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@schedule_id", id);
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapReaderToSchedule(reader);
                        }
                    }
                }
            }
            return null;
        }

        public List<Schedule> GetSchedulesByClass(string class_name)
        {
            List<Schedule> schedules = new List<Schedule>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM schedules WHERE class_name = @class_name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@class_name", class_name);
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            schedules.Add(MapReaderToSchedule(reader));
                        }
                    }
                }
            }
            return schedules;
        }

        public List<Schedule> GetSchedulesByTeacher(string teacher_name)
        {
            List<Schedule> schedules = new List<Schedule>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM schedules WHERE teacher_name = @teacher_name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@teacher_name", teacher_name);
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            schedules.Add(MapReaderToSchedule(reader));
                        }
                    }
                }
            }
            return schedules;
        }

        public bool AddSchedule(Schedule schedule)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"INSERT INTO schedules (user_id, title, description, date, time, 
                               subject_name, teacher_name, room, day_of_week, start_time, end_time, 
                               class_name, semester, academic_year)
                               VALUES (@user_id, @title, @description, @date, @time,
                               @subject_name, @teacher_name, @room, @day_of_week, @start_time, @end_time,
                               @class_name, @semester, @academic_year)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", schedule.user_id);
                    cmd.Parameters.AddWithValue("@title", schedule.title);
                    cmd.Parameters.AddWithValue("@description", (object)schedule.description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@date", schedule.date);
                    cmd.Parameters.AddWithValue("@time", schedule.time);
                    cmd.Parameters.AddWithValue("@subject_name", (object)schedule.subject_name ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@teacher_name", (object)schedule.teacher_name ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@room", (object)schedule.room ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@day_of_week", (object)schedule.day_of_week ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@start_time", (object)schedule.start_time ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@end_time", (object)schedule.end_time ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@class_name", (object)schedule.class_name ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@semester", (object)schedule.semester ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@academic_year", (object)schedule.academic_year ?? DBNull.Value);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateSchedule(Schedule schedule)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"UPDATE schedules 
                               SET user_id = @user_id,
                                   title = @title,
                                   description = @description,
                                   date = @date,
                                   time = @time,
                                   subject_name = @subject_name,
                                   teacher_name = @teacher_name,
                                   room = @room,
                                   day_of_week = @day_of_week,
                                   start_time = @start_time,
                                   end_time = @end_time,
                                   class_name = @class_name,
                                   semester = @semester,
                                   academic_year = @academic_year
                               WHERE schedule_id = @schedule_id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@schedule_id", schedule.schedule_id);
                    cmd.Parameters.AddWithValue("@user_id", schedule.user_id);
                    cmd.Parameters.AddWithValue("@title", schedule.title);
                    cmd.Parameters.AddWithValue("@description", (object)schedule.description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@date", schedule.date);
                    cmd.Parameters.AddWithValue("@time", schedule.time);
                    cmd.Parameters.AddWithValue("@subject_name", (object)schedule.subject_name ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@teacher_name", (object)schedule.teacher_name ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@room", (object)schedule.room ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@day_of_week", (object)schedule.day_of_week ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@start_time", (object)schedule.start_time ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@end_time", (object)schedule.end_time ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@class_name", (object)schedule.class_name ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@semester", (object)schedule.semester ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@academic_year", (object)schedule.academic_year ?? DBNull.Value);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteSchedule(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM schedules WHERE schedule_id = @schedule_id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@schedule_id", id);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteAllSchedulesByUser(int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM schedules WHERE user_id = @user_id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Schedule MapReaderToSchedule(MySqlDataReader reader)
        {
            return new Schedule
            {
                schedule_id = Convert.ToInt32(reader["schedule_id"]),
                user_id = Convert.ToInt32(reader["user_id"]),
                title = reader["title"].ToString(),
                description = reader["description"] != DBNull.Value ? reader["description"].ToString() : null,
                date = Convert.ToDateTime(reader["date"]),
                time = (TimeSpan)reader["time"],
                create_at = reader["create_at"] != DBNull.Value ? Convert.ToDateTime(reader["create_at"]) : DateTime.MinValue,
                subject_name = reader["subject_name"] != DBNull.Value ? reader["subject_name"].ToString() : null,
                teacher_name = reader["teacher_name"] != DBNull.Value ? reader["teacher_name"].ToString() : null,
                room = reader["room"] != DBNull.Value ? reader["room"].ToString() : null,
                day_of_week = reader["day_of_week"] != DBNull.Value ? Convert.ToInt32(reader["day_of_week"]) : (int?)null,
                start_time = reader["start_time"] != DBNull.Value ? (TimeSpan?)reader["start_time"] : null,
                end_time = reader["end_time"] != DBNull.Value ? (TimeSpan?)reader["end_time"] : null,
                class_name = reader["class_name"] != DBNull.Value ? reader["class_name"].ToString() : null,
                semester = reader["semester"] != DBNull.Value ? reader["semester"].ToString() : null,
                academic_year = reader["academic_year"] != DBNull.Value ? Convert.ToInt32(reader["academic_year"]) : (int?)null
            };
        }
    }
} 
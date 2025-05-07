using System.Collections.Generic;
using MySql.Data.MySqlClient;
using StudentDashboard.Models;

namespace StudentDashboard.DAL
{
    public class RoomDAL
    {
        private string connectionString;

        public RoomDAL()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        }

        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM rooms";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new Room
                            {
                                room_id = reader.GetInt32("room_id"),
                                room_name = reader.GetString("room_name")
                            });
                        }
                    }
                }
            }
            return rooms;
        }
    }
} 
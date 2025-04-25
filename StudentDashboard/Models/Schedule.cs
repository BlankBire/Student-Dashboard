using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDashboard.Models
{
    class Schedule
    {
        public int schedule_id { get; set; }
        public int user_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public TimeSpan time { get; set; }
        public DateTime create_at { get; set; }
    }
}
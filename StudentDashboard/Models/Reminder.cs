using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDashboard.Models
{
    class Reminder
    {
        public int reminder_id { get; set; }
        public int user_id { get; set; }
        public int schedule_id { get; set; }
        public DateTime remind_time { get; set; }
        public string status { get; set; }
    }
}

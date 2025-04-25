using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDashboard.Models
{
    class Message
    {
        public int message_id { get; set; }
        public int sender_id { get; set; }
        public int receiver_id { get; set; }
        public string content { get; set; }
        public DateTime sent_at { get; set; }
    }
}
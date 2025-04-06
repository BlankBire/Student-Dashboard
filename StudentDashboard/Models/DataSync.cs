using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDashboard.Models
{
    class DataSync
    {
        public int sync_id { get; set; }
        public int user_id { get; set; }
        public string status { get; set; } 
        public DateTime last_sync { get; set; } 
    }
}

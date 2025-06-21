using System;

namespace StudentDashboard.Models
{
    public class ForumPostViewModel
    {
        public int post_id { get; set; }
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime created_at { get; set; }
    }
} 
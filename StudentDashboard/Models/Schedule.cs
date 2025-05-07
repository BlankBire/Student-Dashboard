using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDashboard.Models
{
    public class Schedule
    {
        public int schedule_id { get; set; }
        public int user_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public TimeSpan time { get; set; }
        public DateTime create_at { get; set; }
        
        // Thêm các thuộc tính mới cho thời khóa biểu
        public string subject_name { get; set; }
        public string teacher_name { get; set; }
        public string room { get; set; }
        public int? day_of_week { get; set; }
        public TimeSpan? start_time { get; set; }
        public TimeSpan? end_time { get; set; }
        public string class_name { get; set; }
        public string semester { get; set; }
        public int? academic_year { get; set; }
    }
}
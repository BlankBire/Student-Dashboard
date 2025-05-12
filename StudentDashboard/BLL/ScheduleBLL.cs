using System;
using System.Collections.Generic;
using StudentDashboard.Models;
using StudentDashboard.DAL;

namespace StudentDashboard.BLL
{
    public class ScheduleBLL
    {
        private ScheduleDAL scheduleDAL;

        public ScheduleBLL()
        {
            scheduleDAL = new ScheduleDAL();
        }

        public List<Schedule> GetAllSchedulesSorted()
        {
            return scheduleDAL.GetAllSchedulesSorted();
        }

        public Schedule GetScheduleById(int id)
        {
            return scheduleDAL.GetScheduleById(id);
        }

        public bool AddSchedule(Schedule schedule)
        {
            // Validate schedule data
            if (schedule.user_id <= 0)
            {
                throw new ArgumentException("Vui lòng chọn người dùng");
            }

            // Validate time if it's a class schedule
            if (!string.IsNullOrEmpty(schedule.subject_name))
            {
                if (string.IsNullOrEmpty(schedule.teacher_name) ||
                    string.IsNullOrEmpty(schedule.room) ||
                    string.IsNullOrEmpty(schedule.class_name))
                {
                    throw new ArgumentException("Vui lòng điền đầy đủ thông tin cho lịch học");
                }

                if (schedule.start_time.HasValue && schedule.end_time.HasValue && schedule.start_time >= schedule.end_time)
                {
                    throw new ArgumentException("Thời gian kết thúc phải sau thời gian bắt đầu");
                }
            }

            return scheduleDAL.AddSchedule(schedule);
        }

        public bool UpdateSchedule(Schedule schedule)
        {
            // Validate schedule data
            if (schedule.user_id <= 0)
            {
                throw new ArgumentException("Vui lòng chọn người dùng");
            }

            // Validate time if it's a class schedule
            if (!string.IsNullOrEmpty(schedule.subject_name))
            {
                if (string.IsNullOrEmpty(schedule.teacher_name) ||
                    string.IsNullOrEmpty(schedule.room) ||
                    string.IsNullOrEmpty(schedule.class_name))
                {
                    throw new ArgumentException("Vui lòng điền đầy đủ thông tin cho lịch học");
                }

                if (schedule.start_time.HasValue && schedule.end_time.HasValue && schedule.start_time >= schedule.end_time)
                {
                    throw new ArgumentException("Thời gian kết thúc phải sau thời gian bắt đầu");
                }
            }

            return scheduleDAL.UpdateSchedule(schedule);
        }

        public bool DeleteSchedule(int id)
        {
            return scheduleDAL.DeleteSchedule(id);
        }

        public List<Schedule> GetSchedulesByClass(string className)
        {
            return scheduleDAL.GetSchedulesByClass(className);
        }

        public List<Schedule> GetSchedulesByTeacher(string teacherName)
        {
            return scheduleDAL.GetSchedulesByTeacher(teacherName);
        }

        public bool DeleteAllSchedulesByUser(int userId)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("User ID không hợp lệ");
            }
            return scheduleDAL.DeleteAllSchedulesByUser(userId);
        }
    }
} 
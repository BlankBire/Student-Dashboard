using System;
using System.Windows.Forms;
using StudentDashboard.DAL;
using StudentDashboard.Models;

namespace StudentDashboard.GUI
{
    public partial class AddScheduleForm : Form
    {
        public Schedule NewSchedule { get; private set; }
        private int _userId;

        public AddScheduleForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            // Môn học
            var subjectDAL = new SubjectDAL();
            cbSubject.DataSource = subjectDAL.GetAllSubjects();
            cbSubject.DisplayMember = "subject_name";
            cbSubject.ValueMember = "subject_id";

            // Giáo viên
            var teacherDAL = new TeacherDAL();
            cbTeacher.DataSource = teacherDAL.GetAllTeachers();
            cbTeacher.DisplayMember = "teacher_name";
            cbTeacher.ValueMember = "teacher_id";

            // Phòng
            var roomDAL = new RoomDAL();
            cbRoom.DataSource = roomDAL.GetAllRooms();
            cbRoom.DisplayMember = "room_name";
            cbRoom.ValueMember = "room_id";

            // Lớp
            var classDAL = new ClassDAL();
            cbClass.DataSource = classDAL.GetAllClasses();
            cbClass.DisplayMember = "class_name";
            cbClass.ValueMember = "class_id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate dữ liệu
            if (cbSubject.SelectedItem == null || cbTeacher.SelectedItem == null ||
                cbRoom.SelectedItem == null || cbClass.SelectedItem == null ||
                cbDayOfWeek.SelectedIndex == -1 || cbStartPeriod.SelectedIndex == -1 || cbEndPeriod.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin.");
                return;
            }

            int startPeriod = cbStartPeriod.SelectedIndex;
            int endPeriod = cbEndPeriod.SelectedIndex;
            if (startPeriod >= endPeriod)
            {
                MessageBox.Show("Tiết bắt đầu phải nhỏ hơn tiết kết thúc.");
                return;
            }

            // Chuyển thứ về int (Thứ 2 = 1, Chủ nhật = 7)
            int dayOfWeek = cbDayOfWeek.SelectedIndex + 1;

            // Bảng ánh xạ tiết -> thời gian bắt đầu
            TimeSpan[] periodStartTimes = new[]
            {
                new TimeSpan(7,30,0),   // Tiết 1
                new TimeSpan(8,15,0),   // Tiết 2
                new TimeSpan(9,0,0),    // Tiết 3
                new TimeSpan(10,0,0),   // Tiết 4
                new TimeSpan(10,45,0),  // Tiết 5
                new TimeSpan(13,0,0),   // Tiết 6
                new TimeSpan(13,45,0),  // Tiết 7
                new TimeSpan(14,30,0),  // Tiết 8
                new TimeSpan(15,30,0),  // Tiết 9
                new TimeSpan(16,15,0)   // Tiết 10
            };
                        // Bảng ánh xạ tiết -> thời gian kết thúc
                        TimeSpan[] periodEndTimes = new[]
                        {
                new TimeSpan(8,15,0),   // Kết thúc tiết 1
                new TimeSpan(9,0,0),    // Kết thúc tiết 2
                new TimeSpan(9,45,0),   // Kết thúc tiết 3
                new TimeSpan(10,45,0),  // Kết thúc tiết 4
                new TimeSpan(11,30,0),  // Kết thúc tiết 5
                new TimeSpan(13,45,0),  // Kết thúc tiết 6
                new TimeSpan(14,30,0),  // Kết thúc tiết 7
                new TimeSpan(15,15,0),  // Kết thúc tiết 8
                new TimeSpan(16,15,0),  // Kết thúc tiết 9
                new TimeSpan(17,0,0)    // Kết thúc tiết 10
            };

            TimeSpan startTime = periodStartTimes[startPeriod];
            TimeSpan endTime = periodEndTimes[endPeriod];

            var scheduleDAL = new ScheduleDAL();
            var userSchedules = scheduleDAL.GetSchedulesByUserAndDay(_userId, dayOfWeek); 

            bool IsOverlapping(TimeSpan s1, TimeSpan e1, TimeSpan s2, TimeSpan e2) =>
                s1 < e2 && s2 < e1;

            foreach (var s in userSchedules)
            {
                if (s.start_time.HasValue && s.end_time.HasValue &&
                    IsOverlapping(startTime, endTime, s.start_time.Value, s.end_time.Value))
                {
                    MessageBox.Show($"Bạn đã có môn '{s.subject_name}' từ {s.start_time:hh\\:mm} đến {s.end_time:hh\\:mm}.");
                    return;
                }
            }

            // Tạo đối tượng Schedule
            NewSchedule = new Schedule
            {
                user_id = _userId,
                subject_name = ((Subject)cbSubject.SelectedItem).subject_name,
                teacher_name = ((Teacher)cbTeacher.SelectedItem).teacher_name,
                room = ((Room)cbRoom.SelectedItem).room_name,
                class_name = ((ClassModel)cbClass.SelectedItem).class_name,
                day_of_week = dayOfWeek,
                start_time = startTime,
                end_time = endTime,
                title = ((Subject)cbSubject.SelectedItem).subject_name, 
                description = "",
                date = DateTime.Today, 
                time = startTime,     
                create_at = DateTime.Now
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
} 
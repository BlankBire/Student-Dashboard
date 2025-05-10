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
            // Validate dữ liệu (có thể mở rộng thêm)
            if (cbSubject.SelectedItem == null || cbTeacher.SelectedItem == null || cbRoom.SelectedItem == null || cbClass.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin.");
                return;
            }
            if (dtpStartTime.Value.TimeOfDay >= dtpEndTime.Value.TimeOfDay)
            {
                MessageBox.Show("Giờ kết thúc phải sau giờ bắt đầu.");
                return;
            }
            // Lấy giờ bắt đầu và kết thúc, ép giây về 0
            var start = dtpStartTime.Value;
            var end = dtpEndTime.Value;
            var startTime = new TimeSpan(start.Hour, start.Minute, 0);
            var endTime = new TimeSpan(end.Hour, end.Minute, 0);
            // Tạo đối tượng Schedule (có UserID)
            NewSchedule = new Schedule
            {
                user_id = _userId,
                subject_name = ((Subject)cbSubject.SelectedItem).subject_name,
                teacher_name = ((Teacher)cbTeacher.SelectedItem).teacher_name,
                room = ((Room)cbRoom.SelectedItem).room_name,
                class_name = ((ClassModel)cbClass.SelectedItem).class_name,
                date = dtpDate.Value.Date,
                start_time = startTime,
                end_time = endTime,
                semester = txtSemester.Text.Trim(),
                academic_year = (int)numAcademicYear.Value
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
} 
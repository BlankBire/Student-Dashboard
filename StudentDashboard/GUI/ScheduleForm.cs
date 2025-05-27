using System;
using System.Windows.Forms;
using System.Linq;
using StudentDashboard.Models;
using StudentDashboard.BLL;

namespace StudentDashboard.GUI
{
    public class ScheduleForm : Form
    {
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private ScheduleWeekView weekView;
        private int _userId;
        private int? _selectedScheduleId = null;

        public ScheduleForm(int userId)
        {
            _userId = userId;
            InitializeComponent();
            weekView.ScheduleSelected += OnScheduleSelected;
            LoadScheduleData();
        }

        private void InitializeComponent()
        {
            this.Text = "Thời khóa biểu";
            this.Size = new System.Drawing.Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            weekView = new ScheduleWeekView
            {
                Dock = DockStyle.Fill
            };

            btnAdd = new Button
            {
                Text = "Thêm mới",
                Dock = DockStyle.Bottom,
                Height = 40
            };
            btnAdd.Click += BtnAdd_Click;

            btnDelete = new Button
            {
                Text = "Xóa",
                Dock = DockStyle.Bottom,
                Height = 40
            };
            btnDelete.Click += BtnDelete_Click;

            btnEdit = new Button
            {
                Text = "Làm mới",
                Dock = DockStyle.Bottom,
                Height = 40
            };
            btnEdit.Click += BtnRefresh_Click;

            this.Controls.Add(weekView);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnEdit);
        }
        private void OnScheduleSelected(int scheduleId)
        {
            _selectedScheduleId = scheduleId;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddScheduleForm(_userId);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var scheduleBLL = new ScheduleBLL();
                try
                {
                    scheduleBLL.AddSchedule(addForm.NewSchedule);
                    LoadScheduleData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedScheduleId.HasValue)
            {
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa môn này khỏi thời khóa biểu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    var scheduleBLL = new ScheduleBLL();
                    scheduleBLL.DeleteSchedule(_selectedScheduleId.Value);
                    _selectedScheduleId = null;
                    LoadScheduleData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học trên lưới để xóa!");
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ thời khóa biểu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                var scheduleBLL = new ScheduleBLL();
                scheduleBLL.DeleteAllSchedulesByUser(_userId);
                _selectedScheduleId = null;
                LoadScheduleData();
            }
        }

        private void LoadScheduleData()
        {
            var scheduleBLL = new ScheduleBLL();
            var schedules = scheduleBLL.GetAllSchedulesSorted().Where(s => s.user_id == _userId).ToList();
            weekView.LoadSchedules(schedules);
        }
    }
} 
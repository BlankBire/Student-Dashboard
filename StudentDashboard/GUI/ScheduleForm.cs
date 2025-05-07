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
        private DataGridView dgvSchedule;
        private int _userId;

        public ScheduleForm(int userId)
        {
            _userId = userId;
            InitializeComponent();
            LoadScheduleData();
        }

        private void InitializeComponent()
        {
            this.Text = "Thời khóa biểu";
            this.Size = new System.Drawing.Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialize DataGridView
            dgvSchedule = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dgvSchedule.CellFormatting += DgvSchedule_CellFormatting;

            // Initialize Buttons
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

            // Add controls to form
            this.Controls.Add(dgvSchedule);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnEdit);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddScheduleForm(_userId);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var scheduleBLL = new ScheduleBLL();
                scheduleBLL.AddSchedule(addForm.NewSchedule);
                LoadScheduleData();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count > 0)
            {
                var selectedRow = dgvSchedule.SelectedRows[0];
                var schedule = (Schedule)selectedRow.DataBoundItem;
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa môn này khỏi thời khóa biểu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    var scheduleBLL = new ScheduleBLL();
                    scheduleBLL.DeleteSchedule(schedule.schedule_id);
                    LoadScheduleData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ thời khóa biểu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                var scheduleBLL = new ScheduleBLL();
                scheduleBLL.DeleteAllSchedulesByUser(_userId);
                LoadScheduleData();
            }
        }

        private void LoadScheduleData()
        {
            var scheduleBLL = new ScheduleBLL();
            var schedules = scheduleBLL.GetAllSchedules().Where(s => s.user_id == _userId).ToList();
            dgvSchedule.DataSource = schedules;

            // Ẩn các cột không cần thiết
            dgvSchedule.Columns["schedule_id"].Visible = false;
            dgvSchedule.Columns["user_id"].Visible = false;
            dgvSchedule.Columns["title"].Visible = false;
            dgvSchedule.Columns["description"].Visible = false;
            dgvSchedule.Columns["time"].Visible = false;
            dgvSchedule.Columns["create_at"].Visible = false;
            dgvSchedule.Columns["day_of_week"].Visible = false;

            // Đổi tên hiển thị các cột
            dgvSchedule.Columns["date"].HeaderText = "Ngày";
            dgvSchedule.Columns["subject_name"].HeaderText = "Môn học";
            dgvSchedule.Columns["teacher_name"].HeaderText = "Giáo viên";
            dgvSchedule.Columns["room"].HeaderText = "Phòng học";
            dgvSchedule.Columns["start_time"].HeaderText = "Giờ bắt đầu";
            dgvSchedule.Columns["end_time"].HeaderText = "Giờ kết thúc";
            dgvSchedule.Columns["class_name"].HeaderText = "Lớp";
            dgvSchedule.Columns["semester"].HeaderText = "Học kỳ";
            dgvSchedule.Columns["academic_year"].HeaderText = "Năm học";

            // Định dạng hiển thị
            dgvSchedule.Columns["date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSchedule.Columns["start_time"].DefaultCellStyle.Format = "HH:mm";
            dgvSchedule.Columns["end_time"].DefaultCellStyle.Format = "HH:mm";
        }

        private void DgvSchedule_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSchedule.Columns[e.ColumnIndex].Name == "start_time" || dgvSchedule.Columns[e.ColumnIndex].Name == "end_time")
            {
                if (e.Value != null && e.Value is TimeSpan ts)
                {
                    e.Value = ts.ToString(@"hh\:mm");
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }
    }
} 
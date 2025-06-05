using System;
using System.Windows.Forms;
using System.Linq;
using StudentDashboard.Models;
using StudentDashboard.BLL;
using Guna.UI2.WinForms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace StudentDashboard.GUI
{
    public class ScheduleForm : Form
    {
        private Guna2Button btnEdit;
        private Guna2Button btnDelete;
        private Guna2Button btnAdd;
        private ScheduleWeekView weekView;
        private int _userId;
        private int? _selectedScheduleId = null;
        private Guna2Panel buttonPanel;
        private Panel mainContainer;
        private Panel buttonContainer; // Panel to hold buttons for centering

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
            this.BackColor = System.Drawing.Color.White;

            // Create main container with gradient
            mainContainer = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };
            mainContainer.Paint += (sender, e) =>
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    mainContainer.ClientRectangle,
                    Color.FromArgb(130, 110, 230), // Màu tím/xanh lam nhạt
                    Color.FromArgb(0, 200, 200), // Màu xanh lục/lam
                    LinearGradientMode.Horizontal))
                {
                    e.Graphics.FillRectangle(brush, mainContainer.ClientRectangle);
                }
            };

            // Create button panel
            buttonPanel = new Guna2Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                Padding = new Padding(10),
                FillColor = System.Drawing.Color.FromArgb(240, 240, 240),
                ShadowDecoration = { Enabled = true, Depth = 5, Color = System.Drawing.Color.FromArgb(0, 0, 0, 50) }
            };
            // Add resize event to buttonPanel for centering buttons
            buttonPanel.Resize += ButtonPanel_Resize;

            // Create panel to hold buttons
            buttonContainer = new Panel
            {
                AutoSize = true, // Auto size based on contents
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(0) // No padding needed here
            };

            weekView = new ScheduleWeekView
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent // Ensure background is transparent
            };

            btnAdd = new Guna2Button
            {
                Text = "Thêm mới",
                Size = new System.Drawing.Size(120, 40),
                BorderRadius = 8,
                FillColor = System.Drawing.Color.FromArgb(94, 148, 255),
                HoverState = { FillColor = System.Drawing.Color.FromArgb(74, 128, 235) },
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White
            };
            btnAdd.Click += BtnAdd_Click;

            btnDelete = new Guna2Button
            {
                Text = "Xóa",
                Size = new System.Drawing.Size(120, 40),
                BorderRadius = 8,
                FillColor = System.Drawing.Color.FromArgb(255, 87, 87),
                HoverState = { FillColor = System.Drawing.Color.FromArgb(235, 67, 67) },
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White
            };
            btnDelete.Click += BtnDelete_Click;

            btnEdit = new Guna2Button
            {
                Text = "Làm mới",
                Size = new System.Drawing.Size(120, 40),
                BorderRadius = 8,
                FillColor = System.Drawing.Color.FromArgb(46, 204, 113),
                HoverState = { FillColor = System.Drawing.Color.FromArgb(26, 184, 93) },
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White
            };
            btnEdit.Click += BtnRefresh_Click;

            // Add buttons to the button container
            buttonContainer.Controls.AddRange(new Control[] { btnAdd, btnDelete, btnEdit });
            // Arrange buttons horizontally within the container with some spacing
            btnAdd.Location = new System.Drawing.Point(0, 0);
            btnDelete.Location = new System.Drawing.Point(btnAdd.Right + 20, 0); // 20 pixels spacing
            btnEdit.Location = new System.Drawing.Point(btnDelete.Right + 20, 0);

            // Add button container to buttonPanel
            buttonPanel.Controls.Add(buttonContainer);

            mainContainer.Controls.Add(weekView);
            this.Controls.AddRange(new Control[] { mainContainer, buttonPanel });
            
            // Initial centering
            ButtonPanel_Resize(this, EventArgs.Empty);
        }

        // Handle buttonPanel resize to center the buttonContainer
        private void ButtonPanel_Resize(object sender, EventArgs e)
        {
            if (buttonPanel.Width > buttonContainer.Width)
            {
                int x = (buttonPanel.Width - buttonContainer.Width) / 2;
                buttonContainer.Location = new System.Drawing.Point(x, (buttonPanel.Height - buttonContainer.Height) / 2); // Center vertically too
            } else
            {
                // If panel is smaller than buttons, just place at 0, center vertically
                buttonContainer.Location = new System.Drawing.Point(0, (buttonPanel.Height - buttonContainer.Height) / 2);
            }
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
                MessageBox.Show("Vui lòng chọn môn học để xóa!");
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
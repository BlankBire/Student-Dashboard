using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using StudentDashboard.Models;

namespace StudentDashboard.GUI
{
    public class ScheduleWeekView : UserControl
    {
        private TableLayoutPanel table;
        private Label _selectedLabel = null;
        public event Action<int> ScheduleSelected;
        private readonly string[] days = { "", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "CN" };
        private readonly (string, string)[] periods = new (string, string)[]
        {
            ("Tiết 1", "7:30 - 8:15"),
            ("Tiết 2", "8:15 - 9:00"),
            ("Tiết 3", "9:00 - 9:45"),
            ("Tiết 4", "10:00 - 10:45"),
            ("Tiết 5", "10:45 - 11:30"),
            ("Tiết 6", "13:00 - 13:45"),
            ("Tiết 7", "13:45 - 14:30"),
            ("Tiết 8", "14:30 - 15:15"),
            ("Tiết 9", "15:30 - 16:15"),
            ("Tiết 10", "16:15 - 17:00"),
        };

        public ScheduleWeekView()
        {
            table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 8, 
                RowCount = 11,   
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
            };
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            for (int i = 1; i < 11; i++)
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            for (int i = 0; i < 8; i++)
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));

            // Thêm tiêu đề các cột
            for (int i = 0; i < 8; i++)
            {
                var lbl = new Label
                {
                    Text = days[i],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.LightGray,
                    Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold)
                };
                table.Controls.Add(lbl, i, 0);
            }

            // Thêm chú thích tiết vào cột đầu tiên
            for (int i = 0; i < periods.Length; i++)
            {
                var lbl = new Label
                {
                    Text = $"{periods[i].Item1}\n{periods[i].Item2}",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.WhiteSmoke,
                    Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular)
                };
                table.Controls.Add(lbl, 0, i + 1);
            }

            this.Controls.Add(table);
        }

        public void LoadSchedules(List<Schedule> schedules)
        {
            // Xóa các label cũ (trừ header)
            for (int r = 1; r < table.RowCount; r++)
                for (int c = 1; c < table.ColumnCount; c++)
                {
                    var ctrl = table.GetControlFromPosition(c, r);
                    if (ctrl != null) table.Controls.Remove(ctrl);
                }

            foreach (var s in schedules)
            {
                // Xác định cột (thứ) và dòng (tiết)
                if (!s.day_of_week.HasValue) continue; // Bỏ qua nếu chưa có thứ
                int col = s.day_of_week.Value;
                int startPeriod = GetPeriodIndex(s.start_time);
                int endPeriod = GetPeriodIndex(s.end_time);
                int row = startPeriod + 1;
                int rowSpan = endPeriod - startPeriod;
                if (rowSpan < 1) rowSpan = 1;
                if (row < 1 || row + rowSpan - 1 > 10 || col < 1 || col > 7) continue;

                var lbl = new Label
                {
                    Text = $"{s.class_name}\n{s.subject_name}\n{s.room}\n{s.start_time:hh\\:mm} - {s.end_time:hh\\:mm}",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.LightBlue,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(2),
                    Tag = s.schedule_id
                };
                lbl.Click += (sender, e) =>
                {
                    if (_selectedLabel != null)
                        _selectedLabel.BackColor = Color.LightBlue;
                    lbl.BackColor = Color.DodgerBlue;
                    _selectedLabel = lbl;
                    ScheduleSelected?.Invoke(s.schedule_id);
                };
                table.Controls.Add(lbl, col, row);
                table.SetRowSpan(lbl, rowSpan);
            }
        }

        // Hàm xác định tiết dựa vào giờ bắt đầu
        private int GetPeriodIndex(TimeSpan? startTime)
        {
            if (!startTime.HasValue) return 0;
            var times = new[]
            {
                new TimeSpan(7,30,0),
                new TimeSpan(8,15,0),
                new TimeSpan(9,0,0),
                new TimeSpan(10,0,0),
                new TimeSpan(10,45,0),
                new TimeSpan(13,0,0),
                new TimeSpan(13,45,0),
                new TimeSpan(14,30,0),
                new TimeSpan(15,30,0),
                new TimeSpan(16,15,0)
            };
            for (int i = 0; i < times.Length; i++)
            {
                if (startTime.Value >= times[i] && (i == times.Length - 1 || startTime.Value < times[i == times.Length - 1 ? i : i + 1]))
                    return i;
            }
            return 0;
        }
    }
}
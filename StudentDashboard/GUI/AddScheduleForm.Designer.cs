namespace StudentDashboard.GUI
{
    partial class AddScheduleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbDayOfWeek;
        private System.Windows.Forms.ComboBox cbStartPeriod;
        private System.Windows.Forms.ComboBox cbEndPeriod;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.Label lblStartPeriod;
        private System.Windows.Forms.Label lblEndPeriod;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblSubject = new Label();
            cbSubject = new ComboBox();
            lblTeacher = new Label();
            cbTeacher = new ComboBox();
            lblRoom = new Label();
            cbRoom = new ComboBox();
            lblClass = new Label();
            cbClass = new ComboBox();
            lblDayOfWeek = new Label();
            cbDayOfWeek = new ComboBox();
            lblStartPeriod = new Label();
            cbStartPeriod = new ComboBox();
            lblEndPeriod = new Label();
            cbEndPeriod = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(30, 39);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(83, 25);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "Môn học";
            // 
            // cbSubject
            // 
            cbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubject.Location = new Point(144, 36);
            cbSubject.Name = "cbSubject";
            cbSubject.Size = new Size(200, 33);
            cbSubject.TabIndex = 1;
            // 
            // lblTeacher
            // 
            lblTeacher.AutoSize = true;
            lblTeacher.Location = new Point(30, 78);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Size = new Size(85, 25);
            lblTeacher.TabIndex = 2;
            lblTeacher.Text = "Giáo viên";
            // 
            // cbTeacher
            // 
            cbTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTeacher.Location = new Point(144, 75);
            cbTeacher.Name = "cbTeacher";
            cbTeacher.Size = new Size(200, 33);
            cbTeacher.TabIndex = 3;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(30, 117);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(64, 25);
            lblRoom.TabIndex = 4;
            lblRoom.Text = "Phòng";
            // 
            // cbRoom
            // 
            cbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoom.Location = new Point(144, 114);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(200, 33);
            cbRoom.TabIndex = 5;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Location = new Point(30, 156);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(42, 25);
            lblClass.TabIndex = 6;
            lblClass.Text = "Lớp";
            // 
            // cbClass
            // 
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.Location = new Point(144, 153);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(200, 33);
            cbClass.TabIndex = 7;
            // 
            // lblDayOfWeek
            // 
            lblDayOfWeek.AutoSize = true;
            lblDayOfWeek.Location = new Point(30, 195);
            lblDayOfWeek.Name = "lblDayOfWeek";
            lblDayOfWeek.Size = new Size(42, 25);
            lblDayOfWeek.TabIndex = 8;
            lblDayOfWeek.Text = "Thứ";
            // 
            // cbDayOfWeek
            // 
            cbDayOfWeek.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDayOfWeek.Items.AddRange(new object[] { "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ nhật" });
            cbDayOfWeek.Location = new Point(144, 192);
            cbDayOfWeek.Name = "cbDayOfWeek";
            cbDayOfWeek.Size = new Size(200, 33);
            cbDayOfWeek.TabIndex = 9;
            // 
            // lblStartPeriod
            // 
            lblStartPeriod.AutoSize = true;
            lblStartPeriod.Location = new Point(30, 234);
            lblStartPeriod.Name = "lblStartPeriod";
            lblStartPeriod.Size = new Size(106, 25);
            lblStartPeriod.TabIndex = 10;
            lblStartPeriod.Text = "Tiết bắt đầu";
            // 
            // cbStartPeriod
            // 
            cbStartPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStartPeriod.Items.AddRange(new object[] { "Tiết 1", "Tiết 2", "Tiết 3", "Tiết 4", "Tiết 5", "Tiết 6", "Tiết 7", "Tiết 8", "Tiết 9", "Tiết 10" });
            cbStartPeriod.Location = new Point(144, 231);
            cbStartPeriod.Name = "cbStartPeriod";
            cbStartPeriod.Size = new Size(200, 33);
            cbStartPeriod.TabIndex = 11;
            // 
            // lblEndPeriod
            // 
            lblEndPeriod.AutoSize = true;
            lblEndPeriod.Location = new Point(30, 273);
            lblEndPeriod.Name = "lblEndPeriod";
            lblEndPeriod.Size = new Size(108, 25);
            lblEndPeriod.TabIndex = 12;
            lblEndPeriod.Text = "Tiết kết thúc";
            // 
            // cbEndPeriod
            // 
            cbEndPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEndPeriod.Items.AddRange(new object[] { "Tiết 1", "Tiết 2", "Tiết 3", "Tiết 4", "Tiết 5", "Tiết 6", "Tiết 7", "Tiết 8", "Tiết 9", "Tiết 10" });
            cbEndPeriod.Location = new Point(144, 270);
            cbEndPeriod.Name = "cbEndPeriod";
            cbEndPeriod.Size = new Size(200, 33);
            cbEndPeriod.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(144, 339);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 14;
            btnSave.Text = "Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // AddScheduleForm
            // 
            ClientSize = new Size(412, 400);
            Controls.Add(lblSubject);
            Controls.Add(cbSubject);
            Controls.Add(lblTeacher);
            Controls.Add(cbTeacher);
            Controls.Add(lblRoom);
            Controls.Add(cbRoom);
            Controls.Add(lblClass);
            Controls.Add(cbClass);
            Controls.Add(lblDayOfWeek);
            Controls.Add(cbDayOfWeek);
            Controls.Add(lblStartPeriod);
            Controls.Add(cbStartPeriod);
            Controls.Add(lblEndPeriod);
            Controls.Add(cbEndPeriod);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddScheduleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đăng ký môn học";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
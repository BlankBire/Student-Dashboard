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
            components = new System.ComponentModel.Container();

            lblSubject = new System.Windows.Forms.Label();
            cbSubject = new System.Windows.Forms.ComboBox();
            lblTeacher = new System.Windows.Forms.Label();
            cbTeacher = new System.Windows.Forms.ComboBox();
            lblRoom = new System.Windows.Forms.Label();
            cbRoom = new System.Windows.Forms.ComboBox();
            lblClass = new System.Windows.Forms.Label();
            cbClass = new System.Windows.Forms.ComboBox();
            lblDayOfWeek = new System.Windows.Forms.Label();
            cbDayOfWeek = new System.Windows.Forms.ComboBox();
            lblStartPeriod = new System.Windows.Forms.Label();
            cbStartPeriod = new System.Windows.Forms.ComboBox();
            lblEndPeriod = new System.Windows.Forms.Label();
            cbEndPeriod = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();

            // 
            // lblSubject
            // 
            lblSubject.Text = "Môn học";
            lblSubject.Location = new System.Drawing.Point(30, 30);
            lblSubject.Size = new System.Drawing.Size(70, 23);
            // 
            // cbSubject
            // 
            cbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubject.Location = new System.Drawing.Point(120, 30);
            cbSubject.Size = new System.Drawing.Size(200, 23);

            // 
            // lblTeacher
            // 
            lblTeacher.Text = "Giáo viên";
            lblTeacher.Location = new System.Drawing.Point(30, 70);
            lblTeacher.Size = new System.Drawing.Size(70, 23);
            // 
            // cbTeacher
            // 
            cbTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTeacher.Location = new System.Drawing.Point(120, 70);
            cbTeacher.Size = new System.Drawing.Size(200, 23);

            // 
            // lblRoom
            // 
            lblRoom.Text = "Phòng";
            lblRoom.Location = new System.Drawing.Point(30, 110);
            lblRoom.Size = new System.Drawing.Size(70, 23);
            // 
            // cbRoom
            // 
            cbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoom.Location = new System.Drawing.Point(120, 110);
            cbRoom.Size = new System.Drawing.Size(200, 23);

            // 
            // lblClass
            // 
            lblClass.Text = "Lớp";
            lblClass.Location = new System.Drawing.Point(30, 150);
            lblClass.Size = new System.Drawing.Size(70, 23);
            // 
            // cbClass
            // 
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.Location = new System.Drawing.Point(120, 150);
            cbClass.Size = new System.Drawing.Size(200, 23);

            // 
            // lblDayOfWeek
            // 
            lblDayOfWeek.Text = "Thứ";
            lblDayOfWeek.Location = new System.Drawing.Point(30, 190);
            lblDayOfWeek.Size = new System.Drawing.Size(70, 23);
            // 
            // cbDayOfWeek
            // 
            cbDayOfWeek.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDayOfWeek.Items.AddRange(new object[] {
                "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ nhật"
            });
            cbDayOfWeek.Location = new System.Drawing.Point(120, 190);
            cbDayOfWeek.Size = new System.Drawing.Size(200, 23);

            // 
            // lblStartPeriod
            // 
            lblStartPeriod.Text = "Tiết bắt đầu";
            lblStartPeriod.Location = new System.Drawing.Point(30, 230);
            lblStartPeriod.Size = new System.Drawing.Size(70, 23);
            // 
            // cbStartPeriod
            // 
            cbStartPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStartPeriod.Items.AddRange(new object[] {
                "Tiết 1", "Tiết 2", "Tiết 3", "Tiết 4", "Tiết 5", "Tiết 6", "Tiết 7", "Tiết 8", "Tiết 9", "Tiết 10"
            });
            cbStartPeriod.Location = new System.Drawing.Point(120, 230);
            cbStartPeriod.Size = new System.Drawing.Size(200, 23);

            // 
            // lblEndPeriod
            // 
            lblEndPeriod.Text = "Tiết kết thúc";
            lblEndPeriod.Location = new System.Drawing.Point(30, 270);
            lblEndPeriod.Size = new System.Drawing.Size(70, 23);
            // 
            // cbEndPeriod
            // 
            cbEndPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEndPeriod.Items.AddRange(new object[] {
                "Tiết 1", "Tiết 2", "Tiết 3", "Tiết 4", "Tiết 5", "Tiết 6", "Tiết 7", "Tiết 8", "Tiết 9", "Tiết 10"
            });
            cbEndPeriod.Location = new System.Drawing.Point(120, 270);
            cbEndPeriod.Size = new System.Drawing.Size(200, 23);

            // 
            // btnSave
            // 
            btnSave.Text = "Lưu";
            btnSave.Location = new System.Drawing.Point(120, 320);
            btnSave.Size = new System.Drawing.Size(100, 35);
            btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // Add controls to the form
            // 
            this.Controls.Add(lblSubject);
            this.Controls.Add(cbSubject);
            this.Controls.Add(lblTeacher);
            this.Controls.Add(cbTeacher);
            this.Controls.Add(lblRoom);
            this.Controls.Add(cbRoom);
            this.Controls.Add(lblClass);
            this.Controls.Add(cbClass);
            this.Controls.Add(lblDayOfWeek);
            this.Controls.Add(cbDayOfWeek);
            this.Controls.Add(lblStartPeriod);
            this.Controls.Add(cbStartPeriod);
            this.Controls.Add(lblEndPeriod);
            this.Controls.Add(cbEndPeriod);
            this.Controls.Add(btnSave);

            // 
            // Form settings
            // 
            this.Text = "Đăng ký môn học";
            this.ClientSize = new System.Drawing.Size(370, 400);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        }
    }
}
namespace StudentDashboard.GUI
{
    partial class AddScheduleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.Label lblAcademicYear;
        private System.Windows.Forms.NumericUpDown numAcademicYear;
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
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblStartTime = new Label();
            dtpStartTime = new DateTimePicker();
            lblEndTime = new Label();
            dtpEndTime = new DateTimePicker();
            lblSemester = new Label();
            txtSemester = new TextBox();
            lblAcademicYear = new Label();
            numAcademicYear = new NumericUpDown();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numAcademicYear).BeginInit();
            SuspendLayout();
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(30, 60);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(83, 25);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "Môn học";
            // 
            // cbSubject
            // 
            cbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubject.Location = new Point(150, 57);
            cbSubject.Name = "cbSubject";
            cbSubject.Size = new Size(250, 33);
            cbSubject.TabIndex = 1;
            // 
            // lblTeacher
            // 
            lblTeacher.AutoSize = true;
            lblTeacher.Location = new Point(30, 100);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Size = new Size(85, 25);
            lblTeacher.TabIndex = 2;
            lblTeacher.Text = "Giáo viên";
            // 
            // cbTeacher
            // 
            cbTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTeacher.Location = new Point(150, 97);
            cbTeacher.Name = "cbTeacher";
            cbTeacher.Size = new Size(250, 33);
            cbTeacher.TabIndex = 3;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(30, 140);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(64, 25);
            lblRoom.TabIndex = 4;
            lblRoom.Text = "Phòng";
            // 
            // cbRoom
            // 
            cbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoom.Location = new Point(150, 137);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(250, 33);
            cbRoom.TabIndex = 5;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Location = new Point(30, 180);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(42, 25);
            lblClass.TabIndex = 6;
            lblClass.Text = "Lớp";
            // 
            // cbClass
            // 
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.Location = new Point(150, 177);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(250, 33);
            cbClass.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(30, 220);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(54, 25);
            lblDate.TabIndex = 8;
            lblDate.Text = "Ngày";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(150, 217);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 31);
            dtpDate.TabIndex = 9;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(30, 260);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(105, 25);
            lblStartTime.TabIndex = 10;
            lblStartTime.Text = "Giờ bắt đầu";
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "HH:mm";
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.Location = new Point(150, 257);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(250, 31);
            dtpStartTime.TabIndex = 11;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Location = new Point(30, 300);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(107, 25);
            lblEndTime.TabIndex = 12;
            lblEndTime.Text = "Giờ kết thúc";
            // 
            // dtpEndTime
            // 
            dtpEndTime.CustomFormat = "HH:mm";
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.Location = new Point(150, 297);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(250, 31);
            dtpEndTime.TabIndex = 13;
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Location = new Point(30, 340);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(67, 25);
            lblSemester.TabIndex = 14;
            lblSemester.Text = "Học kỳ";
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(150, 337);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(250, 31);
            txtSemester.TabIndex = 15;
            // 
            // lblAcademicYear
            // 
            lblAcademicYear.AutoSize = true;
            lblAcademicYear.Location = new Point(30, 380);
            lblAcademicYear.Name = "lblAcademicYear";
            lblAcademicYear.Size = new Size(84, 25);
            lblAcademicYear.TabIndex = 16;
            lblAcademicYear.Text = "Năm học";
            // 
            // numAcademicYear
            // 
            numAcademicYear.Location = new Point(150, 377);
            numAcademicYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numAcademicYear.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numAcademicYear.Name = "numAcademicYear";
            numAcademicYear.Size = new Size(250, 31);
            numAcademicYear.TabIndex = 17;
            numAcademicYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // btnSave
            // 
            btnSave.Location = new Point(150, 420);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 18;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddScheduleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 486);
            Controls.Add(lblSubject);
            Controls.Add(cbSubject);
            Controls.Add(lblTeacher);
            Controls.Add(cbTeacher);
            Controls.Add(lblRoom);
            Controls.Add(cbRoom);
            Controls.Add(lblClass);
            Controls.Add(cbClass);
            Controls.Add(lblDate);
            Controls.Add(dtpDate);
            Controls.Add(lblStartTime);
            Controls.Add(dtpStartTime);
            Controls.Add(lblEndTime);
            Controls.Add(dtpEndTime);
            Controls.Add(lblSemester);
            Controls.Add(txtSemester);
            Controls.Add(lblAcademicYear);
            Controls.Add(numAcademicYear);
            Controls.Add(btnSave);
            Name = "AddScheduleForm";
            Text = "Thêm thời khóa biểu";
            ((System.ComponentModel.ISupportInitialize)numAcademicYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
} 
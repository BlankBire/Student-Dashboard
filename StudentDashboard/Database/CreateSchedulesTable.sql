CREATE TABLE Schedules (
    ScheduleId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    Title NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX),
    Date DATE NOT NULL,
    Time TIME NOT NULL,
    CreateAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    
    -- Thêm các cột mới cho thời khóa biểu
    SubjectName NVARCHAR(100),
    TeacherName NVARCHAR(100),
    Room NVARCHAR(50),
    DayOfWeek INT,
    StartTime TIME,
    EndTime TIME,
    ClassName NVARCHAR(50),
    Semester NVARCHAR(20),
    AcademicYear INT
); 
-- Users table with role-based inheritance
CREATE TABLE Users (
        UserID       INT IDENTITY(1,1) PRIMARY KEY,
        Username     NVARCHAR(50) NOT NULL UNIQUE,
        PasswordHash NVARCHAR(256) NOT NULL,    
        UserRole     NVARCHAR(20) NOT NULL CHECK ([UserRole] IN ('Admin', 'Teacher', 'Student')), 
        FullName     NVARCHAR(100) NOT NULL,
        Email        NVARCHAR(255) UNIQUE,
        CreatedAt    DATETIME2 DEFAULT GETDATE()
    );

-- Subjects/Courses
CREATE TABLE Subjects (
    SubjectID INT PRIMARY KEY IDENTITY(1,1),
    SubjectCode NVARCHAR(20) UNIQUE NOT NULL,
    SubjectName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500)
);

-- Sections
CREATE TABLE Sections (
    SectionID INT PRIMARY KEY IDENTITY(1,1),
    SectionName NVARCHAR(50) NOT NULL,
    SubjectID INT FOREIGN KEY REFERENCES Subjects(SubjectID),
    TeacherID INT FOREIGN KEY REFERENCES Users(UserID),
    AcademicTerm NVARCHAR(20),
    Year INT
);

-- Tests/Assessments
CREATE TABLE Tests (
    TestID INT PRIMARY KEY IDENTITY(1,1),
    TestTitle NVARCHAR(200) NOT NULL,
    Description NVARCHAR(1000),
    SubjectID INT FOREIGN KEY REFERENCES Subjects(SubjectID),
    TestType NVARCHAR(20) CHECK(TestType IN ('Quiz', 'Exam', 'Diagnostic', 'Practice')),
    DurationMinutes INT,
    PassingScore DECIMAL(5,2),
    TotalPoints DECIMAL(5,2),
    Instructions NVARCHAR(MAX),
    CreatedBy INT FOREIGN KEY REFERENCES Users(UserID),
    CreatedDate DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);

-- Questions (abstract base implemented via table)
CREATE TABLE Questions (
    QuestionID INT PRIMARY KEY IDENTITY(1,1),
    TestID INT FOREIGN KEY REFERENCES Tests(TestID),
    QuestionText NVARCHAR(MAX) NOT NULL,
    QuestionType NVARCHAR(20) DEFAULT 'MultipleChoice',
    Points DECIMAL(5,2) NOT NULL,
    DifficultyLevel NVARCHAR(10) CHECK(DifficultyLevel IN ('Easy', 'Average', 'Difficult')),
    CognitiveLevel NVARCHAR(20),
    Topic NVARCHAR(100)
);

-- Multiple Choice Options
CREATE TABLE QuestionChoices (
    ChoiceID INT PRIMARY KEY IDENTITY(1,1),
    QuestionID INT FOREIGN KEY REFERENCES Questions(QuestionID),
    ChoiceText NVARCHAR(500) NOT NULL,
    IsCorrect BIT DEFAULT 0,
    DisplayOrder INT
);

-- Test Instances (when test is administered)
CREATE TABLE TestInstances (
    TestInstanceID INT PRIMARY KEY IDENTITY(1,1),
    TestID INT FOREIGN KEY REFERENCES Tests(TestID),
    SectionID INT FOREIGN KEY REFERENCES Sections(SectionID),
    StartDateTime DATETIME,
    EndDateTime DATETIME,
    IsRandomized BIT DEFAULT 0,
    IsChoicesRandomized BIT DEFAULT 0,
    ShowAnswers BIT DEFAULT 0,
    AllowReview BIT DEFAULT 0,
    Status NVARCHAR(20) DEFAULT 'Scheduled'
);

-- Student Answers
CREATE TABLE StudentAnswers (
    AnswerID INT PRIMARY KEY IDENTITY(1,1),
    TestInstanceID INT FOREIGN KEY REFERENCES TestInstances(TestInstanceID),
    StudentID INT FOREIGN KEY REFERENCES Users(UserID),
    QuestionID INT FOREIGN KEY REFERENCES Questions(QuestionID),
    SelectedChoiceID INT FOREIGN KEY REFERENCES QuestionChoices(ChoiceID),
    IsCorrect BIT,
    TimeTakenSeconds INT
);

-- Test Results
CREATE TABLE TestResults (
    ResultID INT PRIMARY KEY IDENTITY(1,1),
    TestInstanceID INT FOREIGN KEY REFERENCES TestInstances(TestInstanceID),
    StudentID INT FOREIGN KEY REFERENCES Users(UserID),
    RawScore DECIMAL(5,2),
    Percentage DECIMAL(5,2),
    LetterGrade NVARCHAR(2),
    CompletedDate DATETIME DEFAULT GETDATE()
);

-- Question Statistics for Item Analysis
CREATE TABLE QuestionStatistics (
    StatID INT PRIMARY KEY IDENTITY(1,1),
    QuestionID INT FOREIGN KEY REFERENCES Questions(QuestionID),
    TestInstanceID INT FOREIGN KEY REFERENCES TestInstances(TestInstanceID),
    DifficultyIndex DECIMAL(5,4),
    DiscriminationIndex DECIMAL(5,4),
    TotalResponses INT,
    CorrectResponses INT,
    CalculatedDate DATETIME DEFAULT GETDATE()
);
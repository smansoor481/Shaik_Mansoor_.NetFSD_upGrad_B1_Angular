CREATE DATABASE  SchoolManagementDB;
USE SchoolManagementDB;

CREATE TABLE Departments (
	DepartmentID INT PRIMARY KEY,
	DepartmentName VARCHAR(20),
	Location VARCHAR(50)
);

CREATE TABLE Teachers (
	TeacherID INT PRIMARY KEY,
	TeacherName VARCHAR(20),
	Email VARCHAR(50) UNIQUE,
	DepartmentID INT,
	HireDate DATE,
	FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

CREATE TABLE Students (
	StudentID INT PRIMARY KEY,
	FirstName VARCHAR(30),
	LastName VARCHAR(30),
	DateOfBirth DATE,
	Gender VARCHAR(10) CHECK (Gender IN ('Male','Female')),
	DepartmentID INT,
	AdmissionDate DATE,
	FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

CREATE TABLE Courses (
	CourseID INT PRIMARY KEY,
	CourseName VARCHAR(50),
	Credits INT,
	DepartmentID INT,
	TeacherID INT,
	FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID),
	FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID)
);

CREATE TABLE Enrollments (
    EnrollmentID INT PRIMARY KEY,
    StudentID INT,
    CourseID INT,
    EnrollmentDate DATE,
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE Exams (
    ExamID INT PRIMARY KEY,
    CourseID INT,
    ExamDate DATE,
    ExamType VARCHAR(20),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE Marks (
    MarkID INT PRIMARY KEY,
    StudentID INT,
    ExamID INT,
    MarksObtained INT,
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
);



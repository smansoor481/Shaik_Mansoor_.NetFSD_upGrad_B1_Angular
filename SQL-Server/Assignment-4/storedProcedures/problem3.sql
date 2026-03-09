-- Course Enrollment Procedure

ALTER PROCEDURE sp_EnrollStudent
@StudentID INT,
@CourseID INT
AS
BEGIN
INSERT INTO SchoolManagementDB.dbo.Enrollments(StudentID, CourseID, EnrollmentDate)
VALUES(@StudentID, @CourseID, GETDATE())
END

EXEC sp_EnrollStudent 1,2;


SELECT * FROM Enrollments;
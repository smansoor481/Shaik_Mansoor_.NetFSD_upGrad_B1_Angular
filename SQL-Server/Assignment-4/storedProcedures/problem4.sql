--Student Marks Procedure


CREATE PROCEDURE sp_GetStudentMarks
@StudentID INT
AS
BEGIN
    SELECT 
        s.FirstName,
        c.CourseName,
        e.ExamType,
        m.MarksObtained
    FROM Students s
    JOIN Marks m ON s.StudentID = m.StudentID
    JOIN Exams e ON m.ExamID = e.ExamID
    JOIN Courses c ON e.CourseID = c.CourseID
    WHERE s.StudentID = @StudentID
END


EXEC sp_GetStudentMarks 1;








SELECT * from Students;
SELECT * from Marks
SELECT * from Exams
SELECT * from Courses

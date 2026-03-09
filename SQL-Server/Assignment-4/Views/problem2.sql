-- Student Course Enrollment View
CREATE VIEW vw_StudentCourses
AS
    SELECT 
        s.StudentID,
        s.FirstName + ' ' + s.LastName AS FullName,
        c.CourseName,
        e.EnrollmentDate
    FROM Students s
    JOIN Enrollments e ON s.StudentID = e.StudentID
    JOIN Courses c ON e.CourseID = c.CourseID
GO

--Show courses taken by StudentID = 5
SELECT * FROM vw_StudentCourses WHERE StudentID = 5;

--Count courses taken by each student
SELECT studentid, fullname, COUNT(CourseName) AS TotalCourses
FROM vw_StudentCourses GROUP BY StudentID, FullName;


--List students enrolled after 2024
SELECT * FROM vw_StudentCourses WHERE EnrollmentDate >= '2024-03-06'



SELECT * FROM Students;
SELECT * FROM Courses;
SELECT * FROM Enrollments;

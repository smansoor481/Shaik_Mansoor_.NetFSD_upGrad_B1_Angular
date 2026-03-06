--Students must write queries to: 
--Show students with department names 

SELECT * FROM Students;
SELECT * FROM Departments;

SELECT s.FirstName +' '+s.LastName , d.DepartmentName FROM 
Students s INNER JOIN Departments d
ON s.DepartmentID = d.DepartmentID;



-- Show courses with teacher names 

SELECT * FROM Courses;
SELECT * FROM Teachers;

SELECT c.courseName, t.teacherName FROM 
Courses c INNER JOIN Teachers t
ON c.DepartmentID = t.DepartmentID;


-- Show student name and enrolled courses 
--Students + Enrollments + Courses 
SELECT * FROM Students;
SELECT * FROM Enrollments;
SELECT * FROM Courses;

SELECT s.FirstName + ' ' + s.LastName AS StudentName, c.CourseName
FROM Students s INNER JOIN Enrollments e
ON s.StudentID = e.StudentID
INNER JOIN Courses c
ON e.CourseID = c.CourseID;

 -- Show all courses and teachers (even if no teacher assigned) 
 
 SELECT * FROM Courses;
 SELECT * FROM Teachers;

 SELECT c.CourseName, t.TeacherName FROM Courses c LEFT JOIN Teachers t
 ON c.DepartmentID = t.DepartmentID;

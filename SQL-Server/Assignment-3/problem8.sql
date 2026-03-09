-- Find students whose marks are greater than average marks 
SELECT * FROM Marks;
SELECT * FROM Students;
SELECT s.* FROM Students s INNER JOIN Marks m ON s.StudentID = m.StudentID
WHERE m.MarksObtained >(SELECT AVG(MarksObtained) FROM Marks);


-- Find courses with maximum credits 
SELECT * FROM Courses;
SELECT CourseName, Credits FROM Courses WHERE Credits = (SELECT MAX(Credits) FROM Courses);

-- Find students enrolled in more than 2 courses 
SELECT StudentID, COUNT(CourseID) AS TotalCourses
FROM Enrollments
GROUP BY StudentID
HAVING COUNT(CourseID) >=2;


-- Find teachers working in the same department as teacher 'John' 
SELECT * FROM Teachers;
SELECT * FROM Departments;

SELECT TeacherName, DepartmentID
FROM Teachers
WHERE DepartmentID = 
(
    SELECT DepartmentID 
    FROM Teachers
    WHERE TeacherName = 'Eva'
);

--- Find students who scored highest marks in an exam 
SELECT s.*
FROM Students s
JOIN Marks m ON s.StudentID = m.StudentID
WHERE m.MarksObtained = (SELECT MAX(MarksObtained) FROM Marks);


-- Find departments having maximum number of students 
SELECT DepartmentID, COUNT(StudentID) AS TotalStudents
FROM Students
GROUP BY DepartmentID
HAVING COUNT(StudentID) =
(
    SELECT MAX(StudentCount)
    FROM
    (
        SELECT COUNT(StudentID) AS StudentCount
        FROM Students
        GROUP BY DepartmentID
    ) AS DeptCounts
);
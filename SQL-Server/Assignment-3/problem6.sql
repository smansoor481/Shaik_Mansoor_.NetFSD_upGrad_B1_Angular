-- Count students in each department
SELECT DepartmentID, COUNT(StudentID) AS TotalStudents
FROM Students
GROUP BY DepartmentID;

--Find average marks per exam
SELECT ExamID, AVG(MarksObtained) AS AverageMarks FROM Marks
GROUP BY ExamID;

--  Find total students enrolled per course 
SELECT CourseID, SUM(StudentID) FROM Enrollments
GROUP BY CourseID;


-- Find maximum marks scored in each exam
SELECT * FROM Marks;
SELECT examID, MAX(MarksObtained) AS Maximum_Marks FROM Marks
GROUP BY ExamID;

-- Find minimum marks per course 
SELECT e.CourseID, MIN(m.MarksObtained) AS MinMarks
FROM Marks m
INNER JOIN Exams e
ON m.ExamID = e.ExamID
GROUP BY e.CourseID;


-- Find departments having more than 5 students 
SELECT DepartmentID, COUNT(StudentID) AS TotalStudents
FROM Students
GROUP BY DepartmentID
HAVING COUNT(StudentID) > 5;

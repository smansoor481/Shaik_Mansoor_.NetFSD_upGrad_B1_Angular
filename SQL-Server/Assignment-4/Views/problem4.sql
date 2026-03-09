--Aggregate View
ALTER VIEW vw_DepartmentStudentCount
AS
	SELECT DepartmentName, COUNT(StudentID) AS TotalStudents FROM
	Students s JOIN Departments d ON s.DepartmentID = d.DepartmentID
	GROUP BY DepartmentName
GO

 
 --Retrieve departments with more than 3 students
 SELECT * FROM vw_DepartmentStudentCount WHERE TotalStudents > 3;


 --Sort departments by highest student count.
 SELECT departmentName,TotalStudents FROM vw_DepartmentStudentCount 
 ORDER BY DepartmentName DESC;


SELECT * FROM Students;
SELECT * FROM Departments;
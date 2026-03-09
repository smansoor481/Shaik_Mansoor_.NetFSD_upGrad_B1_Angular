--Student Department View
CREATE VIEW vw_StudentDepartment
AS
	SELECT s.studentID, s.FirstName+''+s.LastName AS FullName, d.departmentName, s.admissiondate 
	FROM Students s JOIN Departments d
	ON s.DepartmentID = d.DepartmentID
GO

SELECT * FROM vw_StudentDepartment;


--Filter students from Computer Science department using the view.
SELECT * FROM vw_StudentDepartment WHERE departmentName = 'CSE';

--Drop the view
DROP VIEW vw_StudentDepartment;
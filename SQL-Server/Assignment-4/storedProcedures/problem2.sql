--Get Students By Department

CREATE PROCEDURE sp_GetStudentsByDepartment(@DepartmentID int)
AS
BEGIN
	SELECT StudentID, FirstName, AdmissionDate FROM Students WHERE DepartmentID = @DepartmentID;
END

EXEC sp_GetStudentsByDepartment 102;

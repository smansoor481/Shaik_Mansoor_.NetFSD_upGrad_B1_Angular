-- Create index on Student LastName 
SELECT * FROM Students;

sp_help students;

CREATE nonclustered index NC_Index on Students(LastName);


-- Create index on Teacher Email 
SELECT * FROM Teachers;
CREATE nonclustered index CI_EMAIL on Teachers(Gmail);

--Create composite index on StudentID + CourseID in Enrollments table.

SELECT * FROM Enrollments;
sp_help Enrollments;
CREATE INDEX IDX_Enrollments_Student_Course
ON Enrollments (StudentID, CourseID);

-- Create unique index on DepartmentName 

CREATE UNIQUE INDEX IDX_DepartmentName ON Departments(DepartmentName);


--  Drop an index 
DROP INDEX CI_EMAIL ON Teachers;
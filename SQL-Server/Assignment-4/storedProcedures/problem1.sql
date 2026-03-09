--Stored Procedures Assignments
--insert student procedure

ALTER PROCEDURE sp_InsertStudent
(
 @id int,
 @first varchar(20),
 @last varchar(20),
 @dob date,
 @gender varchar(10),
 @depid int,
 @Admin date
)
AS
BEGIN
INSERT INTO Students
(StudentID, FirstName, LastName, DateofBirth, Gender, DepartmentId, AdmissionDate)
VALUES
(@id, @first, @last, @dob, @gender, @depid, @Admin)
END
	
EXEC sp_InsertStudent
1,'John','Doe','2002-05-10','Male',2,'2024-06-01';

SELECT * FROM Students;




ALTER PROCEDURE sp_InsertStudent
AS
BEGIN
INSERT INTO Students
(FirstName, LastName, DateofBirth, Gender, DepartmentId, AdmissionDate)
VALUES
('Mansoor','Doe','2002-05-10','Male',2,'2024-06-01')
END

EXEC sp_InsertStudent
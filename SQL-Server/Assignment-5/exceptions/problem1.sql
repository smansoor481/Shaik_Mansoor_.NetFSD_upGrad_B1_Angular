-- Insert Student Procedure with Exception Handling
alter procedure sp_AddStudent(@StudentID int,@Firstname varchar(20), @lastname varchar(20), @DepartmentID int, @gender varchar(10),
@Admissiondate date)
as
begin try
	insert into Students(StudentID,FirstName, LastName, DepartmentID, Gender,AdmissionDate) values
	(@StudentID,@Firstname, @lastname, @DepartmentID, @gender, @Admissiondate)
end try

begin catch
	print ERROR_MESSAGE()
end catch


--exec 
EXEC sp_AddStudent 
    @studentID = 1000,
    @Firstname = 'Mansoor',
    @Lastname = 'Shaik',
    @DepartmentID = 10067,
    @Gender = 'Male',
    @Admissiondate = '2026-03-10';



--Student Age Function 

CREATE FUNCTION fn_GetStudentAge (@DateOfBirth DATE)
RETURNS INT
AS
BEGIN
	DECLARE @Age INT
	SET @Age = DATEDIFF(YEAR, @DateOfBirth, GETDATE())

	RETURN @Age

END

SELECT dbo.fn_GetStudentAge('2000-05-10') AS Age

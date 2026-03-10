--User Defined Functions Assignments 

--Calculate Grade (Scalar Function) 
ALTER FUNCTION GetGrade(@MarksObtained INT)
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @Grade VARCHAR(20)
	IF @MarksObtained >= 90
		SET @Grade = 'A'
	ELSE IF @MarksObtained >= 75
		SET @Grade ='B'
	ELSE IF @MarksObtained >= 60
		SET @Grade ='C'
	ELSE
		SET @Grade ='Fail'

	RETURN @Grade
END


SELECT dbo.GetGrade(70)
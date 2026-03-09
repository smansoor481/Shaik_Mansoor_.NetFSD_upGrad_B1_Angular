-- Update Student Marks
CREATE PROCEDURE sp_UpdateMarks
@MarkID INT,@NewMarks INT
AS
BEGIN
	UPDATE Marks set MarksObtained = @NewMarks where MarkID = @MarkID
END

EXEC sp_UpdateMarks 1,100;




SELECT * FROM Marks;
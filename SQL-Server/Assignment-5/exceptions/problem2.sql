CREATE PROCEDURE sp_InsertMarks
    @StudentID INT,
    @ExamID INT,
    @MarksObtained INT
AS
BEGIN
    BEGIN TRY
        IF @MarksObtained < 0 OR @MarksObtained > 100
        BEGIN
            RAISERROR('Invalid Marks. Must be between 0 and 100.', 16, 1);
            RETURN; 
        END

        INSERT INTO Marks(StudentID, ExamID, MarksObtained)
        VALUES(@StudentID, @ExamID, @MarksObtained);

        PRINT 'Marks inserted successfully.';
    END TRY
    BEGIN CATCH
        -- Show error message
        SELECT ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
END

EXEC sp_InsertMarks @StudentID = 1, @ExamID = 101, @MarksObtained = 85;

EXEC sp_InsertMarks @StudentID = 1, @ExamID = 101, @MarksObtained = 120;
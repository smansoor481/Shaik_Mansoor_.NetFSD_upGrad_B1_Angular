CREATE PROCEDURE sp_DeleteStudent
    @StudentID INT
AS
BEGIN
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Enrollments WHERE StudentID = @StudentID)
        BEGIN
            RAISERROR('Student has enrollments and cannot be deleted.', 16, 1);
            RETURN;
        END

        DELETE FROM Students
        WHERE StudentID = @StudentID;

        PRINT 'Student deleted successfully.';
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
END


EXEC sp_DeleteStudent @StudentID = 1;


EXEC sp_DeleteStudent @StudentID = 5;
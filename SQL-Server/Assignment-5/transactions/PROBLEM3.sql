CREATE PROCEDURE sp_TransferStudentDepartment
    @StudentID INT,
    @DepartmentID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        -- Verify department exists
        IF EXISTS (SELECT 1 FROM Departments WHERE DepartmentID = @DepartmentID)
        BEGIN
            -- Update student department
            UPDATE Students
            SET DepartmentID = @DepartmentID
            WHERE StudentID = @StudentID

            COMMIT TRANSACTION
            PRINT 'Department transferred successfully'
        END
        ELSE
        BEGIN
            PRINT 'Department does not exist'
            ROLLBACK TRANSACTION
        END

    END TRY

    BEGIN CATCH
        ROLLBACK TRANSACTION
        PRINT ERROR_MESSAGE()
    END CATCH
END


EXEC sp_TransferStudentDepartment 5, 2
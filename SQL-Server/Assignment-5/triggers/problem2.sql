--Students should not be deleted if they have enrollments

create trigger trg_PreventStudentDelete
on Students
instead of delete
as
begin
	IF EXISTS (
        SELECT 1
        FROM Enrollments e
        INNER JOIN deleted d ON e.StudentID = d.StudentID
    )

    begin
        RAISERROR('Student has course enrollments and cannot be deleted', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    end

    DELETE s
    FROM Students s
    INNER JOIN deleted d ON s.StudentID = d.StudentID;
end


-- Try deleting a student with enrollments
DELETE FROM Students WHERE StudentID = 1; 

-- Try deleting a student without enrollments
DELETE FROM Students WHERE StudentID = 5; 

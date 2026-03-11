--Student Enrollment Transaction

create procedure sp_EnrollStudentTransaction(@studentid int, @courseid int)
as
begin
	begin try
		begin transaction
			INSERT INTO Enrollments (StudentID, CourseID, EnrollmentDate)
			VALUES (@StudentID, @CourseID, GETDATE());

			COMMIT Transaction
			print 'Enrollment Successful'
	end try

	begin catch

		rollback transaction
		DECLARE @ErrorMessage NVARCHAR(4000), 
                @ErrorSeverity INT,
                @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState)
	end catch

end


EXEC sp_EnrollStudentTransaction @StudentID = 1, @CourseID = 101;
	



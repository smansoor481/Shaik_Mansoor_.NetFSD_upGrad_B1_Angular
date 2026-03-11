--Exam Marks Transaction

create procedure sp_RecordExamMarks
as
begin
	begin try
		begin transaction
			insert into Marks(MarkID, StudentID, ExamID, MarksObtained) values (16,9,5,100);

			update Exams set ExamDate = GETDATE() where ExamID = 5;
			commit transaction
			print 'succesffuly committed'
	end try
	begin catch
		rollback transaction
		print error_message()
	end catch
end


exec sp_RecordExamMarks;



select * from Exams;
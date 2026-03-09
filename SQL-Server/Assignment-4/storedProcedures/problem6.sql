--Delete Enrollment

CREATE PROCEDURE sp_DeleteEnrollment(@EnrollmentID INT)
AS
BEGIN
	DELETE FROM Enrollments where EnrollmentID = @EnrollmentID
END

sp_DeleteEnrollment 1;


SELECT * FROM Enrollments;
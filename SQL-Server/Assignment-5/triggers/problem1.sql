--Trigger Assignment
--Audit Trigger for studnets

CREATE TABLE StudentAudit
(
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT,
    ActionType VARCHAR(50),
    ActionDate DATETIME
);


--create trigger

CREATE TRIGGER trg_StudentInsertAudit
ON Students
AFTER INSERT
AS
BEGIN
    INSERT INTO StudentAudit(StudentID, ActionType, ActionDate)

    SELECT StudentID, 'INSERT', GETDATE()
    FROM inserted
END

SELECT * FROM StudentAudit;
SELECT * FROM Students;

INSERT INTO Students 
(StudentID, FirstName, LastName, DateOfBirth, Gender, DepartmentID, AdmissionDate)
VALUES
(11022, 'Rahul', 'Sharma', '2003-05-12', 'Male', 101, '2024-06-01');

INSERT INTO Students 
(StudentID, FirstName, LastName, DateOfBirth, Gender, DepartmentID, AdmissionDate)
VALUES
(11023, 'Mahesh', 'Sharma', '1990-05-12', 'Male', 102, '2026-06-01');

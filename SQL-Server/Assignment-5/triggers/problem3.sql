CREATE TABLE MarksAudit
(
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT,
    ExamID INT,
    OldMarks INT,
    NewMarks INT,
    UpdatedDate DATETIME DEFAULT GETDATE()
);


-- Trigger to audit marks updates
CREATE TRIGGER trg_UpdateMarksAudit
ON Marks
AFTER UPDATE
AS
BEGIN
    INSERT INTO MarksAudit (StudentID, ExamID, OldMarks, NewMarks, UpdatedDate)
    SELECT 
        d.StudentID,
        d.ExamID,
        d.Marks AS OldMarks,
        i.Marks AS NewMarks,
        GETDATE()
    FROM deleted d
    INNER JOIN inserted i ON d.StudentID = i.StudentID AND d.ExamID = i.ExamID;
END




UPDATE Marks
SET Marks = 95
WHERE StudentID = 1 AND ExamID = 101;


SELECT * FROM MarksAudit;
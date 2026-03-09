-- Exam Result View
CREATE VIEW vw_ExamResults
AS
SELECT 
    s.FirstName + ' ' + s.LastName AS StudentName, 
    c.CourseName, 
    e.ExamType, 
    m.MarksObtained
FROM Students s
JOIN Marks m ON s.StudentID = m.StudentID
JOIN Exams e ON m.ExamID = e.ExamID
JOIN Courses c ON e.CourseID = c.CourseID;

--Retrieve students scoring more than 80
SELECT StudentName, MarksObtained 
FROM vw_ExamResults 
WHERE MarksObtained >= 80;


--Find students who failed
SELECT StudentName, MarksObtained
FROM vw_ExamResults
WHERE Marksobtained <70;

--Retrieve top scorers in each exam

SELECT StudentName, CourseName, MarksObtained
FROM vw_ExamResults
WHERE MarksObtained IN (
    SELECT MAX(MarksObtained) 
    FROM vw_ExamResults 
    GROUP BY CourseName
);



SELECT * FROM Students;
SELECT * FROM Marks;
SELECT * FROM Exams;
SELECT * FROM Courses;


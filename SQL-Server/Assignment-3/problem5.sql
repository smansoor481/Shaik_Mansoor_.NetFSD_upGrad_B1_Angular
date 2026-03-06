SELECT * FROM Students;
SELECT * FROM Departments;

-- Find students from Computer Science department 
SELECT * FROM Students s 
INNER JOIN
Departments d
ON s.DepartmentID = d.DepartmentID
WHERE d.DepartmentName = 'CSE';


-- Find teachers hired after 2020 
SELECT * FROM Teachers;

SELECT * FROM Teachers
WHERE YEAR(HireDate) >= 2020;



-- Find students whose name starts with 'A' 
SELECT * FROM Students
WHERE FirstName LIKE 'A%';

--Find courses having credits greater than 3 
SELECT * FROM Courses;
SELECT CourseName FROM Courses
WHERE Credits > 3;

--Find students born between 2001 and 2004 
SELECT FirstName+' '+LastName FROM Students
WHERE YEAR(DateOfBirth) <= 2005;


-- Find students not belonging to Mechanical department 
SELECT * FROM Students s 
INNER JOIN Departments d
ON s.DepartmentID = d.DepartmentID
WHERE d.DepartmentName <> 'Mech';


-- Find teachers whose salary between 40000 and 70000 
SELECT * FROM Teachers
WHERE Salary BETWEEN 40000 AND 70000;


--Find courses not taught by TeacherID = 3 

SELECT * FROM Courses c 
INNER JOIN Teachers t
ON c.TeacherID = t.TeacherID
WHERE t.TeacherID <> 3;





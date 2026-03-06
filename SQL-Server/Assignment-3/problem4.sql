SELECT * FROM Departments;

INSERT INTO Departments VALUES (101,'ECE','Banglore');
INSERT INTO Departments VALUES (102,'CSE','Hydarabad');
INSERT INTO Departments VALUES (103,'DS','Chennai');
INSERT INTO Departments VALUES (104,'AI','Mumbai');
INSERT INTO Departments VALUES (105,'Mech','Kolkatta');
INSERT INTO Departments VALUES (106,'Civil','Delhi');

-- Teachers
SELECT * FROM Teachers;
INSERT INTO Teachers VALUES (1,'Alice','alice@school.com',101,'2020-01-15',34000);
INSERT INTO Teachers VALUES (2,'Bob','bob@school.com',102,'2019-03-10',45000);
INSERT INTO Teachers VALUES (3,'Charlie','charlie@school.com',103,'2021-06-20',56000);
INSERT INTO Teachers VALUES (4,'David','david@school.com',104,'2018-08-05',78000);
INSERT INTO Teachers VALUES (5,'Eva','eva@school.com',105,'2020-09-12',67000);
INSERT INTO Teachers VALUES (6,'Frank','frank@school.com',106,'2019-11-01',45000);
INSERT INTO Teachers VALUES (7,'Grace','grace@school.com',101,'2021-02-14',67000);
INSERT INTO Teachers VALUES (8,'Henry','henry@school.com',102,'2020-05-18',89000);
INSERT INTO Teachers VALUES (9,'Isabella','isabella@school.com',103,'2019-07-22',56000);
INSERT INTO Teachers VALUES (10,'Jack','jack@school.com',104,'2021-01-25',45000);


SELECT * FROM Students;

ALTER TABLE Students
DROP CONSTRAINT CK_Gender;

ALTER TABLE Students
ADD CONSTRAINT CK_Gender
CHECK (Gender IN ('M','F','Male','Female'));

INSERT INTO Students VALUES (1,'Rahul','Sharma','2003-05-10','Male',101,'2020-06-01');
INSERT INTO Students VALUES (2,'Anita','Reddy','2004-07-15','Female',102,'2021-06-01');
INSERT INTO Students VALUES (3,'Karan','Verma','2003-08-20','Male',103,'2020-06-01');
INSERT INTO Students VALUES (4,'Sana','Khan','2004-09-05','Female',104,'2021-06-01');
INSERT INTO Students VALUES (5,'Rohit','Patel','2003-10-12','Male',105,'2020-06-01');
INSERT INTO Students VALUES (6,'Nisha','Singh','2004-11-18','Female',106,'2021-06-01');
INSERT INTO Students VALUES (7,'Vikram','Gupta','2003-12-22','Male',101,'2020-06-01');
INSERT INTO Students VALUES (8,'Meera','Das','2004-01-30','Female',102,'2021-06-01');
INSERT INTO Students VALUES (9,'Aman','Shah','2003-02-14','Male',103,'2020-06-01');
INSERT INTO Students VALUES (10,'Pooja','Rao','2004-03-21','Female',104,'2021-06-01');
INSERT INTO Students VALUES (11,'Arjun','Mehta','2003-04-10','Male',105,'2020-06-01');
INSERT INTO Students VALUES (12,'Divya','Iyer','2004-05-15','Female',106,'2021-06-01');
INSERT INTO Students VALUES (13,'Sameer','Joshi','2003-06-18','Male',101,'2020-06-01');
INSERT INTO Students VALUES (14,'Kavya','Nair','2004-07-25','Female',102,'2021-06-01');
INSERT INTO Students VALUES (15,'Aditya','Bhat','2003-08-30','Male',103,'2020-06-01');
INSERT INTO Students VALUES (16,'Priya','Chopra','2004-09-12','Female',104,'2021-06-01');
INSERT INTO Students VALUES (17,'Rishi','Kapoor','2003-10-05','Male',105,'2020-06-01');
INSERT INTO Students VALUES (18,'Ananya','Sen','2004-11-15','Female',106,'2021-06-01');
INSERT INTO Students VALUES (19,'Manav','Malik','2003-12-01','Male',101,'2020-06-01');
INSERT INTO Students VALUES (20,'Isha','Trivedi','2004-01-20','Female',102,'2021-06-01');


-- 10 Courses
SELECT * FROM Courses;
INSERT INTO Courses VALUES (1,'Data Structures',4,101,1);
INSERT INTO Courses VALUES (2,'Algorithms',4,102,2);
INSERT INTO Courses VALUES (3,'Database Systems',3,103,3);
INSERT INTO Courses VALUES (4,'Calculus',5,104,4);
INSERT INTO Courses VALUES (5,'Linear Algebra',4,105,5);
INSERT INTO Courses VALUES (6,'Probability',3,106,6);
INSERT INTO Courses VALUES (7,'Mechanics',4,105,7);
INSERT INTO Courses VALUES (8,'Optics',3,106,8);
INSERT INTO Courses VALUES (9,'Electromagnetism',4,104,9);
INSERT INTO Courses VALUES (10,'Computer Networks',3,101,10);


--30 Enrollments
SELECT * FROM Enrollments;
INSERT INTO Enrollments VALUES (1,1,1,GETDATE());
INSERT INTO Enrollments VALUES (2,2,1,GETDATE());
INSERT INTO Enrollments VALUES (3,3,2,GETDATE());
INSERT INTO Enrollments VALUES (4,4,2,GETDATE());
INSERT INTO Enrollments VALUES (5,5,3,GETDATE());
INSERT INTO Enrollments VALUES (6,6,3,GETDATE());
INSERT INTO Enrollments VALUES (7,7,4,GETDATE());
INSERT INTO Enrollments VALUES (8,8,4,GETDATE());
INSERT INTO Enrollments VALUES (9,9,5,GETDATE());
INSERT INTO Enrollments VALUES (10,10,5,GETDATE());
INSERT INTO Enrollments VALUES (11,11,6,GETDATE());
INSERT INTO Enrollments VALUES (12,12,6,GETDATE());
INSERT INTO Enrollments VALUES (13,13,7,GETDATE());
INSERT INTO Enrollments VALUES (14,14,7,GETDATE());
INSERT INTO Enrollments VALUES (15,15,8,GETDATE());
INSERT INTO Enrollments VALUES (16,16,8,GETDATE());
INSERT INTO Enrollments VALUES (17,17,9,GETDATE());
INSERT INTO Enrollments VALUES (18,18,9,GETDATE());
INSERT INTO Enrollments VALUES (19,19,10,GETDATE());
INSERT INTO Enrollments VALUES (20,20,10,GETDATE());
INSERT INTO Enrollments VALUES (21,1,2,GETDATE());
INSERT INTO Enrollments VALUES (22,2,3,GETDATE());
INSERT INTO Enrollments VALUES (23,3,4,GETDATE());
INSERT INTO Enrollments VALUES (24,4,5,GETDATE());
INSERT INTO Enrollments VALUES (25,5,6,GETDATE());
INSERT INTO Enrollments VALUES (26,6,7,GETDATE());
INSERT INTO Enrollments VALUES (27,7,8,GETDATE());
INSERT INTO Enrollments VALUES (28,8,9,GETDATE());
INSERT INTO Enrollments VALUES (29,9,10,GETDATE());
INSERT INTO Enrollments VALUES (30,10,1,GETDATE());


-- 5 Exams
SELECT * FROM Exams;
INSERT INTO Exams VALUES (1,1,'2026-03-10','Midterm');
INSERT INTO Exams VALUES (2,2,'2026-03-12','Midterm');
INSERT INTO Exams VALUES (3,3,'2026-03-14','Midterm');
INSERT INTO Exams VALUES (4,4,'2026-03-16','Final');
INSERT INTO Exams VALUES (5,5,'2026-03-18','Final');

-- 30 Marks
SELECT * FROM Marks;
INSERT INTO Marks VALUES (1,1,1,85);
INSERT INTO Marks VALUES (2,2,1,78);
INSERT INTO Marks VALUES (3,3,2,90);
INSERT INTO Marks VALUES (4,4,2,88);
INSERT INTO Marks VALUES (5,5,3,76);
INSERT INTO Marks VALUES (6,6,3,82);
INSERT INTO Marks VALUES (7,7,4,91);
INSERT INTO Marks VALUES (8,8,4,87);
INSERT INTO Marks VALUES (9,9,5,69);
INSERT INTO Marks VALUES (10,10,5,73);
INSERT INTO Marks VALUES (11,11,6,80);
INSERT INTO Marks VALUES (12,12,6,85);
INSERT INTO Marks VALUES (13,13,7,77);
INSERT INTO Marks VALUES (14,14,7,88);
INSERT INTO Marks VALUES (15,15,8,92);
INSERT INTO Marks VALUES (16,16,8,81);
INSERT INTO Marks VALUES (17,17,9,74);
INSERT INTO Marks VALUES (18,18,9,79);
INSERT INTO Marks VALUES (19,19,10,86);
INSERT INTO Marks VALUES (20,20,10,90);
INSERT INTO Marks VALUES (21,1,2,84);
INSERT INTO Marks VALUES (22,2,3,75);
INSERT INTO Marks VALUES (23,3,4,89);
INSERT INTO Marks VALUES (24,4,5,77);
INSERT INTO Marks VALUES (25,5,6,83);
INSERT INTO Marks VALUES (26,6,7,80);
INSERT INTO Marks VALUES (27,7,8,88);
INSERT INTO Marks VALUES (28,8,9,91);
INSERT INTO Marks VALUES (29,9,10,85);
INSERT INTO Marks VALUES (30,10,1,79);

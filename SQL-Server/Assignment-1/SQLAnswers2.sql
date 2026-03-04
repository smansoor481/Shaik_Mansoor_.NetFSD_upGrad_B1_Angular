-- Write an SQL query to fetch “FIRST_NAME” from Worker table using the alias name as <WORKER_NAME>.
SELECT FIRST_NAME AS First_Name FROM Worker;

-- Write an SQL query to fetch “FIRST_NAME” from Worker table in upper case.
SELECT UPPER(FIRST_NAME) FROM Worker;

--  Write an SQL query to fetch unique values of DEPARTMENT from Worker table.
SELECT DEPARTMENT FROM Worker
GROUP BY DEPARTMENT;

SELECT DISTINCT DEPARTMENT FROM Worker;

-- Write an SQL query to print the first three characters of  FIRST_NAME from Worker table.
SELECT LEFT(FIRST_NAME, 3) FROM Worker;

-- Write an SQL query to find the position of the alphabet (‘a’) in the first name column ‘Amitabh’ from Worker table.
SELECT CHARINDEX('A', FIRST_NAME)
FROM Worker WHERE FIRST_NAME = 'Amitabh';

-- Write an SQL query to print the FIRST_NAME from Worker table after removing white spaces from the right side.
SELECT RTRIM(FIRST_NAME) FROM Worker;

-- Write an SQL query to print the DEPARTMENT from Worker table after removing white spaces from the left side.
SELECT LTRIM(DEPARTMENT) FROM Worker;

-- Write an SQL query that fetches the unique values of DEPARTMENT from Worker table and prints its length.
SELECT DISTINCT DEPARTMENT, LEN(DEPARTMENT) AS DEPT_LENGTH FROM Worker;

-- Write an SQL query to print the FIRST_NAME from Worker table after replacing ‘a’ with ‘A’.
SELECT REPLACE(FIRST_NAME, 'a', 'A') FROM Worker;

-- Write an SQL query to print the FIRST_NAME and LAST_NAME from Worker table into a single column COMPLETE_NAME. A space char should separate them.
SELECT FIRST_NAME+' '+LAST_NAME AS Full_Name FROM Worker;

-- Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending.
SELECT * FROM Worker ORDER BY FIRST_NAME ASC;

-- Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending and DEPARTMENT Descending.
SELECT * FROM Worker ORDER BY FIRST_NAME ASC, DEPARTMENT DESC;

-- Write an SQL query to print details for Workers with the first name as “Vipul” and “Satish” from Worker table.
SELECT * FROM Worker where FIRST_NAME IN ('Vipul','Satish');

-- Write an SQL query to print details of workers excluding first names, “Vipul” and “Satish” from Worker table.
SELECT * FROM Worker where FIRST_NAME NOT IN ('Vipul','Satish');

-- Write an SQL query to print details of Workers with DEPARTMENT name as “Admin”.
SELECT * FROM Worker WHERE DEPARTMENT = 'Admin';

-- Write an SQL query to print details of the Workers whose FIRST_NAME contains ‘a’.
SELECT * FROM Worker WHERE FIRST_NAME LIKE '%a%';

-- Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘a’.
SELECT * FROM Worker WHERE FIRST_NAME LIKE '%a';

-- Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘h’ and contains six alphabets.
SELECT * FROM Worker WHERE FIRST_NAME LIKE '%h' AND LEN(FIRST_NAME) = 6;

-- Write an SQL query to print details of the Workers whose SALARY lies between 100000 and 500000.
SELECT * FROM Worker WHERE SALARY BETWEEN 100000 AND 500000;

--  Write an SQL query to print details of the Workers who have joined in Feb’2014.
SELECT * FROM Worker
WHERE MONTH(JOINING_DATE) = 2
AND YEAR(JOINING_DATE) = 2014;

-- Write an SQL query to fetch worker names with salaries >= 50000 and <= 100000.
SELECT FIRST_NAME +' '+LAST_NAME AS WorkerNames FROM Worker WHERE SALARY >= 50000 AND SALARY <= 100000;

-- Write an SQL query to fetch the no. of workers for each department in the descending order.
SELECT DEPARTMENT, COUNT(*) AS TOTAL_WORKERS FROM Worker GROUP BY DEPARTMENT ORDER BY TOTAL_WORKERS DESC;

-- Write an SQL query to print details of the Workers who are also Managers

-- Write an SQL query to show the current date and time.
SELECT GETDATE() AS CURRENT_DATE_TIME;

-- Write an SQL query to show the top n (say 10) records of a table.
SELECT TOP 10 * FROM Worker; 





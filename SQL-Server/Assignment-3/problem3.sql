--Add a column PhoneNumber to Students table
ALTER TABLE Students
ADD PhoneNumber VARCHAR(10);

SELECT * FROM Students;

-- Add column Salary to Teachers table.
ALTER TABLE Teachers
ADD Salary DECIMAL(10,2);

SELECT * FROM Teachers;

--Modify Salary datatype.
ALTER TABLE Teachers
ALTER COLUMN SALARY INT;
sp_help Teachers;

--Add CHECK constraint to Salary (salary > 20000).
ALTER TABLE Teachers
ADD CONSTRAINT SALARY CHECK (salary > 20000);


-- Drop PhoneNumber column.
ALTER TABLE Students
DROP COLUMN PhoneNumber;

-- Rename a column.
EXEC sp_rename 'Teachers.Email', 'Gmail', 'COLUMN';


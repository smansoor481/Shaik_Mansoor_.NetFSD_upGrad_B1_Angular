CREATE DATABASE StoreDB;
USE StoreDB;

CREATE TABLE Customers (
    customer_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    email VARCHAR(100)
);

CREATE TABLE Orders (
    order_id INT PRIMARY KEY,
    customer_id INT,
    order_date DATE,
    order_status INT,
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);

INSERT INTO Customers VALUES
(1,'Ram','Sharma','ram@gmail.com'),
(2,'Karan','Verma','karan@gmail.com'),
(3,'Robert','Brown','robert@gmail.com'),
(4,'David','Miller','david@gmail.com'),
(5,'Priya','Reddy','priya@gmail.com');


INSERT INTO Orders VALUES
(101,1,'2025-03-01',1),
(102,2,'2025-03-03',4),
(103,3,'2025-03-02',2),
(104,1,'2025-03-04',4),
(105,5,'2025-03-05',1),
(106,4,'2025-03-06',3);


SELECT * FROM Customers;
SELECT * FROM Orders;



SELECT c.first_name, c.last_name, o.order_id, o.order_date, o.order_status 
FROM Customers c JOIN Orders o
ON c.customer_id = o.customer_id;



--Display only orders with status Pending (1) or Completed (4).
SELECT * FROM Orders WHERE Order_status = 1 OR Order_status = 4;

SELECT * FROM Orders WHERE Order_status IN (1,4);


--Sort the results by order_date in descending order.
SELECT * FROM Orders ORDER BY Order_date  DESC;

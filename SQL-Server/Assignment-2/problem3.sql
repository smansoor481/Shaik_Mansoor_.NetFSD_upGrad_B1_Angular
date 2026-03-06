CREATE DATABASE SalesDB;
USE SalesDB;

CREATE TABLE Stores (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(50),
    city VARCHAR(50)
);

CREATE TABLE Orders (
    order_id INT PRIMARY KEY,
    store_id INT,
    order_date DATE,
    order_status INT,
    FOREIGN KEY (store_id) REFERENCES Stores(store_id)
);

ALTER TABLE Orders
ALTER COLUMN order_status VARCHAR(20);

UPDATE Orders SET order_status = 'Completed' WHERE order_id = 101;

UPDATE Orders SET order_status = 'Pending' WHERE order_id = 102;

UPDATE Orders SET order_status = 'Completed' WHERE order_id = 103;

UPDATE Orders SET order_status = 'Completed' WHERE order_id = 104;

UPDATE Orders SET order_status = 'Shipped' WHERE order_id = 105;

UPDATE Orders SET Order
CREATE TABLE Order_Items (
    item_id INT PRIMARY KEY,
    order_id INT,
    product_name VARCHAR(50),
    quantity INT,
    list_price DECIMAL(10,2),
    discount DECIMAL(4,2),
    FOREIGN KEY (order_id) REFERENCES Orders(order_id)
);


INSERT INTO Stores VALUES
(1,'Central Store','Hyderabad'),
(2,'City Mall Store','Bangalore'),
(3,'Metro Store','Chennai');

INSERT INTO Orders VALUES
(101,1,'2025-03-01',4),
(102,2,'2025-03-02',1),
(103,1,'2025-03-03',4),
(104,3,'2025-03-04',4),
(105,2,'2025-03-05',3);


INSERT INTO Order_Items VALUES
(1,101,'Laptop',2,50000,0.10),
(2,101,'Mouse',3,500,0.05),
(3,102,'Keyboard',2,1500,0.10),
(4,103,'Monitor',1,12000,0.15),
(5,104,'Printer',1,8000,0.10),
(6,104,'Scanner',2,6000,0.05),
(7,105,'Speaker',2,3000,0.10);

SELECT * FROM Stores;
SELECT * FROM Orders;
SELECT * FROM Order_Items;


SELECT s.store_name,
SUM(i.quantity * i.list_price * (1 - i.discount)) AS total_sales
FROM Stores s
JOIN Orders o
ON s.store_id = o.store_id
JOIN Order_Items i
ON o.order_id = i.order_id
WHERE o.order_status = 'Completed'
GROUP BY s.store_name
ORDER BY total_sales DESC;
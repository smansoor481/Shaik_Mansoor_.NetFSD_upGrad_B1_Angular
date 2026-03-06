CREATE DATABASE InventoryDB;
USE InventoryDB;

CREATE TABLE Products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(50)
);

CREATE TABLE Stores (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(50)
);

CREATE TABLE Stocks (
    stock_id INT PRIMARY KEY,
    product_id INT,
    store_id INT,
    quantity INT,
    FOREIGN KEY (product_id) REFERENCES Products(product_id),
    FOREIGN KEY (store_id) REFERENCES Stores(store_id)
);

CREATE TABLE Order_Items (
    item_id INT PRIMARY KEY,
    product_id INT,
    store_id INT,
    quantity INT,
    FOREIGN KEY (product_id) REFERENCES Products(product_id),
    FOREIGN KEY (store_id) REFERENCES Stores(store_id)
);

INSERT INTO Products VALUES
(1,'Laptop'),
(2,'Mobile'),
(3,'Headphones'),
(4,'Keyboard');

INSERT INTO Stores VALUES
(1,'Central Store'),
(2,'City Mall Store');

INSERT INTO Stocks VALUES
(1,1,1,20),
(2,2,1,35),
(3,3,1,15),
(4,1,2,10),
(5,4,2,25);

INSERT INTO Order_Items VALUES
(1,1,1,5),
(2,1,1,3),
(3,2,1,10),
(4,1,2,2),
(5,3,1,4);



SELECT 
p.product_name,
s.store_name,
st.quantity AS stock_quantity,
SUM(oi.quantity) AS total_quantity_sold
FROM Stocks st
INNER JOIN Products p
ON st.product_id = p.product_id
INNER JOIN Stores s
ON st.store_id = s.store_id
LEFT JOIN Order_Items oi
ON st.product_id = oi.product_id
AND st.store_id = oi.store_id
GROUP BY p.product_name, s.store_name, st.quantity
ORDER BY p.product_name;
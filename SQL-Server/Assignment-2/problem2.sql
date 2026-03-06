use StoreDB;

CREATE TABLE Categories (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(50)
);

CREATE TABLE Brands (
    brand_id INT PRIMARY KEY,
    brand_name VARCHAR(50)
);

CREATE TABLE Products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(50),
    category_id INT,
    brand_id INT,
    price DECIMAL(10,2),
    FOREIGN KEY (category_id) REFERENCES Categories(category_id),
    FOREIGN KEY (brand_id) REFERENCES Brands(brand_id)
);


INSERT INTO Categories VALUES
(1,'Electronics'),
(2,'Clothing'),
(3,'Home Appliances');

INSERT INTO Brands VALUES
(1,'Samsung'),
(2,'Nike'),
(3,'LG'),
(4,'Adidas');


INSERT INTO Products VALUES
(101,'Smartphone',1,1,25000),
(102,'Television',1,3,45000),
(103,'T-Shirt',2,2,1200),
(104,'Running Shoes',2,4,3500),
(105,'Washing Machine',3,3,30000),
(106,'Refrigerator',3,1,40000);


SELECT * FROM Categories;
SELECT * FROM Brands;
SELECT * FROM Products;


-- Display product_name, brand_name, category_name,and list_price.
SELECT p.product_name, b.brand_name, c.category_name, p.price
FROM
Products p JOIN Brands b
ON p.brand_id = b.brand_id
JOIN Categories c
ON c.category_id = p.category_id;


SELECT * FROM Products
WHERE price > 500;

SELECT * FROM Products 
ORDER BY price ASC;


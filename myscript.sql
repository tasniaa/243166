CREATE Database ProductDB
Use ProductDB
CREATE Table Category
(
CatagoryID int IDENTITY(1,1),
CatagoryName VARCHAR(50)
)
INSERT INTO Category VALUES('Stationery')
INSERT INTO Category VALUES('Computer')
INSERT INTO Category VALUES('Moblie')
INSERT INTO Category VALUES('Notebook')
SELECT * from Category
CREATE Table Product
(
ProductID int IDENTITY(1,1),
CatagoryID int,
ProductName VARCHAR(50),
QTY int,
Price float,
Description text
)
INSERT INTO Product VALUES (1,'Pen',10,15,'Good pen for exam')
INSERT INTO Product VALUES (1,'Pencil',100,5,'Good pencil for drawing') 
INSERT INTO Product VALUES (1,'Notebook',50,25,'Notebook for primary students') 
INSERT INTO Product VALUES (1,'Fullscape',200,15,'Fullscape for higer secondary students') 
INSERT INTO Product VALUES (1,'Eraser',1000,1.50,'Eraser for KG Students') 
INSERT INTO Product VALUES (2,'Mouse',20,200,'USB 2.0 Mouse') 
INSERT INTO Product VALUES (2,'Keyboard',20,250,'USB 3.0 Keyboard') 
INSERT INTO Product VALUES (2,'USB Stick',1000,450,'4 GB Pendrives') 
INSERT INTO Product VALUES (2,'Laptop',1000,450,'') 
INSERT INTO Product VALUES (0,'Table' ,10 ,1500 ,'Computer Table') 
2.1: Get all columns and all rows from ‘Product’ table 
SELECT * from Product
2.2: Get Column with their respective values from the table. 
SELECT ProductName,QTY,Price from Product
2.3: Get all columns from ‘Product’ table with where clause. 
SELECT * from Product where ProductName='Mouse'
2.4: Get all columns from ‘Product’ table  using Between Operator-
SELECT * from Product where ProductID BETWEEN 2 and 4
2.5: Get all rows from ‘Product’ table where ProductName is Mouse,Keyboard,USB Stick 
SELECT * from Product where ProductName in('Mouse','Keyboard','USB Stick' )
2.6: Get all rows from ‘Product’ table where the name starts with ‘K’ letter. 
SELECT * from Product where ProductName like 'K%'
2.7: Get all rows from ‘Product’ table where the name ends with ‘K’ letter. 
SELECT * from Product where ProductName like '%K'
SELECT * from Product where ProductName like '%K%'
Get all rows from ‘Product’ table where the name starts with ‘E/F’ letter. 
SELECT * from Product where ProductName like '[EF]%'
2.9: Get all rows from ‘Product’ table where the name not starts with ‘E/F’ letter. 
SELECT * from Product where ProductName like '[^EF]%'
2.10: Get single column with a combination of Product and Qty added together with a space from Product’ table 
Select (Productname  +SPACE(1)+CONVERT(VARCHAR,QTY)) as ProductWithQTY from Product
2.11: Get all rows from ‘Product’ table where ProductName column is not containing null values 
SELECT * FROM Product WHERE ProductName IS  NOT NULL 
2.12: Get all rows from ‘Product’ table in descending order of ProductId 
SELECT * FROM Product ORDER BY ProductID DESC
2.13: Get all rows from ‘Product’ table in ascending order of ProductId 
SELECT * FROM Product ORDER BY ProductID 
2.14: Get Unique row from ‘Product’ table based on CategoryId 
SELECT DISTINCT CatagoryID FROM Product 
2.15: Get top 5 Rows from ‘Product’ table  
SELECT Top 5 * FROM Product
2.16: Get maximum value Of ProductId from ‘Product’ table 
SELECT MAX(ProductID) as ProductID FROM Product
2.17: Get maximum value Of Qty from ‘Product’ table 
SELECT  MAX(QTY) As QTY FROM Product 
SELECT  MIN(QTY) As QTY FROM Product 
2.18: Get even row from table 'Product' 
SELECT * FROM Product Where ProductID%2=0
2.19: Get odd row from table 'Product' 
SELECT * FROM Product Where ProductID%2=1
2.20: Count number of records in a 'Product' table
SELECT COUNT(*) as Records FROM Product
2.21: List all the categories with products (Inner Join) 
SELECT * From Category as c
INNER JOIN Product as p ON  p.CatagoryID=c.CatagoryID
2.22: List all rows from category, even if there are no matches in the product table (Left Join) 
SELECT * From Category as c
Left OUTER JOIN Product as p ON  p.CatagoryID=c.CatagoryID
2.23: List all the rows from product, even if there are no matches in the category table (Right Join) 
SELECT * From Category as c
Right OUTER JOIN Product as p ON  p.CatagoryID=c.CatagoryID
2.24: List all the rows from the category table and all the rows from the product table (Full Join
SELECT * From Category as c
Full JOIN Product as p ON  p.CatagoryID=c.CatagoryID
2.25: Get average value of price from product table 
SELECT AVG(Price) as AveragePrice FROM Product
Get number of products from product table
SELECT COUNT(*) as NoOfProducts FROM Product
Get Maximum price of product from product table 
SELECT  MAX(Price) As MAximumPrice FROM Product 
2.28: Get minimum price of product from product table
SELECT  MIN(Price) As MAximumPrice FROM Product 
2.29: Get total number of qty of products from product table 
SELECT  SUM(QTY) As TotalPrice FROM Product 
2.30: Get all product name is in upper case from product table

SELECT  UPPER(ProductName) As ProductName FROM Product 
2.31: Get all product name is in lower case from product table
SELECT  LOWER(ProductName) As ProductName FROM Product 
 List all columns of all tables in a database
 SELECT * From Category,Product
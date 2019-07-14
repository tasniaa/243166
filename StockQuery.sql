CREATE Database StockManagment
USE StockManagment
CREATE TABLE Category
(
	ID int IDENTITY(1,1),
	CategoryName varchar(50) 
)
INSERT INTO Category VALUES('Stationery')
INSERT INTO Category VALUES('Cosmetics')
SELECT * FROM Category

CREATE TABLE Company
(
	ID int IDENTITY(1,1),
	CompanyName varchar(50) 
)
INSERT INTO Company VALUES('Uniliver')
INSERT INTO Company VALUES('RFL')
SELECT * FROM Company
CREATE TABLE Items
(
	ID int IDENTITY(1,1),
	CategoryName varchar(50),
	CompanyName varchar(50),
	Item varchar(50),
	ReorderLevel int 
)
INSERT INTO Items VALUES('Cosmetics','Uniliver', 'vaseline Lotion',5)

SELECT * FROM Items
CREATE TABLE StockIn
(
	StockId int IDENTITY(1,1),
	CategoryName varchar(50),
	CompanyName varchar(50),
	Item varchar(50),
	StockInQuantity int,
	Date date 
	)
	INSERT INTO StockIn VALUES('Cosmetics','Uniliver', 'vaseline Lotion',5,getdate())
	SELECT * FROM StockIn

	CREATE TABLE StockOut
(
	StockId int IDENTITY(1,1),
	CategoryName varchar(50),
	CompanyName varchar(50),
	Item varchar(50),
	StockOutQuantity int,
	Date date 
	)
	INSERT INTO StockOut VALUES('Cosmetics','Uniliver', 'vaseline Lotion',5,getdate())
	SELECT * FROM Category
	SELECT * FROM Company
	SELECT * FROM Items
	SELECT * FROM StockIn
	SELECT * FROM StockOut

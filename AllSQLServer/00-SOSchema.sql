CREATE TABLE Categories (
	CategoryID 					INT  			NOT NULL  IDENTITY  PRIMARY KEY,
	CategoryDescription 		NVARCHAR (75)	NULL 
);

CREATE TABLE Customers (
	CustomerID 					INT  			NOT NULL  IDENTITY(1001, 1)  PRIMARY KEY,
	CustomerFirstName 			NVARCHAR (25) 	NULL,
	CustomerLastName 			NVARCHAR (25) 	NULL,
	CustomerStreetAddress 		NVARCHAR (50) 	NULL,
	CustomerCity 				NVARCHAR (30) 	NULL,
	CustomerState 				NVARCHAR (2) 	NULL,
	CustomerZipCode 			NVARCHAR (10) 	NULL,
	CustomerAreaCode 			SMALLINT 		NULL,
	CustomerPhoneNumber 		NVARCHAR (8) 	NULL 
);

CREATE TABLE Employees (
	EmployeeID 					INT  			NOT NULL  IDENTITY(701, 1)  PRIMARY KEY,
	EmployeeFirstName 			NVARCHAR (25) 	NULL,
	EmployeeLastName 			NVARCHAR (25) 	NULL,
	EmployeeStreetAddress 		NVARCHAR (50) 	NULL,
	EmployeeCity 				NVARCHAR (30)	NULL,
	EmployeeState 				NVARCHAR (2) 	NULL,
	EmployeeZipCode 			NVARCHAR (10) 	NULL,
	EmployeeAreaCode 			SMALLINT 		NULL,
	EmployeePhoneNumber 		NVARCHAR (8) 	NULL 
);

CREATE TABLE Vendors (
	VendorID 					INT  			NOT NULL  IDENTITY  PRIMARY KEY,
	VendorName 					NVARCHAR (25) 	NULL,
	VendorStreetAddress 		NVARCHAR (50) 	NULL,
	VendorCity 					NVARCHAR (30) 	NULL,
	VendorState 				NVARCHAR (2) 	NULL,
	VendorZipCode 				NVARCHAR (10) 	NULL,
	VendorPhoneNumber 			NVARCHAR (15) 	NULL,
	VendorFaxNumber 			NVARCHAR (15) 	NULL,
	VendorWebPage 				TEXT 			NULL,
	VendorEMailAddress 			NVARCHAR (50) 	NULL
);

CREATE TABLE Products (
	ProductID 					INT  			NOT NULL  IDENTITY  PRIMARY KEY,
	ProductName 				NVARCHAR (50) 	NULL,
	ProductDescShort 			NVARCHAR (MAX) 	NULL,
	ProductDescLong 			NVARCHAR (MAX) 	NULL,
	ProductImage				NVARCHAR (MAX) 	NULL,
	ProductPrice 				DECIMAL (15,2) 	NULL,
	ProductQty 					INT 			NULL,
	CategoryID 					INT 			NULL 
);

CREATE TABLE ProductVendors (
	ProductID  					INT,
	VendorID 					INT 			NOT NULL,
	ProductVendorWholesalePrice	DECIMAL (15,2) 	NULL,
	ProductVendorDaysToDeliver	SMALLINT 		NULL
	PRIMARY KEY (ProductID, VendorID) 
);

CREATE TABLE Orders (
	OrderID  					INT 			NOT NULL    IDENTITY    PRIMARY KEY,
	OrderDate 					datetime 		NULL,
	OrderShipDate 				datetime 		NULL,
	CustomerID 					INT 			NULL,
	EmployeeID 					INT 			NULL 
);

CREATE TABLE OrderDetails (
	OrderID 					INT,
	ProductID 					INT 			NOT NULL,
	OrderDetailQuotedPrice 		DECIMAL (15,2) 	NULL,
	OrderDetailQuantityOrdered 	INT 			NULL,
	PRIMARY KEY (OrderID, ProductID)
);

CREATE  INDEX idx_CustomerAreaCode ON Customers(CustomerAreaCode);

CREATE  INDEX idx_CustomerZipCode ON Customers(CustomerZipCode);

CREATE  INDEX idx_EmployeeAreaCode ON Employees(EmployeeAreaCode);

CREATE  INDEX idx_EmployeeZipCode ON Employees(EmployeeZipCode);

CREATE  INDEX idx_CustomerID ON Orders(CustomerID);

CREATE  INDEX idx_EmployeeID ON Orders(EmployeeID);

CREATE  INDEX idx_EmployeesOrders ON Orders(EmployeeID);

CREATE  INDEX idx_CategoriesProducts ON Products(CategoryID);

CREATE  INDEX idx_VendorZipCode ON Vendors(VendorZipCode);

ALTER TABLE OrderDetails ADD CONSTRAINT OrderDetailsFK00 
FOREIGN KEY (OrderID) REFERENCES Orders (OrderID);

ALTER TABLE OrderDetails ADD CONSTRAINT OrderDetailsFK01 
FOREIGN KEY (ProductID) REFERENCES Products (ProductID);

ALTER TABLE Orders ADD CONSTRAINT OrdersFK00 
FOREIGN KEY (CustomerID) REFERENCES Customers (CustomerID);

ALTER TABLE Orders ADD CONSTRAINT OrdersFK01 
FOREIGN KEY (EmployeeID) REFERENCES Employees (EmployeeID);

ALTER TABLE ProductVendors ADD CONSTRAINT ProductVendorsFK00 
FOREIGN KEY (ProductID) REFERENCES Products (ProductID);

ALTER TABLE ProductVendors ADD CONSTRAINT ProductVendorsFK01 
FOREIGN KEY (VendorID) REFERENCES Vendors (VendorID);

ALTER TABLE Products ADD CONSTRAINT ProductsFK00 
FOREIGN KEY (CategoryID) REFERENCES Categories (CategoryID);

CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(50) NOT NULL,
	DailyRate DECIMAL(5,2) NOT NULL,
	WeeklyRate DECIMAL(6,2) NOT NULL,
	MonthlyRate DECIMAL(7,2) NOT NULL,
	WeekendRate DECIMAL(5,2) NOT NULL
	)

CREATE TABLE Cars (
	Id INT PRIMARY KEY IDENTITY,
	PlateNumber NVARCHAR(12) NOT NULL,
	Manufacturer NVARCHAR(20) NOT NULL,
	Model NVARCHAR(20) NOT NULL,
	CarYear DATE NOT NULL,
	CategoryId INT NOT NULL FOREIGN KEY REFERENCES Categories(Id),
	Doors INT NOT NULL,
	Picture VARBINARY(MAX),
	Condition NVARCHAR(MAX),
	Available BIT NOT NULL
	)

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	Title NVARCHAR(30) NOT NULL,
	Notes NVARCHAR(MAX) NULL
	)
	
CREATE TABLE Customers (
	Id INT PRIMARY KEY IDENTITY,
	DriverLicenceNumber NVARCHAR(30) NOT NULL,
	FullName NVARCHAR(30) NOT NULL,
	Address NVARCHAR(50) NOT NULL,
	City NVARCHAR(30) NOT NULL,
	ZIPCode INT NOT NULL,
	Notes NVARCHAR(MAX)
	)

CREATE TABLE RentalOrders (
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT NOT NULL FOREIGN KEY REFERENCES Employees(Id),
	CustomerId INT NOT NULL FOREIGN KEY REFERENCES Customers(Id),
	CarId INT NOT NULL FOREIGN KEY REFERENCES Cars(Id),
	TankLevel DECIMAL(5,2) NOT NULL,
	KilometrageStart DECIMAL(10,2) NOT NULL,
	KilometrageEnd DECIMAL(10,2) NOT NULL,
	TotalKilometrage DECIMAL(10,2) NOT NULL,
	StartDate DATETIME NOT NULL,
	EndDate DATETIME NOT NULL,
	TotalDays INT NOT NULL,
	RateApplied DECIMAL(10,2) NOT NULL,
	TaxRate DECIMAL(10,2) NOT NULL,
	OrderStatus NVARCHAR(30),
	Notes NVARCHAR(MAX)
	)

INSERT INTO Categories(CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) VALUES
('Coupe', 25.2, 175.33, 750.99, 80.55),
('Hachback', 25.2, 175.33, 750.99, 80.55),
('Sedan', 25.2, 175.33, 750.99, 80.55)

INSERT INTO Cars(PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available) VALUES
('CA 1901 PC', 'Ford', 'Mondeo', '1996', 3, 5, 900, 'Excellent', 1),
('PK 9843 BA', 'Pegeout', '406', '2000', 2, 5, 900, 'Excellent', 1),
('CO 7648 HH', 'Seat', 'Leon', '2004', 1, 3, 900, 'Excellent', 1)

INSERT INTO Employees(FirstName, LastName, Title, Notes) VALUES
('Ivanh', 'Lazarov', 'Jicata', 'she ti ba maikata'),
('Mitkho', 'Garbov', 'Krika', 'ima golqma opast'),
('Stahvri', 'Stamatov', 'mekata kitka', 'drug takuv nema')

INSERT INTO Customers(DriverLicenceNumber, FullName, Address, City, ZIPCode, Notes) VALUES
('o1h42irjg209', 'Grigor Dolpachiev', 'Mladost 2 bl 223', 'Sofia', 12379, NULL),
('0qfj93mg1941', 'Nafarfori Bojkov', 'Lulin 7 bl 758', 'Sofia', 89894, NULL),
('s46fsg1sgwf4', 'Minzuhar Cvetkov', 'Orlandovci bl 85', 'Sofia', 98459, 'Posledniq put ydari Ford-a')

INSERT INTO RentalOrders (EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes) VALUES
(1,2,3,25.3, 1352.45, 1542.69, (1542.69- 1352.45), '2012-02-26 09:34:00.000', '2012-04-23 19:33:00.000', 57, 25.33, 20.00, 'returned', 'prasnal e leviq migach'),
(1,2,3,25.3, 1352.45, 1542.69, (1542.69- 1352.45), '2012-02-26 09:34:00.000', '2012-04-23 19:33:00.000', 57, 25.33, 20.00, 'returned', 'prasnal e leviq migach'),
(1,2,3,25.3, 1352.45, 1542.69, (1542.69- 1352.45), '2012-02-26 09:34:00.000', '2012-04-23 19:33:00.000', 57, 25.33, 20.00, 'returned', 'prasnal e leviq migach')
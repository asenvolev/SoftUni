CREATE TABLE Employees(
Id INT NOT NULL PRIMARY KEY IDENTITY,
FirstName NVARCHAR(30) NOT NULL,
LastName NVARCHAR(30) NOT NULL,
Title NVARCHAR(30) NOT NULL,
Notes NVARCHAR(MAX)
)

CREATE TABLE Customers(
AccountNumber INT NOT NULL PRIMARY KEY,
FirstName NVARCHAR(30) NOT NULL,
LastName NVARCHAR(30) NOT NULL,
PhoneNumber VARCHAR(10) NOT NULL,
EmergencyName NVARCHAR(30) NOT NULL,
EmergencyNumber NVARCHAR(30) NOT NULL,
Notes NVARCHAR(MAX)
)

CREATE TABLE RoomStatus(
RoomStatus NVARCHAR(30) NOT NULL PRIMARY KEY,
Notes NVARCHAR(MAX)
)

CREATE TABLE RoomTypes(
RoomType NVARCHAR(30) NOT NULL PRIMARY KEY,
Notes NVARCHAR(MAX)
)

CREATE TABLE BedTypes(
BedType NVARCHAR(30) NOT NULL PRIMARY KEY,
Notes NVARCHAR(MAX)
)

CREATE TABLE Rooms(
RoomNumber INT NOT NULL PRIMARY KEY,
RoomType NVARCHAR(30) NOT NULL FOREIGN KEY REFERENCES RoomTypes(RoomType),
BedType NVARCHAR(30) NOT NULL FOREIGN KEY REFERENCES BedTypes(BedType),
Rate DECIMAL(5,2) NOT NULL,
RoomStatus NVARCHAR(30) NOT NULL FOREIGN KEY REFERENCES RoomStatus(RoomStatus),
Notes NVARCHAR(MAX)
)

CREATE TABLE Payments(
Id INT NOT NULL PRIMARY KEY IDENTITY,
EmployeeId INT NOT NULL FOREIGN KEY REFERENCES Employees(Id),
PaymentDate DATE NOT NULL,
AccountNumber INT NOT NULL FOREIGN KEY REFERENCES Customers(AccountNumber),
FirstDateOccupied DATE NOT NULL,
LastDateOccupied DATE NOT NULL,
TotalDays INT NOT NULL,
AmountCharged DECIMAL(6,2) NOT NULL,
TaxRate DECIMAL(5,2) NOT NULL,
TaxAmount DECIMAL(5,2) NOT NULL,
PaymentTotal DECIMAL(6,2) NOT NULL,
Notes NVARCHAR(MAX)
)

CREATE TABLE Occupancies(
Id INT NOT NULL PRIMARY KEY IDENTITY,
EmployeeId INT NOT NULL FOREIGN KEY REFERENCES Employees(Id),
DateOccupied DATE NOT NULL,
AccountNumber INT NOT NULL FOREIGN KEY REFERENCES Customers(AccountNumber),
RoomNumber INT NOT NULL FOREIGN KEY REFERENCES Rooms(RoomNumber),
RateApplied DECIMAL(6,2),
PhoneCharge DECIMAL(6,2),
Notes NVARCHAR(MAX)
)

INSERT INTO Employees (FirstName, LastName, Title, Notes) VALUES
('Ivan', 'Ivanov', 'Shkembeto', NULL),
('Bat', 'Georgi', 'Komara', NULL),
('Joro', 'Rogachev', 'Chiflika', NULL)

INSERT INTO Customers(AccountNumber, FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes) VALUES
(985681, 'Kliment', 'Ohridski', '0884658931', 'Knigata', '84929843', 'No notes'),
(749416, 'Krasimir', 'Stavrovski', '0884958856', 'Opela', '98459648', NULL),
(841318, 'Bimbos', 'Morkas', '0879653259', 'Ouzuto', '98426849', 'No comment')

INSERT INTO RoomStatus (RoomStatus, Notes) VALUES
('Ready', NULL),
('Not cleaned', 'Really messy people'),
('Occupied', NULL)

INSERT INTO RoomTypes (RoomType, Notes) VALUES
('2 rooms', NULL),
('3 rooms', 'With studio'),
('1 room', NULL)

INSERT INTO BedTypes (BedType, Notes) VALUES
('Small', 'For 1 person'),
('King', 'For 1 person'),
('Big', 'For couples')

INSERT INTO Rooms (RoomNumber, RoomType, BedType, Rate, RoomStatus, Notes) VALUES
(201, '2 rooms', 'Small', 40.00, 'Ready', NULL),
(305, '3 rooms', 'Big', 40.00, 'Occupied', NULL),
(101, '1 room', 'King', 40.00, 'Not cleaned', NULL)

INSERT INTO Payments (EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes) VALUES
(1, '2016-03-23', 985681, '2016-03-20', '2016-03-23', 3, 56.43, 22.45, 12.22, 98.43, NULL),
(2, '2016-03-23', 749416, '2016-03-20', '2016-03-23', 3, 56.43, 22.45, 12.22, 98.43, NULL),
(3, '2016-03-23', 841318, '2016-03-20', '2016-03-23', 3, 56.43, 22.45, 12.22, 98.43, NULL)

 INSERT INTO Occupancies (EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes) VALUES
 (1, '2016-03-20', 985681, 201, 50.00, 20.00, NULL),
 (2, '2016-03-20', 985681, 305, 50.00, 20.00, NULL),
 (3, '2016-03-23', 985681, 101, 50.00, 20.00, NULL)
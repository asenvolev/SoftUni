CREATE TABLE Towns(
Id INT NOT NULL PRIMARY KEY IDENTITY,
Name NVARCHAR(30) NOT NULL
)
CREATE TABLE Addresses(
Id INT NOT NULL PRIMARY KEY IDENTITY,
AddressText NVARCHAR(50) NOT NULL,
TownId INT NOT NULL FOREIGN KEY REFERENCES Towns(Id)
)

CREATE TABLE Departments(
Id INT NOT NULL PRIMARY KEY IDENTITY,
Name NVARCHAR(30) NOT NULL
)

CREATE TABLE Employees(
Id INT NOT NULL PRIMARY KEY IDENTITY,
FirstName NVARCHAR(30) NOT NULL,
MiddleName NVARCHAR(30) NOT NULL,
LastName NVARCHAR(30) NOT NULL,
JobTitle NVARCHAR(30) NOT NULL,
DepartmentId INT NOT NULL FOREIGN KEY REFERENCES Departments(Id),
HireDate DATE NOT NULL,
Salary DECIMAL(10,2) NOT NULL,
AddressId INT NOT NULL FOREIGN KEY REFERENCES Addresses(Id),
)


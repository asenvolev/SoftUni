CREATE TABLE Passports(
PassportID INT NOT NULL PRIMARY KEY IDENTITY(101, 1),
PassportNumber NVARCHAR(30) NOT NULL,
)

CREATE TABLE Persons(
PersonID INT NOT NULL PRIMARY KEY IDENTITY,
FirstName VARCHAR(30) NOT NULL,
Salary DECIMAL(10,2) NOT NULL,
PassportID INT FOREIGN KEY REFERENCES Passports(PassportID)
)

INSERT INTO Passports(PassportNumber) VALUES
('N34FG21B'),
('K65LO4R7'),
('ZE657QP2')


INSERT INTO Persons(FirstName,Salary,PassportID) VALUES
('Roberto', 43300.00, 102),
('Tom', 56100.00, 103),
('Yana', 60200, 101)
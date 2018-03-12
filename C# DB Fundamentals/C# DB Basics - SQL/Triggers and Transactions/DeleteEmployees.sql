CREATE TABLE Deleted_Employees(
EmployeeId INT NOT NULL PRIMARY KEY IDENTITY,
FirstName NVARCHAR(30) NOT NULL,
LastName NVARCHAR(30) NOT NULL,
MiddleName NVARCHAR(30) NOT NULL,
JobTitle NVARCHAR(30) NOT NULL,
DepartmentId INT NOT NULL FOREIGN KEY REFERENCES Departments(DepartmentId),
Salary DECIMAL(15,4) NOT NULL)

GO
CREATE TRIGGER tr_DeletedEmployees ON Employees AFTER DELETE
AS
BEGIN
	INSERT INTO Deleted_Employees 
	SELECT FirstName, LastName, MiddleName, JobTitle, DepartmentId, Salary FROM deleted
END
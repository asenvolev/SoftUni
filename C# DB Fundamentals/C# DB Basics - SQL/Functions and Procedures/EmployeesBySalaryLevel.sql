CREATE PROC usp_EmployeesBySalaryLevel (@Level NVARCHAR(10))
AS
	SELECT FirstName, LastName FROM Employees
	WHERE dbo.ufn_GetSalaryLevel(Salary) = 'High'

EXEC usp_EmployeesBySalaryLevel 'High'
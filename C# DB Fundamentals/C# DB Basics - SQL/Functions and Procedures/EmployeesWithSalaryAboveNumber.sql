CREATE PROC usp_GetEmployeesSalaryAboveNumber(@Salary DECIMAL(18,4))
AS
	SELECT FirstName, LastName FROM Employees
	WHERE Salary >= @Salary;
	go

EXEC usp_GetEmployeesSalaryAboveNumber 48100
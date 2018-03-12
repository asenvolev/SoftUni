CREATE VIEW V_EmployeeNameJobTitle AS
SELECT FirstName + ' ' + IsNull(MiddleName, '') + ' ' + LastName AS [Full Name], JobTitle
FROM Employees
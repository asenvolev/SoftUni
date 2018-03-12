SELECT TOP(3) e.EmployeeID, e.FirstName FROM Employees AS e
LEFT JOIN EmployeesProjects as p
ON p.EmployeeID = e.EmployeeID
WHERE p.ProjectID IS NULL AND p.EmployeeID IS NULL
ORDER BY EmployeeID
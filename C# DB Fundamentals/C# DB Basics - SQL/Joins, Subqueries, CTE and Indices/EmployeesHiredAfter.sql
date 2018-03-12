SELECT e.FirstName, e.LastName, e.HireDate, d.Name AS [DeptName] FROM Employees AS e
INNER JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE HireDate > '01-01-1999' AND ( d.Name = 'Sales' OR d.Name = 'Finance')
ORDER BY HireDate
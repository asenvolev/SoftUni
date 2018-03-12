SELECT TOP(10) e.FirstName, e.LastName, e.DepartmentID
FROM Employees AS e
WHERE e.Salary > (SELECT AVG(m.Salary) AS [AverageSalary]
                  FROM Employees AS m
                  WHERE m.DepartmentID =	e.DepartmentID)
SELECT DepartmentID, MIN(Salary) AS [MinimumSalary] 
FROM Employees
WHERE HireDate > '2000-01-01' AND (DepartmentID = 2 OR DepartmentID=5 OR DepartmentID = 7)
GROUP BY DepartmentID
ORDER BY DepartmentID
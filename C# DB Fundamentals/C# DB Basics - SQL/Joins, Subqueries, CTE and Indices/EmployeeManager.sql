SELECT e.EmployeeID, e.FirstName, e.ManagerID, m.FirstName AS [ManagerName] 
FROM Employees AS e
INNER JOIN Employees AS m
ON e.ManagerID = m.EmployeeID
WHERE e.ManagerID = 7 OR e.ManagerID = 3
ORDER BY e.EmployeeID
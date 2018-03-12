SELECT e.EmployeeID, e.FirstName, 
CASE
		WHEN YEAR(p.StartDate) > 2004 THEN NULL
		ELSE p.Name
	END AS [ProjectName] FROM Employees AS e
INNER JOIN EmployeesProjects AS ep
ON e.EmployeeID = ep.EmployeeID
INNER JOIN Projects AS p
ON ep.ProjectID = p.ProjectID
WHERE ep.EmployeeID = 24
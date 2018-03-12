SELECT DepartmentID, Salary, ManagerID 
INTO AvgSalaryByDepartment 
FROM Employees
WHERE Salary > 30000

DELETE FROM AvgSalaryByDepartment
WHERE ManagerID = 42

UPDATE AvgSalaryByDepartment
SET Salary = Salary+5000
WHERE DepartmentID = 1

SELECT DepartmentID, AVG(Salary) AS [AverageSalary] FROM AvgSalaryByDepartment
GROUP BY DepartmentID
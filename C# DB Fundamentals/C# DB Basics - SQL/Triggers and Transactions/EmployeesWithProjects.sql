
CREATE PROC usp_AssignProject(@emloyeeId INT, @projectID INT)
AS
BEGIN
	BEGIN TRANSACTION
	INSERT INTO EmployeesProjects (EmployeeID, ProjectID) VALUES
	(@emloyeeId, @projectID)
	DECLARE @employeeProjects INT = (SELECT COUNT(ProjectID) FROM EmployeesProjects
	WHERE EmployeeID = @emloyeeId
	GROUP BY EmployeeID)
	IF (@employeeProjects > 3)
	BEGIN
	ROLLBACK
	RAISERROR('The employee has too many projects!', 16, 1)
	RETURN
	END
	COMMIT
END
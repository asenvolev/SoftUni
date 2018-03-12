CREATE PROC usp_GetTownsStartingWith(@StartString NVARCHAR(30))
AS
	SELECT Name FROM Towns
	WHERE Name LIKE @StartString + '%';

EXEC usp_GetTownsStartingWith Bal
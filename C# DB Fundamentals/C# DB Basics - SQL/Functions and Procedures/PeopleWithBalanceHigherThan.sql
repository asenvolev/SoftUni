CREATE OR ALTER PROC usp_GetHoldersWithBalanceHigherThan (@number DECIMAL(12,4))
AS
BEGIN
	SELECT ah.FirstName, ah.LastName FROM AccountHolders AS ah
	INNER JOIN Accounts as a
	ON ah.Id = a.AccountHolderId
	GROUP BY ah.FirstName, ah.LastName
	HAVING SUM(Balance) > @number
	--order by ah.FirstName, ah.LastName
END

EXEC usp_GetHoldersWithBalanceHigherThan 5000
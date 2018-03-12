CREATE TABLE Logs(
LogId INT NOT NULL PRIMARY KEY IDENTITY,
AccountId INT NOT NULL,
OldSum DECIMAL(10,2) NOT NULL,
NewSum DECIMAL(10,2) NOT NULL
)
GO

CREATE TRIGGER tr_Insert ON Accounts FOR UPDATE
AS
BEGIN
	INSERT INTO Logs(AccountId, OldSum, NewSum)
	SELECT d.Id,
		   d.Balance,
		   i.Balance
	FROM deleted AS d
	JOIN inserted AS i ON d.Id = i.Id
END

UPDATE Accounts
SET Balance += 268
WHERE Id = 2
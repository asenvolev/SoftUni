CREATE TABLE NotificationEmails(
Id INT NOT NULL PRIMARY KEY IDENTITY,
Recipient INT NOT NULL,
Subject VARCHAR(50) NOT NULL,
Body VARCHAR(50) NOT NULL
)
GO
CREATE TRIGGER tr_NotificationEmails ON Logs FOR INSERT
AS
BEGIN
	INSERT INTO NotificationEmails(Recipient,Subject,Body)
	SELECT a.AccountId,
		   CONCAT('Balance change for account: ',a.AccountId),
		   CONCAT('On ',GETDATE(),' your balance was changed from ',a.OldSum,' to ',a.NewSum)
	FROM Logs AS a
END

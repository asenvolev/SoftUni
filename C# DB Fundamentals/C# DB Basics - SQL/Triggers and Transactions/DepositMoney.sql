CREATE PROC usp_DepositMoney (@AccountId INT, @MoneyAmount DECIMAL(10,4))
AS
BEGIN
	IF(@MoneyAmount >=0)
	BEGIN
		UPDATE Accounts
		SET Balance += @MoneyAmount
		WHERE Id = @AccountId
	END
END

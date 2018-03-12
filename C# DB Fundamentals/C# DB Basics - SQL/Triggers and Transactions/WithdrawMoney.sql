CREATE PROC usp_WithdrawMoney (@AccountId INT, @MoneyAmount DECIMAL(10,4))
AS
BEGIN
	IF(@MoneyAmount >=0)
	BEGIN
		UPDATE Accounts
		SET Balance -= @MoneyAmount
		WHERE Id = @AccountId
	END
END

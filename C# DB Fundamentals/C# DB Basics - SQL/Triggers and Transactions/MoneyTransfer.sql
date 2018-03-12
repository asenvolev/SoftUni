CREATE PROC usp_TransferMoney(@SenderId INT, @ReceiverId INT, @Amount DECIMAL(10,4))
AS
BEGIN TRANSACTION Tran1
	EXEC usp_WithdrawMoney @SenderId, @Amount
	EXEC usp_DepositMoney @ReceiverId, @Amount
	DECLARE @SenderBalance DECIMAL(15,4) = (SELECT Balance FROM Accounts WHERE Id = @SenderId)
	IF (@SenderBalance < 0) 
	BEGIN
	ROLLBACK
	RAISERROR('Insufficient funds for the transaction!', 16, 1)
	RETURN
	END
COMMIT





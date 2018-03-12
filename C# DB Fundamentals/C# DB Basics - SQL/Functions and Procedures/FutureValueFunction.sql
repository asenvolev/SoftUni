CREATE FUNCTION ufn_CalculateFutureValue (@sum DECIMAL(12,4), @yearlyInterestRate FLOAT, @numOfYears INT)
RETURNS DECIMAL(12,4)
AS
BEGIN
	DECLARE @answer DECIMAL(12,4) = @sum * POWER((1+@yearlyInterestRate),@numOfYears)
	RETURN @answer
END

DROP FUNCTION ufn_CalculateFutureValue

SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5)
SELECT SUM(HostWizardDeposit - GuestWizardDeposit) AS [SumDifference] FROM
(
	SELECT DepositAmount AS [HostWizardDeposit],
	LEAD(DepositAmount) OVER (ORDER BY Id) AS [GuestWizardDeposit]
	FROM WizzardDeposits
) AS sql
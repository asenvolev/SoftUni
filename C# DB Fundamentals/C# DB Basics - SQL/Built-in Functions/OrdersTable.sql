SELECT ProductName,
	 OrderDate,
	 DATEADD(DAY,3,Orderdate) AS [Pay Due],
	 DATEADD(MONTH, 1, Orderdate) AS [Deliver Due]
FROM Orders
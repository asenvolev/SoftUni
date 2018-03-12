SELECT tab.ContinentCode, tab.CurrencyCode, tab.CurrencyUsage FROM  (
SELECT c.ContinentCode, c.CurrencyCode, COUNT(*) AS [CurrencyUsage],
DENSE_RANK() OVER(PARTITION BY c.ContinentCode ORDER BY COUNT(*) DESC) AS Rank
FROM Countries AS c
GROUP BY c.ContinentCode, c.CurrencyCode
HAVING COUNT(*) > 1) AS tab
WHERE tab.Rank = 1
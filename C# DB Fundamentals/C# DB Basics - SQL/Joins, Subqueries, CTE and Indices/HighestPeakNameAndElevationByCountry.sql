SELECT TOP(5) Tab.Country, Tab.[Highest Peak Name], Tab.[Highest Peak Elevation], tab.Mountain
FROM (
	SELECT c.CountryName AS [Country],
	ISNULL(p.PeakName, '(no highest peak)') AS [Highest Peak Name],
	ISNULL(p.Elevation, '0') AS [Highest Peak Elevation],
	ISNULL(m.MountainRange,'(no mountain)') AS [Mountain],
	DENSE_RANK() OVER(PARTITION BY c.CountryName ORDER BY p.Elevation DESC) AS [Rank]
	FROM Countries AS c
	FULL JOIN MountainsCountries AS mc
	ON c.CountryCode = mc.CountryCode
	FULL JOIN Mountains AS m
	ON mc.MountainId = m.Id
	FULL JOIN Peaks AS p
	ON mc.MountainId = p.MountainId
) AS Tab
WHERE Tab.Rank = 1
ORDER BY Tab.[Highest Peak Name]
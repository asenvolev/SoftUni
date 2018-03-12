SELECT TOP(5) c.CountryName, MAX(p.Elevation) AS [HighestPeakElevation],
MAX(r.Length) AS [LongestRiverLength]
 FROM Countries AS c
INNER JOIN MountainsCountries AS mc
ON c.CountryCode = mc.CountryCode
INNER JOIN Peaks AS p
ON mc.MountainId = p.MountainId
INNER JOIN CountriesRivers AS cr
ON c.CountryCode = cr.CountryCode
INNER JOIN Rivers AS r
ON cr.RiverId = r.Id
GROUP BY c.CountryName
ORDER BY MAX(p.Elevation) DESC, MAX(r.Length) DESC
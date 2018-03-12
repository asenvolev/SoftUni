SELECT mc.CountryCode, m.MountainRange, p.PeakName, p.Elevation FROM Peaks AS p
INNER JOIN MountainsCountries AS mc
ON p.MountainId = mc.MountainId
INNER JOIN Mountains AS m
ON mc.MountainId = m.Id
WHERE mc.CountryCode = 'BG' AND p.Elevation > 2835
ORDER BY Elevation DESC
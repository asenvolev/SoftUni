SELECT TOP(5) c.CountryName, r.RiverName FROM Countries AS c
LEFT JOIN CountriesRivers AS mc
ON c.CountryCode = mc.CountryCode
LEFT JOIN Rivers AS r
ON mc.RiverId = r.Id
WHERE c.ContinentCode = 'AF'
ORDER BY CountryName
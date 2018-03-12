SELECT TownID, Name FROM Towns
WHERE NOT (Name LIKE 'R%'OR Name LIKE 'B%' OR Name LIKE 'D%')
ORDER BY Name
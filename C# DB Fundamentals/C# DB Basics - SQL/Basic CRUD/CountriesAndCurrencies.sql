SELECT CountryName, CountryCode,
CASE CurrencyCode
WHEN 'EUR' THEN 'Euro'
ELSE 'Not euro'
END  AS Currency
FROM Countries ORDER BY CountryName
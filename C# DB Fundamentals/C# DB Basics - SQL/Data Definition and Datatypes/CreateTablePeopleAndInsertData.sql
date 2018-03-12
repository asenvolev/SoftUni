CREATE TABLE People(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(200) NOT NULL,
	Picture VARBINARY(8000),
	Height DECIMAL(8,2),
	Weight DECIMAL(8,2),
	Gender CHAR(1) NOT NULL CHECK (Gender IN ('m','f')),
	BirthDate DATE NOT NULL,
	Biography NVARCHAR(MAX)
)

INSERT INTO People(Name, Picture, Height, Weight, Gender, BirthDate, Biography) VALUES
('Gosho', 400, 1.90, 110,'m','20120618', 'I am the best'),
('Gosho', 400, 1.90, 110,'m','20120618', 'I am the best'),
('Gosho', 400, 1.90, 110,'m','20120618', 'I am the best'),
('Gosho', 400, 1.90, 110,'m','20120618', 'I am the best'),
('Gosho', 400, 1.90, 110,'m','20120618', 'I am the best')
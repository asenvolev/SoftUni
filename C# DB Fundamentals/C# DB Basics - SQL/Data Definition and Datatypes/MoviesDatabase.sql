CREATE DATABASE Movies

USE Movies

CREATE TABLE Directors (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	DirectorName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
	)

CREATE TABLE Genres (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	GenreName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
	)

CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	CategoryName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
	)

CREATE TABLE Movies (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	Title NVARCHAR(50) NOT NULL,
	DirectorId INT NOT NULL FOREIGN KEY REFERENCES Directors(Id),
	CopyRightYear DATE NOT NULL,
	Length INT NOT NULL,
	GenreId INT NOT NULL FOREIGN KEY REFERENCES Genres(Id),
	CategoryId INT NOT NULL FOREIGN KEY REFERENCES Categories(Id),
	Rating DECIMAL(4,2) NOT NULL CHECK(Rating BETWEEN 0.00 AND 10.00),
	Notes NVARCHAR(MAX)
	)

INSERT INTO Directors (DirectorName, Notes) VALUES
('John Wick', 'Very cool person'),
('Gary Barrou', NULL),
('Coolio Hammas', 'Really smart'),
('Jarock Willson',NULL),
('Nasko Manchev',NULL)


INSERT INTO Genres(GenreName, Notes) VALUES
('Action', 'Very cool movie'),
('Comedy', NULL),
('Thriller', 'Really scary'),
('Fantasy',NULL),
('SciFi',NULL)

INSERT INTO Categories(CategoryName, Notes) VALUES
('A', 'Recommended for children'),
('B', 'No age restrictions'),
('C', 'Not recommended for children under 12 years of age'),
('D','Prohibited for persons under 16 years of age'),
('E','Prohibited for persons under 18 years of age')

INSERT INTO Movies(Title,DirectorId,CopyRightYear,Length,GenreId,CategoryId,Rating,Notes) VALUES
('Underworld', 1,'2012',120,3,5,9.8,NULL),
('Close', 2,'2015',120,3,5,9.8,NULL),
('Sharks', 3,'2014',120,3,5,9.8,NULL),
('Tsunami', 4,'2011',120,3,5,9.8,NULL),
('Wassabi', 5,'2017',120,3,5,9.8,NULL)
CREATE TABLE Users(
	Id BIGINT PRIMARY KEY IDENTITY,
	Username VARCHAR(30) NOT NULL,
	Password VARCHAR(30) NOT NULL,
	ProfilePicture VARBINARY(900),
	LastLoginTime DATETIME NOT NULL,
	IsDeleted BIT NOT NULL
)

INSERT INTO Users(Username, Password, ProfilePicture, LastLoginTime, IsDeleted) VALUES
('Gosho', 'student', 400, '20120618 10:34:09 AM', 0),
('Gosho', 'student', 400, '20120618 10:34:09 AM', 0),
('Gosho', 'student', 400, '20120618 10:34:09 AM', 0),
('Gosho', 'student', 400, '20120618 10:34:09 AM', 0),
('Gosho', 'student', 400, '20120618 10:34:09 AM', 0)
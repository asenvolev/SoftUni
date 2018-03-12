CREATE TABLE Majors(
MajorID INT NOT NULL PRIMARY KEY IDENTITY,
Name NVARCHAR(50) NOT NULL
)

CREATE TABLE Students(
StudentID INT NOT NULL PRIMARY KEY IDENTITY,
StudentNumber INT NOT NULL,
StudentName NVARCHAR(50) NOT NULL,
MajorID INT NOT NULL FOREIGN KEY REFERENCES Majors(MajorID)
)

CREATE TABLE Payments(
PaymentID INT NOT NULL PRIMARY KEY IDENTITY,
PaymentDate DATE NOT NULL,
PaymentAmount DECIMAL(10,2) NOT NULL,
StudentID INT NOT NULL FOREIGN KEY REFERENCES Students(StudentID)
)

CREATE TABLE Subjects(
SubjectID INT NOT NULL PRIMARY KEY IDENTITY,
SubjectName NVARCHAR(50) NOT NULL
)

CREATE TABLE Agenda(
StudentID INT NOT NULL FOREIGN KEY REFERENCES Students(StudentID),
SubjectID INT NOT NULL FOREIGN KEY REFERENCES Subjects(SubjectID)
)

ALTER TABLE Agenda
ADD CONSTRAINT PK_OrderItems_Orders_Items PRIMARY KEY(StudentID,SubjectID)
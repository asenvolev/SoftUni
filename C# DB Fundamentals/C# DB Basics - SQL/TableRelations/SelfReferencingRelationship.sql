CREATE TABLE Teachers(
TeacherID INT NOT NULL PRIMARY KEY IDENTITY(101,1),
Name NVARCHAR(30) NOT NULL,
ManagerID INT 
)

INSERT INTO Teachers(Name,ManagerID) VALUES
('John', NULL),
('Maya', 106),
('Silvia', 106),
('Ted', 105),
('Mark', 101),
('Greta', 101)

ALTER TABLE Teachers
ADD CONSTRAINT FK_Teachers_teacherID_ManagerID FOREIGN KEY(ManagerID) REFERENCES Teachers(TeacherID)
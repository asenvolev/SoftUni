ALTER TABLE Users
DROP CONSTRAINT [PK__Users__3214EC07C7716126]

ALTER TABLE Users
ADD CONSTRAINT PK_IdUsername PRIMARY KEY (Id,Username)
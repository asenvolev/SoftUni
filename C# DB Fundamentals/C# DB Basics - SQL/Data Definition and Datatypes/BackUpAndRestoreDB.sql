BACKUP DATABASE SoftUni 
TO DISK = 'E:\SoftUni\DB\SoftUni.BAK'
GO

RESTORE DATABASE SoftUni  
   FROM DISK = 'E:\SoftUni\DB\SoftUni.BAK'
CREATE TABLE [dbo].[Task]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [username] NVARCHAR(50) NOT NULL, 
    [taskID] NCHAR(10) NOT NULL, 
    [requests] NVARCHAR(50) NULL 
)

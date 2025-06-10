CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] NCHAR(100) NOT NULL, 
    [Author] NCHAR(100) NOT NULL, 
    [Year] INT NOT NULL, 
    [IsAvailable] BIT NOT NULL
)

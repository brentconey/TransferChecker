CREATE TABLE [dbo].[Station]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StationNumber] INT NOT NULL, 
    [Name] NVARCHAR(250) NOT NULL, 
    [DateAdded] DATETIME NOT NULL 
)

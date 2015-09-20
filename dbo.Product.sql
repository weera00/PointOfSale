CREATE TABLE [dbo].[product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NCHAR(100) NULL, 
    [mydate] DATETIME NULL DEFAULT now()
)

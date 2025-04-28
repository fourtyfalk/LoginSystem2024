CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [benutzername] NVARCHAR(50) NULL, 
    [passwort] NVARCHAR(50) NULL, 
    [emailname] NVARCHAR(50) NULL, 
    [emaildomain] NVARCHAR(50) NULL, 
    [emailtopdomain] NVARCHAR(50) NULL
)

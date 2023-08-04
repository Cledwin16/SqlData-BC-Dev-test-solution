CREATE TABLE [dbo].[ClientTable]
(
	[ClientCode] CHAR(6) NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [Linked_Contacts] INT NULL
)

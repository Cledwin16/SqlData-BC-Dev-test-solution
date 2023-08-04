CREATE TABLE [dbo].[ContactsTable]
(
    [Name] VARCHAR(50) NULL, 
    [Surname] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_ContactsTable] PRIMARY KEY ([Email])
)

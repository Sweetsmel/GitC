﻿CREATE TABLE [dbo].[Autores]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Nome] VARCHAR(100) NOT NULL, 
    [Descrição] VARCHAR(1000) NULL
)
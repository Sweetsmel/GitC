﻿CREATE TABLE [dbo].[Generos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Tipo] VARCHAR(200) NOT NULL, 
    [Descrição] VARCHAR(1000) NOT NULL
)

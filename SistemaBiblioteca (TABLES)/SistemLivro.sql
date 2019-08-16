CREATE TABLE [dbo].[Livro]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[Registro] INT NOT NULL,
    [Titulo] VARCHAR(1200) NOT NULL, 
    [Isbn] VARCHAR(15) NOT NULL, 
    [Genero] INT NOT NULL, 
    [Editora] INT NOT NULL, 
    [Sinopse] NVARCHAR(MAX) NULL, 
    [Obervacoes] VARCHAR(1000) NULL, 
	[Ativo] BIT NOT NULL,
    [UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInt] DATETIME NOT NULL, 
    [DatAlt] DATETIME NOT NULL
)

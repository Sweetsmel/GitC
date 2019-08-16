CREATE TABLE [dbo].[Frequencias]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Aluno] VARCHAR(100) NOT NULL, 
    [Dia] DATE NOT NULL DEFAULT GETDATE(), 
	[Presenca] BIT NOT NULL,   

	CONSTRAINT [FK_Frequencias_AlunoNome] FOREIGN KEY ([Aluno]) REFERENCES [Alunos]([Id])
)

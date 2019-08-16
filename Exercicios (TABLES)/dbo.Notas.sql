CREATE TABLE [dbo].[Notas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[Aluno] VARCHAR(100) NOT NULL,
    [Nota1] INT NOT NULL, 
    [Nota2] INT NOT NULL, 
    [Nota3] INT NOT NULL, 
    [Nota4] INT NOT NULL,

	CONSTRAINT [FK_Notas_AlunoNome] FOREIGN KEY ([Aluno]) REFERENCES [Alunos]([Id])
)

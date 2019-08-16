insert into Diario1
(Nome, Materia, Nota1, Nota2, Nota3, Nota4, Nota5, Nota6)

Values
('Ana','Paint', 9, 7, 8, 4, 8, 7);

Select * from Diario1;

select
Nome,
Materia,

((Nota1 + Nota2 + Nota3 + Nota4 + Nota5 + Nota6)/ 6) as 'Media',
IIF(((Nota1 + Nota2 + Nota3 + Nota4 + Nota5 + Nota6)/ 6) >= 5, 'Aprovado','Reprovado') as 'Status'
from Diario1

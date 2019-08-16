select 
		Nome,
		Materia,
		(SUM(Nota) / COUNT(Nota)) --SUM soma as notas e COUNT pega a quantidade de notas registradas no sistema
from NotaAlunos
GROUP BY Nome, Materia

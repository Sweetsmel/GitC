select * 
	from Marcas Mr 
	inner join Carros Cr on Mr.Id = Cr.Marcas
order by Marcas desc

	--select * 
	--from Turmas tr 
	--inner join TurmaAlunos ta on tr.Id = ta.Turma

select n.Nome as 'Marcas',
		m.Marcas
	from Marcas n 
	inner join Marcas mr on n.Id = mr.Nome
	inner join Usuarios m on mr.Usuario = a.Id


select tr.Nome as 'Turma',
	a.Aluno
from Turmas tr 
inner join TurmaAlunos ta on tr.Id = ta.Turma
inner join Alunos a on ta.Aluno = a.Id

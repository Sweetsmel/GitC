--Trazer somente as marcas que Felipe e Giomar cadastraram (separado):

select Nome as 'Marcas que Felipe cadastrou'
from Marcas 
where UsuInc = 1;


select Nome as 'Marcas que Giomar cadastrou'
from Marcas 
where UsuInc = 2;

-----------------------------------------------------------

--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram (separado):

select count(*) as 'Quantidade de marcas que Felipe cadastrou'
from Marcas 
where UsuInc = 1
Order by 'Quantidade de marcas que Felipe cadastrou' desc;


select count(*) as 'Quantidade de marcas que Giomar cadastrou'
from Marcas 
where UsuInc = 2
Order by 'Quantidade de marcas que Giomar cadastrou' asc;

------------------------------------------------------------

--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram :

select count(*) as 'Quantidade de marcas que Felipe e Giomar cadastraram'
from Marcas
--where UsuInc = 1 OR UsuInc = 2;

------------------------------------------------------------

--Trazer somente os carros que Felipe e Giomar cadastraram (separado):

select Modelo as 'Carros que Felipe cadastrou'
from Carros 
where UsuInc = 1;


select Modelo as 'Carros que Giomar cadastrou'
from Carros 
where UsuInc = 2;

------------------------------------------------------------

--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram (separado desc e asc):

select count(*) as 'Quantidade de carros que Felipe cadastrou'
from Carros 
where UsuInc = 1
Order by 'Quantidade de carros que Felipe cadastrou' desc;


select count(*) as 'Quantidade de carros que Giomar cadastrou'
from Carros 
where UsuInc = 2
Order by 'Quantidade de carros que Giomar cadastrou' asc;

------------------------------------------------------------

--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram :

select count(*) as 'Quantidade de carros que Felipe e Giomar cadastraram'
from Carros
--where UsuInc = 1 OR UsuInc = 2;

------------------------------------------------------------

--Trazer somente os carros das marcas que Felipe e Giomar cadastraram (separado):

select 
		c.Modelo as 'Modelos cadastrados por Felipe'

from Carros c
		inner join Marcas m on m.Id = c.Marca

where m.UsuInc = 1;


select --Carros.Modelo
		c.Modelo as 'Modelos cadastrados por Giomar'

from Carros c	--tabela que quer
		inner join Marcas m on m.Id = c.Marca
				--de qual tabela quero a informação on ...
where m.UsuInc = 2;

------------------------------------------------------------

--Trazer somente a quantidade de carros das marcas que Felipe e Giomar cadastraram (separado desc e asc):

select 
		count(c.Modelo) as 'Quantidade de Modelos que Felipe cadastrou'
from Carros c
			inner join Marcas m on m.Id = c.Marca

where m.UsuInc = 1
Order by 'Quantidade de Modelos que Felipe cadastrou' desc;


select 
		count(c.Modelo) as 'Quantidade de Modelos que Giomar cadastrou'
from Carros c
			inner join Marcas m on m.Id = c.Marca

where m.UsuInc = 2
Order by 'Quantidade de Modelos que Giomar cadastrou' asc;

-----------------------------------------------------------

--Trazer o valor total de vendas 2019 isolado:

select 
		SUM(Quantidade*Valor) as 'Valor total de vendas em 2019'
from Vendas

where YEAR(DatInc) = 2019;

-----------------------------------------------------------

--Trazer a quantidade total de vendas 2019 isolado:

select 
		SUM(Quantidade) as 'Quantidade total de vendas em 2019'
from Vendas

where YEAR(DatInc) = 2019;

-----------------------------------------------------------

--Trazer o valor total de vendas em cada ano e ordernar do maior para o menor:

select 
		SUM(Quantidade*Valor) 'Venda total',
		YEAR(DatInc) as 'Ano'
from Vendas

group by YEAR(DatInc)
order by 'Ano' desc;

-----------------------------------------------------------

--Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor:

select 
		SUM(Quantidade) 'Quantidade total',
		YEAR(DatInc) as 'Ano'
from Vendas

group by YEAR(DatInc)
order by 'Ano' desc;

-----------------------------------------------------------

--Trazer o mês de cada ano que retornou a maior quantidade de vendas:

select 
		SUM(Quantidade) as 'Quantidade de vendas',
		MONTH(DatInc) as 'Mês',
		YEAR(DatInc) as 'Ano'
from Vendas

group by MONTH(DatInc), YEAR(DatInc)
order by 'Mês' desc;

-----------------------------------------------------------

--Trazer o mês de cada ano que retornou o maior valor de vendas:

select 
		SUM(Quantidade*Valor) as 'Valor de vendas',
		MONTH(DatInc) as 'Mês',
		YEAR(DatInc) as 'Ano'
from Vendas

group by MONTH(DatInc), YEAR(DatInc)
order by 'Mês' desc;

-----------------------------------------------------------

--Trazer o valor total de vendas que Felipe e Giomar realizaram (separadas):

select 
		SUM(Quantidade*Valor) as 'Valor total de vendas',
		Usuario as 'Vendedor'
from Vendas V
inner join Usuarios U on U.Id = V.UsuInc
where U.Id = 1

group by U.Usuario


select 
		SUM(Quantidade*Valor) as 'Valor total de vendas',
		Usuario as 'Vendedor'
from Vendas V
inner join Usuarios U on U.Id = V.UsuInc
where U.Id = 2

group by U.Usuario

-----------------------------------------------------------

--Trazer a quantidade total de vendas que Felipe e Giomar realizaram (separadas):

select 
		SUM(Quantidade) as 'Quantidade total de vendas',
		Usuario as 'Vendedor'
from Vendas V
inner join Usuarios U on U.Id = V.UsuInc
where U.Id = 1

group by U.Usuario


select 
		SUM(Quantidade) as 'Quantidade total de vendas',
		Usuario as 'Vendedor'
from Vendas V
inner join Usuarios U on U.Id = V.UsuInc
where U.Id = 2

group by U.Usuario

-----------------------------------------------------------

--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor:

select 
		SUM(Quantidade) as 'Quantidade total de vendas',
		Usuario as 'Vendedor'
from Vendas V
inner join Usuarios U on U.Id = V.UsuInc
--where U.Id = 1 or U.Id  = 2

group by U.Usuario
order by 'Quantidade total de vendas' desc;


-----------------------------------------------------------

--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor:

select 
		SUM(Quantidade*Valor) as 'Valor total de vendas',
		Usuario as 'Vendedor'
from Vendas V
inner join Usuarios U on U.Id = V.UsuInc
--where U.Id = 1 or U.Id  = 2

group by U.Usuario
order by 'Valor total de vendas' desc;

-----------------------------------------------------------

--Trazer  a marca mais vendida de todos os anos:

select 
		M.Nome as 'Marca',
		SUM(V.Quantidade) as 'Total de vendas',
		YEAR(V.DatInc) as 'Ano'

from Vendas V
inner join Carros C on C.Id = V.Carro
inner join Marcas M on C.Marca = M.Id

group by YEAR(V.DatInc), M.Nome
order by 'Total de vendas' desc;

-----------------------------------------------------------

--Trazer o valor total da marca mais vendida de todos os anos:**

select 
		M.Nome as 'Marca',
		SUM(V.Quantidade*Valor) as 'Valor total de vendas',
		YEAR(V.DatInc) as 'Ano'

from Vendas V
inner join Carros C on C.Id = V.Carro
inner join Marcas M on C.Marca = M.Id

group by YEAR(V.DatInc), M.Nome
order by 'Valor total de vendas' desc;

-----------------------------------------------------------

--Trazer a quantidade do carro mais vendido de todos os anos:**

select 
		C.Modelo as 'Carro',
		SUM(V.Quantidade) as 'Quantidade total de vendas',
		YEAR(V.DatInc) as 'Ano'

from Vendas V
inner join Carros C on C.Id = V.Carro

group by YEAR(V.DatInc), C.Modelo
order by 'Quantidade total de vendas' desc;

-----------------------------------------------------------

--Trazer o valor do carro mais vendido de todos os anos:

select 
		C.Modelo as 'Carro',
		SUM(V.Quantidade*Valor) as 'Valor total de vendas',
		YEAR(V.DatInc) as 'Ano'

from Vendas V
inner join Carros C on C.Id = V.Carro

group by YEAR(V.DatInc), C.Modelo
order by 'Valor total de vendas' desc;
select UsuInc as 'Quantidade de marcas que Felipe cadastrou'
from Marcas 
where UsuInc = 1
Order by UsuInc desc;

select UsuInc as 'Quantidade de marcas que Giomar cadastrou'
from Marcas 
where UsuInc = 2
Order by UsuInc asc;


select count(*) as 'Quantidade de marcas que Felipe cadastrou'
from Marcas
where UsuInc = 1;


select count(*) as 'Quantidade de marcas que Giomar cadastrou'
from Marcas
where UsuInc = 2

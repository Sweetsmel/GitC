select * from TabelaCarros

select 'Carros' as 'Carros',
	SUM(Temp.Media) as 'Vendas',
	Temp.AnoVenda
	
from (select
			Modelo,
			Ano,
			(SUM(Vendas) / COUNT(*)) as 'Media de Vendas',
			YEAR(DataVenda) as 'Ano Venda'
	 from TabelaCarros
	 GROUP BY Modelo, Ano, YEAR(DataVenda)) Temp

GROUP BY Temp.AnoVenda
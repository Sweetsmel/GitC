select 
	HotDog,
	(SUM(TotalVendas)) as 'Total',
	MONTH(DataVenda) as 'Venda no Mes'

from FoodTruckNene
GROUP BY HotDog, TotalVendas, MONTH(DataVenda)
order by TotalVendas desc

SELECT top 1 SUM(Valor), Placa from TANQUEOS group by Placa Order by sum(valor) Desc

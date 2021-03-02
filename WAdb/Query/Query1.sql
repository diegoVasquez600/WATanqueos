
---- Top One -----
SELECT top 1 SUM(Valor), Placa from TANQUEOS group by Placa Order by sum(valor) Desc

------Top two -----

SELECT TOP 1 total, Placa FROM (SELECT TOP 2 SUM(Valor) AS total, Placa FROM TANQUEOS GROUP BY Placa ORDER BY SUM(valor) DESC) AS X ORDER BY total ASC


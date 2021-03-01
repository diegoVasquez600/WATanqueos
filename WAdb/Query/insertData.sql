/*
Plantilla de script posterior a la implementación							
--------------------------------------------------------------------------------------
 Este archivo contiene instrucciones de SQL que se anexarán al script de compilación.		
 Use la sintaxis de SQLCMD para incluir un archivo en el script posterior a la implementación.			
 Ejemplo:      :r .\miArchivo.sql								
 Use la sintaxis de SQLCMD para hacer referencia a una variable en el script posterior a la implementación.		
 Ejemplo:      :setvar TableName miTabla							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
USE WAdb

INSERT INTO TIPO_COMBUSTIBLE(tipoCombustible) VALUES('Diesel'), ('Gas'), ('Extra'), ('Corriente'), ('ACPM');

INSERT INTO VEHICULOS (idTipoCombustible, Placa) VALUES(4, 'KBT565'), (4, 'HGO887'), (4, 'LVD71D');

INSERT INTO ISLAS (idTipoCombustible, nIsla) VALUES(4, 'ISLA 1'), (4, 'ISLA 2'), (4, 'ISLA 3'), (1, 'ISLA 4'), (2, 'ISLA 5'), (3, 'ISLA 6'), (5, 'ISLA 7')

INSERT INTO TANQUEOS (idVehiculo, idIsla, Placa, Valor) VALUES (1, 1, 'KBT565' ,10000), (2, 1, 'HGO887' ,25000), (3, 2, 'LVD71D' ,12000), (1, 3, 'KBT565' ,8000), (1, 2, 'KBT565' ,5000), (3, 3, 'LVD71D' ,30000)


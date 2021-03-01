﻿CREATE TABLE [dbo].[TANQUEOS]
(
	[idTanqueo] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [idVehiculo] INT NOT NULL, 
    [idIsla] INT NOT NULL, 
    [Placa] VARCHAR(10) NULL DEFAULT NULL, 
    [Valor] INT NULL DEFAULT NULL
    FOREIGN KEY (idVehiculo) REFERENCES VEHICULOS (idVehiculo),
    FOREIGN KEY ([idIsla]) REFERENCES ISLAS ([idIsla]),
)
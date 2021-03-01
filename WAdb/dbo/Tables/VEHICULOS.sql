CREATE TABLE [dbo].[VEHICULOS]
(
	[idVehiculo] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [idTipoCombustible] INT NOT NULL, 
    [Placa] VARCHAR(10) NULL DEFAULT NULL,
    FOREIGN KEY (idTipoCombustible) REFERENCES TIPO_COMBUSTIBLE (idTipoCOmbustible),
)

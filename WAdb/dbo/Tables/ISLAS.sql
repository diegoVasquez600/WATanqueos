CREATE TABLE [dbo].[ISLAS]
(
	[idIsla] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [idTipoCombustible] INT NOT NULL, 
    [nIsla] VARCHAR(15) NULL,
	FOREIGN KEY (idTipoCombustible) REFERENCES TIPO_COMBUSTIBLE (idTipoCOmbustible),
)

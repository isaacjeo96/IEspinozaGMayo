CREATE DATABASE IEspinozaGMayo
GO
USE IEspinozaGMayo
GO

CREATE TABLE Materia
(
	IdMateria INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(50),
	Costo DECIMAL(18,2),
	Creditos TINYINT,
	Descripcion VARCHAR(100)
)
GO

CREATE PROCEDURE MateriaAdd
@Nombre VARCHAR(50),
@Costo DECIMAL(18,2),
@Creditos TINYINT,
@Descripcion VARCHAR(100)
AS
	INSERT INTO [dbo].[Materia]
           ([Nombre]
           ,[Costo]
           ,[Creditos]
           ,[Descripcion])
     VALUES
           (@Nombre,
           @Costo, 
           @Creditos,
           @Descripcion)
GO

CREATE PROCEDURE MateriaGetAll
AS
	SELECT 
	   [IdMateria]
      ,[Nombre]
      ,[Costo]
      ,[Creditos]
      ,[Descripcion]
  FROM [Materia]
GO

CREATE PROCEDURE MateriaGetById 
@IdMateria INT
AS
		SELECT 
	   [IdMateria]
      ,[Nombre]
      ,[Costo]
      ,[Creditos]
      ,[Descripcion]
  FROM [Materia]
  WHERE IdMateria = @IdMateria

GO

CREATE PROCEDURE MateriaDelete
@IdMateria INT
AS 
	DELETE FROM Materia
	WHERE IdMateria = @IdMateria
GO

CREATE PROCEDURE MateriaUpdate 
@IdMateria INT,
@Nombre VARCHAR(50),
@Costo DECIMAL(18,2),
@Creditos TINYINT,
@Descripcion VARCHAR(100)
AS
	UPDATE [Materia]
   SET [Nombre] = @Nombre
      ,[Costo] = @Costo
      ,[Creditos] = @Creditos
      ,[Descripcion] = @Descripcion
 WHERE IdMateria = @IdMateria
GO


MateriaAdd 'Matem�ticas',500,10,'Introducci�n a las Matem�ticas'
GO
MateriaAdd 'Historia',250,10,'Historia de M�xico'
GO
MateriaAdd 'Biolog�a',200,10,'Ciencias Naturales '
GO
MateriaAdd 'Espa�ol',100,10,'Introducci�n a la lengua'
GO
MateriaAdd 'Ingles',300,10,'Introduction to the language'
GO


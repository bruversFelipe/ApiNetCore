USE master
GO

DROP DATABASE CRUD_BASICO
GO

CREATE DATABASE CRUD_BASICO
GO

USE CRUD_BASICO
GO


CREATE TABLE dbo.Cliente(
  ID_Cliente     Integer IDENTITY(1,1) NOT NULL,
  NM_Cliente     Varchar(40)           NOT NULL,
	CPF_Cliente    Varchar(11)           NOT NULL,
  CONSTRAINT PKCliente PRIMARY KEY (ID_Cliente));
GO


CREATE PROCEDURE dbo.ConsultaCliente @NM_Cliente Varchar(40)
AS
BEGIN
  SET NOCOUNT ON;

  SELECT NM_Cliente, CPF_Cliente FROM Cliente
	WHERE NM_Cliente LIKE '%' + @NM_Cliente + '%'

END
CREATE DATABASE LibrosDb
GO
USE LibrosDb
GO
CREATE TABLE Libros
(
	LibroId int primary key identity,
	Descripcion varchar(max),
	Siglas varchar(13),
	TipoId int
);
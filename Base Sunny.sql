CREATE DATABASE BECAS_SUNNY

USE BECAS_SUNNY

CREATE TABLE Datos_Academicos
(
Id int identity (1,1), 
Escuela varchar (50) not null,
Nivel_escolar varchar (50) not null,
Direccion Varchar (50) not null, 
Matricula varchar (50) not null,
carrera varchar (50) not null,
Cuatrimestre varchar (50) not null
)
select 
CREATE TABLE Datos_Alumnos
(
Id int identity (1,1),
Nombre varchar (50) not null,
Apellido_paterno varchar (50) not null,
Apellido_materno varchar (50) not null,
curp varchar (50) not null,
Nacionalidad varchar (50) not null,
Fecha_nacimiento datetime2(7) not null,
Genero varchar (1) not null,
Discapacidad varchar (50) not null,
Telefono bigint null,
Colonia varchar (50)not null,
Direccion varchar (50) not null,
correo_tutor varchar (50)not null
)

--int64

CREATE TABLE Datos_Tutor
(
Id int identity (1,1),
Nombre_tutor varchar (50) not null,
Apellido_paterno varchar (50) not null,
Apellido_materno varchar (50) not null,
Fecha_nacimiento date not null,
Nacionalidad varchar (50) not null,
Ocupacion varchar (50) not null,
Ingreso decimal (5,2) not null,
Telefono bigint,
)
CREATE TABLE Datos_Madre
(
Id int identity (1,1),
Nombre_Madre varchar (50) not null,
Apellido_paterno varchar (50) not null,
Apellido_materno varchar (50) not null,
Fecha_nacimiento date not null,
Nacionalidad varchar (50) not null,
Ocupacion varchar (50) not null,
Telefono bigint,
Domicilio_padres varchar (50) not null,
municipio varchar (50) not null,
colonia varchar(50) not null,
comunidad varchar (50) not null,
Estado_civil varchar (50) not null,
)

CREATE TABLE Datos_Socioeconomicos
(
Id int identity (1,1),
Ingresos_mensuales int not null,
Gastos_Alimentos int not null,
Gastos_Escolaridad int not null,
Gastos_Servicios int not null,
Gastos_Transportes int not null,
Pago_vivienda int,
otros int,
)

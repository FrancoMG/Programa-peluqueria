drop database if exists Clientas;
create database Clientas;
use Clientas;

create table Clientas(
nombre char(50),
CONSTRAINT PK_Clientas PRIMARY KEY(nombre)
);

create table Tratamiento(
idTratamiento int auto_increment,
nombre char(50),
nombreTratamiento char(50),
precio int,
fecha date,
CONSTRAINT PK_Tratamiento PRIMARY KEY (idTratamiento),
CONSTRAINT FK_Tratamiento FOREIGN KEY (nombre) REFERENCES Clientas(nombre)
);

insert into Clientas values
('Franco'),
('Juanse');

insert into Tratamiento values
('', 'Franco', 'Corte de pelo', 800, '2022/10/25'),
('', 'Franco', 'Luzpulsada', 1000, '2022/10/27'),
('', 'Juanse', 'Rulos', 1500, '2022/10/13');



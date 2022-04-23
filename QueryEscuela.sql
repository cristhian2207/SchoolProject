create database SchoolDB
use SchoolDB

create table usuario(
username varchar(10) primary key not null,
pass varchar(20) not null
)

create table profesores(
ID int identity(1,1),
Nombre varchar(50),
Apellido varchar(50),
Sexo varchar(15),
Materia_impartida varchar(100),
Primary key (ID)
)

create table estudiantes(
ID int identity(1,1),
Nombre varchar(50),
Apellido varchar(50),
Sexo varchar(15),
Primary key(ID)
)

create table suplidores(
ID int identity(1,1) primary key,
Nombre_producto varchar(30),
Cantidad int
)

-- INSERTS PARA ESTUDIANTES Y PROFESORES
 insert into estudiantes values('Juan','Perez Mercedes', 'Masculino'); 
 insert into estudiantes values('Marta','Morales', 'Femenino');
 insert into estudiantes values('Laura','Torres', 'Femenino');
 insert into estudiantes values('Mariano','Juarez', 'Masculino');
 insert into estudiantes values('Federico Ram�n','Lopez', 'Indefinido');
 insert into estudiantes values('Francisco Alberto','Taveras', 'Masculino');
 insert into estudiantes values('Cristal','Ramirez Diaz', 'Femenino');
 insert into estudiantes values('Jos� Francisco','Garc�a', 'Masculino');
 insert into estudiantes values('Manuel','De la Cruz', 'Masculino');
 insert into estudiantes values('Federico','Castillo', 'Masculino');
 -----------------------------------------------------
 insert into profesores values('Susana','Molina', 'Femenino', 'Matem�ticas');
 insert into profesores values('Oliver','Garc�a', 'Masculino', 'Ciencias Inform�ticas');
 insert into profesores values('Marino','Dicent', 'Masculino', 'Introducci�n a las base de datos');
 insert into profesores values('Teresita','Martinez', 'Femenino', 'Lengua Espa�ola');
 insert into profesores values('Joselin','Valdez', 'Masculino', 'Ingl�s');
 insert into profesores values('Victor','Gomez', 'Indefinido', 'Educaci�n sexual');
 insert into profesores values('Maria Susana','Vicini', 'Indefinido', 'Religi�n');
 insert into profesores values('Sonia','De Los Santos', 'Femenino', 'Educaci�n f�sica');
 insert into profesores values('Carmen','Solis Ramirez', 'Femenino', 'Franc�s');
 insert into profesores values('Juan Jos�','Carrasco Diaz', 'Masculino', 'Educaci�n c�vica');

-- INSERTS PARA SUPLIDORES
 insert into suplidores values ('Borradores', 10)
 insert into suplidores values ('Marcadores', 20)
 insert into suplidores values ('Cuadernos', 200)
 insert into suplidores values ('Libros', 200)
 insert into suplidores values ('Butacas', 500)
 insert into suplidores values ('Pizarras',50)
 insert into suplidores values ('Aires acondicionados',10)
 insert into suplidores values ('Empanadas',100)
 insert into suplidores values ('Quipes',100)
 insert into suplidores values ('Papitas',200)
 insert into suplidores values ('Dulces',500)
 insert into suplidores values ('Pelotas',10)
 insert into suplidores values ('Productos de limpieza',50)
 insert into suplidores values ('Uniformes',200)
 insert into suplidores values ('Mesas',50)

-- INSERT PARA EL ADMIN
 insert into usuario values('admin', 'admin')

select Nombre, Apellido, Sexo, 'Estudiante' as Condicion from estudiantes where Nombre = 'Susana' 
 union 
   select Nombre, Apellido, Materia_impartida as Materia, 'Profesor' as Condicion from profesores where Nombre = 'Susana' 
  order by Nombre asc





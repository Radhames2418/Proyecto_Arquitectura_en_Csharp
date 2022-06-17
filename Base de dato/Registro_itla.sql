Create database Registro_itla
use Registro_itla
go


--- Creacion de tablas ----

Create table Edificio
(
  Id int identity(1,1) primary key not null,
  nombre_edificio varchar(50) unique
)

go



Create table Aula
(

  Id int identity(1,1) primary key not null,
  nombre_aula varchar(50) unique,
  ID_edificio_aula int,

  constraint fk_Edificio_aula foreign key (ID_edificio_aula) references Edificio(Id)
)

go


Create table Visitante
(

  Id int identity(1,1) primary key not null,
  Codigo as ('VS'+ Right('00'+Convert(Varchar,Id),(2))),
  Nombre varchar(50) not null,
  Apellido varchar(50) not null,
  Carrera varchar(50),
  Correo varchar(50),
  ID_Edificio int,
  Hora_entrada datetime not null,
  Hora_salida datetime not null,
  Motivos_visita varchar(150) not null,
  Foto_visitante image,
  ID_Aula int


    constraint fk_ID_Edificio foreign key (ID_Edificio) references Edificio(Id),
    constraint ID_Aula foreign key (ID_Aula) references Aula(Id)


)

go

Create table Usuario
(

  Id int identity(1,1) primary key not null,
  nombre_usuario varchar(50),
  Apellido_usuario varchar(50),
  Fecha_Nacimiento datetime,
  N_Usuario varchar(50) unique,
  Contraseña_usuario varchar(50),
  Tipo_de_usuario varchar(50)
)

go




---- Creacion de Stored procedure usuario

Alter Proc SP_LogicUsuario
  @N_Usuario varchar(50),
  @Contraseña_usuario varchar(50)
  AS
  Select N_Usuario,Tipo_de_usuario from Usuario
  Where N_Usuario = @N_Usuario and Contraseña_usuario = @Contraseña_usuario
go

Create Proc SP_BuscarUsuario
  @Buscar varchar(50)
  AS
  Select * from Usuario
  Where N_Usuario Like @Buscar + '%'

go
--- SP_Insertar
Create Proc SP_InsertarUsuario
  @nombre_usuario varchar(50),
  @Apellido_usuario varchar(50),
  @Fecha_Nacimiento datetime,
  @N_Usuario varchar(50),
  @Contraseña_usuario varchar(50),
  @Tipo_de_usuario varchar(50)
  AS
  Insert into Usuario values(@nombre_usuario,@Apellido_usuario,@Fecha_Nacimiento,@N_Usuario,@Contraseña_usuario,@Tipo_de_usuario)
go
--- SP_Actualizar
Create Proc SP_ActualizarUsuario
  @Id int,
  @nombre_usuario varchar(50),
  @Apellido_usuario varchar(50),
  @Fecha_Nacimiento datetime,
  @N_Usuario varchar(50),
  @Contraseña_usuario varchar(50),
  @Tipo_de_usuario varchar(50)
  AS
  Update Usuario set nombre_usuario = @nombre_usuario, Apellido_usuario = @Apellido_usuario, Fecha_Nacimiento = @Fecha_Nacimiento, N_Usuario = @N_Usuario, Contraseña_usuario = @Contraseña_usuario, Tipo_de_usuario = @Tipo_de_usuario
  where Id = @Id
go
--- SP_Eliminar
Create Proc SP_EliminarUsuario
@Id int
AS
Delete Usuario where Id = @Id
go


----- Creacion de Stored procedure visitante
Create Proc SP_BuscarVisitante
  @Buscar varchar(50)
  AS
  Select * from Visitante
  Where Nombre Like @Buscar + '%'

go
--- SP_Insertar
Create Proc SP_InsertarVisitante
  @Nombre varchar(50),
  @Apellido varchar(50),
  @Carrera varchar(50),
  @Correo varchar(50),
  @ID_Edificio int,
  @Hora_entrada datetime,
  @Hora_salida datetime,
  @Motivos_visita varchar(150),
  @Foto_visitante image,
  @ID_Aula int
  AS
  Insert into Visitante values(@Nombre,@Apellido,@Carrera,@Correo,@ID_Edificio,@Hora_entrada,@Hora_salida,@Motivos_visita,@Foto_visitante,@ID_Aula)
go
--- SP_Actualizar
Create Proc SP_ActualizarVisitant
  @Id int,
  @Nombre varchar(50),
  @Apellido varchar(50),
  @Carrera varchar(50),
  @Correo varchar(50),
  @ID_Edificio int,
  @Hora_entrada datetime,
  @Hora_salida datetime,
  @Motivos_visita varchar(150),
  @Foto_visitante image,
  @ID_Aula int
  AS
  Update Visitante set Nombre = @Nombre, Apellido = @Apellido, Carrera = @Carrera, Correo = @Correo, ID_Edificio  = @ID_Edificio, Hora_entrada = @Hora_entrada, Hora_salida = @Hora_salida, Motivos_visita = @Motivos_visita, Foto_visitante = @Foto_visitante, ID_Aula = @ID_Aula
  where Id = @Id
go
--- SP_Eliminar
Create Proc SP_EliminarVisitante
@Id int
AS
Delete Visitante where Id = @Id
go



----- Creacion de Stored procedure Edificio
Create Proc SP_BuscarEdificio
  @Buscar varchar(50)
  AS
  Select * from Edificio
  Where nombre_edificio Like @Buscar + '%'

go
--- SP_Insertar
Create Proc SP_InsertarEdificio
  @nombre_edificio varchar(50)
  AS
  Insert into Edificio values(@nombre_edificio)
go
--- SP_Actualizar
Create Proc SP_ActualizarEdificio
  @Id int,
  @nombre_edificio varchar(50)
  AS
  Update Edificio set nombre_edificio = @nombre_edificio
  where Id = @Id
go

--- SP_Eliminar
Create Proc SP_EliminarEdificio
@Id int
AS
Delete Edificio where Id = @Id
go


------  Creacion de Stored procedure Edificio
Create Proc SP_BuscarAula
  @Buscar varchar(50)
  AS
  Select * from Aula
  Where nombre_aula Like @Buscar + '%'

go
--- SP_Insertar
Create Proc SP_InsertarAula
  @nombre_aula varchar(50),
  @ID_edificio_aula int
  AS
  Insert into Aula values(@nombre_aula,@ID_edificio_aula)
go
--- SP_Actualizar
Create Proc SP_ActualizarAula
  @Id int,
  @nombre_aula varchar(50),
  @ID_edificio_aula int
  AS
  Update Aula set nombre_aula = @nombre_aula, ID_edificio_aula = @ID_edificio_aula
  where Id = @Id 
go
--- SP_Eliminar
Create Proc SP_EliminarAula
@Id int
AS
Delete Aula where Id = @Id
go



---- Creacion de los combobox

Create Proc SP_ComboxEdificio
as
Select Id, nombre_edificio from Edificio
go


exec SP_ComboxEdificio

insert into Aula Values('Aula mecatronica', 5)

Select nombre_edificio, nombre_edificio from Edificio
go


Create table Aula
(

  Id int identity(1,1) primary key not null,
  nombre_aula varchar(50) unique,
  ID_edificio_aula varchar(50),

  constraint fk_Edificio_aula foreign key (ID_edificio_aula) references Edificio(nombre_edificio)
)

go

USE DBHISTORIACLINICA


--!USUARIO---!
create procedure sp_ListaUsuario
as
begin
	select * from usuario
end

create procedure sp_ListaDoctor
as
begin
	select nombre +' - '+especialidad as doctesp,id from usuario where rol='Doctor'
end

create procedure sp_UsuarioId(
@idusuario varchar(50))
as
begin
	select * from usuario where id=@idusuario
end


create procedure sp_Login(
@usr varchar(50),
@pwd varchar(50)
)
as
begin
	select * from usuario where usr=@usr and pwd=@pwd
end

create procedure sp_UsuarioId(
@idusuario varchar(50))
as
begin
	select * from usuario where id=@idusuario
end

create procedure sp_AgregarUsuario(
@id varchar(50), 
@nombre varchar(50),
@fechanacimiento varchar(10),
@cargo varchar(50),
@telefono varchar(50),
@correo varchar(50),
@rol varchar(50),
@especialidad varchar(50),
@nombusuario varchar(50),
@password varchar(100)
)
as
begin
	insert into usuario(id, nombre,cargo, telefono, correo, rol, especialidad, usr, pwd, fecha_nacimiento)
	values
	(@id, @nombre, @cargo, @telefono, @correo, @rol, @especialidad, @nombusuario, @password, @fechanacimiento)
end

create procedure sp_EditarUsuario(
@id varchar(50),
@nombre varchar(50),
@fechanacimiento varchar(10),
@cargo varchar(50),
@telefono varchar(50),
@correo varchar(50),
@rol varchar(50),
@especilidad varchar(50),
@nombusuario varchar(50),
@password varchar(100)
)
as
begin
	update usuario set
	nombre=@nombre,
	fecha_nacimiento= @fechanacimiento,
	cargo=@cargo,
	telefono=@telefono,
	correo=@correo,
	rol=@rol,
	especialidad=@especilidad,
	usr=@nombusuario,
	pwd=@password
	where id=@id
end


---! PACIENTE-----!

create procedure sp_BuscaPaciente(
@id varchar(50) 
)
as
begin
  select * from paciente where id=@id
end

create procedure sp_AgregarPaciente(
@id varchar(50), 
@nombre varchar(50),
@sexo varchar(50),
@fechanacimiento varchar(10),
@domicilio varchar(50),
@telefono varchar(50),
@correo varchar(50),
@lugarnacimiento varchar(50)
)
as
begin
	insert into paciente(id, nombre, sexo, fecha_nacimiento, domicilio, telefono, correo, lugar_nacimiento)
	values
	(@id, @nombre, @sexo, @fechanacimiento, @domicilio, @telefono, @correo, @lugarnacimiento)
end

create procedure sp_EditarPaciente(
@id varchar(50), 
@nombre varchar(50),
@sexo varchar(50),
@fechanacimiento varchar(10),
@domicilio varchar(50),
@telefono varchar(50),
@correo varchar(50),
@lugarnacimiento varchar(50)
)
as
begin
	update paciente set
	nombre=@nombre,
	sexo=@sexo,
	fecha_nacimiento= @fechanacimiento,
	domicilio=@domicilio,
	telefono=@telefono,
	correo=@correo,
	lugar_nacimiento=@lugarnacimiento
	where id=@id
end

-----!  PATOLOGÍA  !----------

create procedure sp_ListaPatologia
as
begin
	select * from patologia
end

-----!  TRIAJE !-------

create procedure sp_AgregarTriaje(
@idpaciente varchar(50),
@talla varchar(10),
@temperatura varchar(50)
@peso varchar(10),
@presionarterial varchar(50),
@patologia varchar(50),
@derivar varchar(50),
@fechaactual varchar(50)
)
as
begin
	insert into triaje(id_paciente,talla, temperatura,peso, presion_arterial, patologia, derivar, fecha_actual)
	values
	(@idpaciente, @talla, @temperatura,@peso, @presionarterial, @patologia, @derivar, @fechaactual)
end

create procedure sp_BuscaTriajeActual(
@idpaciente varchar(50),
@fechaactual varchar(10),
@derivar varchar(50)

)
as 
begin
	select * from triaje as t,usuario as u where t.id_paciente=@idpaciente  and u.id=derivar and fecha_actual=@fechaactual and derivar=@derivar
end


----! CONSULTA MEDICA !----

create procedure sp_AgregarConsulta(
@idpaciente varchar(50),
@doctor varchar(50),
@fecha varchar(50),
@diagnostico varchar(max),
@medicacion varchar(max)
)
as
begin
	insert into consulta(id_paciente,doctor, fecha,diagnostico, medicacion)
	values
	(@idpaciente, @doctor, @fecha,@diagnostico, @medicacion)
end


create procedure sp_ListarConsultaPaciente(
@idpaciente varchar(50)
)
as 
begin
	select c.fecha, t.talla, t.temperatura,t.peso, t.presion_arterial, t.patologia, c.diagnostico,medicacion, u.nombre,u.id as iddoctor from triaje as t,consulta as c, usuario as u where t.id_paciente=@idpaciente  and  t.fecha_actual=c.fecha and c.doctor=t.derivar and u.id=c.doctor
end


create procedure sp_ConsultaPacienteFecha(
@idpaciente varchar(50),
@iddoctor varchar(50),
@fecha varchar(50)
)
as 
begin
	select c.fecha, t.talla, t.temperatura,t.peso, t.presion_arterial, t.patologia, c.diagnostico,medicacion, u.nombre as nombdoctor, p.nombre as nombpaciente, p.id as idpaciente, p.sexo, p.fecha_nacimiento from triaje as t,consulta as c, usuario as u,paciente as p where c.id_paciente=@idpaciente and t.id_paciente=c.id_paciente and p.id=c.id_paciente   and c.fecha=@fecha and  t.fecha_actual=c.fecha and c.doctor=t.derivar and u.id=c.doctor and c.doctor=@iddoctor
end


select c.fecha, t.talla, t.temperatura,t.peso, t.presion_arterial, t.patologia, c.diagnostico,medicacion, u.nombre as nombdoctor, p.nombre as nombpaciente, p.sexo, p.fecha_nacimiento from triaje as t,consulta as c, usuario as u,paciente as p where c.id_paciente=@idpaciente and t.id_paciente=c.id_paciente and p.id=c.id_paciente   and c.fecha=@fecha and  t.fecha_actual=c.fecha and c.doctor=t.derivar and u.id=c.doctor and c.doctor=@iddoctor


----! CITA !----

create procedure sp_AgregarCita(
@idpaciente varchar(50),
@fecha varchar(50),
@doctor varchar(50)
)
as
begin
	insert into cita(id_paciente,fecha, doctor)
	values
	(@idpaciente, @fecha, @doctor)
end
create procedure sp_ConsultaOrdenCita(
@idpaciente varchar(50),
@fecha varchar(50)
)
as
begin
	select * from 
	cita where cita.id_paciente=@idpaciente  and fecha=convert(date,@fecha)
end

create procedure sp_ConsultaCita(
@idpaciente varchar(50),
@fecha varchar(50),
@doctor varchar(50)
)
as
begin
	select paciente.id as idpaciente, paciente.nombre as nombpac, sexo, paciente.fecha_nacimiento, fecha,usuario.nombre as nombdoctor, usuario.especialidad  from 
	cita,usuario,paciente where cita.id_paciente=@idpaciente and paciente.id=@idpaciente and usuario.id=@doctor and cita.doctor=@doctor and fecha=@fecha and doctor=@doctor
end

	select paciente.id as idpaciente, paciente.nombre as nombpac, sexo, paciente.fecha_nacimiento, fecha,usuario.nombre as nombdoctor, usuario.especialidad  from 
	cita,usuario,paciente where cita.id_paciente='2323' and paciente.id='2323' and usuario.id=doctor and (fecha=convert(date,'01-03-2023'))



create procedure sp_ConsultaCitaPaciente(
@idpaciente varchar(50),
@fechaini varchar(50),
@fechafin varchar(50)
)
as
begin
	set dateformat dmy
	select cita.id,paciente.id as idpaciente, paciente.nombre as nombpac, sexo, paciente.fecha_nacimiento, fecha,usuario.nombre as nombdoctor, usuario.especialidad  from 
	cita,usuario,paciente where cita.id_paciente=@idpaciente and paciente.id=@idpaciente and usuario.id=cita.doctor and (fecha>=convert(date,@fechaini) and fecha<= convert(date,@fechafin))
end


create procedure sp_ConsultaCitaPDoctor(
@iddoctor varchar(50),
@fechaini varchar(50),
@fechafin varchar(50)
)
as
begin
	set dateformat dmy
	select cita.id,paciente.id as idpaciente, paciente.nombre as nombpac, sexo, paciente.fecha_nacimiento, fecha,usuario.nombre as nombdoctor, usuario.especialidad  from 
	cita,usuario,paciente where cita.doctor=@iddoctor and usuario.id=@iddoctor and paciente.id=cita.id_paciente and (fecha>=convert(date,@fechaini) and fecha<= convert(date,@fechafin))
end



	set dateformat dmy
	select cita.id,paciente.id as idpaciente, paciente.nombre as nombpac, sexo, paciente.fecha_nacimiento, fecha,usuario.nombre as nombdoctor, usuario.especialidad  from 
	cita,usuario,paciente where cita.doctor='123' and usuario.id='123' and paciente.id=cita.id_paciente and (fecha>=convert(date,'01-02-2023') and fecha<= convert(date,'01-03-2023'))


set dateformat dmy

	select cita.id, paciente.id as idpaciente, paciente.nombre as nombpac, sexo, paciente.fecha_nacimiento, cita.fecha,usuario.nombre as nombdoctor, usuario.especialidad  from 
	cita,usuario,paciente where cita.id_paciente='4321' and paciente.id='4321'  and usuario.id=cita.doctor and (fecha>= convert(date,'01-02-2023') and fecha<=convert(date,'01-03-2023'))

select paciente.id as idpaciente, paciente.nombre as nombpac, sexo, paciente.fecha_nacimiento, fecha,usuario.nombre as nombdoctor, usuario.especialidad from 
	cita,usuario,paciente where cita.id_paciente='4321' and paciente.id='4321' and usuario.id='123' and cita.doctor='123' and  cita.fecha='01-03-2023'
----! HORARIO DOCTOR !----

create procedure sp_AgregarHorario(
@iddoctor varchar(50),
@lunes int,
@martes int,
@miercoles int,
@jueves int,
@viernes int,
@sabado int,
@fechaini varchar(10),
@fechafin varchar(10)
)
as
begin
	set dateformat dmy
	insert into horariodoctor(id_doctor,lunes, martes, miercoles, jueves, viernes, sabado,fecha_ini,feccha_final)
	values
	(@iddoctor, @lunes, @martes,@miercoles,@jueves,@viernes,@sabado,convert(date,@fechaini),convert(date,@fechafin))
end

create procedure sp_EditarHorario(
@iddoctor varchar(50),
@lunes int,
@martes int,
@miercoles int,
@jueves int,
@viernes int,
@sabado int,
@fechaini varchar(10),
@fechafin varchar(10)
)
as
begin
	set dateformat dmy
	update horariodoctor set
	lunes=@lunes,
	martes=@martes,
	miercoles= @miercoles,
	jueves=@jueves,
	viernes=@viernes,
	sabado=@sabado,
	fecha_ini=convert(date,@fechaini),
	feccha_final=convert(date,@fechafin)
	where id_doctor=@iddoctor
end

create procedure sp_consultaHorario(
@iddoctor varchar(50))
as
begin
select * from horariodoctor where id_doctor=@iddoctor
end
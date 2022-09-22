CREATE TABLE registro_usuario.Usuario (
	dbid BigInt(20) auto_increment NOT NULL COMMENT 'Identificador del usuario',
	nombre_usuario varchar(250) DEFAULT NULL NULL COMMENT 'Propietario, Nombre de usuario',
	usuario varchar(25) NOT NULL COMMENT 'Usuario para iniciar sesion',
	contrasena varchar(20) NOT NULL COMMENT 'Contraseña usuario',
	CONSTRAINT Usuario_pk PRIMARY KEY (dbid)
)
ENGINE=InnoDB
DEFAULT CHARSET=utf8mb4
COLLATE=utf8mb4_general_ci;


varchar(250)
------------------------
CREATE TABLE registro_usuario.persona (
	dbid BigInt(20) auto_increment NOT NULL COMMENT 'Identificador persona',
	primer_nombre varchar(50) NULL COMMENT 'Primer Nombre Usuario',
	segundo_nombre varchar(250) NULL COMMENT 'Segundo Nombre persona',
	apellido_paterno varchar(250) NULL COMMENT 'Primer Apellido Persona',
	apellido_materno varchar(100) NULL COMMENT 'Apellido Materno Persona',
	profesion varchar(250) NULL COMMENT 'Profesion que desarrolla la persona',
	estado_civil varchar(250) NULL COMMENT 'Estado civil persona',
	direccion_vivienda varchar(250) NULL COMMENT 'Direccion de vivienda persona',
	apellido_casada varchar(100) NULL COMMENT 'Apellido de casada',
	telefono varchar(250) NULL COMMENT 'Telefono de la persona',
	fecha_nacimiento DATE NULL COMMENT 'Fecha de nacimiento de persona',
	genero varchar(250) NULL COMMENT 'Genero persona',
	dpi BigInt(20) NULL COMMENT 'Numero de dpi de persona',
	sabe_leer BOOL NULL COMMENT 'Sabe Leer',
	sabe_escribir BOOL NULL COMMENT 'Persona Sabe Escribir',
	bautizado BOOL NULL COMMENT 'Esta bautizado',
	fecha_bautizo DATE NULL COMMENT 'fecha de bautizo',
	ministro_oficio_bautizo varchar(250) NULL COMMENT 'Ministro que oficio bautizo persona',
	cargo_actual_iglesia varchar(250) NULL COMMENT 'Cargo Actual en la iglesia',
	fuera_pais BOOL NULL COMMENT 'Persona se encuentra fuera del pais',
	fecha_migracion DATE NULL COMMENT 'Fecha de migracion',
	pais_migracion varchar(250) NULL COMMENT 'Pais migracion persona',
	retirado BOOL NULL COMMENT 'Persona retirada de la organizacion',
	fecha_retiro DATE NULL COMMENT 'Fecha de retiro de la organizacion',
	fallecido BOOL NULL COMMENT 'Fecha de fallecimiento persona',
	fecha_deceso varchar(100) NULL COMMENT 'Fecha deceso persona',
	conyuge varchar(250) NULL COMMENT 'Persona tiene conyuge',
	nombre_conyuge varchar(250) NULL COMMENT 'Nombre conyuge de persona',
	CONSTRAINT persona_pk PRIMARY KEY (dbid)
)
ENGINE=InnoDB
DEFAULT CHARSET=utf8mb4
COLLATE=utf8mb4_general_ci;


-----------------------

--  Auto-generated SQL script #202209220008
INSERT INTO registro_usuario.usuario (nombre_usuario,usuario,contrasena)
	VALUES ('Yulian','yortiz','yortiz');

---

--  Auto-generated SQL script #202209220022
INSERT INTO registro_usuario.persona (primer_nombre,segundo_nombre,apellido_paterno,apellido_materno,profesion,estado_civil,direccion_vivienda,apellido_casada,telefono,fecha_nacimiento,genero,dpi,sabe_leer,sabe_escribir,bautizado,fecha_bautizo,ministro_oficio_bautizo,cargo_actual_iglesia,fuera_pais,fecha_migracion,pais_migracion,retirado,fecha_retiro,fallecido,fecha_deceso,conyuge,nombre_conyuge)
	VALUES ('primernombre','segundonombre','apellidoparterno','apellidomaterno','profesion','estadocivil','direccionviviend','apellidocasada','telefno','2000-09-12','genero',3042277300114,1,0,1,'2022-01-01','ministrooficiobautizo','cargoiglesia',1,'2021-02-02','paismigracion',1,'2022-09-09',1,'2100-01-01','1','nombreconyuge');

--------------------------------
INSERT INTO registro_usuario.persona (primer_nombre,segundo_nombre,apellido_paterno,apellido_materno,profesion,estado_civil,direccion_vivienda,apellido_casada,telefono,fecha_nacimiento,genero,dpi,sabe_leer,sabe_escribir,bautizado,fecha_bautizo,ministro_oficio_bautizo,cargo_actual_iglesia,fuera_pais,fecha_migracion,pais_migracion,retirado,fecha_retiro,fallecido,fecha_deceso,conyuge,nombre_conyuge)
	VALUES ('"
        primernombre+"','" + segundonombre + "','" + apellidoparterno + "','" + apellidomaterno + "','" + profesion + "','" + estadocivil + "','" + direccionviviend + "','" + apellidocasada + "','" + telefno + "','" + 2000 - 9 - 12 + "','" + genero + "'," + 3042277300114 + "," + 1 + "," + 0 + "," + 1 + ",'" + 2022 - 1 - 1 + "','" + ministrooficiobautizo + "','" + cargoiglesia + "'," + 1 + ",'" + 2021 - 2 - 2 + "','" + paismigracion + "'," + 1 + ",'" + 2022 - 9 - 9 + "'," + 1 + ",'" + 2100 - 1 - 1 + "','" + 1 + "','" + nombreconyuge + "')"

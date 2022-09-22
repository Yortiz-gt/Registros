        comando.CommandText = "INSERT INTO registro_usuario.persona (primer_nombre,segundo_nombre,apellido_paterno,apellido_materno,profesion,estado_civil,direccion_vivienda,apellido_casada,telefono,fecha_nacimiento,genero,dpi,sabe_leer,sabe_escribir,bautizado,fecha_bautizo,ministro_oficio_bautizo,cargo_actual_iglesia,fuera_pais,fecha_migracion,pais_migracion,retirado,fecha_retiro,fallecido,fecha_deceso,conyuge,nombre_conyuge)
         VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox6.Text + "','" + TextBox15.Text + "','" + TextBox8.Text + "','" + TextBox5.Text + "','" + TextBox9.Text + "','" + DateTimePicker1.Value.ToShortDateString + "','" + TextBox16.Text + "'," + TextBox11.Text + "," + CheckBox3.Checked + "," + CheckBox2.Checked + "," + CheckBox1.Checked + ",'" + DateTimePicker2.Value.ToShortDateString + "','" + TextBox12.Text + "','" + TextBox13.Text + "'," + CheckBox4.Checked + ",'" + DateTimePicker3.Value.ToShortDateString + "','" + TextBox18.Text + "'," + CheckBox5.Checked + ",'" + DateTimePicker4.Value.ToShortDateString + "'," + CheckBox6.Checked + ",'" + DateTimePicker5.Value.ToShortDateString + "','" + CheckBox7.Checked + "','" + TextBox7.Text + "')"



        comando.CommandText = "INSERT INTO persona (primer_nombre,segundo_nombre)
         VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "')"
		 
		 
		         comando.CommandText = "INSERT INTO registro_usuario.persona (primer_nombre,segundo_nombre,apellido_paterno,apellido_materno,profesion,estado_civil,direccion_vivienda,apellido_casada,telefono,fecha_nacimiento,genero,dpi,sabe_leer,sabe_escribir,bautizado,fecha_bautizo,ministro_oficio_bautizo,cargo_actual_iglesia,fuera_pais,fecha_migracion,pais_migracion,retirado,fecha_retiro,fallecido,fecha_deceso,conyuge,nombre_conyuge)
         VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox6.Text + "','" + TextBox15.Text + "','" + TextBox8.Text + "','" + TextBox5.Text + "','" + TextBox9.Text + "','" + DateTimePicker1.Value.ToShortDateString + "','" + TextBox16.Text + "'," + TextBox11.Text + "," + CheckBox3.Checked + "," + CheckBox2.Checked + "," + CheckBox1.Checked + ",'" + DateTimePicker2.Value.ToShortDateString + "','" + TextBox12.Text + "','" + TextBox13.Text + "'," + CheckBox4.Checked + ",'" + DateTimePicker3.Value.ToShortDateString + "','" + TextBox18.Text + "'," + CheckBox5.Checked + ",'" + DateTimePicker4.Value.ToShortDateString + "'," + CheckBox6.Checked + ",'" + DateTimePicker5.Value.ToShortDateString + "','" + CheckBox7.Checked + "','" + TextBox7.Text + "')"



    comando.CommandText = "INSERT INTO registro_usuario.persona (primer_nombre,segundo_nombre,apellido_paterno,apellido_materno,profesion,estado_civil,direccion_vivienda,apellido_casada,telefono,fecha_nacimiento)
         VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox6.Text + "','" + TextBox15.Text + "','" + TextBox8.Text + "','" + TextBox5.Text + "','" + TextBox9.Text + DateTimePicker1.Value.ToShortDateString + "')"



-- nota para que se guarden las fechas es necesario tener formato de fecha y hora  yyyy-mm-dd configurado en windows

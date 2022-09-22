'IMPORTAMOS LAS LIBRERIAS NECESARIAS PARA LA CONEXIÓN A MYSQL/MARIADB
Imports MySqlConnector.MySqlConnection
'EMPIEZA EL MODULO
Module Module1
    ' CON PUBLIC SUB CREAMOS PROCEDIMIENTOS
    Public Sub generaModelo()

        ' METEMOS LA CADENA DE CONEXIÓN EN UNA VARIABLE
        Dim cadenaConexion = "Server=127.0.0.1;User ID=root;Password=root;Database=person;Port=3308;"

        ' CREAMOS LA CONEXIÓN CON LA CADENA DE CONEXIÓN
        Dim connection = New MySqlConnector.MySqlConnection(cadenaConexion)

        Try

            ' SI SE ABRE LA CONEXIÓN MANDAMOS MENSAJE
            connection.Open()
            MsgBox("Conexion Correcta")
            Dim comando = New MySqlConnector.MySqlCommand("select * from Person.person;", connection)
            Dim resultado = comando.ExecuteReader
            resultado.Read()
            resultado.GetString("user")
            resultado.GetString("password")
            MessageBox.Show(resultado.GetInt64("dbid"))




        Catch ex As Exception
            ' SI NO SE ABRE LA CONEXIÓN MANDAMOS MENSAJE DE ERROR
            MsgBox("ERROR " & ex.Message)

            Exit Sub
        End Try

    End Sub
End Module

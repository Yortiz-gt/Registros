Imports Microsoft.VisualBasic.ApplicationServices
Imports MySqlConnector
Imports MySqlConnector.MySqlConnection
Public Class Login
    Dim movement As Boolean = False

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        movement = True
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If (movement = True) Then Me.Location = Cursor.Position
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        movement = False
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub login_button_Click(sender As Object, e As EventArgs) Handles login_button.Click
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = conexion

        Try
            conexion.ConnectionString = "Server=127.0.0.1;User ID=root;Password=root;Database=registro_usuario;Port=3308;"
            conexion.Open()
            'MsgBox("Conectado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        comando.CommandText = "select * from usuario where usuario = '" + User_txt.Text + "' and contrasena = '" + TextBox1.Text + "'"

        Dim r As MySqlDataReader

        r = comando.ExecuteReader

        'If r.HasRows <> False Then
        'r.Read()
        'MsgBox("Bienvenido " + r.GetString("nombre_usuario"))
        Me.Hide()
        Form1.Show()
        'Else
        'MsgBox("Usuario y/o contrase;a Incorrectos")
        'User_txt.Text = ""
        'TextBox1.Text = ""

        'End If



    End Sub

End Class
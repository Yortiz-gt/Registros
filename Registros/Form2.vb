Imports System.Runtime.CompilerServices
Imports MySqlConnector
Imports MySqlConnector.MySqlConnection
Public Class Form2
    Dim movement As Boolean = False
    Dim filefoto As String
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        movement = True
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If (movement = True) Then Me.Location = Cursor.Position
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        movement = False
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs)
        '  If RadioButton1.Checked = True And RadioButton2.Checked = False Then
        ' GroupBox2.Enabled = True
        '  End If
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs)
        ' If RadioButton1.Checked = False And RadioButton2.Checked = True Then
        ' GroupBox2.Enabled = False
        ' End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = conexion

        Try
            conexion.ConnectionString = "Server=127.0.0.1;User ID=root;Password=root;Database=registro_usuario;Port=3308;"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        comando.CommandText =
                        "INSERT INTO registro_usuario.persona 
            (primer_nombre,
            segundo_nombre,
            apellido_paterno,
            apellido_materno,
            profesion,
            estado_civil,
            direccion_vivienda,
            apellido_casada,
            telefono,
            fecha_nacimiento,
            genero,
            dpi,
            sabe_leer,
            sabe_escribir,
            bautizado,
            fecha_bautizo,
            ministro_oficio_bautizo,
            cargo_actual_iglesia,
            fuera_pais,
            fecha_migracion,
            pais_migracion,
            retirado,
            fecha_retiro,
            fallecido,
            fecha_deceso,
            conyuge,
            nombre_conyuge)
    VALUES ('" + TextBox1.Text +
     "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox6.Text + "','" + TextBox15.Text + "','" + TextBox8.Text + "','" + TextBox5.Text + "','" + TextBox9.Text + "','" + DateTimePicker1.Value.ToShortDateString + "','" + TextBox16.Text + "'," + TextBox11.Text + ",'" + CheckBox3.Checked.ToString + "','" + CheckBox2.Checked.ToString + "','" + CheckBox1.Checked.ToString + "','" + DateTimePicker2.Value.ToShortDateString + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + CheckBox4.Checked.ToString + "','" + DateTimePicker3.Value.ToShortDateString + "','" + TextBox18.Text + "','" + CheckBox5.Checked.ToString + "','" + DateTimePicker4.Value.ToShortDateString + "'," + CheckBox6.Checked.ToString + ",'" + DateTimePicker5.Value.ToShortDateString + "','" + CheckBox7.Checked.ToString + "','" + TextBox7.Text + "')"



        comando.ExecuteNonQuery()
        MsgBox("Datos insertados")
        conexion.Close()




    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            GroupBox2.Enabled = True
        ElseIf CheckBox1.Checked = False Then
            GroupBox2.Enabled = False
        End If


    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            GroupBox3.Enabled = True
        ElseIf CheckBox4.Checked = False Then
            GroupBox3.Enabled = False
        End If

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            GroupBox4.Enabled = True
        ElseIf CheckBox5.Checked = False Then
            GroupBox4.Enabled = False
        End If

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged


        If CheckBox6.Checked = True Then
            GroupBox5.Enabled = True
        ElseIf CheckBox6.Checked = False Then
            GroupBox5.Enabled = False
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            GroupBox6.Enabled = True
        ElseIf CheckBox7.Checked = False Then
            GroupBox6.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(CheckBox3.Checked.ToString)
        MsgBox(DateTimePicker2.Value.ToShortDateString)



    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub
End Class
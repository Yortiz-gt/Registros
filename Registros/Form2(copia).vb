Imports System.Runtime.CompilerServices
Imports MySqlConnector
Imports MySqlConnector.MySqlConnection
Public Class Form2_copia_
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

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        '  If RadioButton1.Checked = True And RadioButton2.Checked = False Then
        ' GroupBox2.Enabled = True
        '  End If
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        ' If RadioButton1.Checked = False And RadioButton2.Checked = True Then
        ' GroupBox2.Enabled = False
        ' End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "PNG| *.png|JPG |*.jpg"
        OpenFileDialog1.FileName = " Fotografía"
        OpenFileDialog1.Title = "Subir Archivo"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            filefoto = OpenFileDialog1.FileName
            PictureBox8.Image = System.Drawing.Image.FromFile(filefoto)
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = conexion

        Try
            conexion.ConnectionString = "Server=127.0.0.1;User ID=root;Password=root;Database=Person;Port=3308;"
            conexion.Open()
            'MsgBox("Conectado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        comando.CommandText =
            "INSERT INTO Person.person (first_name,middle_name,last_name,second_last_name,married_name,profession,marital_status,phone_number,dpi,nationality,home_address,birthday,can_read,can_write,baptized,date_baptized,baptism_minister,church_privileges,address_church,date_death,picture)
	VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox15.Text + "','" + TextBox9.Text + "','" + TextBox11.Text + "','" + TextBox10.Text + "','" + TextBox8.Text + "','" + DateTimePicker1.Value.ToShortDateString + "'," + 1 + "," + 1 + "," + 1 + ",'" + DateTimePicker2.Value.ToShortDateString + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "','" + 2100 - 1 - 1 + "'," + 0 + ")"


        Dim r As MySqlDataReader

        r = comando.ExecuteReader

        If r.HasRows <> False Then
            r.Read()
            MsgBox(r.GetInt64("dbid"))

        Else
            MsgBox("Usuario y/o contrase;a Incorrectos")


        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            GroupBox2.Enabled = True
        ElseIf CheckBox1.Checked = False Then
            GroupBox2.Enabled = False
        End If
        MsgBox(CheckBox1.Checked.ToString)

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            GroupBox3.Enabled = True
        ElseIf CheckBox4.Checked = False Then
            GroupBox3.Enabled = False
        End If
        MsgBox(CheckBox4.Checked.ToString)
    End Sub
End Class
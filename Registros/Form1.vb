Public Class Form1
    Dim movement As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub


    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        movement = True
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If (movement = True) Then Me.Location = Cursor.Position
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        movement = False
    End Sub

End Class

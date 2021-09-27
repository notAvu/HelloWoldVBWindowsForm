Imports MisClases

Public Class HolaMundo
    ''' <summary>
    ''' Recogemos el texto introducido por el usuario y escribimos "Hello "+ la caddena introducida por el usuario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim persona As New clsPersona(TextBox1.Text)
        Dim noVacio As Boolean = TextBox1.Text.Length > 0
        If noVacio Then
            MessageBox.Show($"Hello {persona.Nombre}")
        End If
    End Sub
End Class

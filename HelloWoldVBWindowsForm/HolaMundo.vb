Public Class HolaMundo
    ''' <summary>
    ''' Recogemos el texto introducido por el usuario y escribimos "Hello "+ la caddena introducida por el usuario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As String
        p = String.Concat("Hello ", TextBox1.Text)
        Dim v As Boolean = TextBox1.Text.Length > 0
        If v Then
            MessageBox.Show(p, "Hello world")
        End If
    End Sub
End Class

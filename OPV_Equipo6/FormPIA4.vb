Public Class FormPIA4
    Private Sub btncalcularedad_Click(sender As Object, e As EventArgs) Handles btncalcularedad.Click
        Dim fechaNacimiento As DateTime = dtpFechaNacimiento.Value

        Dim edad As Integer = CalcularEdad(fechaNacimiento)

        MessageBox.Show($"la edad es: {edad} años", "edad")
    End Sub

    Private Function CalcularEdad(fechaNacimiento As DateTime) As Integer
        Dim fechaActual As DateTime = DateTime.Today

        Dim edad As Integer = fechaActual.Year - fechaNacimiento.Year

        If fechaNacimiento > fechaActual.AddYears(-edad) Then
            edad -= 1
        End If
        Return edad
    End Function

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        FormMenu.Show()
        Me.Hide()
    End Sub
End Class
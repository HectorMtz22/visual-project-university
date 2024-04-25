Public Class FormMC3
    Private Sub btn_verificar_Click(sender As Object, e As EventArgs) Handles btn_verificar.Click
        Dim dias(7) As String
        Dim n As Integer

        ' Se ponen los 7 días de la semana en la variable
        dias = New String() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"}
        ' Se obtiene el numero tecleado
        ' Se le resta 1 para que coincida con el arreglo
        n = Val(txt_numero.Text) - 1

        ' Verifica que el número esté en el rango
        If dias.Length > n And n >= 0 Then
            lbl_dia.Text = "El día es: " + dias(n)
        Else
            lbl_dia.Text = "El número es incorrecto, intenta de nuevo"
        End If

    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        Me.Hide()
        FormMenu.Show()
    End Sub
End Class
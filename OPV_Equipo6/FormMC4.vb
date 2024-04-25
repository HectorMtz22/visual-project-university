Public Class FormMC4
    Private Sub btn_verificar_Click(sender As Object, e As EventArgs) Handles btn_verificar.Click
        Dim desde, hasta As Integer
        Dim i As Integer

        desde = 10
        hasta = 1
        i = desde

        lbl_numeros.Text = ""

        While i >= hasta
            ' Se actualiza el texto del label con lo mismo mas una fila con el siguiente numero
            lbl_numeros.Text = lbl_numeros.Text + i.ToString() + vbCrLf
            i = i - 1
        End While
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        Me.Hide()
        FormMenu.Show()
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        lbl_numeros.Text = ""
    End Sub
End Class
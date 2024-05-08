Public Class FormPIA3
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        dtp_fecha.Value = DateTime.Today
        dtp_hora.Value = DateTime.Now
        txt_titulo.Clear()
        txt_descripcion.Clear()
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        FormMenu.Show()
        Me.Hide()
    End Sub
End Class
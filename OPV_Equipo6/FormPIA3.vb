Public Class FormPIA3
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If String.IsNullOrWhiteSpace(txt_titulo.Text) Or String.IsNullOrWhiteSpace(txt_descripcion.Text) Then
            MessageBox.Show("Por favor, llene todos los campos.")
            Return
        End If

        Dim fecha As String = dtp_fecha.Value.ToShortDateString()
        Dim hora As String = dtp_hora.Value.ToString()
        Dim titulo As String = txt_titulo.Text.Trim()
        Dim descripcion As String = txt_descripcion.Text.Trim()

        dgv_eventos.Rows.Add(fecha, hora, titulo, descripcion)

        MessageBox.Show("Evento Agregado")

        btn_limpiar_Click(Nothing, Nothing)
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
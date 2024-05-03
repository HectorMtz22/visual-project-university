Public Class FormORD3
    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        FormMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If Not String.IsNullOrWhiteSpace(txttareas.Text) Then
            lsttareas.Items.Add(txttareas.Text)
            txttareas.Clear() ' Limpia el Txt
        Else
            MessageBox.Show("Ingrese una tarea.")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If lsttareas.SelectedIndex >= 0 Then
            lsttareas.Items.RemoveAt(lsttareas.SelectedIndex)
        Else
            MessageBox.Show("Seleccione una tarea para eliminar.")
        End If
    End Sub

    Private Sub BtnCompletar_Click(sender As Object, e As EventArgs) Handles btncompletar.Click
        If lsttareas.SelectedIndex >= 0 Then
            lsttareas.Items(lsttareas.SelectedIndex) = "Completado: " & lsttareas.Items(lsttareas.SelectedIndex)
        Else
            MessageBox.Show("Seleccione una tarea para marcar como completada.")
        End If
    End Sub
End Class
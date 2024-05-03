Public Class FormORD4
    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        FormMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If Not String.IsNullOrWhiteSpace(txtnombre.Text) AndAlso Not String.IsNullOrWhiteSpace(txttelefono.Text) Then

            lstcontactos.Items.Add(txtnombre.Text & " - " & txttelefono.Text)

            txtnombre.Clear()
            txttelefono.Clear()
        Else
            MessageBox.Show("Ingrese el nombre y el teléfono del contacto.")
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim busqueda As String = txtbuscar.Text.ToLower()
        For Each contacto As String In lstcontactos.Items
            If contacto.ToLower().Contains(busqueda) Then

                lstcontactos.SelectedItem = contacto
                Exit For
            End If
        Next
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If lstcontactos.SelectedIndex >= 0 Then
            lstcontactos.Items.RemoveAt(lstcontactos.SelectedIndex)
        Else
            MessageBox.Show("Seleccione un contacto para eliminar.")
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtbuscar.Clear()
        lstcontactos.SelectedIndex = -1
        lstcontactos.ClearSelected()
    End Sub
End Class
Public Class FormPIA1
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        ' Verificar si se ingresó un monto válido de la cuenta
        Dim montoCuenta As Double
        If Not Double.TryParse(TxtMonto.Text, montoCuenta) OrElse montoCuenta <= 0 Then
            MessageBox.Show("Por favor, ingrese un monto válido de la cuenta.")
            Return
        End If

        ' Verificar si se ingresó un porcentaje válido de propina
        Dim porcentajePropina As Double
        If Not Double.TryParse(TxtPropina.Text, porcentajePropina) OrElse porcentajePropina < 0 Then
            MessageBox.Show("Por favor, ingrese un porcentaje válido de propina.")
            Return
        End If

        ' Calcular la cantidad de propina
        Dim propina As Double = montoCuenta * (porcentajePropina / 100)

        ' Mostrar la cantidad de propina en el cuadro de texto de resultado
        TxtResultado.Text = propina.ToString("C")
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        FormMenu.Show()
        Me.Hide()
    End Sub
End Class

Public Class FormORD1
    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        FormMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSuma_Click(sender As Object, e As EventArgs) Handles btn_suma.Click
        RealizarOperacion("suma")
    End Sub

    Private Sub BtnResta_Click(sender As Object, e As EventArgs) Handles btn_resta.Click
        RealizarOperacion("resta")
    End Sub

    Private Sub BtnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btn_multi.Click
        RealizarOperacion("multiplicar")
    End Sub

    Private Sub BtnDivision_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        RealizarOperacion("division")
    End Sub

    Private Sub RealizarOperacion(operacion As String)
        Dim num1 As Double
        Dim num2 As Double
        Dim resultado As Double

        If Double.TryParse(txtnum1.Text, num1) AndAlso Double.TryParse(txtnum2.Text, num2) Then
            Select Case operacion
                Case "suma"
                    resultado = num1 + num2
                Case "resta"
                    resultado = num1 - num2
                Case "multiplicar"
                    resultado = num1 * num2
                Case "division"

                    If num2 <> 0 Then
                        resultado = num1 / num2
                    Else
                        MessageBox.Show("No se puede dividir por cero.")
                        Return
                    End If
            End Select

            txtresultado.Text = resultado.ToString()
        Else
            MessageBox.Show("Por favor, ingrese números válidos.")
        End If
    End Sub

End Class
Public Class FormORD2
    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        FormMenu.Show()
        Me.Hide()
    End Sub

    Function CelsiusAFahrenheit(celsius As Double) As Double
        Return (celsius * 9 / 5) + 32
    End Function

    Function FahrenheitACelsius(fahrenheit As Double) As Double
        Return (fahrenheit - 32) * 5 / 9
    End Function

    Private Sub BtnConvertir_Click(sender As Object, e As EventArgs) Handles btnconvertir.Click
        Dim valorEntrada As Double
        Dim resultado As Double

        If Double.TryParse(txtvalor.Text, valorEntrada) Then
            If rb_cel_to_far.Checked Then
                resultado = CelsiusAFahrenheit(valorEntrada)
            ElseIf rb_far_to_cel.Checked Then
                resultado = FahrenheitACelsius(valorEntrada)
            Else
                MessageBox.Show("Sleccione una opción de conversión.")
                Return
            End If

            txtresultado.Text = resultado.ToString("N2")
        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If
    End Sub

    Private Sub FormORD2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb_cel_to_far.Checked = True
    End Sub
End Class
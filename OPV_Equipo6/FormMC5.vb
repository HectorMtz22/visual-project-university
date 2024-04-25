Public Class FormMC5
    Private Sub btn_verificar_Click(sender As Object, e As EventArgs) Handles btn_verificar.Click
        Dim n As Integer
        Dim texto As String = ""

        If Not IsNumeric(txt_numero.Text) Then
            MsgBox("Ingresa un número válido...")
            Return
        End If

        n = txt_numero.Text

        For i As Integer = 1 To 10
            texto = texto + n.ToString() + " x " + i.ToString() + " = " + (n * i).ToString() + vbCrLf
        Next

        txt_tabla.Text = texto
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        Me.Hide()
        FormMenu.Show()
    End Sub
End Class
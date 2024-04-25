Public Class FormMC1
    Private Sub btn_verificar_Click(sender As Object, e As EventArgs) Handles btn_verificar.Click
        Dim nota As Integer

        ' Mensaje que indica que no se introdujo un número
        If Not IsNumeric(txt_calificacion.Text) Then
            MsgBox("Número invalido, intenta de nuevo...")
            Return
        End If

        nota = Val(txt_calificacion.Text)

        If nota < 80 Then
            ' Reprobado
            lbl_resultado.Text = "Reprobado"
            lbl_resultado.ForeColor = Color.Red

        Else
            ' Aprobado
            lbl_resultado.Text = "Aprobado"
            lbl_resultado.ForeColor = Color.Green

        End If
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        FormMenu.Show()
        Me.Hide()
    End Sub
End Class
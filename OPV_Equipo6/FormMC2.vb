Public Class FormMC2
    Private Sub btn_verificar_Click(sender As Object, e As EventArgs) Handles btn_verificar.Click
        Dim n As Integer
        Dim hasta As Integer

        ' Validamos primero si es un número para que no dé errores
        ' Si no es número, no permitimos continuar
        If Not IsNumeric(txt_numero.Text) Then
            MsgBox("Número invalido, intenta de nuevo...")
            Return
        End If

        n = Val(txt_numero.Text)

        ' Como encontrar el numero primo
        ' Una manera es dividiendo el numero desde el 2 hasta la mitad del numero ingresado

        hasta = n / 2

        For i As Integer = 2 To hasta
            If (n Mod i) = 0 Then
                MsgBox("El numero NO es primo")
                Return
            End If
        Next
        MsgBox("El numero SI es primo")
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        FormMenu.Show()
        Me.Hide()
    End Sub

End Class
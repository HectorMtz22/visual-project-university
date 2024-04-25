Public Class FormLogin
    Private Sub btn_mostrar_pass_Click(sender As Object, e As EventArgs) Handles btn_mostrar_pass.Click
        MsgBox("Usuario: Hector" + vbCrLf + "Contraseña: 1897759")
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        ' Usuario: Hector
        ' Contraseña: 1897759

        Dim user As String = txt_user.Text
        Dim pass As String = txt_password.Text

        If Not user.Equals("Hector") Or Not pass.Equals("1897759") Then
            MsgBox("Inicio de sesión incorrecto, intenta de nuevo...")
            Return
        End If

        ' Clear las credenciales
        txt_user.Text = ""
        txt_password.Text = ""

        Dim frm_menu As New FormMenu()
        frm_menu.Show()
        Me.Hide()
    End Sub
End Class
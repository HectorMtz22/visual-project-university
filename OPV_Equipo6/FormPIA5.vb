Public Class FormPIA5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Dim longitud As Integer = CInt(nudLongitud.Value)
        Dim caracteres As String = "abcdefghijklmopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789!@#$%^&*()_+-=[]{}|;:,.<>?~/\"

        Dim rnd As New Random()
        Dim contraseña As String = ""
        For i As Integer = 1 To longitud
            Dim indice As Integer = rnd.Next(0, caracteres.Length)
            contraseña &= caracteres(indice)
        Next

        txtContraseña.Text = contraseña

    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        FormMenu.Show()
        Me.Hide()
    End Sub
End Class

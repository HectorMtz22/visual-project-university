﻿Public Class FormMenu
    Private Sub Prob1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Prob1ToolStripMenuItem.Click
        FormMC1.Show()
        Me.Hide()
    End Sub

    Private Sub Prob2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Prob2ToolStripMenuItem.Click
        FormMC2.Show()
        Me.Hide()
    End Sub

    Private Sub Prob3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Prob3ToolStripMenuItem.Click
        FormMC3.Show()
        Me.Hide()
    End Sub

    Private Sub Prob4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Prob4ToolStripMenuItem.Click
        FormMC4.Show()
        Me.Hide()
    End Sub

    Private Sub Prob5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Prob5ToolStripMenuItem.Click
        FormMC5.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_click(sender As Object, e As EventArgs) Handles btn_exit.Click
        ' Asi reutilizo el form anterior
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        FormORD1.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        FormORD2.Show()
        Me.Hide()
    End Sub

    Private Sub GestiónDeTareasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeTareasToolStripMenuItem.Click
        FormORD3.Show()
        Me.Hide()
    End Sub

    Private Sub GestiónDeContactosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeContactosToolStripMenuItem.Click
        FormORD4.Show()
        Me.Hide()
    End Sub

    Private Sub BaseDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaseDeDatosToolStripMenuItem.Click
        FormORD5.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        FormPIA2.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        FormPIA1.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        FormPIA4.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        FormPIA5.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        FormPIA3.Show()
        Me.Hide()
    End Sub
End Class

Public Class FormMenu
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
        Me.Hide()
    End Sub

    Private Sub Prob5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Prob5ToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub btn_exit_click(sender As Object, e As EventArgs) Handles btn_exit.Click
        ' Asi reutilizo el form anterior
        Me.Close()
    End Sub
End Class

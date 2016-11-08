Public Class frm_menu
    Private Sub ToolStripUsuario_Click(sender As Object, e As EventArgs) Handles ToolStripUsuario.Click
        frm_usuarios.show()
        Me.Close()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub


End Class
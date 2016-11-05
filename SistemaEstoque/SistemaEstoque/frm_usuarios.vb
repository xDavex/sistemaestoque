Public Class frm_usuarios
    Private Sub txt_usuario_LostFocus(sender As Object, e As EventArgs) Handles txt_usuario.LostFocus
        sql = "select * from tb_usuario where NomeUsu ='" & txt_usuario.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            lbl_status.Text = "Usuario Já Cadastrado"
            lbl_status.ForeColor = Color.Red
            btn_criar.Enabled = False
        Else
            lbl_status.Text = "Usuario Disponivel"
            lbl_status.ForeColor = Color.Green
            btn_criar.Enabled = True
        End If
    End Sub

    
    Private Sub frm_usuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frm_menu.Show()
    End Sub
End Class

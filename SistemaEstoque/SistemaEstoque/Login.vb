Public Class Login
    Dim cont, existeUsu As Integer

    Private Sub txt_usu_LostFocus(sender As Object, e As EventArgs) Handles txt_usu.LostFocus
        sql = "select * from tb_usuario where NomeUsu ='" & txt_usu.Text & "'"
        Try
            rs = db.Execute(sql)
            If rs.EOF = False Then
                lbl_tent.Text = "Você possui mais " & rs.Fields(4).Value & " tentativas."
                cont = CInt(rs.Fields(4).Value)
                existeUsu = 1 'pode descontar as tentativas
                lbl_tent.Visible = True
            Else
                existeUsu = 0
                lbl_tent.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Erro! \nDesc:" & ex.Message)
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_tent.Visible = False
        conexao_banco()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If cont > 0 And existeUsu = 1 Then
                sql = "select * from tb_usuario where NomeUsu ='" & txt_usu.Text & "' and Senha='" & txt_senha.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    sql = "update tb_usuario set TentativaUsu ='3' where NomeUsu='" & txt_usu.Text & "'"
                    rs = db.Execute(sql)
                    '  If cb_nivel.Text = "USUÁRIO" Then 'abre o menu conforme o nivel
                    'menu_usu()
                    'End If
                    Me.Hide()
                    frm_menu.Show() 'MENU
                Else
                    MsgBox("Senha e usuário/e-mail não coincidem!")
                    cont = cont - 1
                    lbl_tent.Text = "Você possui mais " & cont.ToString & " tentativas."
                    sql = "update tb_usuario set TentativaUsu =" & cont & " where NomeUsu='" & txt_usu.Text & "'"
                    rs = db.Execute(sql)
                End If
            Else
                If existeUsu = 1 Then                                           'status 0 - bloqueado
                    sql = "update tb_usuario set TentativaUsu ='" & cont & "', StatusUsu='0' where NomeUsu='" & txt_usu.Text & "' "
                    rs = db.Execute(sql)
                    MsgBox("Usuário bloquado, contate o administrador!")
                Else
                    MsgBox("Usuário não existe!")
                    txt_usu.Focus()
                    txt_usu.Clear()
                    txt_senha.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro! \nDesc:" & ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frm_esqueceuSenha.Show()
    End Sub
End Class

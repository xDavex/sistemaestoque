Public Class Login


    Private Sub txt_usu_LostFocus(sender As Object, e As EventArgs) Handles txt_usu.LostFocus
        sql = "select * from tb_usuario where NomeUsu ='" & txt_usu.Text & "'"
        Try
            rs = db.Execute(sql)
            If rs.EOF = False Then
                If rs.Fields(4).Value > 0 Then
                    lbl_tent.Text = "Você possui mais " & rs.Fields(4).Value & " tentativas."
                    cont = CInt(rs.Fields(4).Value)
                    btn_entrar.Enabled = True
                Else
                    btn_entrar.Enabled = False
                    lbl_tent.Text = "CONTA BLOQUEADA"

                End If
                lbl_tent.Visible = True
            Else
                If txt_usu.Text <> "" Then
                    lbl_tent.Visible = True

                    lbl_tent.Text = "USUÁRIO NÃO CADASTRADO"
                    txt_usu.Focus()
                Else
                    btn_entrar.Enabled = True
                    lbl_tent.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro Generico 1! \nDesc:" & ex.Message)
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_tent.Visible = False
        lbl_bloq.Visible = False
        conexao_banco()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If txt_usu.Text = "" Or txt_senha.Text = "" Then
            MsgBox("Preencha todos os (2) campos")
        Else
            Try
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
                    MsgBox("Senha Incorreta")
                    cont = cont - 1
                    lbl_tent.Text = "Você possui mais " & cont.ToString & " tentativas."
                    txt_senha.Clear()
                    txt_senha.Focus()
                    If cont = 0 Then
                        sql = "update tb_usuario set TentativaUsu ='" & cont & "', StatusUsu='0' where NomeUsu='" & txt_usu.Text & "' " 'status 0 - bloqueado
                        rs = db.Execute(sql)
                        MsgBox("Usuário bloquado, contate o administrador!")
                    Else
                        sql = "update tb_usuario set TentativaUsu =" & cont & " where NomeUsu='" & txt_usu.Text & "'"
                        rs = db.Execute(sql)
                    End If
                End If

            Catch ex As Exception
                MsgBox("Erro Generico 2 \nDesc:" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frm_esqueceuSenha.Show()
    End Sub

    'fazer piscar a mensagem de "USUARIO BLOQUEADO"
    '  Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    ' If lbl_bloq.Visible = True Then
    '        lbl_bloq.Visible = False
    'ElseIf lbl_tent.Visible = False Then
    '       lbl_bloq.Visible = True
    '      lbl_bloq.ForeColor = Color.Red
    '  End If

    'End Sub
End Class

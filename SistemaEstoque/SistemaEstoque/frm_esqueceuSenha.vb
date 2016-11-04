Public Class frm_esqueceuSenha

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        sql = "select * from tb_usuario where NomeUsu ='" & txt_usu.Text & "' and RespostaUsu='" & txt_resposta.Text & "'"
        Try
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("Senha da conta: '" & rs.Fields(7).Value & "'", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                Me.Dispose()
            Else
                MsgBox("Resposta ou usuário incorreto!")
                txt_resposta.Clear()
                txt_resposta.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro! \nDesc:" & ex.Message)
        End Try
    End Sub

End Class
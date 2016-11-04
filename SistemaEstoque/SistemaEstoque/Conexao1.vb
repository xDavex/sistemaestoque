Module Conexao1

    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String
    Public conexao = Application.StartupPath & "\db.mdb"

    Sub conexao_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & Conexao)
            'db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & conexao)'
        Catch ex As Exception
            MsgBox("Conexão falhou!" & ex.Message)
        End Try
    End Sub

    Sub limpar_login()
        With Login
            .txt_senha.Clear()
            .txt_usu.Clear()
            .lbl_tent.Visible = False
        End With
    End Sub
End Module

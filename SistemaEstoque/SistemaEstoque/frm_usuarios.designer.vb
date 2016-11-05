<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_usuarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_pergunta = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.btn_criar = New System.Windows.Forms.Button()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.25!)
        Me.Label1.Location = New System.Drawing.Point(125, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastro de Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome do Usuário"
        '
        'cmb_pergunta
        '
        Me.cmb_pergunta.Font = New System.Drawing.Font("Verdana", 9.25!)
        Me.cmb_pergunta.FormattingEnabled = True
        Me.cmb_pergunta.Items.AddRange(New Object() {"1 - Operador", "2 - Contador", "3 - Administrador"})
        Me.cmb_pergunta.Location = New System.Drawing.Point(37, 119)
        Me.cmb_pergunta.Name = "cmb_pergunta"
        Me.cmb_pergunta.Size = New System.Drawing.Size(211, 22)
        Me.cmb_pergunta.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Selecione o Tipo de Usuario"
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Verdana", 9.25!)
        Me.txt_usuario.Location = New System.Drawing.Point(36, 74)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(288, 22)
        Me.txt_usuario.TabIndex = 0
        '
        'btn_criar
        '
        Me.btn_criar.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_criar.Location = New System.Drawing.Point(179, 258)
        Me.btn_criar.Name = "btn_criar"
        Me.btn_criar.Size = New System.Drawing.Size(109, 31)
        Me.btn_criar.TabIndex = 6
        Me.btn_criar.Text = "Criar Conta"
        Me.btn_criar.UseVisualStyleBackColor = True
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(330, 78)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(36, 13)
        Me.lbl_status.TabIndex = 8
        Me.lbl_status.Text = "adsad"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(371, 92)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "OBS..: Todos os usuários cadastrados tem senha padrão 123.No primeiro acesso o us" & _
    "uario devera configurar a nova senha"
        '
        'frm_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 298)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.btn_criar)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_pergunta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_pergunta As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents btn_criar As System.Windows.Forms.Button
    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

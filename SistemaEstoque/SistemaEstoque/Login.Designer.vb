﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_usu = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.lbl_tent = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_bloq = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bem-vindo(a)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuário"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Senha"
        '
        'txt_usu
        '
        Me.txt_usu.Location = New System.Drawing.Point(83, 68)
        Me.txt_usu.Name = "txt_usu"
        Me.txt_usu.Size = New System.Drawing.Size(119, 20)
        Me.txt_usu.TabIndex = 1
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(83, 104)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(119, 20)
        Me.txt_senha.TabIndex = 2
        '
        'btn_entrar
        '
        Me.btn_entrar.Location = New System.Drawing.Point(51, 158)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_entrar.TabIndex = 3
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.UseVisualStyleBackColor = True
        '
        'lbl_tent
        '
        Me.lbl_tent.AutoSize = True
        Me.lbl_tent.Location = New System.Drawing.Point(80, 137)
        Me.lbl_tent.Name = "lbl_tent"
        Me.lbl_tent.Size = New System.Drawing.Size(57, 13)
        Me.lbl_tent.TabIndex = 6
        Me.lbl_tent.Text = "Tentativas"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(132, 163)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(108, 13)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Esqueci minha senha"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.SistemaEstoque.My.Resources.Resources.lock_png
        Me.PictureBox1.Location = New System.Drawing.Point(208, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 63)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'lbl_bloq
        '
        Me.lbl_bloq.AutoSize = True
        Me.lbl_bloq.Location = New System.Drawing.Point(80, 137)
        Me.lbl_bloq.Name = "lbl_bloq"
        Me.lbl_bloq.Size = New System.Drawing.Size(126, 13)
        Me.lbl_bloq.TabIndex = 9
        Me.lbl_bloq.Text = "USUÁRIO BLOQUEADO"
        Me.lbl_bloq.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 207)
        Me.Controls.Add(Me.lbl_bloq)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lbl_tent)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_usu As System.Windows.Forms.TextBox
    Friend WithEvents txt_senha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_entrar As System.Windows.Forms.Button
    Friend WithEvents lbl_tent As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_bloq As Label
End Class

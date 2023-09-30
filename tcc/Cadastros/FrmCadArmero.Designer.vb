<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadArmero
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MskCpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpLoc = New System.Windows.Forms.GroupBox()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnImp = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnExc = New System.Windows.Forms.Button()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MskTel = New System.Windows.Forms.MaskedTextBox()
        Me.GrpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(19, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Telefone"
        '
        'MskCpf
        '
        Me.MskCpf.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCpf.Location = New System.Drawing.Point(132, 73)
        Me.MskCpf.Mask = "000.000.000-00"
        Me.MskCpf.Name = "MskCpf"
        Me.MskCpf.Size = New System.Drawing.Size(140, 26)
        Me.MskCpf.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Cpf"
        '
        'TxtNom
        '
        Me.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNom.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(132, 41)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(245, 26)
        Me.TxtNom.TabIndex = 2
        '
        'TxtCod
        '
        Me.TxtCod.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(132, 9)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(50, 26)
        Me.TxtCod.TabIndex = 1
        Me.TxtCod.Tag = "x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(19, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Código"
        '
        'GrpLoc
        '
        Me.GrpLoc.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Controls.Add(Me.BtnOk)
        Me.GrpLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GrpLoc.Location = New System.Drawing.Point(12, 323)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Size = New System.Drawing.Size(362, 108)
        Me.GrpLoc.TabIndex = 116
        Me.GrpLoc.TabStop = False
        Me.GrpLoc.Text = "Localizar por código ou Nome"
        Me.GrpLoc.Visible = False
        '
        'TxtLoc
        '
        Me.TxtLoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLoc.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLoc.Location = New System.Drawing.Point(11, 45)
        Me.TxtLoc.Name = "TxtLoc"
        Me.TxtLoc.Size = New System.Drawing.Size(265, 26)
        Me.TxtLoc.TabIndex = 0
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(298, 39)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(40, 38)
        Me.BtnOk.TabIndex = 1
        Me.BtnOk.Text = "&Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'BtnLoc
        '
        Me.BtnLoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnLoc.Location = New System.Drawing.Point(421, 273)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(105, 38)
        Me.BtnLoc.TabIndex = 11
        Me.BtnLoc.Text = "&Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = True
        '
        'BtnSai
        '
        Me.BtnSai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnSai.Location = New System.Drawing.Point(420, 317)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(105, 38)
        Me.BtnSai.TabIndex = 12
        Me.BtnSai.Text = "Sai&r"
        Me.BtnSai.UseVisualStyleBackColor = True
        '
        'BtnImp
        '
        Me.BtnImp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnImp.Location = New System.Drawing.Point(420, 229)
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.Size = New System.Drawing.Size(105, 38)
        Me.BtnImp.TabIndex = 10
        Me.BtnImp.Text = "&Imprimir"
        Me.BtnImp.UseVisualStyleBackColor = True
        '
        'BtnCan
        '
        Me.BtnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnCan.Location = New System.Drawing.Point(420, 185)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(105, 38)
        Me.BtnCan.TabIndex = 9
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = True
        '
        'BtnExc
        '
        Me.BtnExc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnExc.Location = New System.Drawing.Point(420, 141)
        Me.BtnExc.Name = "BtnExc"
        Me.BtnExc.Size = New System.Drawing.Size(105, 38)
        Me.BtnExc.TabIndex = 8
        Me.BtnExc.Text = "&Excluir"
        Me.BtnExc.UseVisualStyleBackColor = True
        '
        'BtnAlt
        '
        Me.BtnAlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnAlt.Location = New System.Drawing.Point(420, 97)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(105, 38)
        Me.BtnAlt.TabIndex = 7
        Me.BtnAlt.Text = "&Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = True
        '
        'BtnGra
        '
        Me.BtnGra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnGra.Location = New System.Drawing.Point(420, 53)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(105, 38)
        Me.BtnGra.TabIndex = 6
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = True
        '
        'BtnNov
        '
        Me.BtnNov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnNov.Location = New System.Drawing.Point(420, 9)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(105, 38)
        Me.BtnNov.TabIndex = 0
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = True
        '
        'TxtEmail
        '
        Me.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEmail.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(132, 143)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(245, 26)
        Me.TxtEmail.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(19, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Email"
        '
        'MskTel
        '
        Me.MskTel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTel.Location = New System.Drawing.Point(132, 109)
        Me.MskTel.Mask = "(99) 00000-0000"
        Me.MskTel.Name = "MskTel"
        Me.MskTel.Size = New System.Drawing.Size(140, 26)
        Me.MskTel.TabIndex = 4
        '
        'FrmCadArmero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(538, 443)
        Me.Controls.Add(Me.MskTel)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GrpLoc)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnImp)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnExc)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MskCpf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(518, 481)
        Me.Name = "FrmCadArmero"
        Me.Text = "Cadastro do Armero"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MskCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents TxtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpLoc As System.Windows.Forms.GroupBox
    Friend WithEvents TxtLoc As System.Windows.Forms.TextBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BtnLoc As System.Windows.Forms.Button
    Friend WithEvents BtnSai As System.Windows.Forms.Button
    Friend WithEvents BtnImp As System.Windows.Forms.Button
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnExc As System.Windows.Forms.Button
    Friend WithEvents BtnAlt As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MskTel As System.Windows.Forms.MaskedTextBox
End Class

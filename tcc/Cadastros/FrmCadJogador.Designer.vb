<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadJogador
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
        Me.TxtNomrespon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MskCpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.GrpLoc = New System.Windows.Forms.GroupBox()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnImp = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnExc = New System.Windows.Forms.Button()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.dtpDataNasc = New System.Windows.Forms.DateTimePicker()
        Me.TxtIdade = New System.Windows.Forms.TextBox()
        Me.MskCpfRespon = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ChkBanidos = New System.Windows.Forms.CheckBox()
        Me.MskTelRespon = New System.Windows.Forms.MaskedTextBox()
        Me.MskTel = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.GrpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNomrespon
        '
        Me.TxtNomrespon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNomrespon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomrespon.Location = New System.Drawing.Point(213, 197)
        Me.TxtNomrespon.Name = "TxtNomrespon"
        Me.TxtNomrespon.Size = New System.Drawing.Size(245, 26)
        Me.TxtNomrespon.TabIndex = 5
        Me.TxtNomrespon.Tag = "x"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Nome Do Responsável"
        '
        'MskCpf
        '
        Me.MskCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCpf.Location = New System.Drawing.Point(213, 91)
        Me.MskCpf.Mask = "000.000.000-00"
        Me.MskCpf.Name = "MskCpf"
        Me.MskCpf.Size = New System.Drawing.Size(140, 26)
        Me.MskCpf.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Data de Nacimento"
        '
        'TxtEmail
        '
        Me.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(213, 305)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(245, 26)
        Me.TxtEmail.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Cpf"
        '
        'TxtNom
        '
        Me.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(213, 45)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(245, 26)
        Me.TxtNom.TabIndex = 1
        '
        'TxtCod
        '
        Me.TxtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(117, 9)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(50, 26)
        Me.TxtCod.TabIndex = 29
        Me.TxtCod.Tag = "x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nome"
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(298, 39)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(40, 38)
        Me.BtnOk.TabIndex = 1
        Me.BtnOk.Text = "&Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'GrpLoc
        '
        Me.GrpLoc.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Controls.Add(Me.BtnOk)
        Me.GrpLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GrpLoc.Location = New System.Drawing.Point(19, 371)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Size = New System.Drawing.Size(362, 108)
        Me.GrpLoc.TabIndex = 54
        Me.GrpLoc.TabStop = False
        Me.GrpLoc.Text = "Localizar por código ou Nome"
        Me.GrpLoc.Visible = False
        '
        'TxtLoc
        '
        Me.TxtLoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLoc.Location = New System.Drawing.Point(11, 45)
        Me.TxtLoc.Name = "TxtLoc"
        Me.TxtLoc.Size = New System.Drawing.Size(265, 26)
        Me.TxtLoc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Código"
        '
        'BtnLoc
        '
        Me.BtnLoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoc.Location = New System.Drawing.Point(500, 273)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(105, 38)
        Me.BtnLoc.TabIndex = 16
        Me.BtnLoc.Text = "&Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = True
        '
        'BtnSai
        '
        Me.BtnSai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSai.Location = New System.Drawing.Point(500, 317)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(105, 38)
        Me.BtnSai.TabIndex = 17
        Me.BtnSai.Text = "Sai&r"
        Me.BtnSai.UseVisualStyleBackColor = True
        '
        'BtnImp
        '
        Me.BtnImp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImp.Location = New System.Drawing.Point(500, 229)
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.Size = New System.Drawing.Size(105, 38)
        Me.BtnImp.TabIndex = 15
        Me.BtnImp.Text = "&Imprimir"
        Me.BtnImp.UseVisualStyleBackColor = True
        '
        'BtnCan
        '
        Me.BtnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCan.Location = New System.Drawing.Point(500, 185)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(105, 38)
        Me.BtnCan.TabIndex = 14
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = True
        '
        'BtnExc
        '
        Me.BtnExc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExc.Location = New System.Drawing.Point(500, 141)
        Me.BtnExc.Name = "BtnExc"
        Me.BtnExc.Size = New System.Drawing.Size(105, 38)
        Me.BtnExc.TabIndex = 13
        Me.BtnExc.Text = "&Excluir"
        Me.BtnExc.UseVisualStyleBackColor = True
        '
        'BtnAlt
        '
        Me.BtnAlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlt.Location = New System.Drawing.Point(500, 97)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(105, 38)
        Me.BtnAlt.TabIndex = 12
        Me.BtnAlt.Text = "&Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = True
        '
        'BtnGra
        '
        Me.BtnGra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGra.Location = New System.Drawing.Point(500, 53)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(105, 38)
        Me.BtnGra.TabIndex = 11
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = True
        '
        'BtnNov
        '
        Me.BtnNov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.Location = New System.Drawing.Point(500, 9)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(105, 38)
        Me.BtnNov.TabIndex = 0
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = True
        '
        'dtpDataNasc
        '
        Me.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataNasc.Location = New System.Drawing.Point(213, 169)
        Me.dtpDataNasc.Name = "dtpDataNasc"
        Me.dtpDataNasc.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataNasc.TabIndex = 4
        '
        'TxtIdade
        '
        Me.TxtIdade.Location = New System.Drawing.Point(377, 169)
        Me.TxtIdade.Name = "TxtIdade"
        Me.TxtIdade.Size = New System.Drawing.Size(81, 20)
        Me.TxtIdade.TabIndex = 30
        Me.TxtIdade.Tag = "x"
        '
        'MskCpfRespon
        '
        Me.MskCpfRespon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCpfRespon.Location = New System.Drawing.Point(213, 235)
        Me.MskCpfRespon.Mask = "000.000.000-00"
        Me.MskCpfRespon.Name = "MskCpfRespon"
        Me.MskCpfRespon.Size = New System.Drawing.Size(140, 26)
        Me.MskCpfRespon.TabIndex = 6
        Me.MskCpfRespon.Tag = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Cpf Do Responsável"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Telefone Do Responsável"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 345)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 20)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Banidos"
        '
        'ChkBanidos
        '
        Me.ChkBanidos.AutoSize = True
        Me.ChkBanidos.Location = New System.Drawing.Point(213, 348)
        Me.ChkBanidos.Name = "ChkBanidos"
        Me.ChkBanidos.Size = New System.Drawing.Size(43, 17)
        Me.ChkBanidos.TabIndex = 10
        Me.ChkBanidos.Text = "Sim"
        Me.ChkBanidos.UseVisualStyleBackColor = True
        '
        'MskTelRespon
        '
        Me.MskTelRespon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTelRespon.Location = New System.Drawing.Point(213, 273)
        Me.MskTelRespon.Mask = "(99) 00000-0000"
        Me.MskTelRespon.Name = "MskTelRespon"
        Me.MskTelRespon.Size = New System.Drawing.Size(140, 26)
        Me.MskTelRespon.TabIndex = 7
        Me.MskTelRespon.Tag = "x"
        '
        'MskTel
        '
        Me.MskTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTel.Location = New System.Drawing.Point(213, 123)
        Me.MskTel.Mask = "(99) 00000-0000"
        Me.MskTel.Name = "MskTel"
        Me.MskTel.Size = New System.Drawing.Size(140, 26)
        Me.MskTel.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Telefone"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(278, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 20)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Data"
        '
        'txtDia
        '
        Me.txtDia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDia.Enabled = False
        Me.txtDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDia.Location = New System.Drawing.Point(332, 6)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(126, 26)
        Me.txtDia.TabIndex = 56
        '
        'FrmCadJogador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(617, 488)
        Me.Controls.Add(Me.txtDia)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.MskTel)
        Me.Controls.Add(Me.MskTelRespon)
        Me.Controls.Add(Me.ChkBanidos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MskCpfRespon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtIdade)
        Me.Controls.Add(Me.dtpDataNasc)
        Me.Controls.Add(Me.TxtNomrespon)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MskCpf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GrpLoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnImp)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnExc)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.MinimumSize = New System.Drawing.Size(602, 527)
        Me.Name = "FrmCadJogador"
        Me.Text = "Cadastro De Jogador"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNomrespon As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MskCpf As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnOk As Button
    Friend WithEvents GrpLoc As GroupBox
    Friend WithEvents TxtLoc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLoc As Button
    Friend WithEvents BtnSai As Button
    Friend WithEvents BtnImp As Button
    Friend WithEvents BtnCan As Button
    Friend WithEvents BtnExc As Button
    Friend WithEvents BtnAlt As Button
    Friend WithEvents BtnGra As Button
    Friend WithEvents BtnNov As Button
    Friend WithEvents dtpDataNasc As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtIdade As System.Windows.Forms.TextBox
    Friend WithEvents MskCpfRespon As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ChkBanidos As System.Windows.Forms.CheckBox
    Friend WithEvents MskTelRespon As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MskTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
End Class

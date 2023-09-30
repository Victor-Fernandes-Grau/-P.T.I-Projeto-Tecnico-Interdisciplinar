<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManutencaoArma
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
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnImp = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnExc = New System.Windows.Forms.Button()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.GrpLoc = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtpreco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCodArmero = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCodArma = New System.Windows.Forms.TextBox()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFim = New System.Windows.Forms.DateTimePicker()
        Me.lblNumArma = New System.Windows.Forms.Label()
        Me.lblNomArmero = New System.Windows.Forms.Label()
        Me.BtnArma = New System.Windows.Forms.Button()
        Me.BtnArmero = New System.Windows.Forms.Button()
        Me.GrpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCod
        '
        Me.TxtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(241, 4)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(50, 26)
        Me.TxtCod.TabIndex = 1
        Me.TxtCod.Tag = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Código"
        '
        'BtnLoc
        '
        Me.BtnLoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoc.Location = New System.Drawing.Point(575, 273)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(105, 38)
        Me.BtnLoc.TabIndex = 12
        Me.BtnLoc.Text = "&Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = True
        '
        'BtnSai
        '
        Me.BtnSai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSai.Location = New System.Drawing.Point(575, 317)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(105, 38)
        Me.BtnSai.TabIndex = 13
        Me.BtnSai.Text = "Sai&r"
        Me.BtnSai.UseVisualStyleBackColor = True
        '
        'BtnImp
        '
        Me.BtnImp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImp.Location = New System.Drawing.Point(575, 229)
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.Size = New System.Drawing.Size(105, 38)
        Me.BtnImp.TabIndex = 11
        Me.BtnImp.Text = "&Imprimir"
        Me.BtnImp.UseVisualStyleBackColor = True
        '
        'BtnCan
        '
        Me.BtnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCan.Location = New System.Drawing.Point(575, 185)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(105, 38)
        Me.BtnCan.TabIndex = 10
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = True
        '
        'BtnExc
        '
        Me.BtnExc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExc.Location = New System.Drawing.Point(575, 141)
        Me.BtnExc.Name = "BtnExc"
        Me.BtnExc.Size = New System.Drawing.Size(105, 38)
        Me.BtnExc.TabIndex = 9
        Me.BtnExc.Text = "&Excluir"
        Me.BtnExc.UseVisualStyleBackColor = True
        '
        'BtnAlt
        '
        Me.BtnAlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlt.Location = New System.Drawing.Point(575, 97)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(105, 38)
        Me.BtnAlt.TabIndex = 8
        Me.BtnAlt.Text = "&Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = True
        '
        'BtnGra
        '
        Me.BtnGra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGra.Location = New System.Drawing.Point(575, 53)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(105, 38)
        Me.BtnGra.TabIndex = 7
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = True
        '
        'BtnNov
        '
        Me.BtnNov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.Location = New System.Drawing.Point(575, 9)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(105, 38)
        Me.BtnNov.TabIndex = 0
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = True
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
        Me.GrpLoc.Location = New System.Drawing.Point(16, 247)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Size = New System.Drawing.Size(362, 108)
        Me.GrpLoc.TabIndex = 91
        Me.GrpLoc.TabStop = False
        Me.GrpLoc.Text = "Localizar por código ou Nome"
        Me.GrpLoc.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Preço"
        '
        'Txtpreco
        '
        Me.Txtpreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtpreco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpreco.Location = New System.Drawing.Point(241, 163)
        Me.Txtpreco.Name = "Txtpreco"
        Me.Txtpreco.Size = New System.Drawing.Size(195, 26)
        Me.Txtpreco.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Data De Início"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Data De Final"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Código Do Armero  "
        '
        'TxtCodArmero
        '
        Me.TxtCodArmero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodArmero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodArmero.Location = New System.Drawing.Point(241, 68)
        Me.TxtCodArmero.Name = "TxtCodArmero"
        Me.TxtCodArmero.Size = New System.Drawing.Size(50, 26)
        Me.TxtCodArmero.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Código Da Arma"
        '
        'TxtCodArma
        '
        Me.TxtCodArma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodArma.Location = New System.Drawing.Point(241, 36)
        Me.TxtCodArma.Name = "TxtCodArma"
        Me.TxtCodArma.Size = New System.Drawing.Size(50, 26)
        Me.TxtCodArma.TabIndex = 2
        Me.TxtCodArma.Tag = "x"
        '
        'dtpInicio
        '
        Me.dtpInicio.Enabled = False
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(241, 105)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(79, 20)
        Me.dtpInicio.TabIndex = 92
        '
        'dtpFim
        '
        Me.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFim.Location = New System.Drawing.Point(241, 135)
        Me.dtpFim.Name = "dtpFim"
        Me.dtpFim.Size = New System.Drawing.Size(79, 20)
        Me.dtpFim.TabIndex = 93
        '
        'lblNumArma
        '
        Me.lblNumArma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumArma.Location = New System.Drawing.Point(357, 36)
        Me.lblNumArma.Name = "lblNumArma"
        Me.lblNumArma.Size = New System.Drawing.Size(206, 26)
        Me.lblNumArma.TabIndex = 94
        '
        'lblNomArmero
        '
        Me.lblNomArmero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNomArmero.Location = New System.Drawing.Point(357, 68)
        Me.lblNomArmero.Name = "lblNomArmero"
        Me.lblNomArmero.Size = New System.Drawing.Size(206, 26)
        Me.lblNomArmero.TabIndex = 95
        '
        'BtnArma
        '
        Me.BtnArma.Location = New System.Drawing.Point(309, 36)
        Me.BtnArma.Name = "BtnArma"
        Me.BtnArma.Size = New System.Drawing.Size(40, 26)
        Me.BtnArma.TabIndex = 96
        Me.BtnArma.Text = "..."
        Me.BtnArma.UseVisualStyleBackColor = True
        '
        'BtnArmero
        '
        Me.BtnArmero.Location = New System.Drawing.Point(309, 68)
        Me.BtnArmero.Name = "BtnArmero"
        Me.BtnArmero.Size = New System.Drawing.Size(40, 26)
        Me.BtnArmero.TabIndex = 97
        Me.BtnArmero.Text = "..."
        Me.BtnArmero.UseVisualStyleBackColor = True
        '
        'FrmManutencaoArma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(692, 374)
        Me.Controls.Add(Me.BtnArmero)
        Me.Controls.Add(Me.BtnArma)
        Me.Controls.Add(Me.lblNomArmero)
        Me.Controls.Add(Me.lblNumArma)
        Me.Controls.Add(Me.dtpFim)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.TxtCodArma)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtCodArmero)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txtpreco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnImp)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnExc)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.GrpLoc)
        Me.MinimumSize = New System.Drawing.Size(708, 413)
        Me.Name = "FrmManutencaoArma"
        Me.Text = "Manutenção De Arma"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLoc As Button
    Friend WithEvents BtnSai As Button
    Friend WithEvents BtnImp As Button
    Friend WithEvents BtnCan As Button
    Friend WithEvents BtnExc As Button
    Friend WithEvents BtnAlt As Button
    Friend WithEvents BtnGra As Button
    Friend WithEvents BtnNov As Button
    Friend WithEvents TxtLoc As TextBox
    Friend WithEvents BtnOk As Button
    Friend WithEvents GrpLoc As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtpreco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCodArmero As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCodArma As TextBox
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNumArma As System.Windows.Forms.Label
    Friend WithEvents lblNomArmero As System.Windows.Forms.Label
    Friend WithEvents BtnArma As System.Windows.Forms.Button
    Friend WithEvents BtnArmero As System.Windows.Forms.Button
End Class

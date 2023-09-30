<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadProdLanco
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
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPreco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtQuan = New System.Windows.Forms.TextBox()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.GrpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCod
        '
        Me.TxtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(184, 4)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(50, 26)
        Me.TxtCod.TabIndex = 1
        Me.TxtCod.Tag = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Código"
        '
        'BtnLoc
        '
        Me.BtnLoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoc.Location = New System.Drawing.Point(460, 268)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(105, 38)
        Me.BtnLoc.TabIndex = 11
        Me.BtnLoc.Text = "&Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = True
        '
        'BtnSai
        '
        Me.BtnSai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSai.Location = New System.Drawing.Point(460, 312)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(105, 38)
        Me.BtnSai.TabIndex = 12
        Me.BtnSai.Text = "Sai&r"
        Me.BtnSai.UseVisualStyleBackColor = True
        '
        'BtnImp
        '
        Me.BtnImp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImp.Location = New System.Drawing.Point(460, 224)
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.Size = New System.Drawing.Size(105, 38)
        Me.BtnImp.TabIndex = 10
        Me.BtnImp.Text = "&Imprimir"
        Me.BtnImp.UseVisualStyleBackColor = True
        '
        'BtnCan
        '
        Me.BtnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCan.Location = New System.Drawing.Point(460, 180)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(105, 38)
        Me.BtnCan.TabIndex = 9
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = True
        '
        'BtnExc
        '
        Me.BtnExc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExc.Location = New System.Drawing.Point(460, 136)
        Me.BtnExc.Name = "BtnExc"
        Me.BtnExc.Size = New System.Drawing.Size(105, 38)
        Me.BtnExc.TabIndex = 8
        Me.BtnExc.Text = "&Excluir"
        Me.BtnExc.UseVisualStyleBackColor = True
        '
        'BtnAlt
        '
        Me.BtnAlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlt.Location = New System.Drawing.Point(460, 92)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(105, 38)
        Me.BtnAlt.TabIndex = 7
        Me.BtnAlt.Text = "&Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = True
        '
        'BtnGra
        '
        Me.BtnGra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGra.Location = New System.Drawing.Point(460, 48)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(105, 38)
        Me.BtnGra.TabIndex = 6
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = True
        '
        'BtnNov
        '
        Me.BtnNov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.Location = New System.Drawing.Point(460, 4)
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
        Me.GrpLoc.Location = New System.Drawing.Point(12, 242)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Size = New System.Drawing.Size(362, 108)
        Me.GrpLoc.TabIndex = 91
        Me.GrpLoc.TabStop = False
        Me.GrpLoc.Text = "Localizar por código ou Nome"
        Me.GrpLoc.Visible = False
        '
        'TxtNom
        '
        Me.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(184, 73)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(245, 26)
        Me.TxtNom.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nome"
        '
        'TxtPreco
        '
        Me.TxtPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPreco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPreco.Location = New System.Drawing.Point(184, 137)
        Me.TxtPreco.Name = "TxtPreco"
        Me.TxtPreco.Size = New System.Drawing.Size(159, 26)
        Me.TxtPreco.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Preço"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Quantidade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tipo"
        '
        'TxtQuan
        '
        Me.TxtQuan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtQuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuan.Location = New System.Drawing.Point(184, 105)
        Me.TxtQuan.Name = "TxtQuan"
        Me.TxtQuan.Size = New System.Drawing.Size(159, 26)
        Me.TxtQuan.TabIndex = 4
        '
        'CmbTipo
        '
        Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Items.AddRange(New Object() {"", "Salgado", "Doce", "Refrigerante", "Alcool"})
        Me.CmbTipo.Location = New System.Drawing.Point(184, 36)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(154, 28)
        Me.CmbTipo.TabIndex = 2
        '
        'FrmCadProdLanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(572, 364)
        Me.Controls.Add(Me.CmbTipo)
        Me.Controls.Add(Me.TxtQuan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPreco)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNom)
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
        Me.MinimumSize = New System.Drawing.Size(573, 403)
        Me.Name = "FrmCadProdLanco"
        Me.Text = "Cadastro De Produtos da lançonete"
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
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPreco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtQuan As System.Windows.Forms.TextBox
    Friend WithEvents CmbTipo As System.Windows.Forms.ComboBox
End Class

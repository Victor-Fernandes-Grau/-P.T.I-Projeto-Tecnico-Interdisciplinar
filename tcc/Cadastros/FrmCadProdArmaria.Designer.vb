<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadProdArmaria
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
        Me.GrpLoc = New System.Windows.Forms.GroupBox()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnImp = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnExc = New System.Windows.Forms.Button()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNumserie = New System.Windows.Forms.TextBox()
        Me.TxtMode = New System.Windows.Forms.TextBox()
        Me.TxtDoc = New System.Windows.Forms.TextBox()
        Me.TxtQuan = New System.Windows.Forms.TextBox()
        Me.TxtPre = New System.Windows.Forms.TextBox()
        Me.CmbProd = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        'GrpLoc
        '
        Me.GrpLoc.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Controls.Add(Me.BtnOk)
        Me.GrpLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GrpLoc.Location = New System.Drawing.Point(11, 331)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Size = New System.Drawing.Size(362, 108)
        Me.GrpLoc.TabIndex = 67
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Código"
        '
        'BtnLoc
        '
        Me.BtnLoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoc.Location = New System.Drawing.Point(479, 268)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(105, 38)
        Me.BtnLoc.TabIndex = 14
        Me.BtnLoc.Text = "&Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = True
        '
        'BtnSai
        '
        Me.BtnSai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSai.Location = New System.Drawing.Point(479, 312)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(105, 38)
        Me.BtnSai.TabIndex = 15
        Me.BtnSai.Text = "Sai&r"
        Me.BtnSai.UseVisualStyleBackColor = True
        '
        'BtnImp
        '
        Me.BtnImp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImp.Location = New System.Drawing.Point(479, 224)
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.Size = New System.Drawing.Size(105, 38)
        Me.BtnImp.TabIndex = 13
        Me.BtnImp.Text = "&Imprimir"
        Me.BtnImp.UseVisualStyleBackColor = True
        '
        'BtnCan
        '
        Me.BtnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCan.Location = New System.Drawing.Point(479, 180)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(105, 38)
        Me.BtnCan.TabIndex = 12
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = True
        '
        'BtnExc
        '
        Me.BtnExc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExc.Location = New System.Drawing.Point(479, 136)
        Me.BtnExc.Name = "BtnExc"
        Me.BtnExc.Size = New System.Drawing.Size(105, 38)
        Me.BtnExc.TabIndex = 11
        Me.BtnExc.Text = "&Excluir"
        Me.BtnExc.UseVisualStyleBackColor = True
        '
        'BtnAlt
        '
        Me.BtnAlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlt.Location = New System.Drawing.Point(479, 92)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(105, 38)
        Me.BtnAlt.TabIndex = 10
        Me.BtnAlt.Text = "&Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = True
        '
        'BtnGra
        '
        Me.BtnGra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGra.Location = New System.Drawing.Point(479, 48)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(105, 38)
        Me.BtnGra.TabIndex = 9
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = True
        '
        'BtnNov
        '
        Me.BtnNov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.Location = New System.Drawing.Point(479, 4)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(105, 38)
        Me.BtnNov.TabIndex = 0
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = True
        '
        'TxtNom
        '
        Me.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(184, 70)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(245, 26)
        Me.TxtNom.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Número de série"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Modelo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Documento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Quantidade"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Preço de locação"
        '
        'TxtNumserie
        '
        Me.TxtNumserie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumserie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumserie.Location = New System.Drawing.Point(184, 99)
        Me.TxtNumserie.Name = "TxtNumserie"
        Me.TxtNumserie.Size = New System.Drawing.Size(245, 26)
        Me.TxtNumserie.TabIndex = 4
        Me.TxtNumserie.Tag = ""
        '
        'TxtMode
        '
        Me.TxtMode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMode.Location = New System.Drawing.Point(184, 131)
        Me.TxtMode.Name = "TxtMode"
        Me.TxtMode.Size = New System.Drawing.Size(245, 26)
        Me.TxtMode.TabIndex = 5
        Me.TxtMode.Tag = ""
        '
        'TxtDoc
        '
        Me.TxtDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDoc.Location = New System.Drawing.Point(184, 163)
        Me.TxtDoc.Name = "TxtDoc"
        Me.TxtDoc.Size = New System.Drawing.Size(245, 26)
        Me.TxtDoc.TabIndex = 6
        Me.TxtDoc.Tag = ""
        '
        'TxtQuan
        '
        Me.TxtQuan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtQuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuan.Location = New System.Drawing.Point(184, 195)
        Me.TxtQuan.Name = "TxtQuan"
        Me.TxtQuan.Size = New System.Drawing.Size(245, 26)
        Me.TxtQuan.TabIndex = 7
        '
        'TxtPre
        '
        Me.TxtPre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPre.Location = New System.Drawing.Point(184, 227)
        Me.TxtPre.Name = "TxtPre"
        Me.TxtPre.Size = New System.Drawing.Size(245, 26)
        Me.TxtPre.TabIndex = 8
        '
        'CmbProd
        '
        Me.CmbProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbProd.FormattingEnabled = True
        Me.CmbProd.Items.AddRange(New Object() {"", "Arma", "Capacete / Mascara", "Colete", "BBs"})
        Me.CmbProd.Location = New System.Drawing.Point(184, 36)
        Me.CmbProd.Name = "CmbProd"
        Me.CmbProd.Size = New System.Drawing.Size(154, 28)
        Me.CmbProd.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Tipo"
        '
        'FrmCadProdArmaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(591, 443)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmbProd)
        Me.Controls.Add(Me.TxtPre)
        Me.Controls.Add(Me.TxtQuan)
        Me.Controls.Add(Me.TxtDoc)
        Me.Controls.Add(Me.TxtMode)
        Me.Controls.Add(Me.TxtNumserie)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtCod)
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
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.Label2)
        Me.MinimumSize = New System.Drawing.Size(568, 482)
        Me.Name = "FrmCadProdArmaria"
        Me.Text = "Cadastro Dos Produtos Da Armaria"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCod As TextBox
    Friend WithEvents GrpLoc As GroupBox
    Friend WithEvents TxtLoc As TextBox
    Friend WithEvents BtnOk As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLoc As Button
    Friend WithEvents BtnSai As Button
    Friend WithEvents BtnImp As Button
    Friend WithEvents BtnCan As Button
    Friend WithEvents BtnExc As Button
    Friend WithEvents BtnAlt As Button
    Friend WithEvents BtnGra As Button
    Friend WithEvents BtnNov As Button
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNumserie As TextBox
    Friend WithEvents TxtMode As TextBox
    Friend WithEvents TxtDoc As TextBox
    Friend WithEvents TxtQuan As TextBox
    Friend WithEvents TxtPre As TextBox
    Friend WithEvents CmbProd As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class

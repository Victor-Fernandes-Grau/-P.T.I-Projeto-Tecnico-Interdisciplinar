<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLanconete
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
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtGer = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.TxtSub = New System.Windows.Forms.TextBox()
        Me.TxtQtd = New System.Windows.Forms.TextBox()
        Me.TxtPre = New System.Windows.Forms.TextBox()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.TxtPro = New System.Windows.Forms.TextBox()
        Me.BtnLocPro = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblCli = New System.Windows.Forms.Label()
        Me.BtnLocCli = New System.Windows.Forms.Button()
        Me.TxtCli = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCodFunc = New System.Windows.Forms.TextBox()
        Me.lblNomFunc = New System.Windows.Forms.Label()
        Me.BtnLocfun = New System.Windows.Forms.Button()
        Me.lbldata = New System.Windows.Forms.Label()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCan
        '
        Me.BtnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCan.Location = New System.Drawing.Point(567, 99)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(105, 38)
        Me.BtnCan.TabIndex = 60
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = True
        '
        'BtnSai
        '
        Me.BtnSai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSai.Location = New System.Drawing.Point(567, 143)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(105, 38)
        Me.BtnSai.TabIndex = 59
        Me.BtnSai.Text = "Sa&ir"
        Me.BtnSai.UseVisualStyleBackColor = True
        '
        'BtnGra
        '
        Me.BtnGra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGra.Location = New System.Drawing.Point(567, 56)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(105, 38)
        Me.BtnGra.TabIndex = 57
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = True
        '
        'BtnNov
        '
        Me.BtnNov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.Location = New System.Drawing.Point(567, 12)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(105, 38)
        Me.BtnNov.TabIndex = 58
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = True
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column4})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(35, 255)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(570, 201)
        Me.DgdGrade.TabIndex = 56
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.HeaderText = "Produto"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 69
        '
        'Column3
        '
        Me.Column3.HeaderText = "Preço"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 60
        '
        'Column5
        '
        Me.Column5.HeaderText = "Qtd"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 49
        '
        'Column4
        '
        Me.Column4.HeaderText = "Sub Total"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 78
        '
        'TxtGer
        '
        Me.TxtGer.Enabled = False
        Me.TxtGer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGer.Location = New System.Drawing.Point(507, 462)
        Me.TxtGer.Name = "TxtGer"
        Me.TxtGer.Size = New System.Drawing.Size(98, 26)
        Me.TxtGer.TabIndex = 55
        Me.TxtGer.Tag = "x"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(419, 468)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 20)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Total Geral"
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(525, 213)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(42, 26)
        Me.BtnOk.TabIndex = 53
        Me.BtnOk.Text = "&Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'TxtSub
        '
        Me.TxtSub.Enabled = False
        Me.TxtSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSub.Location = New System.Drawing.Point(445, 213)
        Me.TxtSub.Name = "TxtSub"
        Me.TxtSub.Size = New System.Drawing.Size(67, 26)
        Me.TxtSub.TabIndex = 52
        Me.TxtSub.Tag = "x"
        '
        'TxtQtd
        '
        Me.TxtQtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQtd.Location = New System.Drawing.Point(399, 213)
        Me.TxtQtd.Name = "TxtQtd"
        Me.TxtQtd.Size = New System.Drawing.Size(35, 26)
        Me.TxtQtd.TabIndex = 51
        Me.TxtQtd.Tag = "x"
        '
        'TxtPre
        '
        Me.TxtPre.Enabled = False
        Me.TxtPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPre.Location = New System.Drawing.Point(342, 213)
        Me.TxtPre.Name = "TxtPre"
        Me.TxtPre.Size = New System.Drawing.Size(51, 26)
        Me.TxtPre.TabIndex = 50
        Me.TxtPre.Tag = "x"
        '
        'TxtNom
        '
        Me.TxtNom.Enabled = False
        Me.TxtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(139, 213)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(197, 26)
        Me.TxtNom.TabIndex = 49
        Me.TxtNom.Tag = "x"
        '
        'TxtPro
        '
        Me.TxtPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPro.Location = New System.Drawing.Point(36, 213)
        Me.TxtPro.Name = "TxtPro"
        Me.TxtPro.Size = New System.Drawing.Size(51, 26)
        Me.TxtPro.TabIndex = 48
        Me.TxtPro.Tag = "x"
        '
        'BtnLocPro
        '
        Me.BtnLocPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLocPro.Location = New System.Drawing.Point(93, 213)
        Me.BtnLocPro.Name = "BtnLocPro"
        Me.BtnLocPro.Size = New System.Drawing.Size(34, 26)
        Me.BtnLocPro.TabIndex = 47
        Me.BtnLocPro.Text = "..."
        Me.BtnLocPro.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(284, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Data da Venda"
        '
        'TxtCod
        '
        Me.TxtCod.Enabled = False
        Me.TxtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(190, 6)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(68, 26)
        Me.TxtCod.TabIndex = 44
        Me.TxtCod.Tag = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Número da Venda:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 20)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Código Do Funcionário:  "
        '
        'LblCli
        '
        Me.LblCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCli.Location = New System.Drawing.Point(328, 83)
        Me.LblCli.Name = "LblCli"
        Me.LblCli.Size = New System.Drawing.Size(206, 26)
        Me.LblCli.TabIndex = 102
        '
        'BtnLocCli
        '
        Me.BtnLocCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLocCli.Location = New System.Drawing.Point(288, 81)
        Me.BtnLocCli.Name = "BtnLocCli"
        Me.BtnLocCli.Size = New System.Drawing.Size(34, 26)
        Me.BtnLocCli.TabIndex = 101
        Me.BtnLocCli.Text = "..."
        Me.BtnLocCli.UseVisualStyleBackColor = True
        '
        'TxtCli
        '
        Me.TxtCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCli.Location = New System.Drawing.Point(190, 84)
        Me.TxtCli.Name = "TxtCli"
        Me.TxtCli.Size = New System.Drawing.Size(68, 26)
        Me.TxtCli.TabIndex = 100
        Me.TxtCli.Tag = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 20)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Código da Comanda:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(445, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 20)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "Sub Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(399, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 20)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "Qtd"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(342, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Preço"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(139, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Produto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Código"
        '
        'TxtCodFunc
        '
        Me.TxtCodFunc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodFunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodFunc.Location = New System.Drawing.Point(190, 47)
        Me.TxtCodFunc.Name = "TxtCodFunc"
        Me.TxtCodFunc.Size = New System.Drawing.Size(68, 26)
        Me.TxtCodFunc.TabIndex = 96
        '
        'lblNomFunc
        '
        Me.lblNomFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNomFunc.Location = New System.Drawing.Point(328, 44)
        Me.lblNomFunc.Name = "lblNomFunc"
        Me.lblNomFunc.Size = New System.Drawing.Size(206, 26)
        Me.lblNomFunc.TabIndex = 98
        '
        'BtnLocfun
        '
        Me.BtnLocfun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLocfun.Location = New System.Drawing.Point(288, 44)
        Me.BtnLocfun.Name = "BtnLocfun"
        Me.BtnLocfun.Size = New System.Drawing.Size(34, 26)
        Me.BtnLocfun.TabIndex = 108
        Me.BtnLocfun.Text = "..."
        Me.BtnLocfun.UseVisualStyleBackColor = True
        '
        'lbldata
        '
        Me.lbldata.AutoSize = True
        Me.lbldata.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldata.Location = New System.Drawing.Point(419, 12)
        Me.lbldata.Name = "lbldata"
        Me.lbldata.Size = New System.Drawing.Size(41, 20)
        Me.lbldata.TabIndex = 109
        Me.lbldata.Text = "data"
        '
        'FrmLanconete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(683, 489)
        Me.Controls.Add(Me.lbldata)
        Me.Controls.Add(Me.BtnLocfun)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblCli)
        Me.Controls.Add(Me.BtnLocCli)
        Me.Controls.Add(Me.TxtCli)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNomFunc)
        Me.Controls.Add(Me.TxtCodFunc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.TxtGer)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.TxtSub)
        Me.Controls.Add(Me.TxtQtd)
        Me.Controls.Add(Me.TxtPre)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.TxtPro)
        Me.Controls.Add(Me.BtnLocPro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(699, 528)
        Me.Name = "FrmLanconete"
        Me.Text = "Lanchonete"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnSai As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtGer As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents TxtSub As System.Windows.Forms.TextBox
    Friend WithEvents TxtQtd As System.Windows.Forms.TextBox
    Friend WithEvents TxtPre As System.Windows.Forms.TextBox
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents TxtPro As System.Windows.Forms.TextBox
    Friend WithEvents BtnLocPro As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblCli As System.Windows.Forms.Label
    Friend WithEvents BtnLocCli As System.Windows.Forms.Button
    Friend WithEvents TxtCli As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtCodFunc As System.Windows.Forms.TextBox
    Friend WithEvents lblNomFunc As System.Windows.Forms.Label
    Friend WithEvents BtnLocfun As System.Windows.Forms.Button
    Friend WithEvents lbldata As System.Windows.Forms.Label
End Class

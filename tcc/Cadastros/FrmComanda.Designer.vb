<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmComanda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnExc = New System.Windows.Forms.Button()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.GrpLoc = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ChkCampo = New System.Windows.Forms.CheckBox()
        Me.TxtCodJogador = New System.Windows.Forms.TextBox()
        Me.TxtTotgeral = New System.Windows.Forms.TextBox()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblCodJog = New System.Windows.Forms.Label()
        Me.BtnNome = New System.Windows.Forms.Button()
        Me.LblHorarioIni = New System.Windows.Forms.Label()
        Me.ChkPago = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbTipoDePagamento = New System.Windows.Forms.ComboBox()
        Me.LblHorarioSaida = New System.Windows.Forms.Label()
        Me.DgvComanda2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DgvComanda = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrpLoc.SuspendLayout()
        CType(Me.DgvComanda2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvComanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Código Do Jogador"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Campo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Horário De Saida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Horário De Entrada"
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
        'TxtCod
        '
        Me.TxtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(189, 48)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(50, 26)
        Me.TxtCod.TabIndex = 8
        Me.TxtCod.Tag = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Código"
        '
        'BtnLoc
        '
        Me.BtnLoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoc.Location = New System.Drawing.Point(559, 224)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(105, 38)
        Me.BtnLoc.TabIndex = 6
        Me.BtnLoc.Text = "&Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = True
        '
        'BtnSai
        '
        Me.BtnSai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSai.Location = New System.Drawing.Point(559, 268)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(105, 38)
        Me.BtnSai.TabIndex = 7
        Me.BtnSai.Text = "Sai&r"
        Me.BtnSai.UseVisualStyleBackColor = True
        '
        'BtnCan
        '
        Me.BtnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCan.Location = New System.Drawing.Point(558, 180)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(105, 38)
        Me.BtnCan.TabIndex = 4
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = True
        '
        'BtnExc
        '
        Me.BtnExc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExc.Location = New System.Drawing.Point(558, 136)
        Me.BtnExc.Name = "BtnExc"
        Me.BtnExc.Size = New System.Drawing.Size(105, 38)
        Me.BtnExc.TabIndex = 3
        Me.BtnExc.Text = "&Excluir"
        Me.BtnExc.UseVisualStyleBackColor = True
        '
        'BtnAlt
        '
        Me.BtnAlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlt.Location = New System.Drawing.Point(558, 92)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(105, 38)
        Me.BtnAlt.TabIndex = 2
        Me.BtnAlt.Text = "&Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = True
        '
        'BtnGra
        '
        Me.BtnGra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGra.Location = New System.Drawing.Point(558, 48)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(105, 38)
        Me.BtnGra.TabIndex = 1
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = True
        '
        'BtnNov
        '
        Me.BtnNov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.Location = New System.Drawing.Point(558, 4)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(105, 38)
        Me.BtnNov.TabIndex = 0
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = True
        '
        'GrpLoc
        '
        Me.GrpLoc.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Controls.Add(Me.BtnOk)
        Me.GrpLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GrpLoc.Location = New System.Drawing.Point(11, 327)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Size = New System.Drawing.Size(362, 108)
        Me.GrpLoc.TabIndex = 112
        Me.GrpLoc.TabStop = False
        Me.GrpLoc.Text = "Localizar por código "
        Me.GrpLoc.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Total A pagar"
        '
        'ChkCampo
        '
        Me.ChkCampo.AutoSize = True
        Me.ChkCampo.Location = New System.Drawing.Point(189, 149)
        Me.ChkCampo.Name = "ChkCampo"
        Me.ChkCampo.Size = New System.Drawing.Size(49, 17)
        Me.ChkCampo.TabIndex = 10
        Me.ChkCampo.Tag = "x"
        Me.ChkCampo.Text = "ativo"
        Me.ChkCampo.UseVisualStyleBackColor = True
        '
        'TxtCodJogador
        '
        Me.TxtCodJogador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodJogador.Location = New System.Drawing.Point(188, 174)
        Me.TxtCodJogador.Name = "TxtCodJogador"
        Me.TxtCodJogador.Size = New System.Drawing.Size(50, 26)
        Me.TxtCodJogador.TabIndex = 11
        Me.TxtCodJogador.Tag = "x"
        '
        'TxtTotgeral
        '
        Me.TxtTotgeral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTotgeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotgeral.Location = New System.Drawing.Point(189, 213)
        Me.TxtTotgeral.Name = "TxtTotgeral"
        Me.TxtTotgeral.Size = New System.Drawing.Size(245, 26)
        Me.TxtTotgeral.TabIndex = 13
        Me.TxtTotgeral.Tag = "x"
        '
        'txtDia
        '
        Me.txtDia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDia.Enabled = False
        Me.txtDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDia.Location = New System.Drawing.Point(188, 13)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(126, 26)
        Me.txtDia.TabIndex = 114
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 20)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "Data"
        '
        'LblCodJog
        '
        Me.LblCodJog.AutoSize = True
        Me.LblCodJog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodJog.Location = New System.Drawing.Point(309, 174)
        Me.LblCodJog.Name = "LblCodJog"
        Me.LblCodJog.Size = New System.Drawing.Size(0, 20)
        Me.LblCodJog.TabIndex = 115
        '
        'BtnNome
        '
        Me.BtnNome.Location = New System.Drawing.Point(245, 176)
        Me.BtnNome.Name = "BtnNome"
        Me.BtnNome.Size = New System.Drawing.Size(28, 23)
        Me.BtnNome.TabIndex = 12
        Me.BtnNome.Text = "..."
        Me.BtnNome.UseVisualStyleBackColor = True
        '
        'LblHorarioIni
        '
        Me.LblHorarioIni.AutoSize = True
        Me.LblHorarioIni.Location = New System.Drawing.Point(186, 87)
        Me.LblHorarioIni.Name = "LblHorarioIni"
        Me.LblHorarioIni.Size = New System.Drawing.Size(55, 13)
        Me.LblHorarioIni.TabIndex = 9
        Me.LblHorarioIni.Text = "HrEntrada"
        '
        'ChkPago
        '
        Me.ChkPago.AutoSize = True
        Me.ChkPago.Location = New System.Drawing.Point(188, 256)
        Me.ChkPago.Name = "ChkPago"
        Me.ChkPago.Size = New System.Drawing.Size(43, 17)
        Me.ChkPago.TabIndex = 14
        Me.ChkPago.Tag = "x"
        Me.ChkPago.Text = "Sim"
        Me.ChkPago.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 20)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "Pago"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 20)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Forma de pagamento"
        '
        'CmbTipoDePagamento
        '
        Me.CmbTipoDePagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoDePagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipoDePagamento.FormattingEnabled = True
        Me.CmbTipoDePagamento.Items.AddRange(New Object() {"", "Dinheiro", "Debito", "Credito"})
        Me.CmbTipoDePagamento.Location = New System.Drawing.Point(189, 278)
        Me.CmbTipoDePagamento.Name = "CmbTipoDePagamento"
        Me.CmbTipoDePagamento.Size = New System.Drawing.Size(154, 28)
        Me.CmbTipoDePagamento.TabIndex = 15
        Me.CmbTipoDePagamento.Tag = "x"
        '
        'LblHorarioSaida
        '
        Me.LblHorarioSaida.AutoSize = True
        Me.LblHorarioSaida.Location = New System.Drawing.Point(185, 117)
        Me.LblHorarioSaida.Name = "LblHorarioSaida"
        Me.LblHorarioSaida.Size = New System.Drawing.Size(0, 13)
        Me.LblHorarioSaida.TabIndex = 123
        Me.LblHorarioSaida.Tag = "x"
        '
        'DgvComanda2
        '
        Me.DgvComanda2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvComanda2.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DgvComanda2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvComanda2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DgvComanda2.Enabled = False
        Me.DgvComanda2.Location = New System.Drawing.Point(11, 689)
        Me.DgvComanda2.Name = "DgvComanda2"
        Me.DgvComanda2.Size = New System.Drawing.Size(652, 167)
        Me.DgvComanda2.TabIndex = 125
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Codentra"
        Me.Column1.HeaderText = "Comanda"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Codjoga"
        Me.Column2.HeaderText = "Codigo do jogador"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "TabCadJogador.nome"
        Me.Column3.HeaderText = "Nome"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "TabCadProdLanco.nome"
        Me.Column4.HeaderText = "Produto"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "QtdTotal"
        Me.Column5.HeaderText = "Quantidade"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Total"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column6.HeaderText = "Valor"
        Me.Column6.Name = "Column6"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 456)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 20)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "Gastos Armaria"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 666)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 20)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "Gastos Lanchonete"
        '
        'DgvComanda
        '
        Me.DgvComanda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvComanda.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvComanda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DgvComanda.Enabled = False
        Me.DgvComanda.Location = New System.Drawing.Point(12, 479)
        Me.DgvComanda.Name = "DgvComanda"
        Me.DgvComanda.Size = New System.Drawing.Size(652, 167)
        Me.DgvComanda.TabIndex = 130
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codentra"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Comanda"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Codjoga"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo do jogador"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TabCadJogador.nome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TabCadProdArmaria.nome"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Produto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "QtdTotal"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Quantidade"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "totpre"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn6.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'FrmComanda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(671, 867)
        Me.Controls.Add(Me.DgvComanda)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DgvComanda2)
        Me.Controls.Add(Me.LblHorarioSaida)
        Me.Controls.Add(Me.CmbTipoDePagamento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ChkPago)
        Me.Controls.Add(Me.LblHorarioIni)
        Me.Controls.Add(Me.BtnNome)
        Me.Controls.Add(Me.LblCodJog)
        Me.Controls.Add(Me.txtDia)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtTotgeral)
        Me.Controls.Add(Me.TxtCodJogador)
        Me.Controls.Add(Me.ChkCampo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnExc)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.GrpLoc)
        Me.MinimumSize = New System.Drawing.Size(687, 906)
        Me.Name = "FrmComanda"
        Me.Text = "Comanda"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        CType(Me.DgvComanda2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvComanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtLoc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnOk As Button
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLoc As Button
    Friend WithEvents BtnSai As Button
    Friend WithEvents BtnCan As Button
    Friend WithEvents BtnExc As Button
    Friend WithEvents BtnAlt As Button
    Friend WithEvents BtnGra As Button
    Friend WithEvents BtnNov As Button
    Friend WithEvents GrpLoc As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ChkCampo As CheckBox
    Friend WithEvents TxtCodJogador As TextBox
    Friend WithEvents TxtTotgeral As TextBox
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblCodJog As System.Windows.Forms.Label
    Friend WithEvents BtnNome As System.Windows.Forms.Button
    Friend WithEvents LblHorarioIni As System.Windows.Forms.Label
    Friend WithEvents ChkPago As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbTipoDePagamento As System.Windows.Forms.ComboBox
    Friend WithEvents LblHorarioSaida As System.Windows.Forms.Label
    Friend WithEvents DgvComanda2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DgvComanda As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

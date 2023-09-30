<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConComandaPeriodo
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
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.DtpFim = New System.Windows.Forms.DateTimePicker()
        Me.DtpIni = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtmImp = New System.Windows.Forms.Button()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnOK
        '
        Me.BtnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnOK.Location = New System.Drawing.Point(425, 29)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(87, 31)
        Me.BtnOK.TabIndex = 45
        Me.BtnOK.Text = "Ok"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'DtpFim
        '
        Me.DtpFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFim.Location = New System.Drawing.Point(324, 34)
        Me.DtpFim.Name = "DtpFim"
        Me.DtpFim.Size = New System.Drawing.Size(85, 20)
        Me.DtpFim.TabIndex = 44
        '
        'DtpIni
        '
        Me.DtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIni.Location = New System.Drawing.Point(116, 35)
        Me.DtpIni.Name = "DtpIni"
        Me.DtpIni.Size = New System.Drawing.Size(85, 20)
        Me.DtpIni.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Data Final"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Data Inicial"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(820, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Visualizar relatório"
        '
        'BtmImp
        '
        Me.BtmImp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtmImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtmImp.Location = New System.Drawing.Point(863, 32)
        Me.BtmImp.Name = "BtmImp"
        Me.BtmImp.Size = New System.Drawing.Size(95, 28)
        Me.BtmImp.TabIndex = 126
        Me.BtmImp.Text = "Relatório"
        Me.BtmImp.UseVisualStyleBackColor = True
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Nome, Me.Column7, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column8, Me.Column9})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(12, 86)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(946, 201)
        Me.DgdGrade.TabIndex = 129
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Codentra"
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Nome
        '
        Me.Nome.DataPropertyName = "nome"
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.Width = 60
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Data"
        Me.Column7.HeaderText = "Data"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 55
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "hrentrada"
        Me.Column2.HeaderText = "Horario de Entrada"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 111
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "campo"
        Me.Column3.HeaderText = "Campo"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 65
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Codjoga"
        Me.Column4.HeaderText = "Codigo do Jogador"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 111
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "hrsaida"
        Me.Column5.HeaderText = "Horario de saida"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 78
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "totGeral"
        Me.Column6.HeaderText = "Total Geral"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 78
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "pago"
        Me.Column8.HeaderText = "Pago"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 57
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "Tipodepagamento"
        Me.Column9.HeaderText = "Modo De Pagamento"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 122
        '
        'FrmConComandaPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(970, 299)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtmImp)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.DtpFim)
        Me.Controls.Add(Me.DtpIni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.MinimumSize = New System.Drawing.Size(986, 338)
        Me.Name = "FrmConComandaPeriodo"
        Me.Text = "Consulta Comanda Por Período"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents DtpFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtmImp As System.Windows.Forms.Button
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

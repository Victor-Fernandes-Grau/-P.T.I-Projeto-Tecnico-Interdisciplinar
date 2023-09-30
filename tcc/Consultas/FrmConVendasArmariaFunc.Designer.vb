<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConVendasArmariaFunc
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtmImp = New System.Windows.Forms.Button()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNom
        '
        Me.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(16, 32)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(282, 26)
        Me.TxtNom.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Digite o nome ou código do funcionário"
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
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column9, Me.Column10, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(12, 74)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(1080, 239)
        Me.DgdGrade.TabIndex = 54
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CodLoc"
        Me.Column1.HeaderText = "Codigo Locação"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 101
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Codentra"
        Me.Column2.HeaderText = "Numero da comanda "
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 123
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "TabCadJogador.nome"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "R$0,00"
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "Nome Jogador"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 93
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "Codfunc"
        Me.Column9.HeaderText = "Codigo do funcionario"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 123
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "TabCadFunc.nome"
        Me.Column10.HeaderText = "Nome do funcionario"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 119
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Codproarma"
        Me.Column4.HeaderText = "Codigo do produto"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 109
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "TabCadProdArmaria.nome"
        Me.Column5.HeaderText = "Nome do produto"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 105
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "numserie"
        Me.Column6.HeaderText = "Numero de serie"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 80
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "data"
        Me.Column7.HeaderText = "Data"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 55
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "preco"
        Me.Column8.HeaderText = "Preço"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 60
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(954, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Visualizar relatório"
        '
        'BtmImp
        '
        Me.BtmImp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtmImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtmImp.Location = New System.Drawing.Point(997, 32)
        Me.BtmImp.Name = "BtmImp"
        Me.BtmImp.Size = New System.Drawing.Size(95, 26)
        Me.BtmImp.TabIndex = 69
        Me.BtmImp.Text = "Relatório"
        Me.BtmImp.UseVisualStyleBackColor = True
        '
        'FrmConVendasArmariaFunc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1104, 325)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtmImp)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.Label2)
        Me.MinimumSize = New System.Drawing.Size(1120, 364)
        Me.Name = "FrmConVendasArmariaFunc"
        Me.Text = "Consulta Vendas Armaria Por Funcionario"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtmImp As System.Windows.Forms.Button
End Class

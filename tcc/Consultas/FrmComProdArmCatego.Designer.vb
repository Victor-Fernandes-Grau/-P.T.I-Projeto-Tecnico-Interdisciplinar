<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComProdArmCatego
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmbcate = New System.Windows.Forms.ComboBox()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtmImp = New System.Windows.Forms.Button()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 20)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Selecione a Categoria"
        '
        'Cmbcate
        '
        Me.Cmbcate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbcate.FormattingEnabled = True
        Me.Cmbcate.Items.AddRange(New Object() {"", "Arma", "Capacete / Mascara", "Colete", "BBs"})
        Me.Cmbcate.Location = New System.Drawing.Point(12, 36)
        Me.Cmbcate.Name = "Cmbcate"
        Me.Cmbcate.Size = New System.Drawing.Size(154, 28)
        Me.Cmbcate.TabIndex = 41
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
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(12, 70)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(571, 230)
        Me.DgdGrade.TabIndex = 42
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Codproarma"
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "tipo"
        Me.Column2.HeaderText = "Tipo"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 53
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "nome"
        Me.Column3.HeaderText = "Nome"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 60
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "numserie"
        Me.Column4.HeaderText = "Numero De Serie"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 82
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "modelo"
        Me.Column5.HeaderText = "Modelo"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 67
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Documento"
        Me.Column6.HeaderText = "Documento"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 87
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "qtd"
        Me.Column7.HeaderText = "Qtd"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 49
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "preco"
        Me.Column8.HeaderText = "Preço"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 60
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(445, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Visualizar relatório"
        '
        'BtmImp
        '
        Me.BtmImp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtmImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtmImp.Location = New System.Drawing.Point(488, 36)
        Me.BtmImp.Name = "BtmImp"
        Me.BtmImp.Size = New System.Drawing.Size(95, 28)
        Me.BtmImp.TabIndex = 43
        Me.BtmImp.Text = "Relatório"
        Me.BtmImp.UseVisualStyleBackColor = True
        '
        'FrmComProdArmCatego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(598, 315)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtmImp)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.Cmbcate)
        Me.Controls.Add(Me.Label2)
        Me.MinimumSize = New System.Drawing.Size(614, 354)
        Me.Name = "FrmComProdArmCatego"
        Me.Text = "Consulta Produtos Armaria Por Categoria"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cmbcate As System.Windows.Forms.ComboBox
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtmImp As System.Windows.Forms.Button
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConManuArma
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4111 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column45555 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTot = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtmImp = New System.Windows.Forms.Button()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(627, 341)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Total Vendido"
        '
        'TxtNom
        '
        Me.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(12, 35)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(282, 26)
        Me.TxtNom.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 20)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Digite o nome ou código da Arma"
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
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column4111, Me.Column4, Me.Column45555, Me.preco, Me.Column6, Me.Column7})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(12, 67)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(817, 265)
        Me.DgdGrade.TabIndex = 59
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Codmanu"
        Me.Column3.HeaderText = "Cod. Manutenção"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 107
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codarmero"
        Me.Column1.HeaderText = "Cod. Armero"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 83
        '
        'Column4111
        '
        Me.Column4111.DataPropertyName = "TabArmero.nome"
        Me.Column4111.HeaderText = "Nome Armero"
        Me.Column4111.Name = "Column4111"
        Me.Column4111.Width = 88
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Códarma"
        Me.Column4.HeaderText = "Cod. Arma"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 75
        '
        'Column45555
        '
        Me.Column45555.DataPropertyName = "TabCadProdArmaria.nome"
        Me.Column45555.HeaderText = "Nome Arma"
        Me.Column45555.Name = "Column45555"
        Me.Column45555.Width = 80
        '
        'preco
        '
        Me.preco.DataPropertyName = "preco"
        Me.preco.HeaderText = "Preço Manutenção"
        Me.preco.Name = "preco"
        Me.preco.Width = 113
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "dtinicio"
        Me.Column6.HeaderText = "Data Inicio"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 77
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "dtfim"
        Me.Column7.HeaderText = "Data Fim"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 69
        '
        'TxtTot
        '
        Me.TxtTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTot.Enabled = False
        Me.TxtTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTot.Location = New System.Drawing.Point(740, 338)
        Me.TxtTot.Name = "TxtTot"
        Me.TxtTot.Size = New System.Drawing.Size(89, 26)
        Me.TxtTot.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(691, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Visualizar relatório"
        '
        'BtmImp
        '
        Me.BtmImp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtmImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtmImp.Location = New System.Drawing.Point(734, 32)
        Me.BtmImp.Name = "BtmImp"
        Me.BtmImp.Size = New System.Drawing.Size(95, 26)
        Me.BtmImp.TabIndex = 61
        Me.BtmImp.Text = "Relatório"
        Me.BtmImp.UseVisualStyleBackColor = True
        '
        'FrmConManuArma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(845, 385)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtmImp)
        Me.Controls.Add(Me.TxtTot)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.Label2)
        Me.MinimumSize = New System.Drawing.Size(861, 424)
        Me.Name = "FrmConManuArma"
        Me.Text = "Consulta Manutenção Arma"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4111 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column45555 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtTot As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtmImp As System.Windows.Forms.Button
End Class

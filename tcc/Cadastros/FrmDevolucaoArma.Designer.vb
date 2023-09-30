<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDevolucaoArma
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
        Me.lbldata = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.TxtQtd = New System.Windows.Forms.TextBox()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.TxtPro = New System.Windows.Forms.TextBox()
        Me.BtnLocPro = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldata
        '
        Me.lbldata.AutoSize = True
        Me.lbldata.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldata.Location = New System.Drawing.Point(151, 18)
        Me.lbldata.Name = "lbldata"
        Me.lbldata.Size = New System.Drawing.Size(44, 20)
        Me.lbldata.TabIndex = 159
        Me.lbldata.Text = "Data"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(323, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 20)
        Me.Label9.TabIndex = 157
        Me.Label9.Text = "Qtd"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(120, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "Produto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Código"
        '
        'BtnCan
        '
        Me.BtnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCan.Location = New System.Drawing.Point(596, 56)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(105, 38)
        Me.BtnCan.TabIndex = 153
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = True
        '
        'BtnSai
        '
        Me.BtnSai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSai.Location = New System.Drawing.Point(596, 100)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(105, 38)
        Me.BtnSai.TabIndex = 152
        Me.BtnSai.Text = "Sa&ir"
        Me.BtnSai.UseVisualStyleBackColor = True
        '
        'BtnNov
        '
        Me.BtnNov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.Location = New System.Drawing.Point(596, 12)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(105, 38)
        Me.BtnNov.TabIndex = 151
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = True
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(16, 118)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(570, 201)
        Me.DgdGrade.TabIndex = 149
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
        'Column5
        '
        Me.Column5.HeaderText = "Qtd"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 49
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(364, 76)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(42, 26)
        Me.BtnOk.TabIndex = 146
        Me.BtnOk.Text = "&Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'TxtQtd
        '
        Me.TxtQtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQtd.Location = New System.Drawing.Point(323, 76)
        Me.TxtQtd.Name = "TxtQtd"
        Me.TxtQtd.Size = New System.Drawing.Size(35, 26)
        Me.TxtQtd.TabIndex = 144
        Me.TxtQtd.Tag = "x"
        '
        'TxtNom
        '
        Me.TxtNom.Enabled = False
        Me.TxtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(120, 76)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(197, 26)
        Me.TxtNom.TabIndex = 142
        Me.TxtNom.Tag = "x"
        '
        'TxtPro
        '
        Me.TxtPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPro.Location = New System.Drawing.Point(17, 76)
        Me.TxtPro.Name = "TxtPro"
        Me.TxtPro.Size = New System.Drawing.Size(51, 26)
        Me.TxtPro.TabIndex = 141
        Me.TxtPro.Tag = "x"
        '
        'BtnLocPro
        '
        Me.BtnLocPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLocPro.Location = New System.Drawing.Point(74, 76)
        Me.BtnLocPro.Name = "BtnLocPro"
        Me.BtnLocPro.Size = New System.Drawing.Size(34, 26)
        Me.BtnLocPro.TabIndex = 140
        Me.BtnLocPro.Text = "..."
        Me.BtnLocPro.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 20)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "Data"
        '
        'FrmDevolucaoArma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 338)
        Me.Controls.Add(Me.lbldata)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.TxtQtd)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.TxtPro)
        Me.Controls.Add(Me.BtnLocPro)
        Me.Controls.Add(Me.Label5)
        Me.MinimumSize = New System.Drawing.Size(729, 377)
        Me.Name = "FrmDevolucaoArma"
        Me.Text = "Devoluçáo das Armas "
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldata As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnSai As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents TxtQtd As System.Windows.Forms.TextBox
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents TxtPro As System.Windows.Forms.TextBox
    Friend WithEvents BtnLocPro As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

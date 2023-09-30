<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConVendasCliente
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
        Me.btnMostrarDados = New System.Windows.Forms.Button()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMostrarDados
        '
        Me.btnMostrarDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnMostrarDados.Location = New System.Drawing.Point(21, 12)
        Me.btnMostrarDados.Name = "btnMostrarDados"
        Me.btnMostrarDados.Size = New System.Drawing.Size(135, 50)
        Me.btnMostrarDados.TabIndex = 38
        Me.btnMostrarDados.Text = "Mostrar Dados"
        Me.btnMostrarDados.UseVisualStyleBackColor = True
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
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(21, 68)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(468, 230)
        Me.DgdGrade.TabIndex = 37
        '
        'FrmConVendasCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(506, 318)
        Me.Controls.Add(Me.btnMostrarDados)
        Me.Controls.Add(Me.DgdGrade)
        Me.MinimumSize = New System.Drawing.Size(522, 357)
        Me.Name = "FrmConVendasCliente"
        Me.Text = "Consulta Vendas Jogador"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMostrarDados As System.Windows.Forms.Button
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
End Class

Public Class FrmComFunc

    Public quemChamou As String = ""
    Dim objfunc As New ClsFuncionario
    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged
        DgdGrade.DataSource = objfunc.localizarRetornoTable(TxtNom.Text)
    End Sub

    Private Sub FrmConCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
        TxtNom.Clear()
        TxtNom.Focus()
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If quemChamou.ToUpper = "FRMLANCONETE" Then
            FrmLanconete.TxtCodFunc.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmLanconete.lblNomFunc.Text = DgdGrade.CurrentRow.Cells(1).Value

        ElseIf quemChamou.ToUpper = "FRMARMARIA" Then
            FrmArmaria.TxtCodFunc.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmArmaria.lblNomFunc.Text = DgdGrade.CurrentRow.Cells(1).Value

        ElseIf quemChamou.ToUpper = "FRMMENUGERENTE" Then
            FrmCadFunc.quemChamou = Me.Name
            FrmCadFunc.campoChave = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadFunc.Show()
            FrmCadFunc.MdiParent = FrmMenuGerente
        End If
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub BtmImp_Click(sender As Object, e As EventArgs) Handles BtmImp.Click
        Dim rpt As New CrpCadastroDeFuncionario
        rpt.SetDataSource(DgdGrade.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de Funcionario"
        FrmImp.ShowDialog()
    End Sub
End Class
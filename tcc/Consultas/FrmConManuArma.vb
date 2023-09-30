Public Class FrmConManuArma
    Public quemChamou As String = ""
    Dim objArma As New ClsManuArma
    Dim valorTotal As Single

    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged
        DgdGrade.DataSource = objArma.vendasArmariaArma(TxtNom.Text)
        valorTotal = objArma.TotArmariaArma(TxtNom.Text)
        TxtTot.Text = Format(valorTotal, "0.00")
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
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


    Private Sub BtmImp_Click(sender As Object, e As EventArgs) Handles BtmImp.Click
        Dim rpt As New CrpManutençaoSql
        rpt.SetDataSource(DgdGrade.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio manutenção da arma"
        FrmImp.ShowDialog()
    End Sub
End Class
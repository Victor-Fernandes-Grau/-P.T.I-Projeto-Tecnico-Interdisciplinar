Public Class FrmConManuArmaData
    Dim objManuArma As New ClsManuArma
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        DgdGrade.DataSource = objManuArma.Localizar_porData(DtpData.Text)
    End Sub

    Private Sub BtmImp_Click(sender As Object, e As EventArgs) Handles BtmImp.Click
        Dim rpt As New CrpManutençaoSql
        rpt.SetDataSource(DgdGrade.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio manutenção da arma"
        FrmImp.ShowDialog()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
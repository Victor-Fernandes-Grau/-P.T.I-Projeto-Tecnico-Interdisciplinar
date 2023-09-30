Public Class FrmComTipoDPagamento
    Dim objcom As New ClsComanda
    Dim objControle As ClsControle


    Private Sub CmbTipoDePagamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoDePagamento.SelectedIndexChanged
        DgdGrade.DataSource = objcom.localizarformadepag(CmbTipoDePagamento.Text)
    End Sub

    Private Sub BtmImp_Click(sender As Object, e As EventArgs) Handles BtmImp.Click
        Dim rpt As New CrpComandaSql
        rpt.SetDataSource(DgdGrade.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio da Comanda"
        FrmImp.ShowDialog()
    End Sub
End Class
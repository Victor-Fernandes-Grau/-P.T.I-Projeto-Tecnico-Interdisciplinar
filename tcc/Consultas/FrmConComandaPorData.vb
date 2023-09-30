Public Class FrmConComandaPorData
    Dim objcomanda As New ClsComanda
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        DgdGrade.DataSource = objcomanda.Localizar_porData(DtpData.Text)
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
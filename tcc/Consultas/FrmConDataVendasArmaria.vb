Public Class FrmConDataVendasArmaria
    Dim objArmaria As New ClsArmaria
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        DgdGrade.DataSource = objArmaria.Localizar_porDataLoc(DtpData.Text)
    End Sub

    Private Sub BtmImp_Click(sender As Object, e As EventArgs) Handles BtmImp.Click
        Dim rpt As New CrpVendaArmariaFunc
        rpt.SetDataSource(DgdGrade.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de Vendas Armaria"
        FrmImp.ShowDialog()
    End Sub
End Class
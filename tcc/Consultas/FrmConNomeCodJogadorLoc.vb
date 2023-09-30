Public Class FrmConNomeCodJogadorLoc
    Public quemChamou As String = ""
    Dim objLoc As New ClsItensLoc
    '   Dim valorTotal As Single
    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged
        DgdGrade.DataSource = objLoc.CodOuNomejoga(TxtNom.Text)
        '   valorTotal = objCli.TotLancoCli(TxtNom.Text)
        '   TxtTot.Text = Format(valorTotal, "0.00")
    End Sub

    Private Sub BtmImp_Click(sender As Object, e As EventArgs) Handles BtmImp.Click
        Dim rpt As New CrpLocaçaoSql
        rpt.SetDataSource(DgdGrade.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio Locação"
        FrmImp.ShowDialog()
    End Sub
End Class
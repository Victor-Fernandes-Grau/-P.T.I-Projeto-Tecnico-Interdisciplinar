Public Class FrmConVendasLancoCli
    Public quemChamou As String = ""
    Dim objCli As New ClsJogador
    Dim valorTotal As Single

   
    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged
        DataGridView1.DataSource = objCli.vendasLancoCli(TxtNom.Text)
    End Sub

    Private Sub BtmImp_Click(sender As Object, e As EventArgs) Handles BtmImp.Click
        Dim rpt As New CrpVendaLanchoneteSql
        rpt.SetDataSource(DataGridView1.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio venda lanchonete"
        FrmImp.ShowDialog()
    End Sub
End Class
Public Class FrmComProdLancCatego


    Dim objlan As New ClsLanco
    Private Sub CmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipo.SelectedIndexChanged
        DgdGrade.DataSource = objlan.localizarRetornotipo(CmbTipo.Text)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BtmImp_Click(sender As Object, e As EventArgs) Handles BtmImp.Click
        Dim rpt As New CrpCadastroProdutoLancho
        rpt.SetDataSource(DgdGrade.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de jogador"
        FrmImp.ShowDialog()
    End Sub
End Class
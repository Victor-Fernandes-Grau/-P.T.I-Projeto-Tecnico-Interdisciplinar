Public Class FrmComProdArmCatego
  
    Dim objarm As New ClsArmaria

    Private Sub Cmbcate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbcate.SelectedIndexChanged
        
        DgdGrade.DataSource = objarm.localizarRetornotipo(Cmbcate.Text)
    End Sub

    Private Sub BtmImp_Click(sender As Object, e As EventArgs) Handles BtmImp.Click
        Dim rpt As New CrpCadastroProdutoArmaria
        rpt.SetDataSource(DgdGrade.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de jogador"
        FrmImp.ShowDialog()
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub
End Class
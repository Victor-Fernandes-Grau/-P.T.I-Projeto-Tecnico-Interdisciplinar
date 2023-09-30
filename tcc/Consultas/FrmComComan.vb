Public Class FrmComComan

    Public quemChamou As String = ""
    Dim objcom As New ClsComanda


    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged
        DgdGrade.DataSource = objcom.localizarNomeCodcli(TxtNom.Text)
    End Sub

    Private Sub FrmConCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
        TxtNom.Clear()
        TxtNom.Focus()
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If quemChamou.ToUpper = "FRMLANCONETE" Then
            FrmLanconete.TxtCli.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmLanconete.LblCli.Text = DgdGrade.CurrentRow.Cells(9).Value

        ElseIf quemChamou.ToUpper = "FRMARMARIA" Then
            FrmArmaria.TxtCli.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmArmaria.LblCli.Text = DgdGrade.CurrentRow.Cells(9).Value

        ElseIf quemChamou.ToUpper = "FRMMENUGERENTE" Then
            FrmComanda.quemChamou = Me.Name
            FrmComanda.campoChave = DgdGrade.CurrentRow.Cells(0).Value
            FrmComanda.Show()
            FrmComanda.MdiParent = FrmMenuGerente
        End If
        Me.Close()
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
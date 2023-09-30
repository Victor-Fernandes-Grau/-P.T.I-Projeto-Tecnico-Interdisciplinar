Public Class FrmComLanco

    Public quemChamou As String = ""
    Dim objlan As New ClsLanco
    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged
        DgdGrade.DataSource = objlan.localizarRetornoTable(TxtNom.Text)
    End Sub

    Private Sub FrmConCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
        TxtNom.Clear()
        TxtNom.Focus()
    End Sub

    Private Sub FrmConCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If quemChamou.ToUpper = "FRMLANCONETE" Then
            FrmLanconete.TxtPro.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmLanconete.TxtNom.Text = DgdGrade.CurrentRow.Cells(2).Value
            FrmLanconete.TxtPre.Text = DgdGrade.CurrentRow.Cells(4).Value

        ElseIf quemChamou.ToUpper = "FRMMENUGERENTE" Then
            FrmCadProdLanco.quemChamou = Me.Name
            FrmCadProdLanco.campoChave = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadProdLanco.Show()
            FrmCadProdLanco.MdiParent = FrmMenuGerente
        End If
        Me.Close()
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
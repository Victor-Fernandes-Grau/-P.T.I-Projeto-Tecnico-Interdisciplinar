Public Class FrmComArmero


    Public quemChamou As String = ""
    Dim objarme As New ClsArmero
    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged
        DgdGrade.DataSource = objarme.localizarRetornoTable(TxtNom.Text)
    End Sub

    Private Sub FrmConCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
        TxtNom.Clear()
        TxtNom.Focus()
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If  quemChamou.ToUpper = "FRMMANUTENCAOARMA" Then
            FrmManutencaoArma.TxtCodArmero.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmManutencaoArma.lblNomArmero.Text = DgdGrade.CurrentRow.Cells(1).Value

        ElseIf quemChamou.ToUpper = "FRMMENUGERENTE" Then
            FrmCadArmero.quemChamou = Me.Name
            FrmCadArmero.campoChave = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadArmero.Show()
            FrmCadArmero.MdiParent = FrmMenuGerente
        End If
        Me.Close()
    End Sub

    Private Sub BtmImp_Click(sender As Object, e As EventArgs) Handles BtmImp.Click
        Dim rpt As New CrpCadastroDoArmero
        rpt.SetDataSource(DgdGrade.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio do Armero"
        FrmImp.ShowDialog()

    End Sub

    Private Sub FrmComArmero_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class FrmComArmaria

    Public quemChamou As String = ""
    Dim objarm As New ClsArmaria
    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged


        DgdGrade.DataSource = objarm.localizarRetornoNomeCodigo(TxtNom.Text)

    End Sub

    Private Sub FrmConCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
        TxtNom.Clear()
        TxtNom.Focus()
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If quemChamou.ToUpper = "FRMARMARIA" Then
            FrmArmaria.TxtPro.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmArmaria.TxtNom.Text = DgdGrade.CurrentRow.Cells(2).Value
            FrmArmaria.TxtPre.Text = DgdGrade.CurrentRow.Cells(7).Value

        ElseIf quemChamou.ToUpper = "FRMMANUTENCAOARMA" Then
            FrmManutencaoArma.TxtCodArma.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmManutencaoArma.lblNumArma.Text = DgdGrade.CurrentRow.Cells(1).Value

        ElseIf quemChamou.ToUpper = "FRMDEVOLUCAOARMA" Then
            FrmDevolucaoArma.TxtPro.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmDevolucaoArma.TxtNom.Text = DgdGrade.CurrentRow.Cells(1).Value


        ElseIf quemChamou.ToUpper = "FRMMENUGERENTE" Then
            FrmCadProdArmaria.quemChamou = Me.Name
            FrmCadProdArmaria.campoChave = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadProdArmaria.Show()
            FrmCadProdArmaria.MdiParent = FrmMenuGerente
        End If
        Me.Close()
    End Sub

    Private Sub BtmImp_Click(sender As Object, e As EventArgs) Handles BtmImp.Click
        Dim rpt As New CrpCadastroProdutoArmaria
        rpt.SetDataSource(DgdGrade.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de Equipamentos"
        FrmImp.ShowDialog()
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub FrmComArmaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
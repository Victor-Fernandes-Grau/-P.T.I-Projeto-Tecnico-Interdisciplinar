Public Class FrmComJogador

    Public quemChamou As String = ""
    Dim objjog As New ClsJogador
    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged
        DgdGrade.DataSource = objjog.localizarRetornoTable(TxtNom.Text)
    End Sub

    Private Sub FrmConCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
        TxtNom.Clear()
        TxtNom.Focus()
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If quemChamou.ToUpper = "FRMCOMANDA" Then
            ' If DgdGrade.CurrentRow.Cells(0).Value =
            FrmComanda.TxtCodJogador.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmComanda.LblCodJog.Text = DgdGrade.CurrentRow.Cells(2).Value

        ElseIf quemChamou.ToUpper = "FRMMENUGERENTE" Or quemChamou.ToUpper = "FrmMenuFuncionario" Then
            FrmCadJogador.quemChamou = Me.Name
            FrmCadJogador.campoChave = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadJogador.Show()
            FrmCadJogador.MdiParent = FrmMenuGerente
        End If
            Me.Close()
    End Sub

    
    Private Sub BtmImp_Click(sender As Object, e As EventArgs) Handles BtmImp.Click
        Dim rpt As New CrpCadastroDeJogador
        rpt.SetDataSource(DgdGrade.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de jogador"
        FrmImp.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

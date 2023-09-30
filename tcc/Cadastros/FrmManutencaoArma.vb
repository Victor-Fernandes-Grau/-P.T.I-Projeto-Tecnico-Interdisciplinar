Public Class FrmManutencaoArma
    Dim objArmaria As New ClsArmaria
    Dim objArmero As New ClsArmero
    Dim objControle As New ClsControle
    Dim objManu As New ClsManuArma
    Dim novo As Boolean
    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Limpar_tela(Me)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtCodArma.Focus()
        dtpInicio.Enabled = False
        BtnArma.Enabled = True
        BtnArmero.Enabled = True
        novo = True
        lblNomArmero.Text = ""
        lblNumArma.Text = ""

    End Sub

    Private Sub FrmManutencaoArma_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then SendKeys.Send("{tab}")
    End Sub

    Private Sub FrmManutencaoArma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)
        objControle.Limpar_tela(Me)
        BtnExc.Enabled = False
        BtnAlt.Enabled = False
        BtnImp.Enabled = False
        GrpLoc.Visible = False
        BtnCan.Enabled = True
        BtnArma.Enabled = False
        BtnArmero.Enabled = False
        dtpFim.Text = Today
        lblNomArmero.Text = ""
        lblNumArma.Text = ""

    End Sub

    Private Sub TxtNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtpreco.KeyPress
        e.Handled = objControle.So_numerosEvirgula(e.KeyChar)
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If dtpFim.Text < dtpInicio.Text Then
            MessageBox.Show("A data de termino tem que ser maior que a de começo")
            dtpFim.Focus()

        ElseIf TxtCodArma.Text = "" Then
            MessageBox.Show("Favor preencher o codigo da arma")
            TxtCodArma.Focus()

        ElseIf TxtCodArmero.Text = "" Then
            MessageBox.Show("Favor preencher o codigo do Armero")
            TxtCodArmero.Focus()

        ElseIf objArmaria.qtd < 0 Or objArmaria.qtd = 0 Then
            MessageBox.Show("Produto indisponivel")
            TxtCodArma.Focus()

        ElseIf objControle.Testar_vazio(Me) <> True Then
            objManu.codarma = TxtCodArma.Text
            objManu.codarmero = TxtCodArmero.Text
            objManu.dtinicio = dtpInicio.Text
            objManu.dtfim = dtpFim.Text
            objManu.preco = Txtpreco.Text
            If dtpFim.Text < Today Then
                Call devolver_estoque()
            Else
                Call baixar_estoque()
            End If


            objManu.gravar(novo)
            TxtCod.Text = objManu.codmanu

            objControle.Habilitar_botoes(Me, True)
            objControle.Habilitar_tela(Me, False)
            BtnArma.Enabled = False
            BtnArmero.Enabled = False
        End If
    End Sub
    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objManu.excluir(TxtCod.Text, TxtCodArma.Text) = True Then
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
            BtnImp.Enabled = False
        End If
    End Sub
    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click

        GrpLoc.Visible = True
        TxtLoc.Focus()
        BtnOk.Enabled = False
    End Sub
    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOk.Enabled = False
        Else
            BtnOk.Enabled = True
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If objManu.localizar(TxtLoc.Text) = True Then
            TxtLoc.Text = ""
            GrpLoc.Visible = False
            mostrar_dadosdaTela()
        Else
            TxtLoc.Text = ""
            TxtLoc.Focus()
        End If
    End Sub
    Public Sub mostrar_dadosdaTela()
        TxtCod.Text = objManu.codmanu
        TxtCodArma.Text = objManu.codarma
        TxtCodArmero.Text = objManu.codarmero
        dtpInicio.Text = objManu.dtinicio
        dtpFim.Text = objManu.dtfim
        Txtpreco.Text = objManu.preco

        Call TxtCodArma_LostFocus(Nothing, Nothing)
        Call TxtCodArmero_LostFocus(Nothing, Nothing)

        BtnExc.Enabled = True
        BtnAlt.Enabled = True
        BtnImp.Enabled = True
    End Sub
    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmManutencaoArma_Load(Nothing, Nothing)

    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtCodArma.Focus()
        BtnArma.Enabled = True
        BtnArmero.Enabled = True

        novo = False
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Close()
    End Sub




    Private Sub dtpFim_ValueChanged(sender As Object, e As EventArgs) Handles dtpFim.ValueChanged
        If dtpFim.Text < dtpInicio.Text Then
            MessageBox.Show("A data de termino tem que ser maior que a de começo")
            dtpFim.Text = Today
            dtpFim.Focus()
        End If
    End Sub

    Private Sub TxtCodArma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodArma.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub TxtCodArmero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodArmero.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub TxtCodArma_LostFocus(sender As Object, e As EventArgs) Handles TxtCodArma.LostFocus
        If TxtCodArma.Text <> "" Then
            If objArmaria.localizar(TxtCodArma.Text) Then
                lblNumArma.Text = objArmaria.numserie
            Else
                lblNumArma.Text = ""
                TxtCodArma.Clear()
                TxtCodArma.Focus()
            End If
        End If
    End Sub

    Private Sub TxtCodArmero_LostFocus(sender As Object, e As EventArgs) Handles TxtCodArmero.LostFocus
        If TxtCodArmero.Text <> "" Then
            If objArmero.localizar(TxtCodArmero.Text) Then
                lblNomArmero.Text = objArmero.nome
            Else
                lblNomArmero.Text = ""
                TxtCodArmero.Clear()
                TxtCodArmero.Focus()
            End If
        End If
    End Sub
    Private Sub baixar_estoque()
        objArmaria.baixar_estoque(TxtCodArma.Text, 1)
    End Sub
    Public Sub devolver_estoque()
        objArmaria.devolver_estoque(TxtCodArma.Text, 1)
    End Sub
    Private Sub BtnArma_Click(sender As Object, e As EventArgs) Handles BtnArma.Click
        FrmComArmaria.quemChamou = Me.Name
        FrmComArmaria.ShowDialog()
    End Sub


    Private Sub BtnArmero_Click(sender As Object, e As EventArgs) Handles BtnArmero.Click
        FrmComArmero.quemChamou = Me.Name
        FrmComArmero.ShowDialog()
    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click
        ' Dim rpt As New CrpManutençao
        '  rpt.SetDataSource(objManu.localizar(TxtCod.Text))
        ' FrmImp.CrystalReportViewer1.ReportSource = rpt
        ' rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        ' rpt.SummaryInfo.ReportComments = "Relatorio de manutenção da arma"
        ' FrmImp.ShowDialog()
    End Sub
End Class
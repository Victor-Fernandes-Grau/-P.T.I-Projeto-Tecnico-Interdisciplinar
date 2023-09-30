Public Class FrmCadProdLanco

    Dim objControle As New ClsControle
    Dim objlanco As New ClsLanco

    Public quemChamou As String = ""
    Public campoChave As Integer
    Dim novo As Boolean


    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Limpar_tela(Me)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNom.Focus()

        novo = True
    End Sub

    Private Sub FrmCadProdLanco_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
        If quemChamou.ToUpper = "FRMCOMLANCO" Then
            objlanco.localizar(campoChave)
            Call mostrar_dadosdaTela()
        End If
    End Sub

    Private Sub FrmCadProdLanco_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then SendKeys.Send("{tab}")
    End Sub


    Private Sub FrmCadProdLanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)
        objControle.Limpar_tela(Me)
        BtnExc.Enabled = False
        BtnAlt.Enabled = False
        BtnImp.Enabled = False
        GrpLoc.Visible = False
        BtnCan.Enabled = False
        CmbTipo.SelectedItem = ""



    End Sub

    Private Sub TxtCod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If CmbTipo.SelectedItem = "" Then
            MessageBox.Show("Favor selecione o tipo")
            CmbTipo.Focus()

        ElseIf objControle.Testar_vazio(Me) <> True Then
            objlanco.tipo = CmbTipo.Text
            objlanco.nome = TxtNom.Text
            objlanco.qtd = TxtQuan.Text
            objlanco.preco = TxtPreco.Text
            objlanco.gravar(novo)
            TxtCod.Text = objlanco.codigo

            objControle.Habilitar_botoes(Me, True)
            objControle.Habilitar_tela(Me, False)
        End If
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objlanco.excluir(TxtNom.Text, TxtCod.Text) = True Then
            objControle.Limpar_tela(Me)
            CmbTipo.ResetText()
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
        If objlanco.localizar(TxtLoc.Text) = True Then
            TxtLoc.Text = ""
            GrpLoc.Visible = False
            mostrar_dadosdaTela()
        Else
            TxtLoc.Text = ""
            TxtLoc.Focus()
        End If
    End Sub

    Public Sub mostrar_dadosdaTela()
        TxtCod.Text = objlanco.codigo
        CmbTipo.Text = objlanco.tipo
        TxtNom.Text = objlanco.nome
        TxtQuan.Text = objlanco.qtd
        TxtPreco.Text = objlanco.preco

        BtnExc.Enabled = True
        BtnAlt.Enabled = True
        BtnImp.Enabled = True
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmCadProdLanco_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNom.Focus()
        novo = False
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Close()
    End Sub

    Private Sub TxtPreco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPreco.KeyPress
        e.Handled = objControle.So_numerosEvirgula(e.KeyChar)
    End Sub

    Private Sub TxtQuan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtQuan.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click
        Dim rpt As New CrpCadastroProdutoLancho
        rpt.SetDataSource(objlanco.localizarRetornoTable(TxtCod.Text))
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de produtos da lanchonete"
        FrmImp.ShowDialog()
    End Sub
End Class

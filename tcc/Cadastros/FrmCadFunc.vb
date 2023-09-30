Public Class FrmCadFunc

    Dim objControle As New ClsControle
    Dim objfun As New ClsFuncionario

    Public quemChamou As String = ""
    Public campoChave As Integer

    Dim novo As Boolean


    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Limpar_tela(Me)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNom.Focus()
        CmbArea.SelectedItem = ""
        dtpDataNasc.Text = Today
        dtpDataAdmi.Text = Today
        novo = True
    End Sub

    Private Sub FrmCadFunc_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
        If quemChamou.ToUpper = "FRMCOMFUNC" Then
            objfun.localizar(campoChave)
            Call mostrar_dadosdaTela()
        End If
    End Sub

    Private Sub FrmCadFunc_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then SendKeys.Send("{tab}")
    End Sub


    Private Sub FrmCadFunc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)
        objControle.Limpar_tela(Me)
        BtnExc.Enabled = False
        BtnAlt.Enabled = False
        BtnImp.Enabled = False
        GrpLoc.Visible = False
        BtnCan.Enabled = False
        dtpDataAdmi.Text = Today
        dtpDataNasc.Text = Today
        CmbArea.ResetText()


    End Sub

    Private Sub TxtCod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If MskCpf.Text = "   .   .   -  " Then
            MessageBox.Show("Favor preencher o campo de cpf")
            MskCpf.Focus()

        ElseIf dtpDataNasc.Text = Today Then
            MessageBox.Show("Favor editar o campo de data de nascimento ou de admição")
            MskCpf.Focus()

        ElseIf objControle.Testar_vazio(Me) <> True Then
            objfun.nome = TxtNom.Text
            objfun.cpf = MskCpf.Text
            objfun.dtnasc = dtpDataNasc.Text
            objfun.dtadimicao = dtpDataAdmi.Text
            objfun.area = CmbArea.Text
            objfun.usuario = TxtUsuario.Text
            objfun.senha = TxtSenha.Text
            objfun.salario = TxtSalario.Text

            objfun.gravar(novo)
            TxtCod.Text = objfun.codigo

            objControle.Habilitar_botoes(Me, True)
            objControle.Habilitar_tela(Me, False)
        End If
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objfun.excluir(TxtNom.Text, TxtCod.Text) = True Then
            dtpDataNasc.Text = Today
            dtpDataAdmi.Text = Today
            CmbArea.ResetText()
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
            BtnImp.Enabled = False
        End If
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        BtnCan.Enabled = True
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
        If objfun.localizar(TxtLoc.Text) = True Then
            TxtLoc.Text = ""
            GrpLoc.Visible = False
            mostrar_dadosdaTela()
        Else
            TxtLoc.Text = ""
            TxtLoc.Focus()
        End If
    End Sub

    Public Sub mostrar_dadosdaTela()
        TxtCod.Text = objfun.codigo
        TxtNom.Text = objfun.nome
        MskCpf.Text = objfun.cpf
        dtpDataNasc.Text = objfun.dtnasc
        dtpDataAdmi.Text = objfun.dtadimicao
        CmbArea.Text = objfun.area
        TxtUsuario.Text = objfun.usuario
        TxtSenha.Text = objfun.senha
        TxtSalario.Text = objfun.salario

        BtnExc.Enabled = True
        BtnAlt.Enabled = True
        BtnImp.Enabled = True
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmCadFunc_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNom.Focus()
        TxtSenha.Enabled = False
        novo = False
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Close()
    End Sub

    Private Sub TxtSalario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSalario.KeyPress
        e.Handled = objControle.So_numerosEvirgula(e.KeyChar)
    End Sub

    Private Sub dtpDataAdmi_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataAdmi.ValueChanged
        If dtpDataAdmi.Text < dtpDataNasc.Text Then
            MessageBox.Show("A data de adimição não pode pode ser mais velho que a data de nascimento")
            dtpDataAdmi.Text = Today
            dtpDataAdmi.Focus()
        ElseIf dtpDataAdmi.Text > Today Then
            MessageBox.Show("A data de adimição não ocoreu ainda")
            dtpDataAdmi.Text = Today
            dtpDataAdmi.Focus()

        End If
    End Sub

    Private Sub dtpDataNasc_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataNasc.ValueChanged
        If dtpDataNasc.Text > Today Then
            MessageBox.Show("A data de nascimento não ocoreu ainda ")
            dtpDataNasc.Text = Today
            dtpDataNasc.Focus()
        End If
    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click

        Dim rpt As New CrpCadastroDeFuncionario
        rpt.SetDataSource(objfun.localizarRetornoTable(TxtCod.Text))
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de Funcionario"
        FrmImp.ShowDialog()
    End Sub
End Class
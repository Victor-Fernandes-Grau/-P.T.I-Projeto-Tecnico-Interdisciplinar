Public Class FrmCadJogador
    Dim objControle As New ClsControle
    Dim objjog As New ClsJogador
    Dim novo As Boolean
    Dim diaAtual, dianas As Date
    Dim ano As Single
    Dim qtdano As Single

    Public quemChamou As String = ""
    Public campoChave As Integer

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Limpar_tela(Me)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNom.Focus()
        TxtIdade.Enabled = False
        TxtNomrespon.Enabled = False
        MskCpfRespon.Enabled = False
        MskTelRespon.Enabled = False

        dtpDataNasc.Text = Today
        TxtIdade.Clear()
        txtDia.Enabled = False
        txtDia.Text = Today
        novo = True
    End Sub

    Private Sub FrmCadJogador_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
        If quemChamou.ToUpper = "FRMCOMJOGADOR" Then
            objjog.localizar(campoChave)
            Call mostrar_dadosdaTela()
        End If
    End Sub

    Private Sub FrmCadJogador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)
        objControle.Limpar_tela(Me)
        BtnExc.Enabled = False
        BtnAlt.Enabled = False
        BtnImp.Enabled = False
        GrpLoc.Visible = False
        BtnCan.Enabled = False
        dtpDataNasc.Text = Today
        TxtIdade.Clear()
        txtDia.Text = diaAtual
        
    End Sub

    Private Sub FrmCadJogador_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then SendKeys.Send("{tab}")
    End Sub

    Private Sub TxtCod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
     
        If MskCpf.Text = "   .   .   " Then
            MessageBox.Show("Favor preencher o campo de cpf")
            MskCpf.Focus()

        ElseIf dtpDataNasc.Text = Today Then
            MessageBox.Show("Favor edite o campo de data de nacimento")
            dtpDataNasc.Focus()
        ElseIf objControle.Testar_vazio(Me) <> True Then
            objjog.data = txtDia.Text
            objjog.nome = TxtNom.Text
            objjog.cpf = MskCpf.Text
            objjog.telefone = MskTel.Text
            objjog.dtnasc = dtpDataNasc.Text
            objjog.nomerespon = TxtNomrespon.Text
            objjog.cpfrespon = MskCpfRespon.Text
            objjog.telefonerespon = MskTelRespon.Text
            objjog.email = TxtEmail.Text
            objjog.banido = ChkBanidos.Checked

            objjog.gravar(novo)
            TxtCod.Text = objjog.codigo

            diaAtual = Today
            dianas = dtpDataNasc.Text
            qtdano = DateDiff(DateInterval.Year, dianas, diaAtual)
            TxtIdade.Text = qtdano & " anos"


            objControle.Habilitar_botoes(Me, True)
            objControle.Habilitar_tela(Me, False)
        End If
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objjog.excluir(TxtNom.Text, TxtCod.Text) = True Then
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
        If objjog.localizar(TxtLoc.Text) = True Then
            TxtLoc.Text = ""
            GrpLoc.Visible = False
            mostrar_dadosdaTela()
            TxtNomrespon.Enabled = False
            MskCpfRespon.Enabled = False
            MskTelRespon.Enabled = False
        Else
            TxtLoc.Text = ""
            TxtLoc.Focus()
        End If
    End Sub
    Public Sub mostrar_dadosdaTela()
        TxtCod.Text = objjog.codigo
        txtDia.Text = objjog.data
        TxtNom.Text = objjog.nome
        MskCpf.Text = objjog.cpf
        MskTel.Text = objjog.telefone

        diaAtual = Today
        dianas = dtpDataNasc.Text
        qtdano = DateDiff(DateInterval.Year, dianas, diaAtual)
        TxtIdade.Text = qtdano & " anos"
        

        dtpDataNasc.Text = objjog.dtnasc
        TxtNomrespon.Text = objjog.nomerespon
        MskCpfRespon.Text = objjog.cpfrespon
        MskTelRespon.Text = objjog.telefonerespon
        TxtEmail.Text = objjog.email
        ChkBanidos.Checked = objjog.banido


        TxtNomrespon.Enabled = False
        MskCpfRespon.Enabled = False
        MskTelRespon.Enabled = False
        BtnExc.Enabled = True
        BtnAlt.Enabled = True
        BtnImp.Enabled = True
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmCadJogador_Load(Nothing, Nothing)
        TxtNomrespon.Enabled = False
        MskCpfRespon.Enabled = False
        MskTelRespon.Enabled = False
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        'objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNom.Focus()
        TxtIdade.Enabled = False

        If TxtIdade.Text < "18" Then
            objControle.Habilitar_tela(Me, True)

            TxtIdade.Enabled = False
            TxtCod.Enabled = False
            txtDia.Enabled = False

        Else
            objControle.Habilitar_tela(Me, True)
            TxtIdade.Enabled = False
            TxtNomrespon.Enabled = False
            MskCpfRespon.Enabled = False
            MskTelRespon.Enabled = False
            TxtCod.Enabled = False
            txtDia.Enabled = False
        End If
        novo = False
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Close()
    End Sub





    Private Sub dtpDataNasc_TextChanged(sender As Object, e As EventArgs) Handles dtpDataNasc.TextChanged
        If TxtIdade.Text < "18" And TxtNomrespon.Text = "" Then

            TxtNomrespon.Enabled = True
            MskCpfRespon.Enabled = True
            MskTelRespon.Enabled = True

            TxtNomrespon.Tag = ""
            MskCpfRespon.Tag = ""
            MskTelRespon.Tag = ""


        Else
            TxtNomrespon.Enabled = False
            MskCpfRespon.Enabled = False
            MskTelRespon.Enabled = False
            TxtNomrespon.Tag = "x"
            MskCpfRespon.Tag = "x"
            MskTelRespon.Tag = "x"

        End If
    End Sub



    Private Sub dtpDataNasc_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataNasc.ValueChanged
        diaAtual = Today
        dianas = dtpDataNasc.Text
        qtdano = DateDiff(DateInterval.Year, dianas, diaAtual)
        TxtIdade.Text = qtdano & " anos"
      

    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click
        Dim rpt As New CrpCadastroDeJogador
        rpt.SetDataSource(objjog.localizarRetornoTable(TxtCod.Text))
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de jogador"
        FrmImp.ShowDialog()
    End Sub
End Class

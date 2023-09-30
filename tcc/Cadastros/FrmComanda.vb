Public Class FrmComanda
    Dim objControle As New ClsControle
    Dim objcomanda As New ClsComanda
    Dim objjog As New ClsJogador
    Dim objlan As New ClsLanchoneteConsulta
    Dim objarm As New ClsLocConsulta
    Dim objarmaria As New ClsArmaria


    Dim campo As Integer
    Dim Subtot, Totger As Single
    Dim novo As Boolean


    Public quemChamou As String = ""
    Public campoChave As Integer

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Limpar_tela(Me)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False

        txtDia.Text = Today
        txtDia.Enabled = False
        TxtTotgeral.Enabled = False
        BtnNome.Enabled = True
        CmbTipoDePagamento.Enabled = False
        Totger = 0
        TxtTotgeral.Text = Format(Totger, "0.00")
        novo = True
    End Sub

    Private Sub FrmComanda_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
        If quemChamou.ToUpper = "FRMCOMCOMAN" Then
            objcomanda.localizar(campoChave)
            Call mostrar_dadosdaTela()
        End If
    End Sub

    Private Sub FrmComanda_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then SendKeys.Send("{tab}")
    End Sub
    Private Sub FrmComanda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblHorarioIni.Text = DateAndTime.Now.Hour & ":" & DateAndTime.Now.Minute
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)
        objControle.Limpar_tela(Me)
        BtnExc.Enabled = False
        BtnAlt.Enabled = False

        GrpLoc.Visible = False
        LblCodJog.Text = ""
        BtnNome.Enabled = False
        txtDia.Text = Today
        CmbTipoDePagamento.Enabled = False



    End Sub

    Private Sub TxtCod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If TxtCodJogador.Text = "" Then
            MessageBox.Show("Favor preencher o codigo do jogador")

        ElseIf TxtCodJogador.Text = objjog.banido = True Then
            MessageBox.Show("Jogador Banido")
            TxtCodJogador.Focus()

        ElseIf ChkPago.Checked = True And CmbTipoDePagamento.SelectedItem = "" Then
            MessageBox.Show("favor Adicionar forma de pagamento")
            CmbTipoDePagamento.Focus()

        ElseIf objControle.Testar_vazio(Me) <> True Then
            

            ' Totger = objarm.totpreco + objlan.totpre + campo
            ' TxtTotgeral.Text = Format(Totger, "0.00")

            objcomanda.Data = txtDia.Text
            objcomanda.hrentrada = LblHorarioIni.Text
            objcomanda.hrsaida = LblHorarioSaida.Text
            objcomanda.campo = ChkCampo.Checked
            objcomanda.codjoga = TxtCodJogador.Text
            objcomanda.totGeral = TxtTotgeral.Text
            objcomanda.pago = ChkPago.Checked
            objcomanda.tipodepagamento = CmbTipoDePagamento.Text

            Call mostrar_dadosdaTela()


            objcomanda.gravar(novo)
            TxtCod.Text = objcomanda.codigo
            objControle.Habilitar_botoes(Me, True)
            objControle.Habilitar_tela(Me, False)
        End If
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objcomanda.excluir(TxtCod.Text, TxtCod.Text) = True Then
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False

            LblCodJog.Text = ""
        End If
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        GrpLoc.Visible = True
        TxtLoc.Focus()
        BtnOk.Enabled = False
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If objcomanda.localizar(TxtLoc.Text) = True Then
            If objarm.localizarTot(TxtLoc.Text) = True Then
                

                GrpLoc.Visible = False
                mostrar_dadosdaTela()
                CmbTipoDePagamento.Enabled = False
                DgvComanda.DataSource = objcomanda.dgdarma(TxtLoc.Text)
            End If


            If objlan.localizarTot(TxtLoc.Text) = True Then

                GrpLoc.Visible = False
                mostrar_dadosdaTela()
                CmbTipoDePagamento.Enabled = False
                DgvComanda2.DataSource = objcomanda.dgdlanco(TxtLoc.Text)
            End If



            TxtLoc.Text = ""
            GrpLoc.Visible = False
            mostrar_dadosdaTela()
            CmbTipoDePagamento.Enabled = False


        Else
            TxtLoc.Text = ""
            TxtLoc.Focus()
        End If

        '  DgvComanda.DataSource = objarmaria.consultaDgvComanda
        '  DgdGrade.DataSource = objJogador.vendasCliLoc
    End Sub
    Public Sub mostrar_dadosdaTela()
        TxtCod.Text = objcomanda.codigo
        txtDia.Text = objcomanda.data
        LblHorarioIni.Text = objcomanda.hrentrada
        LblHorarioSaida.Text = objcomanda.hrsaida
        ChkCampo.Checked = objcomanda.campo
        TxtCodJogador.Text = objcomanda.codjoga
        ChkPago.Checked = objcomanda.pago
        'TxtTotgeral.Text = objcomanda.totGeral
        CmbTipoDePagamento.SelectedItem = objcomanda.tipodepagamento







        Totger = objarm.totpreco + objlan.totpre + campo
        'TxtTotgeral.Text = objcomanda.totGeral
        TxtTotgeral.Text = Format(Totger, "0.00")
        Call TxtCodJogador_LostFocus(Nothing, Nothing)

        BtnExc.Enabled = True
        BtnAlt.Enabled = True

    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmComanda_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Close()
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        If ChkPago.Checked = True Then
            objControle.Habilitar_tela(Me, True)
            objControle.Habilitar_botoes(Me, False)
            TxtCod.Enabled = False
            txtDia.Enabled = False
            TxtTotgeral.Enabled = False
            BtnNome.Enabled = True
            ChkPago.Enabled = False
            CmbTipoDePagamento.Enabled = False
            novo = False
        Else
            objControle.Habilitar_tela(Me, True)
            objControle.Habilitar_botoes(Me, False)
            TxtCod.Enabled = False
            txtDia.Enabled = False
            TxtTotgeral.Enabled = False
            BtnNome.Enabled = True
            CmbTipoDePagamento.Enabled = False
            novo = False
        End If
    End Sub

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOk.Enabled = False
        Else
            BtnOk.Enabled = True
        End If
    End Sub

    Private Sub TxtCodJogador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodJogador.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub TxtCodJogador_LostFocus(sender As Object, e As EventArgs) Handles TxtCodJogador.LostFocus
        If TxtCodJogador.Text <> "" Then
            If objjog.localizar(TxtCodJogador.Text) Then
                LblCodJog.Text = objjog.nome
            Else
                LblCodJog.Text = ""
                TxtCodJogador.Clear()
                TxtCodJogador.Focus()
            End If
        End If
    End Sub

    Private Sub BtnNome_Click(sender As Object, e As EventArgs) Handles BtnNome.Click
        FrmComJogador.quemChamou = Me.Name
        FrmComJogador.ShowDialog()

    End Sub

    Private Sub ChkPago_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPago.CheckedChanged
        If ChkPago.Checked = True Then
            LblHorarioSaida.Text = DateAndTime.Now.Hour & ":" & DateAndTime.Now.Minute
            CmbTipoDePagamento.Enabled = True
            CmbTipoDePagamento.Tag = ""
        Else
            LblHorarioSaida.Text = ""
            CmbTipoDePagamento.ResetText()
            CmbTipoDePagamento.Enabled = False
            CmbTipoDePagamento.Tag = "x"
        End If
    End Sub

    Private Sub ChkCampo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCampo.CheckedChanged
        If ChkCampo.Checked = True Then
            campo = 30
        Else
            campo = 0
        End If
    End Sub

End Class
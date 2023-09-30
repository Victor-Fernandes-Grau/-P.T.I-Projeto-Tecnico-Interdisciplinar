Public Class FrmLanconete

    Dim objcontrole As New ClsControle
    Dim objjog As New ClsJogador
    Dim objprolanc As New ClsLanco
    Dim objfunc As New ClsFuncionario
    Dim objven As New ClsVendLanco
    Dim objitem As New ClsItem
    Dim objcom As New ClsComanda

    Dim qtdAtual As Integer
    Public Subtot, Totger As Single
    Dim novo As Boolean = False
    Dim seq As Integer

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Close()
    End Sub

    Private Sub TxtCodFunc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodFunc.KeyPress
        e.Handled = objcontrole.So_numeros(e.KeyChar)
    End Sub

    Private Sub TxtCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCli.KeyPress
        e.Handled = objcontrole.So_numeros(e.KeyChar)
    End Sub

    Private Sub FrmLanconete_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then SendKeys.Send("{tab}")
    End Sub

    Private Sub FrmLanconete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbldata.Text = Today
        TxtCodFunc.Clear()
         objcontrole.Habilitar_tela(Me, False)
        objcontrole.Habilitar_botoes(Me, True)
        objcontrole.Limpar_tela(Me)

        BtnOk.Enabled = False
        lbldata.Text = Today
        BtnLocPro.Enabled = False
        BtnLocCli.Enabled = False
        BtnLocfun.Enabled = False

        DgdGrade.Rows.Clear()
        LblCli.Text = ""
        TxtCli.Clear()
        Totger = 0
        TxtGer.Text = Format(Totger, "0.00")
    End Sub

    Private Sub TxtCli_LostFocus(sender As Object, e As EventArgs) Handles TxtCli.LostFocus

        If TxtCli.Text <> "" Then
            If objcom.localizar(TxtCli.Text) Then
                LblCli.Text = objcom.codjoga
            Else
                LblCli.Text = ""
                TxtCli.Clear()
                TxtCli.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPro_LostFocus(sender As Object, e As EventArgs) Handles TxtPro.LostFocus
        If TxtPro.Text <> "" Then
            If objprolanc.localizar(TxtPro.Text) Then
                TxtNom.Text = objprolanc.nome
                TxtPre.Text = Format(objprolanc.preco, "0.00")
                qtdAtual = objprolanc.qtd
                TxtQtd.Focus()
            Else
                TxtPro.Clear()
                TxtNom.Clear()
                TxtPre.Clear()
                TxtQtd.Clear()
                TxtSub.Clear()
                TxtPro.Focus()

            End If
        End If
    End Sub

    Private Sub TxtQtd_TextChanged(sender As Object, e As EventArgs) Handles TxtQtd.TextChanged
        If TxtPre.Text = "" Then
            MessageBox.Show("Antes de digitar a qtd informe o código do produto")
            TxtPro.Focus()
        ElseIf TxtQtd.Text = "" Then
            TxtSub.Text = ""
        Else
            If TxtQtd.Text > qtdAtual Then
                MessageBox.Show("Qtd insuficiente no estoque, temos apenas " & qtdAtual & " itens")
                TxtQtd.Clear()
                TxtQtd.Focus()
            Else
                Subtot = TxtPre.Text * TxtQtd.Text
                TxtSub.Text = Format(Subtot, "0.00")
            End If
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If TxtPro.Text = "" Or TxtQtd.Text = "" Then
            MessageBox.Show("Para incluir o produto digite o código e a quantidade")
            TxtPro.Focus()
        Else
            DgdGrade.Rows.Add(TxtPro.Text, TxtNom.Text, TxtPre.Text, TxtQtd.Text, TxtSub.Text)
            Call baixar_estoque()
            Totger = Totger + Subtot
            TxtGer.Text = Format(Totger, "0.00")
            TxtPro.Clear()
            TxtNom.Clear()
            TxtQtd.Clear()
            TxtSub.Clear()
            TxtPre.Clear()
            TxtPro.Focus()
        End If
    End Sub
    Private Sub baixar_estoque()
        objprolanc.baixar_estoque(TxtPro.Text, TxtQtd.Text)
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        BtnLocfun.Enabled = True
        TxtCli.Enabled = True
        TxtPro.Enabled = True
        TxtQtd.Enabled = True
        TxtCodFunc.Enabled = True
        objcontrole.Limpar_tela(Me)
        LblCli.Text = ""
        DgdGrade.Rows.Clear()
        BtnOk.Enabled = True
        BtnLocCli.Enabled = True
        BtnLocPro.Enabled = True
        objcontrole.Limpar_tela(Me)
        BtnNov.Enabled = False
        BtnGra.Enabled = True
        Totger = 0
        TxtGer.Text = Format(Totger, "0.00")
        TxtCli.Focus()

    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click

        If TxtCli.Text = "" Then
            MessageBox.Show("Por favor preencha o código do cliente")
            TxtCli.Focus()
        ElseIf TxtGer.Text = 0 Then
            MessageBox.Show("Por favor adicione items a essa compra")
            TxtCodFunc.Focus()
            '  ElseIf objjog.dtnasc - Today < 18 And objprolanc.tipo = "Alcool" Then
            '  MessageBox.Show("Proibida a venda de bebidas alcoolicas para menores")
            ' TxtCodFunc.Focus()

        Else
            objven.data = lbldata.Text
            objven.Codfunc = TxtCodFunc.Text
            objven.comanda = TxtCli.Text
            objven.totpre = TxtGer.Text
            objven.gravar()
            TxtCod.Text = objven.Codlanco
            For x = 0 To DgdGrade.Rows.Count - 1
                objitem.codigo = TxtCod.Text
                objitem.sequencia = x
                objitem.produtoi = DgdGrade.Rows(x).Cells(0).Value
                objitem.precoi = DgdGrade.Rows(x).Cells(2).Value
                objitem.quantidadei = DgdGrade.Rows(x).Cells(3).Value
                objitem.gravar()
            Next
            
            objcontrole.Habilitar_botoes(Me, True)
            objcontrole.Habilitar_tela(Me, False)
            BtnOk.Enabled = False
            BtnLocCli.Enabled = False
            BtnLocfun.Enabled = False
            BtnLocPro.Enabled = False
        End If
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmLanconete_Load(Nothing, Nothing)
    End Sub
    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If DgdGrade.Rows.Count > 0 Then
            Dim id As Integer
            Dim qtd As Integer

            id = DgdGrade.CurrentRow.Cells(0).Value
            qtd = DgdGrade.CurrentRow.Cells(3).Value

            objprolanc.devolver_estoque(id, qtd)

            Totger = Totger - DgdGrade.CurrentRow.Cells(4).Value

            TxtGer.Text = Format(Totger, "0.00")

            DgdGrade.Rows.Remove(DgdGrade.CurrentRow)

            TxtPro.Clear()
            TxtNom.Clear()
            TxtQtd.Clear()
            TxtSub.Clear()
            TxtPre.Clear()
            TxtPro.Focus()
        End If



    End Sub
    Private Sub BtnLocCli_Click(sender As Object, e As EventArgs) Handles BtnLocCli.Click
        FrmComComan.quemChamou = Me.Name
        FrmComComan.ShowDialog()

    End Sub

    Private Sub TxtCodFunc_LostFocus(sender As Object, e As EventArgs) Handles TxtCodFunc.LostFocus
        If TxtCodFunc.Text <> "" Then
            If objfunc.localizar(TxtCodFunc.Text) Then
                lblNomFunc.Text = objfunc.nome
            Else
                lblNomFunc.Text = ""
                TxtCodFunc.Clear()
                TxtCodFunc.Focus()
            End If
        End If
    End Sub



    Private Sub BtnLocfun_Click(sender As Object, e As EventArgs) Handles BtnLocfun.Click
        FrmComFunc.quemChamou = Me.Name
        FrmComFunc.ShowDialog()
    End Sub

    Private Sub BtnLocPro_Click(sender As Object, e As EventArgs) Handles BtnLocPro.Click
        FrmComLanco.quemChamou = Me.Name
        FrmComLanco.ShowDialog()
        If TxtPro.Text <> "" Then
            If objprolanc.localizar(TxtPro.Text) Then
                TxtNom.Text = objprolanc.nome
                TxtPre.Text = Format(objprolanc.preco, "0.00")
                qtdAtual = objprolanc.qtd
                TxtQtd.Focus()
            Else
                TxtPro.Clear()
                TxtNom.Clear()
                TxtPre.Clear()
                TxtQtd.Clear()
                TxtSub.Clear()
                TxtPro.Focus()

            End If
        End If
    End Sub

    Private Sub TxtCodFunc_TextChanged(sender As Object, e As EventArgs) Handles TxtCodFunc.TextChanged

    End Sub
End Class
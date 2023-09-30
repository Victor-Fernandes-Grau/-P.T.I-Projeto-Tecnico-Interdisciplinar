﻿Public Class FrmCadProdArmaria
    Dim objControle As New ClsControle
    Dim objarm As New ClsArmaria
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

    Private Sub FrmCadProdArmaria_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
        If quemChamou.ToUpper = "FRMCOMARMARIA" Then
            objarm.localizar(campoChave)
            Call mostrar_dadosdaTela()
        End If
    End Sub

    Private Sub FrmCadProdArmaria_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then SendKeys.Send("{tab}")
    End Sub

    Private Sub FrmCadProdArmaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)
        objControle.Limpar_tela(Me)
        BtnExc.Enabled = False
        BtnAlt.Enabled = False
        BtnImp.Enabled = False
        GrpLoc.Visible = False
        BtnCan.Enabled = False
        CmbProd.ResetText()

    End Sub

    Private Sub TxtCod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If CmbProd.SelectedItem = "" Then
            MessageBox.Show("Favor selecionar a categoria do item")
            CmbProd.Focus()

        elseif objControle.Testar_vazio(Me) <> True Then
        objarm.nome = TxtNom.Text
        objarm.tipo = CmbProd.Text
        objarm.numserie = TxtNumserie.Text
        objarm.modelo = TxtMode.Text
        objarm.documento = TxtDoc.Text
        objarm.qtd = TxtQuan.Text
        objarm.preco = TxtPre.Text



        objarm.gravar(novo)
        TxtCod.Text = objarm.codigo


        objControle.Habilitar_botoes(Me, True)
        objControle.Habilitar_tela(Me, False)


        End If

    End Sub


    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objarm.excluir(TxtNom.Text, TxtCod.Text) = True Then
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
            BtnImp.Enabled = False
            CmbProd.Enabled = False
        End If
    End Sub


    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        BtnCan.Enabled = True
        GrpLoc.Visible = True
        TxtLoc.Focus()
        BtnOk.Enabled = False
        TxtQuan.Enabled = False

    End Sub

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOk.Enabled = False
        Else
            BtnOk.Enabled = True
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If objarm.localizar(TxtLoc.Text) = True Then
            TxtLoc.Text = ""
            GrpLoc.Visible = False
            mostrar_dadosdaTela()
            TxtQuan.Enabled = False
        Else
            TxtLoc.Text = ""
            TxtLoc.Focus()
        End If
    End Sub

    Public Sub mostrar_dadosdaTela()
        TxtCod.Text = objarm.codigo
        TxtNom.Text = objarm.nome
        CmbProd.Text = objarm.tipo
        TxtNumserie.Text = objarm.numserie
        TxtMode.Text = objarm.modelo
        TxtDoc.Text = objarm.documento
        TxtQuan.Text = objarm.qtd
        TxtPre.Text = objarm.preco

        TxtDoc.Enabled = False
        TxtNumserie.Enabled = False
        BtnExc.Enabled = True
        BtnAlt.Enabled = True
        BtnImp.Enabled = True
    End Sub


    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmCadProdArmaria_Load(Nothing, Nothing)

    End Sub


    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)

        If CmbProd.SelectedItem = "Arma" Then
            TxtQuan.Enabled = False

        Else
            TxtNumserie.Enabled = False
            TxtDoc.Enabled = False
        End If
        TxtCod.Enabled = False
        TxtNom.Focus()
        novo = False
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Close()
    End Sub

    Private Sub CmbProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProd.SelectedIndexChanged

        If CmbProd.Text = "Arma" Then
            TxtQuan.Text = "1"
            TxtNumserie.Tag = ""
            TxtDoc.Tag = ""
            TxtQuan.Enabled = False
            TxtNumserie.Enabled = True
            TxtDoc.Enabled = True


        ElseIf CmbProd.Text = "Capacete / Mascara" Or CmbProd.Text = "Colete" Or CmbProd.Text = "BBs" Then
            TxtNumserie.Enabled = False
            TxtNumserie.Clear()
            TxtQuan.Enabled = True
            TxtDoc.Enabled = False
            TxtNumserie.Tag = "x"
            TxtDoc.Tag = "x"
            TxtDoc.Clear()

            TxtQuan.Clear()



        End If
    End Sub

    Private Sub TxtNumserie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumserie.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub TxtPre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPre.KeyPress
        e.Handled = objControle.So_numerosEvirgula(e.KeyChar)
    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click
        Dim rpt As New CrpCadastroProdutoArmaria
        rpt.SetDataSource(objarm.localizarRetornoNomeCodigo(TxtCod.Text))
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de produtos da armaria"
        FrmImp.ShowDialog()
    End Sub
End Class
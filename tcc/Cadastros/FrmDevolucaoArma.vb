Public Class FrmDevolucaoArma

    Dim objcontrole As New ClsControle
    Dim objproArma As New ClsArmaria
    Dim objitem As New ClsItensLoc
    Dim objcom As New ClsComanda

    Dim qtdAtual As Integer

    Dim novo As Boolean = False

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Close()
    End Sub
    Private Sub FrmLanconete_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then SendKeys.Send("{tab}")
    End Sub

    Private Sub FrmLanconete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cuidados com o usuário com relação a inteface
        BtnOk.Enabled = False
        lbldata.Text = Today
        TxtPro.Enabled = False
        TxtQtd.Enabled = False
        BtnOk.Enabled = False
        BtnLocPro.Enabled = False
        BtnNov.Enabled = True
        TxtNom.Clear()
        TxtPro.Clear()
        TxtQtd.Clear()
        DgdGrade.Rows.Clear()


    End Sub
    Private Sub TxtPro_LostFocus(sender As Object, e As EventArgs) Handles TxtPro.LostFocus
        If TxtPro.Text <> "" Then
            If objproArma.localizar(TxtPro.Text) Then
                TxtNom.Text = objproArma.nome
                qtdAtual = objproArma.qtd
                TxtQtd.Focus()
            Else
                TxtPro.Clear()
                TxtNom.Clear()
                TxtQtd.Clear()
                TxtPro.Focus()

            End If
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If TxtPro.Text = "" Or TxtQtd.Text = "" Then
            MessageBox.Show("Para incluir o produto digite o código e a quantidade")
            TxtPro.Focus()
        ElseIf objproArma.tipo = "Arma" And objproArma.qtd > 1 Then
            MessageBox.Show("Esta arma ja esta no estoque")
            TxtPro.Focus()

        ElseIf objproArma.tipo = "Arma" And objproArma.qtd < 1 And TxtQtd.Text > 1 Then
            MessageBox.Show("So se pode devolver uma arma de cada vez")
            TxtPro.Focus()
        ElseIf TxtNom.Text = "" And TxtQtd.Text <> "" Then
            MessageBox.Show("Favor preencher o codigo do produto")
            TxtPro.Focus()
        Else
            DgdGrade.Rows.Add(TxtPro.Text, TxtNom.Text, TxtQtd.Text)
            Call devolver_estoque()

            TxtPro.Clear()
            TxtNom.Clear()
            TxtQtd.Clear()

            TxtPro.Focus()
        End If
    End Sub
    Public Sub devolver_estoque()
        objproArma.devolver_estoque(TxtPro.Text, TxtQtd.Text)
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        TxtPro.Enabled = True
        TxtQtd.Enabled = True

        objcontrole.Limpar_tela(Me)

        DgdGrade.Rows.Clear()
        BtnOk.Enabled = True

        BtnLocPro.Enabled = True
        objcontrole.Limpar_tela(Me)
        BtnNov.Enabled = False


       

    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmLanconete_Load(Nothing, Nothing)
    End Sub
    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If DgdGrade.Rows.Count > 0 Then
            Dim id As Integer
            Dim qtd As Integer
            id = DgdGrade.CurrentRow.Cells(0).Value
            qtd = DgdGrade.CurrentRow.Cells(2).Value
            objproArma.baixar_estoque(id, qtd)
            'subtrai do total geral o sub-total

            'exibe total geral formatado
            'remove o item da grade
            DgdGrade.Rows.Remove(DgdGrade.CurrentRow)

            TxtPro.Clear()
            TxtNom.Clear()
            TxtQtd.Clear()
            
            TxtPro.Focus()
        End If



    End Sub
    Private Sub BtnLocPro_Click(sender As Object, e As EventArgs) Handles BtnLocPro.Click
        FrmComArmaria.quemChamou = Me.Name
        FrmComArmaria.ShowDialog()
        If TxtPro.Text <> "" Then
            If objproArma.localizar(TxtPro.Text) Then
                TxtNom.Text = objproArma.nome
                qtdAtual = objproArma.qtd
                TxtQtd.Focus()
            Else
                TxtPro.Clear()
                TxtNom.Clear()

                TxtQtd.Clear()

                TxtPro.Focus()
            End If
        End If
    End Sub
End Class
Public Class FrmMenuGerente
    Private Sub JogadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JogadorToolStripMenuItem.Click
        FrmCadJogador.Show()
        FrmCadJogador.MdiParent = Me
    End Sub

    Private Sub FuncionarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionarioToolStripMenuItem.Click
        FrmCadFunc.Show()
        FrmCadFunc.MdiParent = Me
    End Sub

    Private Sub ProdutoArmariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutoArmariaToolStripMenuItem.Click
        FrmCadProdArmaria.Show()
        FrmCadProdArmaria.MdiParent = Me
    End Sub

    Private Sub ProdutoLançoneteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutoLançoneteToolStripMenuItem.Click
        FrmCadProdLanco.Show()
        FrmCadProdLanco.MdiParent = Me
    End Sub

    Private Sub CalculadorasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadorasToolStripMenuItem.Click
        Shell("C:\windows\system32\calc.exe")
    End Sub
    Private Sub ComandaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComandaToolStripMenuItem1.Click
        FrmComanda.Show()
        FrmComanda.MdiParent = Me
    End Sub

    Private Sub JogadorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles JogadorToolStripMenuItem1.Click
        FrmComJogador.quemChamou = Me.Name
        FrmComJogador.Show()
        FrmComJogador.MdiParent = Me
    End Sub

    Private Sub FuncionarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FuncionarioToolStripMenuItem1.Click
        FrmComFunc.quemChamou = Me.Name
        FrmComFunc.Show()
        FrmComFunc.MdiParent = Me
    End Sub

    Private Sub ProdutoLançoneteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProdutoLançoneteToolStripMenuItem1.Click
        
    End Sub

    Private Sub ProdutoArmariaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProdutoArmariaToolStripMenuItem1.Click
        
    End Sub

    Private Sub LançoneteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LançoneteToolStripMenuItem.Click
        FrmLanconete.Show()
        FrmLanconete.MdiParent = Me
    End Sub

    Private Sub ComandoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComandoToolStripMenuItem.Click
        
    End Sub

    Private Sub ArmariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArmariaToolStripMenuItem.Click
        FrmArmaria.Show()
        FrmArmaria.MdiParent = Me
    End Sub

    Private Sub ManutençoArmaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManutençoArmaToolStripMenuItem.Click
        FrmManutencaoArma.Show()
        FrmManutencaoArma.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        FrmCadArmero.Show()
        FrmCadArmero.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        FrmComArmero.quemChamou = Me.Name
        FrmComArmero.Show()
        FrmComArmero.MdiParent = Me
    End Sub

    Private Sub PoRCodigoENomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoRCodigoENomeToolStripMenuItem.Click
        FrmComArmaria.quemChamou = Me.Name
        FrmComArmaria.Show()
        FrmComArmaria.MdiParent = Me
    End Sub

    Private Sub PorNomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorNomeToolStripMenuItem.Click
        FrmComLanco.quemChamou = Me.Name
        FrmComLanco.Show()
        FrmComLanco.MdiParent = Me
    End Sub

    Private Sub PorCodigoDeJogadorENomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorCodigoDeJogadorENomeToolStripMenuItem.Click
        FrmComComan.quemChamou = Me.Name
        FrmComComan.Show()
        FrmComComan.MdiParent = Me
    End Sub


    Private Sub PorTipoDePagamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorTipoDePagamentoToolStripMenuItem.Click
        FrmComTipoDPagamento.Show()
        FrmComTipoDPagamento.MdiParent = Me
    End Sub

    Private Sub PorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorToolStripMenuItem.Click
        FrmComProdArmCatego.Show()
        FrmComProdArmCatego.MdiParent = Me
    End Sub

    Private Sub PorCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorCategoriaToolStripMenuItem.Click
        FrmComProdLancCatego.Show()
        FrmComProdLancCatego.MdiParent = Me
    End Sub

    
    Private Sub PorPeriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorPeriToolStripMenuItem.Click
        FrmConComandaPeriodo.Show()
        FrmConComandaPeriodo.MdiParent = Me
    End Sub

    Private Sub PorDiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorDiaToolStripMenuItem.Click
        FrmConComandaPorData.Show()
        FrmConComandaPorData.MdiParent = Me
    End Sub

    

    Private Sub PorCodigoDoFuncionarioENomeDoFuncionarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorCodigoDoFuncionarioENomeDoFuncionarioToolStripMenuItem.Click
        FrmConVendasArmariaFunc.Show()
        FrmConVendasArmariaFunc.MdiParent = Me
    End Sub

    Private Sub PorDataToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PorDataToolStripMenuItem1.Click
        FrmConDataVendasArmaria.Show()
        FrmConDataVendasArmaria.MdiParent = Me
    End Sub

    Private Sub PorPeríodoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PorPeríodoToolStripMenuItem2.Click
        FrmConPeriodoVendasArmaria.Show()
        FrmConPeriodoVendasArmaria.MdiParent = Me
    End Sub

    Private Sub PorCodigoDoClienteENomeDoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorCodigoDoClienteENomeDoClienteToolStripMenuItem.Click
        FrmConVendaClivendaArmaria.Show()
        FrmConVendaClivendaArmaria.MdiParent = Me
    End Sub

    Private Sub PorCodigoDoClienteENomeDoClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PorCodigoDoClienteENomeDoClienteToolStripMenuItem1.Click
        FrmConVendasLancoCli.Show()
        FrmConVendasLancoCli.MdiParent = Me
    End Sub

    Private Sub PorCodigoDoClienteENomeDoFuncionarioLanchoneteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorCodigoDoClienteENomeDoFuncionarioLanchoneteToolStripMenuItem.Click
        FrmConVendasLancoFunc.Show()
        FrmConVendasLancoFunc.MdiParent = Me
    End Sub

    Private Sub PorNomeDoArmeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorNomeDoArmeroToolStripMenuItem.Click
        FrmConManuArmaArmero.Show()
        FrmConManuArmaArmero.MdiParent = Me
    End Sub

    Private Sub PorCodigoDaArmaENomeDaArmaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorCodigoDaArmaENomeDaArmaToolStripMenuItem.Click
        FrmConManuArma.Show()
        FrmConManuArma.MdiParent = Me
    End Sub

    Private Sub PorDiaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PorDiaToolStripMenuItem1.Click
        FrmConManuArmaData.Show()
        FrmConManuArmaData.MdiParent = Me
    End Sub

    Private Sub PorPeríodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorPeríodoToolStripMenuItem.Click
        FrmConManuArmaDataFim.Show()
        FrmConManuArmaDataFim.MdiParent = Me
    End Sub

    Private Sub DevoluçãoDaArmaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevoluçãoDaArmaToolStripMenuItem.Click
        FrmDevolucaoArma.Show()
        FrmDevolucaoArma.MdiParent = Me
    End Sub

    Private Sub PorCodigoDaArmaENomeDaArmaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PorCodigoDaArmaENomeDaArmaToolStripMenuItem1.Click
        FrmConNomeCodArmaLoc.Show()
        FrmConNomeCodArmaLoc.MdiParent = Me
    End Sub

    Private Sub PorDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorDataToolStripMenuItem.Click
        FrmConLocaçãoData.Show()
        FrmConLocaçãoData.MdiParent = Me
    End Sub

    Private Sub PorPeríodoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PorPeríodoToolStripMenuItem1.Click
        FrmConLocaçãoPeriodo.Show()
        FrmConLocaçãoPeriodo.MdiParent = Me
    End Sub
    Private Sub FrmMenuGerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FrmLogin.Visible = True
        Me.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PorToolStripMenuItem1.Click
        FrmConNomeCodJogadorLoc.Show()
        FrmConNomeCodJogadorLoc.MdiParent = Me
    End Sub

    Private Sub PorPeríodoToolStripMenuItem3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CadastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastosToolStripMenuItem.Click
        Dim objjog As New ClsJogador
        Dim rpt As New CrpCadastroDeJogador
        '' rpt.Refresh()
        rpt.SetDataSource(objjog.localizarRetornoTable(""))
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft "
        rpt.SummaryInfo.ReportComments = "Relatorio de jogador"
        FrmImp.ShowDialog()
    End Sub

    Private Sub FuncionarioToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FuncionarioToolStripMenuItem2.Click
        Dim objfun As New ClsFuncionario
        Dim rpt As New CrpCadastroDeFuncionario
        rpt.SetDataSource(objfun.localizarRetornoTable(""))
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de Funcionario"
        FrmImp.ShowDialog()
    End Sub

    Private Sub ProdutoArmariaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ProdutoArmariaToolStripMenuItem2.Click
        Dim objarm As New ClsArmaria
        Dim rpt As New CrpCadastroProdutoArmaria
        rpt.SetDataSource(objarm.localizarRetornoNomeCodigo(""))
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de Produto Armaria"
        FrmImp.ShowDialog()
    End Sub

    Private Sub ProdutoLançoneteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ProdutoLançoneteToolStripMenuItem2.Click
        Dim objlanco As New ClsLanco
        Dim rpt As New CrpCadastroProdutoLancho
        rpt.SetDataSource(objlanco.localizarRetornoTable(""))
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de Produto Lanchonete"
        FrmImp.ShowDialog()
    End Sub

    Private Sub ArmeiroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArmeiroToolStripMenuItem.Click
        Dim objarmero As New ClsArmero
        Dim rpt As New CrpCadastroDoArmero
        rpt.SetDataSource(objarmero.localizarRetornoTable(""))
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de Armeiro"
        FrmImp.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Dim rpt As New CrpComandaSql

        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de Comanda"
        FrmImp.ShowDialog()

    End Sub

    Private Sub ManutençãoArmaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManutençãoArmaToolStripMenuItem.Click
        Dim rpt As New CrpManutençaoSql
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de Manutenção"
        FrmImp.ShowDialog()
    End Sub

    Private Sub LocaçãoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LocaçãoToolStripMenuItem1.Click
        Dim rpt As New CrpLocaçaoSql
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de Locação"
        FrmImp.ShowDialog()
    End Sub

    Private Sub VendasArmariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendasArmariaToolStripMenuItem.Click
        Dim rpt As New CrpVendaArmariaFunc
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de Vendas Armaria"
        FrmImp.ShowDialog()
    End Sub

    Private Sub VendasLanchoneteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VendasLanchoneteToolStripMenuItem1.Click
        Dim rpt As New CrpVendaLanchoneteSql
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        rpt.SummaryInfo.ReportComments = "Relatorio de Vendas Lanchonete"
        FrmImp.ShowDialog()
    End Sub
    Private Sub BanidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BanidosToolStripMenuItem.Click
        Dim objjog As New ClsJogador
        Dim rpt As New CrpGrabanidos
        rpt.SetDataSource(objjog.localizarRetornoTable(""))
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        FrmImp.ShowDialog()
    End Sub

    Private Sub PoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoToolStripMenuItem.Click
        Dim rpt As New CrpGraComandaCampo
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        FrmImp.ShowDialog()
    End Sub

    Private Sub TotalGeralArecadadoNoLanchonetePorDiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalGeralArecadadoNoLanchonetePorDiaToolStripMenuItem.Click
        Dim rpt As New CrpGrafTotalPreçoPorDadaLancho
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        FrmImp.ShowDialog()
    End Sub

    Private Sub TotalGeralArrecadadoNoArmariaPorDiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalGeralArrecadadoNoArmariaPorDiaToolStripMenuItem.Click
        Dim rpt As New CrpGrafTotalPreçoPorDataArmaria
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        FrmImp.ShowDialog()
    End Sub

    Private Sub TotalDePessoasPorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalDePessoasPorToolStripMenuItem.Click
        Dim rpt As New CrpGraFuncArea
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        FrmImp.ShowDialog()
    End Sub

    Private Sub ContagemDeProdutosPorCategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContagemDeProdutosPorCategoriasToolStripMenuItem.Click
        Dim rpt As New CrpGraTipoArmaria
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        FrmImp.ShowDialog()
    End Sub

    Private Sub ContagemDeProdutosPorCategoriasNaLanchoneteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContagemDeProdutosPorCategoriasNaLanchoneteToolStripMenuItem.Click
        Dim rpt As New CrpGraTipoLancho
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        FrmImp.ShowDialog()
    End Sub

    Private Sub ContagemDeManutençõesFeitasPorArmeirosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContagemDeManutençõesFeitasPorArmeirosToolStripMenuItem.Click
        Dim rpt As New CrpManu
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Arena Rush Airsoft"
        FrmImp.ShowDialog()
    End Sub
End Class
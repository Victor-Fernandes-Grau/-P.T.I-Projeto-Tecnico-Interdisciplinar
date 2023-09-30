Public Class ClsFuncionario

    Dim m_cod As Integer
    Dim m_nome As String
    Dim m_cpf As String
    Dim m_dtnas As Date
    Dim m_dtadmi As Date
    Dim m_area As String
    Dim m_usuario As String
    Dim m_senha As String
    Dim m_salario As Single

    Dim sql As String
    Dim objbanco As New ClsBanco
    Dim objdtLocal As DataTable

    Public Property codigo As Integer
        Get
            Return m_cod
        End Get
        Set(ByVal value As Integer)
            m_cod = value
        End Set
    End Property

    Public Property nome As String
        Get
            Return m_nome
        End Get
        Set(ByVal value As String)
            m_nome = value
        End Set
    End Property

    Public Property cpf As String
        Get
            Return m_cpf
        End Get
        Set(ByVal value As String)
            m_cpf = value
        End Set
    End Property

   Public Property dtnasc As Date
        Get
            Return m_dtnas
        End Get
        Set(ByVal value As Date)
            m_dtnas = value
        End Set
    End Property
    Public Property dtadimicao As Date
        Get
            Return m_dtadmi
        End Get
        Set(ByVal value As Date)
            m_dtadmi = value
        End Set
    End Property

    Public Property area As String
        Get
            Return m_area
        End Get
        Set(ByVal value As String)
            m_area = value
        End Set
    End Property

    Public Property usuario As String
        Get
            Return m_usuario
        End Get
        Set(ByVal value As String)
            m_usuario = value
        End Set
    End Property
    Public Property senha As String
        Get
            Return m_senha
        End Get
        Set(ByVal value As String)
            m_senha = value
        End Set
    End Property
    Public Property salario As Single
        Get
            Return m_salario
        End Get
        Set(ByVal value As Single)
            m_salario = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        If novo = True Then
            sql = "Insert into TabCadFunc (nome, cpf, dtnasc, dtadmi, area, usuario, senha, salario) values ('" & m_nome & "','" & m_cpf & "','" & m_dtnas & "','" & m_dtadmi & "','" & m_area & "','" & m_usuario & "','" & m_senha & "','" & m_salario & "')"
            objbanco.executar_comando(sql)
            localizar_ultimo()
        Else

            sql = "Update TabCadFunc set nome='" & m_nome & "', cpf='" & m_cpf & "', dtnasc='" & m_dtnas & "', dtadmi='" & m_dtadmi & "', area='" & m_area & "', usuario='" & m_usuario & "', senha='" & m_senha & "', salario='" & m_salario & "' where Codfunc=" & m_cod

            objbanco.executar_comando(sql)

        End If

    End Sub

    Public Sub localizar_ultimo()
        sql = "select max(Codfunc) as codigo from TabCadFunc"
        m_cod = objbanco.Localizar_ultimocodigo(sql)
    End Sub

    Public Function excluir(nome As String, codigo As Integer) As Boolean
        If MessageBox.Show("Deseja excluir " & nome & "?", "Aviso",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from TabCadFunc where Codfunc=" & codigo
            objbanco.executar_comando(sql)
            Return True
        Else
            Return False
        End If

    End Function

    Public Function localizarRetornoTable(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select TabCadFunc.Codfunc, TabCadFunc.nome, TabCadFunc.cpf, TabCadFunc.dtadmi, TabCadFunc.area from TabCadFunc where Codfunc=" & campo
        Else
            sql = "Select TabCadFunc.Codfunc, TabCadFunc.nome, TabCadFunc.cpf, TabCadFunc.dtadmi, TabCadFunc.area from TabCadFunc where nome like '" & campo & "%' order by Codfunc"
        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function
    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from TabCadFunc where Codfunc=" & campo
        Else
            sql = "Select * from TabCadFunc where nome='" & campo & "'"
        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        If objdtLocal.Rows.Count = 0 Then
            MessageBox.Show("Registro " & campo & " não encontrado")
            Return False
        Else
            mostrar_dadosDaClasse()
            Return True
        End If

    End Function

    Public Function vendasLocFunc(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT TabLoc.CodLoc, TabComanda.Codentra, TabCadJogador.nome, TabCadFunc.Codfunc, TabCadFunc.nome, TabCadProdArmaria.Codproarma, TabCadProdArmaria.nome, TabCadProdArmaria.Documento, TabItensLoc.qtd, TabCadProdArmaria.preco, TabLoc.data FROM ((TabCadJogador INNER JOIN TabComanda ON TabCadJogador.Codjoga = TabComanda.Codjoga) INNER JOIN (TabCadFunc INNER JOIN TabLoc ON TabCadFunc.Codfunc = TabLoc.Codfunc) ON TabComanda.Codentra = TabLoc.comanda) INNER JOIN (TabCadProdArmaria INNER JOIN TabItensLoc ON TabCadProdArmaria.Codproarma = TabItensLoc.Codproarma) ON TabLoc.CodLoc = TabItensLoc.codigo where TabCadFunc.CodFunc=" & campo
            '     sql = "Select TabCadFunc.Codfunc, TabCadFunc.nome, sum(TabLoc.totpreco) AS Total, Count(TabLoc.totpreco) AS [Qtd de Vendas] from TabCadFunc INNER JOIN TabLoc ON TabCadFunc.Codfunc = TabLoc.Codfunc where TabCadFunc.Codfunc=" & campo
        Else
            sql = "SELECT TabLoc.CodLoc, TabComanda.Codentra, TabCadJogador.nome, TabCadFunc.Codfunc, TabCadFunc.nome, TabCadProdArmaria.Codproarma, TabCadProdArmaria.nome, TabCadProdArmaria.Documento, TabItensLoc.qtd, TabCadProdArmaria.preco, TabLoc.data FROM ((TabCadJogador INNER JOIN TabComanda ON TabCadJogador.Codjoga = TabComanda.Codjoga) INNER JOIN (TabCadFunc INNER JOIN TabLoc ON TabCadFunc.Codfunc = TabLoc.Codfunc) ON TabComanda.Codentra = TabLoc.comanda) INNER JOIN (TabCadProdArmaria INNER JOIN TabItensLoc ON TabCadProdArmaria.Codproarma = TabItensLoc.Codproarma) ON TabLoc.CodLoc = TabItensLoc.codigo where TabCadFunc.nome like '" & campo & "%' order by TabCadFunc.nome"
            'sql = "Select TabCadFunc.Codfunc, TabCadFunc.nome, sum(TabLoc.totpreco) AS Total, Count(TabLoc.totpreco) AS [Qtd de Vendas] from TabCadFunc INNER JOIN TabLoc ON TabCadFunc.Codfunc = TabLoc.Codfunc where nome like '" & campo & "%' order by nome"
        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function

    Public Function vendasLancoFunc(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT TabCadFunc.Codfunc, TabCadFunc.nome, TabCadJogador.nome, TabComanda.Codentra, TabLanconete.Codlanco, TabLanconete.totpre, TabLanconete.data, TabCadProdLanco.nome, TabCadProdLanco.Codprolan, TabItens.QtdIte, TabCadProdLanco.preco FROM ((((TabItens AS TabItens INNER JOIN TabLanconete AS TabLanconete ON TabItens.VenIte = TabLanconete.Codlanco) INNER JOIN TabCadProdLanco AS TabCadProdLanco ON TabItens.ProIte = TabCadProdLanco.Codprolan) INNER JOIN TabComanda AS TabComanda ON TabLanconete.comanda = TabComanda.Codentra) INNER JOIN TabCadFunc AS TabCadFunc ON TabLanconete.Codfunc = TabCadFunc.Codfunc) INNER JOIN TabCadJogador AS TabCadJogador ON TabComanda.Codjoga = TabCadJogador.Codjoga where TabCadFunc.Codfunc = " & campo

        Else
            sql = "SELECT TabCadFunc.Codfunc, TabCadFunc.nome, TabCadJogador.nome, TabComanda.Codentra, TabLanconete.Codlanco, TabLanconete.totpre, TabLanconete.data, TabCadProdLanco.nome, TabCadProdLanco.Codprolan, TabItens.QtdIte, TabCadProdLanco.preco FROM ((((TabItens AS TabItens INNER JOIN TabLanconete AS TabLanconete ON TabItens.VenIte = TabLanconete.Codlanco) INNER JOIN TabCadProdLanco AS TabCadProdLanco ON TabItens.ProIte = TabCadProdLanco.Codprolan) INNER JOIN TabComanda AS TabComanda ON TabLanconete.comanda = TabComanda.Codentra) INNER JOIN TabCadFunc AS TabCadFunc ON TabLanconete.Codfunc = TabCadFunc.Codfunc) INNER JOIN TabCadJogador AS TabCadJogador ON TabComanda.Codjoga = TabCadJogador.Codjoga where TabCadFunc.nome like '" & campo & "%' order by TabCadFunc.nome"

        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function

    Public Function TotLancoFunc(campo As String) As Single
        If IsNumeric(campo) Then
            sql = "SELECT sum(TabLanconete.totpre) as Total FROM TabCadFunc INNER JOIN TabLanconete ON TabCadFunc.Codfunc = TabLanconete.Codfunc where TabCadFunc.Codfunc = " & campo & " group by  TabCadFunc.Codfunc"

        Else
            sql = "SELECT sum(TabLanconete.totpre) as Total FROM TabCadFunc INNER JOIN TabLanconete ON TabCadFunc.Codfunc = TabLanconete.Codfunc where nome like '" & campo & "%'  group by  TabCadFunc.Codfunc"

        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        If objdtLocal.Rows.Count > 0 Then
            Return objdtLocal.Rows(0).Item(0)
        Else
            Return 0
        End If

    End Function
    Public Sub mostrar_dadosDaClasse()
        m_cod = objdtLocal.Rows(0).Item(0)
        m_nome = objdtLocal.Rows(0).Item(1)
        m_cpf = objdtLocal.Rows(0).Item(2)
        m_dtnas = objdtLocal.Rows(0).Item(3)
        m_dtadmi = objdtLocal.Rows(0).Item(4)
        m_area = objdtLocal.Rows(0).Item(5)
        m_usuario = objdtLocal.Rows(0).Item(6)
        m_senha = objdtLocal.Rows(0).Item(7)
        m_salario = objdtLocal.Rows(0).Item(8)

    End Sub
End Class

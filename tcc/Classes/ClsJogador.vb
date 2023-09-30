Public Class ClsJogador
    Dim m_cod As Integer
    Dim m_data As Date
    Dim m_nome As String
    Dim m_cpf As String
    Dim m_tele As String
    Dim m_dtnas As Date
    Dim m_nomrespon As String
    Dim m_cpfrespon As String
    Dim m_telerespon As String
    Dim m_email As String
    Dim m_banidos As Boolean

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
    Public Property data As Date
        Get
            Return m_data
        End Get
        Set(ByVal value As Date)
            m_data = value
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
    Public Property telefone As String
        Get
            Return m_tele
        End Get
        Set(ByVal value As String)
            m_tele = value
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
    Public Property nomerespon As String
        Get
            Return m_nomrespon
        End Get
        Set(ByVal value As String)
            m_nomrespon = value
        End Set
    End Property
    Public Property cpfrespon As String
        Get
            Return m_cpfrespon
        End Get
        Set(ByVal value As String)
            m_cpfrespon = value
        End Set
    End Property
    Public Property telefonerespon As String
        Get
            Return m_telerespon
        End Get
        Set(ByVal value As String)
            m_telerespon = value
        End Set
    End Property

    Public Property email As String
        Get
            Return m_email
        End Get
        Set(ByVal value As String)
            m_email = value
        End Set
    End Property
    Public Property banido As Boolean
        Get
            Return m_banidos
        End Get
        Set(ByVal value As Boolean)
            m_banidos = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        If novo = True Then
            sql = "Insert into TabCadJogador (data, nome, cpf, telefone, dtnasc, nomerespon, cpfrespon, telefonerespon, email, banido) values ('" & m_data & "','" & m_nome & "','" & m_cpf & "','" & m_tele & "','" & m_dtnas & "','" & m_nomrespon & "','" & m_cpfrespon & "','" & m_telerespon & "','" & m_email & "'," & m_banidos & ")"
            objbanco.executar_comando(sql)
            localizar_ultimo()
        Else

            sql = "Update TabCadJogador set data='" & m_data & "', nome='" & m_nome & "', cpf='" & m_cpf & "',telefone='" & m_tele & "', dtnasc='" & m_dtnas & "', nomerespon='" & m_nomrespon & "', cpfrespon='" & m_cpfrespon & "',telefonerespon='" & m_telerespon & "', email='" & m_email & "', banido=" & m_banidos & " where Codjoga=" & m_cod

            objbanco.executar_comando(sql)

        End If

    End Sub

    Public Sub localizar_ultimo()
        sql = "select max(Codjoga) as codigo from TabCadJogador"
        m_cod = objbanco.Localizar_ultimocodigo(sql)
    End Sub

    Public Function excluir(nome As String, codigo As Integer) As Boolean
        If MessageBox.Show("Deseja excluir " & nome & "?", "Aviso",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from TabCadJogador where Codjoga=" & codigo
            objbanco.executar_comando(sql)
            Return True
        Else
            Return False
        End If

    End Function

    Public Function localizarRetornoTable(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from TabCadJogador where Codjoga=" & campo
        Else
            sql = "Select * from TabCadJogador where nome like '" & campo & "%' order by Codjoga"
        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function
    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from TabCadJogador where Codjoga=" & campo
        Else
            sql = "Select * from TabCadJogador where nome='" & campo & "'"
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

    Public Function vendasCliLoc(campo As String) As DataTable

        If IsNumeric(campo) Then
            sql = "SELECT TabLoc.CodLoc, TabComanda.Codentra, TabCadJogador.nome, TabCadFunc.Codfunc, TabCadFunc.nome, TabCadProdArmaria.Codproarma, TabCadProdArmaria.nome, TabCadProdArmaria.Documento, TabItensLoc.qtd, TabCadProdArmaria.preco, TabLoc.data FROM ((TabCadJogador INNER JOIN TabComanda ON TabCadJogador.Codjoga = TabComanda.Codjoga) INNER JOIN (TabCadFunc INNER JOIN TabLoc ON TabCadFunc.Codfunc = TabLoc.Codfunc) ON TabComanda.Codentra = TabLoc.comanda) INNER JOIN (TabCadProdArmaria INNER JOIN TabItensLoc ON TabCadProdArmaria.Codproarma = TabItensLoc.Codproarma) ON TabLoc.CodLoc = TabItensLoc.codigo where TabCadJogador.Codjoga=" & campo
            '     sql = "Select TabCadFunc.Codfunc, TabCadFunc.nome, sum(TabLoc.totpreco) AS Total, Count(TabLoc.totpreco) AS [Qtd de Vendas] from TabCadFunc INNER JOIN TabLoc ON TabCadFunc.Codfunc = TabLoc.Codfunc where TabCadFunc.Codfunc=" & campo
        Else
            sql = "SELECT TabLoc.CodLoc, TabComanda.Codentra, TabCadJogador.nome, TabCadFunc.Codfunc, TabCadFunc.nome, TabCadProdArmaria.Codproarma, TabCadProdArmaria.nome, TabCadProdArmaria.Documento, TabItensLoc.qtd, TabCadProdArmaria.preco, TabLoc.data FROM ((TabCadJogador INNER JOIN TabComanda ON TabCadJogador.Codjoga = TabComanda.Codjoga) INNER JOIN (TabCadFunc INNER JOIN TabLoc ON TabCadFunc.Codfunc = TabLoc.Codfunc) ON TabComanda.Codentra = TabLoc.comanda) INNER JOIN (TabCadProdArmaria INNER JOIN TabItensLoc ON TabCadProdArmaria.Codproarma = TabItensLoc.Codproarma) ON TabLoc.CodLoc = TabItensLoc.codigo where TabCadJogador.nome like '" & campo & "%' order by TabCadJogador.nome"
            'sql = "Select TabCadFunc.Codfunc, TabCadFunc.nome, sum(TabLoc.totpreco) AS Total, Count(TabLoc.totpreco) AS [Qtd de Vendas] from TabCadFunc INNER JOIN TabLoc ON TabCadFunc.Codfunc = TabLoc.Codfunc where nome like '" & campo & "%' order by nome"
        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function

    Public Function vendasLancoCli(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT TabCadFunc.Codfunc, TabCadFunc.nome, TabCadJogador.nome, TabComanda.Codentra, TabLanconete.Codlanco, TabLanconete.totpre, TabLanconete.data, TabCadProdLanco.nome, TabCadProdLanco.Codprolan, TabItens.QtdIte, TabCadProdLanco.preco FROM ((((TabItens AS TabItens INNER JOIN TabLanconete AS TabLanconete ON TabItens.VenIte = TabLanconete.Codlanco) INNER JOIN TabCadProdLanco AS TabCadProdLanco ON TabItens.ProIte = TabCadProdLanco.Codprolan) INNER JOIN TabComanda AS TabComanda ON TabLanconete.comanda = TabComanda.Codentra) INNER JOIN TabCadFunc AS TabCadFunc ON TabLanconete.Codfunc = TabCadFunc.Codfunc) INNER JOIN TabCadJogador AS TabCadJogador ON TabComanda.Codjoga = TabCadJogador.Codjoga where TabCadJogador.Codjoga=" & campo

        Else
            sql = " SELECT TabCadFunc.Codfunc, TabCadFunc.nome, TabCadJogador.nome, TabComanda.Codentra, TabLanconete.Codlanco, TabLanconete.totpre, TabLanconete.data, TabCadProdLanco.nome, TabCadProdLanco.Codprolan, TabItens.QtdIte, TabCadProdLanco.preco FROM ((((TabItens AS TabItens INNER JOIN TabLanconete AS TabLanconete ON TabItens.VenIte = TabLanconete.Codlanco) INNER JOIN TabCadProdLanco AS TabCadProdLanco ON TabItens.ProIte = TabCadProdLanco.Codprolan) INNER JOIN TabComanda AS TabComanda ON TabLanconete.comanda = TabComanda.Codentra) INNER JOIN TabCadFunc AS TabCadFunc ON TabLanconete.Codfunc = TabCadFunc.Codfunc) INNER JOIN TabCadJogador AS TabCadJogador ON TabComanda.Codjoga = TabCadJogador.Codjoga where TabCadJogador.nome like '" & campo & "%' order by TabCadJogador.nome"

        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function

    Public Function TotLancoCli(campo As String) As Single
        If IsNumeric(campo) Then
            sql = "SELECT sum(TabLanconete.totpre) as Total FROM TabCadJogador INNER JOIN(TabComanda INNER JOIN Tablanconete ON TabLanconete.comanda = TabComanda.Codentra) ON TabComanda.Codjoga = TabCadJogador.Codjoga where TabCadJogador.Codjoga = " & campo & " group by  TabCadJogador.Codjoga"

        Else
            sql = "SELECT sum(TabLanconete.totpre) as Total FROM TabCadJogador INNER JOIN(TabComanda INNER JOIN Tablanconete ON TabLanconete.comanda = TabComanda.Codentra) ON TabComanda.Codjoga = TabCadJogador.Codjoga where nome like '" & campo & "%'  group by  TabCadJogador.Codjoga"

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
        m_data = objdtLocal.Rows(0).Item(1)
        m_nome = objdtLocal.Rows(0).Item(2)
        m_cpf = objdtLocal.Rows(0).Item(3)
        m_tele = objdtLocal.Rows(0).Item(4)
        m_dtnas = objdtLocal.Rows(0).Item(5)
        m_nomrespon = objdtLocal.Rows(0).Item(6)
        m_cpfrespon = objdtLocal.Rows(0).Item(7)
        m_telerespon = objdtLocal.Rows(0).Item(8)
        m_email = objdtLocal.Rows(0).Item(9)
        m_banidos = objdtLocal.Rows(0).Item(10)

    End Sub
End Class

Public Class ClsItensLoc
    Dim m_cod As Integer
    Dim m_seq As Integer
    Dim m_proarma As Integer
    Dim m_qtdi As Integer
    Dim m_prei As Single

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

    Public Property sequencia As Integer
        Get
            Return m_seq
        End Get
        Set(ByVal value As Integer)
            m_seq = value
        End Set
    End Property

    Public Property Codproarma As Integer
        Get
            Return m_proarma
        End Get
        Set(ByVal value As Integer)
            m_proarma = value
        End Set
    End Property

    Public Property quantidadei As Integer
        Get
            Return m_qtdi
        End Get
        Set(ByVal value As Integer)
            m_qtdi = value
        End Set
    End Property

    Public Property precoi As Integer
        Get
            Return m_prei
        End Get
        Set(ByVal value As Integer)
            m_prei = value
        End Set
    End Property

    Public Function CodOuNomeArmaLoc(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT TabLoc.CodLoc, TabComanda.Codentra, TabCadJogador.nome, TabCadProdArmaria.Codproarma, TabCadProdArmaria.nome, TabCadProdArmaria.numserie, TabLoc.data, TabCadProdArmaria.preco FROM ((TabCadJogador INNER JOIN TabComanda ON TabCadJogador.Codjoga = TabComanda.Codjoga) INNER JOIN TabLoc ON TabComanda.Codentra = TabLoc.comanda) INNER JOIN (TabCadProdArmaria INNER JOIN TabItensLoc ON TabCadProdArmaria.Codproarma = TabItensLoc.Codproarma) ON TabLoc.CodLoc = TabItensLoc.codigo where TabCadProdArmaria.Codproarma = " & campo

        Else
            sql = "SELECT TabLoc.CodLoc, TabComanda.Codentra, TabCadJogador.nome, TabCadProdArmaria.Codproarma, TabCadProdArmaria.nome, TabCadProdArmaria.numserie, TabLoc.data, TabCadProdArmaria.preco FROM ((TabCadJogador INNER JOIN TabComanda ON TabCadJogador.Codjoga = TabComanda.Codjoga) INNER JOIN TabLoc ON TabComanda.Codentra = TabLoc.comanda) INNER JOIN (TabCadProdArmaria INNER JOIN TabItensLoc ON TabCadProdArmaria.Codproarma = TabItensLoc.Codproarma) ON TabLoc.CodLoc = TabItensLoc.codigo where TabCadProdArmaria.nome like '" & campo & "%' order by TabCadProdArmaria.nome"

        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function
    Public Function CodOuNomejoga(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT TabLoc.CodLoc, TabComanda.Codentra, TabCadJogador.nome, TabCadProdArmaria.Codproarma, TabCadProdArmaria.nome, TabCadProdArmaria.numserie, TabLoc.data, TabCadProdArmaria.preco FROM ((TabCadJogador INNER JOIN TabComanda ON TabCadJogador.Codjoga = TabComanda.Codjoga) INNER JOIN TabLoc ON TabComanda.Codentra = TabLoc.comanda) INNER JOIN (TabCadProdArmaria INNER JOIN TabItensLoc ON TabCadProdArmaria.Codproarma = TabItensLoc.Codproarma) ON TabLoc.CodLoc = TabItensLoc.codigo where TabComanda.Codentra = " & campo

        Else
            sql = "SELECT TabLoc.CodLoc, TabComanda.Codentra, TabCadJogador.nome, TabCadProdArmaria.Codproarma, TabCadProdArmaria.nome, TabCadProdArmaria.numserie, TabLoc.data, TabCadProdArmaria.preco FROM ((TabCadJogador INNER JOIN TabComanda ON TabCadJogador.Codjoga = TabComanda.Codjoga) INNER JOIN TabLoc ON TabComanda.Codentra = TabLoc.comanda) INNER JOIN (TabCadProdArmaria INNER JOIN TabItensLoc ON TabCadProdArmaria.Codproarma = TabItensLoc.Codproarma) ON TabLoc.CodLoc = TabItensLoc.codigo where TabCadJogador.nome like '" & campo & "%' order by TabCadJogador.nome"

        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function

    Public Function Localizar_porPeriodo(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StoConCodNomeArmaLocPeriodo", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function

    Public Function Localizar_porData(ByVal data1 As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StoConCodNomeArmaLocData", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))

        objda.SelectCommand.Parameters("campo1").Value = data1


        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function
    Public Sub gravar()
        sql = "Insert into TabItensLoc (codigo, seqItem, Codproarma, qtd, preco) values ('" & m_cod & "', '" & m_seq & "', '" & m_proarma & "', '" & m_qtdi & "', '" & m_prei & "' )"
        objbanco.executar_comando(sql)
    End Sub
End Class

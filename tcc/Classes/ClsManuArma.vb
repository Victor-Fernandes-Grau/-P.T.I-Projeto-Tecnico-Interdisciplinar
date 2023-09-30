Public Class ClsManuArma


    Dim m_codmanu As Integer
    Dim m_codarmero As Integer
    Dim m_dtini As Date
    Dim m_dtfim As Date
    Dim m_codarm As Single
    Dim m_preco As Single

    Dim sql As String
    Dim objbanco As New ClsBanco
    Dim objdtLocal As DataTable


    Public Property codmanu As Integer
        Get
            Return m_codmanu
        End Get
        Set(ByVal value As Integer)
            m_codmanu = value
        End Set
    End Property
    Public Property codarmero As Integer
        Get
            Return m_codarmero
        End Get
        Set(ByVal value As Integer)
            m_codarmero = value
        End Set
    End Property

    Public Property preco As Single
        Get
            Return m_preco
        End Get
        Set(ByVal value As Single)
            m_preco = value
        End Set
    End Property
    Public Property dtinicio As Date
        Get
            Return m_dtini
        End Get
        Set(ByVal value As Date)
            m_dtini = value
        End Set
    End Property
    Public Property dtfim As Date
        Get
            Return m_dtfim
        End Get
        Set(ByVal value As Date)
            m_dtfim = value
        End Set
    End Property
    Public Property codarma As Integer
        Get
            Return m_codarm
        End Get
        Set(ByVal value As Integer)
            m_codarm = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        If novo = True Then
            sql = "Insert into TabManuArma (Codarmero, preco, dtinicio, dtfim, Códarma) values ('" & m_codarmero & "','" & m_preco & "','" & m_dtini & "','" & m_dtfim & "','" & m_codarm & "')"
            objbanco.executar_comando(sql)
            localizar_ultimo()
        Else

            sql = "Update TabManuArma set Codarmero='" & m_codarmero & "',preco='" & m_preco & "',dtinicio='" & m_dtini & "',dtfim='" & m_dtfim & "',Códarma='" & m_codarm & "' where Codmanu=" & m_codmanu
            objbanco.executar_comando(sql)

        End If

    End Sub

    Public Sub localizar_ultimo()
        sql = "select max(Codmanu) as codigo from TabManuArma"
        m_codmanu = objbanco.Localizar_ultimocodigo(sql)
    End Sub

    Public Function excluir(nome As String, codigo As Integer) As Boolean
        If MessageBox.Show("Deseja excluir " & nome & "?", "Aviso",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from TabManuArma where Codmanu=" & codmanu
            objbanco.executar_comando(sql)
            Return True
        Else
            Return False
        End If

    End Function

    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from TabManuArma where Codmanu=" & campo
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

    Public Function vendasArmariaArma(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT TabManuArma.Codmanu, TabArmero.Codarmero, TabArmero.nome, TabManuArma.Códarma, TabCadProdArmaria.nome, TabManuArma.preco, TabManuArma.dtinicio, TabManuArma.dtfim FROM TabArmero INNER JOIN(TabManuArma INNER JOIN TabCadProdArmaria ON TabManuArma.Códarma = TabCadProdArmaria.Codproarma) ON TabManuArma.Codarmero = TabArmero.Codarmero where TabCadProdArmaria.Codproarma = " & campo

        Else
            sql = "SELECT TabManuArma.Codmanu, TabArmero.Codarmero, TabArmero.nome, TabManuArma.Códarma, TabCadProdArmaria.nome, TabManuArma.preco, TabManuArma.dtinicio, TabManuArma.dtfim FROM TabArmero INNER JOIN(TabManuArma INNER JOIN TabCadProdArmaria ON TabManuArma.Códarma = TabCadProdArmaria.Codproarma) ON TabManuArma.Codarmero = TabArmero.Codarmero where TabCadProdArmaria.nome like '" & campo & "%' order by TabCadProdArmaria.nome"

        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function

    Public Function TotArmariaArma(campo As String) As Single
        If IsNumeric(campo) Then
            sql = "SELECT sum(TabManuArma.preco) as Total FROM TabCadProdArmaria INNER JOIN(TabManuArma INNER JOIN TabArmero ON TabArmero.Codarmero = TabManuArma.Codarmero) ON TabManuArma.Códarma = TabCadProdArmaria.Codproarma where TabCadProdArmaria.Codproarma = " & campo & " group by  TabCadProdArmaria.Codproarma"

        Else
            sql = "SELECT sum(TabManuArma.preco) as Total FROM TabCadProdArmaria INNER JOIN(TabManuArma INNER JOIN TabArmero ON TabArmero.Codarmero = TabManuArma.Codarmero) ON TabManuArma.Códarma = TabCadProdArmaria.Codproarma where TabCadProdArmaria.nome like '" & campo & "%'  group by  TabCadProdArmaria.Codproarma"

        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        If objdtLocal.Rows.Count > 0 Then
            Return objdtLocal.Rows(0).Item(0)
        Else
            Return 0
        End If

    End Function

    Public Function Localizar_porPeriodo(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StoPeriodoComanda", objbanco.objcon))
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

        Dim objda = (New OleDb.OleDbDataAdapter("StoConManuArmaData", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))

        objda.SelectCommand.Parameters("campo1").Value = data1


        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function
    Public Function Localizar_porDataFinal(ByVal data1 As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StoConManuArmaDataFim", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))

        objda.SelectCommand.Parameters("campo1").Value = data1


        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function
    Public Sub mostrar_dadosDaClasse()
        m_codmanu = objdtLocal.Rows(0).Item(0)
        m_codarm = objdtLocal.Rows(0).Item(1)
        m_codarmero = objdtLocal.Rows(0).Item(2)
        m_dtini = objdtLocal.Rows(0).Item(3)
        m_dtfim = objdtLocal.Rows(0).Item(4)
        m_preco = objdtLocal.Rows(0).Item(5)


    End Sub




End Class

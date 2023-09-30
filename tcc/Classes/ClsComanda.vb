Public Class ClsComanda

    Dim m_cod As Integer
    Dim m_data As Date
    Dim m_entra As String
    Dim m_saida As String
    Dim m_campo As Boolean
    Dim m_codjog As String
    Dim m_tot As Integer
    Dim m_pago As Boolean
    Dim m_Tipodepagamento As String


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

    Public Property Data As Date
        Get
            Return m_data
        End Get
        Set(ByVal value As Date)
            m_data = value
        End Set
    End Property

    Public Property hrentrada As String
        Get
            Return m_entra
        End Get
        Set(ByVal value As String)
            m_entra = value
        End Set
    End Property
    Public Property hrsaida As String
        Get
            Return m_saida
        End Get
        Set(ByVal value As String)
            m_saida = value
        End Set
    End Property
    Public Property campo As Boolean
        Get
            Return m_campo
        End Get
        Set(ByVal value As Boolean)
            m_campo = value
        End Set
    End Property
    Public Property codjoga As String
        Get
            Return m_codjog
        End Get
        Set(ByVal value As String)
            m_codjog = value
        End Set
    End Property
    Public Property totGeral As Integer
        Get
            Return m_tot
        End Get
        Set(ByVal value As Integer)
            m_tot = value
        End Set
    End Property
    Public Property pago As Boolean
        Get
            Return m_pago
        End Get
        Set(ByVal value As Boolean)
            m_pago = value
        End Set
    End Property
    Public Property tipodepagamento As String
        Get
            Return m_Tipodepagamento
        End Get
        Set(ByVal value As String)
            m_Tipodepagamento = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        If novo = True Then
            sql = "Insert into TabComanda (hrentrada, codjoga, hrsaida, totGeral, Data, campo, pago, Tipodepagamento) values ('" & m_entra & "','" & m_codjog & "','" & m_saida & "','" & m_tot & "','" & m_data & "'," & m_campo & "," & m_pago & ",'" & m_Tipodepagamento & "')"
            objbanco.executar_comando(sql)
            localizar_ultimo()
        Else

            sql = "Update TabComanda set hrentrada='" & m_entra & "', codjoga='" & m_codjog & "', hrsaida='" & m_saida & "',totGeral='" & m_tot & "', Data='" & m_data & "', campo=" & m_campo & ", pago=" & m_pago & ", Tipodepagamento='" & m_Tipodepagamento & "'  where Codentra=" & m_cod

            objbanco.executar_comando(sql)

        End If

    End Sub

    Public Sub localizar_ultimo()
        sql = "select max(Codentra) as codigo from TabComanda"
        m_cod = objbanco.Localizar_ultimocodigo(sql)
    End Sub

    Public Function excluir(nome As String, codigo As Integer) As Boolean
        If MessageBox.Show("Deseja excluir " & nome & "?", "Aviso",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from TabComanda where Codentra=" & codigo
            objbanco.executar_comando(sql)
            Return True
        Else
            Return False
        End If

    End Function
    Public Function localizarNomeCodcli(campo As String) As DataTable
        If IsNumeric(campo) Then
            ' sql = "SELECT TabComanda.*, TabCadJogador.nome FROM TabComanda INNER JOIN TabCadJogador ON TabComanda.Codjoga = TabCadJogador.Codjoga "
            sql = "SELECT TabComanda.*, TabCadJogador.nome FROM TabComanda INNER JOIN TabCadJogador ON TabComanda.Codjoga = TabCadJogador.Codjoga where TabCadJogador.Codjoga=" & campo
            'sql = "Select * from TabComanda where Codentra=" & campo
        Else
            sql = "SELECT TabComanda.*, TabCadJogador.nome FROM TabComanda INNER JOIN TabCadJogador ON TabComanda.Codjoga = TabCadJogador.Codjoga where nome like'" & campo & "%' order by nome"
            'sql = "Select * from TabCadJogador where nome like '" & campo & "%' order by nome"
        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function

    Public Function localizarformadepag(campo As String) As DataTable
        If IsNumeric(campo) Then

            sql = "SELECT TabComanda.*, TabCadJogador.nome FROM TabComanda INNER JOIN TabCadJogador ON TabComanda.Codjoga = TabCadJogador.Codjoga where TabCadJogador.Codjoga=" & campo

        Else
            sql = "SELECT TabComanda.*, TabCadJogador.nome FROM TabComanda INNER JOIN TabCadJogador ON TabComanda.Codjoga = TabCadJogador.Codjoga where Tipodepagamento like'" & campo & "%' order by Tipodepagamento"

        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal
    End Function
    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from TabComanda where Codentra=" & campo

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

        Dim objda = (New OleDb.OleDbDataAdapter("StoDataComanda", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))

        objda.SelectCommand.Parameters("campo1").Value = data1


        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function

    Public Function dgdlanco(cod As String) As DataTable

        sql = "Select * from  StoConDgvComandaLanchonete WHERE Codentra=" & cod

        objdtLocal = objbanco.Localizar_dados(sql)

        Return objdtLocal
    End Function
    Public Function dgdarma(cod As String) As DataTable

        sql = "Select * from StoConDgvComandaArmaria WHERE Codentra=" & cod

        objdtLocal = objbanco.Localizar_dados(sql)

        Return objdtLocal
    End Function
   
    Public Sub mostrar_dadosDaClasse()
        m_cod = objdtLocal.Rows(0).Item(0)
        m_entra = objdtLocal.Rows(0).Item(1)
        m_campo = objdtLocal.Rows(0).Item(2)
        m_codjog = objdtLocal.Rows(0).Item(3)
        m_saida = objdtLocal.Rows(0).Item(4)
        m_tot = objdtLocal.Rows(0).Item(5)
        m_data = objdtLocal.Rows(0).Item(6)
        m_pago = objdtLocal.Rows(0).Item(7)
        m_Tipodepagamento = IIf(IsDBNull(objdtLocal.Rows(0).Item(8)), "", objdtLocal.Rows(0).Item(8))

    End Sub
    Public Function CodNom(cod As String) As DataTable

        sql = "Select * from ConCodNom WHERE codentra=" & cod

        objdtLocal = objbanco.Localizar_dados(sql)

        Return objdtLocal
    End Function
End Class

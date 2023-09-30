Public Class ClsArmaria

    Dim m_cod As Integer
    Dim m_nome As String
    Dim m_tipo As String
    Dim m_numerodeserie As String
    Dim m_mod As String
    Dim m_doc As String
    Dim m_qtd As Integer
    Dim m_preco As Single

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

    Public Property tipo As String
        Get
            Return m_tipo
        End Get
        Set(ByVal value As String)
            m_tipo = value
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

    Public Property numserie As String
        Get
            Return m_numerodeserie
        End Get
        Set(ByVal value As String)
            m_numerodeserie = value
        End Set
    End Property

    Public Property modelo As String
        Get
            Return m_mod
        End Get
        Set(ByVal value As String)
            m_mod = value
        End Set
    End Property
    Public Property documento As String
        Get
            Return m_doc
        End Get
        Set(ByVal value As String)
            m_doc = value
        End Set
    End Property
    Public Property qtd As Integer
        Get
            Return m_qtd
        End Get
        Set(ByVal value As Integer)
            m_qtd = value
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
    Public Sub baixar_estoque(id As Integer, qtd As Integer)
        sql = "Update TabCadProdArmaria set " & _
                  "qtd=qtd-'" & qtd & "'" & _
                  "where Codproarma=" & id

        objbanco.executar_comando(sql)
    End Sub
    Public Sub devolver_estoque(id As Integer, qtd As Integer)
        sql = "Update TabCadProdArmaria set " & _
                  "qtd=qtd+'" & qtd & "'" & _
                  "where Codproarma=" & id

        objbanco.executar_comando(sql)
    End Sub
    Public Sub gravar(novo As Boolean)
        If novo = True Then
            sql = "Insert into TabCadProdArmaria (tipo, nome, numserie, modelo, Documento, qtd, preco) values ('" & m_tipo & "','" & m_nome & "','" & m_numerodeserie & "','" & m_mod & "','" & m_doc & "','" & m_qtd & "','" & m_preco & "')"
            objbanco.executar_comando(sql)
            localizar_ultimo()
        Else

            sql = "Update TabCadProdArmaria set nome='" & m_tipo & "', tipo='" & m_nome & "', numserie='" & m_numerodeserie & "', modelo='" & m_mod & "', Documento='" & m_doc & "', qtd='" & m_qtd & "', preco='" & m_preco & "' where Codproarma=" & m_cod

            objbanco.executar_comando(sql)

        End If

    End Sub

    Public Sub localizar_ultimo()
        sql = "select max(Codproarma) as codigo from TabCadProdArmaria"
        m_cod = objbanco.Localizar_ultimocodigo(sql)
    End Sub

    Public Function excluir(nome As String, codigo As Integer) As Boolean
        If MessageBox.Show("Deseja excluir " & nome & "?", "Aviso",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from TabCadProdArmaria where Codproarma=" & codigo
            objbanco.executar_comando(sql)
            Return True
        Else
            Return False
        End If

    End Function
    Public Function localizarRetornoNomeCodigo(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from TabCadProdArmaria where Codproarma=" & campo
        Else
            sql = "Select * from TabCadProdArmaria where nome like '" & campo & "%' order by Codproarma"
        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function

    Public Function localizarRetornotipo(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from TabCadProdArmaria where tipo=" & campo
        Else
            sql = "Select * from TabCadProdArmaria where tipo like '" & campo & "%' order by Codproarma"
        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function

    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from TabCadProdArmaria where Codproarma=" & campo
        Else
            sql = "Select * from TabCadProdArmaria where nome='" & campo & "'"
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

    Public Function Localizar_porPeriodoLoc(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StoPeriodoLoc", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function

    Public Function Localizar_porDataLoc(ByVal dataini As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StoDataLoc", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))

        objda.SelectCommand.Parameters("campo1").Value = dataini


        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function

    '   Public Function consultaDgvComanda() As DataTable
    '      sql = "Select * from StoConDgvComandaArmaria"
    '     objdtLocal = objbanco.Localizar_dados(sql)
    '     Return objdtLocal

    '   End Function

    Public Sub mostrar_dadosDaClasse()
        m_cod = objdtLocal.Rows(0).Item(0)
        m_nome = objdtLocal.Rows(0).Item(2)
        m_tipo = objdtLocal.Rows(0).Item(1)
        m_numerodeserie = objdtLocal.Rows(0).Item(3)
        m_mod = objdtLocal.Rows(0).Item(4)
        m_doc = objdtLocal.Rows(0).Item(5)
        m_qtd = objdtLocal.Rows(0).Item(6)
        m_preco = objdtLocal.Rows(0).Item(7)

    End Sub
End Class

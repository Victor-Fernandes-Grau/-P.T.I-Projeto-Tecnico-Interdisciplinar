Public Class ClsVendLanco

    Dim m_cod As Integer
    Dim m_codfunc As Integer
    Dim m_codcoman As Integer
    Dim m_preco As Single
    Dim m_data As Date

    Dim sql As String
    Dim objbanco As New ClsBanco
    Dim objdtLocal As DataTable

    Public Property Codlanco As Integer
        Get
            Return m_cod
        End Get
        Set(ByVal value As Integer)
            m_cod = value
        End Set
    End Property

    Public Property Codfunc As Integer
        Get
            Return m_codfunc
        End Get
        Set(ByVal value As Integer)
            m_codfunc = value
        End Set
    End Property

    Public Property comanda As Integer
        Get
            Return m_codcoman
        End Get
        Set(ByVal value As Integer)
            m_codcoman = value
        End Set
    End Property
    Public Property totpre As Single
        Get
            Return m_preco
        End Get
        Set(ByVal value As Single)
            m_preco = value
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
    Public Sub gravar()

        sql = "Insert into TabLanconete (totpre, Codfunc, comanda, data) values ('" & m_preco & "','" & m_codfunc & "', '" & m_codcoman & "', '" & m_data & "'  )"
        objbanco.executar_comando(sql)
        localizar_ultimo()

    End Sub

    Public Sub localizar_ultimo()
        sql = "select max(Codlanco) as codigo from TabLanconete"
        m_cod = objbanco.Localizar_ultimocodigo(sql)
    End Sub
    Public Function localizarTot(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from TabLanconete where comanda=" & campo

        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        If objdtLocal.Rows.Count = 0 Then
            Return False
        Else
            mostrar_dadosDaarma()
            Return True
        End If

    End Function
    Public Sub mostrar_dadosDaarma()
        m_cod = objdtLocal.Rows(0).Item(0)
        m_preco = objdtLocal.Rows(0).Item(1)
        m_codfunc = objdtLocal.Rows(0).Item(2)
        m_codcoman = objdtLocal.Rows(0).Item(3)
        m_data = objdtLocal.Rows(0).Item(4)


    End Sub
End Class

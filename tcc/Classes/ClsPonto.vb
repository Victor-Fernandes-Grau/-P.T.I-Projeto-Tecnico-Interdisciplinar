Public Class ClsPonto
    Dim m_cod As Integer
    Dim m_dia As Date
    Dim m_horaentra As Integer
    Dim m_horasai As Integer
    Dim m_Codfunc As Integer

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
    Public Property dia As Date
        Get
            Return m_dia
        End Get
        Set(ByVal value As Date)
            m_dia = value
        End Set
    End Property
    Public Property horaentra As Integer
        Get
            Return m_horaentra
        End Get
        Set(ByVal value As Integer)
            m_horaentra = value
        End Set
    End Property
    Public Property horasai As Integer
        Get
            Return m_horasai
        End Get
        Set(ByVal value As Integer)
            m_horasai = value
        End Set
    End Property
    Public Property Codfunc As Integer
        Get
            Return m_Codfunc
        End Get
        Set(ByVal value As Integer)
            m_Codfunc = value
        End Set
    End Property
    Public Sub gravar(novo As Boolean)
        If novo = True Then
            sql = "Insert into TabPonto (dia, horaentra, horasai, Codfunc) values ('" & m_dia & "','" & m_horaentra & "','" & m_horasai & "','" & m_Codfunc & "')"
            objbanco.executar_comando(sql)
            localizar_ultimo()
        Else

            sql = "Update TabPonto set dia='" & m_dia & "', horaentra='" & m_horaentra & "', horasai='" & m_horasai & "', Codfunc='" & m_Codfunc & "' where Codigo=" & m_cod

            objbanco.executar_comando(sql)

        End If
    End Sub

    Public Sub localizar_ultimo()
        sql = "select max(Codigo) as codigo from TabPonto"
        m_cod = objbanco.Localizar_ultimocodigo(sql)
    End Sub

End Class

Public Class ClsItem
    Dim m_cod As Integer
    Dim m_seq As Integer
    Dim m_prodi As Integer
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

    Public Property produtoi As Integer
        Get
            Return m_prodi
        End Get
        Set(ByVal value As Integer)
            m_prodi = value
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

    Public Sub gravar()
        sql = "Insert into TabItens (VenIte, SeqIte, ProIte, QtdIte, PreIte) values ('" & m_cod & "', '" & m_seq & "', '" & m_prodi & "', '" & m_qtdi & "', '" & m_prei & "' )"
        objbanco.executar_comando(sql)
    End Sub
End Class

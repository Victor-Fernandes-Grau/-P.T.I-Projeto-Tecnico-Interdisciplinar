Public Class ClsLanchoneteConsulta
    Dim m_codcomanda As Integer
    Dim m_preco As Single


    Dim sql As String
    Dim objbanco As New ClsBanco
    Dim objdtLocal As DataTable

    Public Property comanda As Integer
        Get
            Return m_codcomanda
        End Get
        Set(ByVal value As Integer)
            m_codcomanda = value
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

    Public Sub gravar()

        sql = "Insert into StoConLanchonete (comanda, totpre) values ('" & m_codcomanda & "','" & m_preco & "'  )"
        objbanco.executar_comando(sql)
        localizar_ultimo()

    End Sub
    Public Sub localizar_ultimo()
        sql = "select max(Codlanco) as codigo from StoConLanchonete"
        m_codcomanda = objbanco.Localizar_ultimocodigo(sql)
    End Sub

    Public Function localizarTot(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from StoConLanchonete where comanda=" & campo

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
        m_codcomanda = objdtLocal.Rows(0).Item(0)
        m_preco = objdtLocal.Rows(0).Item(1)

    


    End Sub
End Class

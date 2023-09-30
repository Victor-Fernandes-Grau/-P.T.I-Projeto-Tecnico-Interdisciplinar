Public Class ClsLanco

    Dim m_tipo As String
    Dim m_cod As Integer
    Dim m_nome As String
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
        sql = "Update TabCadProdLanco set " & _
                  "qtd=qtd-'" & qtd & "'" & _
                  "where Codprolan=" & id

        objbanco.executar_comando(sql)
    End Sub
    Public Sub devolver_estoque(id As Integer, qtd As Integer)
        sql = "Update TabCadProdLanco set " & _
                  "qtd=qtd+'" & qtd & "'" & _
                  "where Codprolan=" & id

        objbanco.executar_comando(sql)
    End Sub

    Public Sub gravar(novo As Boolean)
        If novo = True Then
            sql = "Insert into TabCadProdLanco (tipo, nome, qtd, preco) values ('" & m_tipo & "','" & m_nome & "','" & m_qtd & "','" & m_preco & "')"
            objbanco.executar_comando(sql)
            localizar_ultimo()
        Else

            sql = "Update TabCadProdLanco set tipo='" & m_tipo & "' , nome='" & m_nome & "', qtd ='" & m_qtd & "', preco ='" & m_preco & "' where Codprolan=" & m_cod
            objbanco.executar_comando(sql)

        End If

    End Sub

    Public Sub localizar_ultimo()
        sql = "select max(Codprolan) as codigo from TabCadProdlanco"
        m_cod = objbanco.Localizar_ultimocodigo(sql)
    End Sub
    Public Function localizarRetornotipo(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from TabCadProdLanco where tipo=" & campo
        Else
            sql = "Select * from TabCadProdLanco where tipo like '" & campo & "%' order by Codprolan"
        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function
    Public Function excluir(nome As String, codigo As Integer) As Boolean
        If MessageBox.Show("Deseja excluir " & nome & "?", "Aviso",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from TabCadProdlanco where Codprolan=" & codigo
            objbanco.executar_comando(sql)
            Return True
        Else
            Return False
        End If

    End Function
    Public Function localizarRetornoTable(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from TabCadProdlanco where Codprolan=" & campo
        Else
            sql = "Select * from TabCadProdlanco where nome like '" & campo & "%' order by Codprolan"
        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function
    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from TabCadProdlanco where Codprolan=" & campo
        Else
            sql = "Select * from TabCadProdlanco where nome='" & campo & "'"
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
    Public Sub mostrar_dadosDaClasse()
        m_cod = objdtLocal.Rows(0).Item(0)
        m_tipo = objdtLocal.Rows(0).Item(1)
        m_nome = objdtLocal.Rows(0).Item(2)
        m_qtd = objdtLocal.Rows(0).Item(3)
        m_preco = objdtLocal.Rows(0).Item(4)


    End Sub
End Class
Public Class ClsArmero
    Dim m_cod As Integer
    Dim m_nom As String
    Dim m_cpf As String
    Dim m_tel As String
    Dim m_ema As String

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

    Public Property nome As String
        Get
            Return m_nom
        End Get
        Set(ByVal value As String)
            m_nom = value
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
            Return m_tel
        End Get
        Set(ByVal value As String)
            m_tel = value
        End Set
    End Property
    Public Property email As String
        Get
            Return m_ema
        End Get
        Set(ByVal value As String)
            m_ema = value
        End Set
    End Property
    Public Sub gravar(novo As Boolean)
        If novo = True Then
            sql = "Insert into TabArmero (nome, cpf, telefone, email) values ('" & m_nom & "','" & m_cpf & "','" & m_tel & "','" & m_ema & "')"
            objbanco.executar_comando(sql)
            localizar_ultimo()
        Else

            sql = "Update TabArmero set nome='" & m_nom & "',cpf='" & m_cpf & "', telcli='" & m_tel & "', email='" & m_ema & "' where Codarmero=" & m_cod

            objbanco.executar_comando(sql)

        End If

    End Sub

    Public Sub localizar_ultimo()
        sql = "select max(Codarmero) as codigo from TabArmero"
        m_cod = objbanco.Localizar_ultimocodigo(sql)
    End Sub

    Public Function excluir(nome As String, codigo As Integer) As Boolean
        If MessageBox.Show("Deseja excluir " & nome & "?", "Aviso",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from TabArmero where Codarmero=" & codigo
            objbanco.executar_comando(sql)
            Return True
        Else
            Return False
        End If

    End Function
    Public Function localizarRetornoTable(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from TabArmero where Codarmero=" & campo
        Else
            sql = "Select * from TabArmero where nome like '" & campo & "%' order by nome"
        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function

    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from TabArmero where Codarmero=" & campo
        Else
            sql = "Select * from TabArmero where nome='" & campo & "'"
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

    Public Function vendasArmariaArmero(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT TabManuArma.Codmanu, TabArmero.Codarmero, TabArmero.nome, TabManuArma.Códarma, TabCadProdArmaria.nome, TabManuArma.preco, TabManuArma.dtinicio, TabManuArma.dtfim FROM TabArmero INNER JOIN(TabManuArma INNER JOIN TabCadProdArmaria ON TabManuArma.Códarma = TabCadProdArmaria.Codproarma) ON TabManuArma.Codarmero = TabArmero.Codarmero where TabArmero.Codarmero = " & campo

        Else
            sql = "SELECT TabManuArma.Codmanu, TabArmero.Codarmero, TabArmero.nome, TabManuArma.Códarma, TabCadProdArmaria.nome, TabManuArma.preco, TabManuArma.dtinicio, TabManuArma.dtfim FROM TabArmero INNER JOIN(TabManuArma INNER JOIN TabCadProdArmaria ON TabManuArma.Códarma = TabCadProdArmaria.Codproarma) ON TabManuArma.Codarmero = TabArmero.Codarmero where TabArmero.nome like '" & campo & "%' order by TabArmero.nome"

        End If
        objdtLocal = objbanco.Localizar_dados(sql)
        Return objdtLocal

    End Function

    Public Function TotArmariaArmero(campo As String) As Single
        If IsNumeric(campo) Then
            sql = "SELECT sum(TabManuArma.preco) as Total FROM TabArmero INNER JOIN TabManuArma ON TabArmero.Codarmero = TabManuArma.Codarmero where TabArmero.Codarmero = " & campo & " group by  TabArmero.Codarmero"

        Else
            sql = "SELECT sum(TabManuArma.preco) as Total FROM TabArmero INNER JOIN TabManuArma ON TabArmero.Codarmero = TabManuArma.Codarmero where nome like '" & campo & "%'  group by  TabArmero.Codarmero"

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
        m_nom = objdtLocal.Rows(0).Item(1)
        m_cpf = objdtLocal.Rows(0).Item(2)
        m_tel = objdtLocal.Rows(0).Item(3)
        m_ema = objdtLocal.Rows(0).Item(4)


    End Sub
End Class


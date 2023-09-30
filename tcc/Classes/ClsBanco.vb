Public Class ClsBanco
    Dim strcon As String = "Provider=microsoft.ace.oledb.12.0;data source=bancotcc.mdb"
    Public objcon As New OleDb.OleDbConnection(strcon)

    Private Sub Abrir_banco()
        objcon.Open()
    End Sub

    Private Sub Fechar_banco()
        objcon.Close()
    End Sub

    Public Sub executar_comando(Sql As String)
        Abrir_banco()
        Dim objcmd As New OleDb.OleDbCommand(Sql, objcon)
        objcmd.ExecuteNonQuery()
        Fechar_banco()
    End Sub

    Public Function Localizar_ultimocodigo(sql As String) As Integer
        Dim objda As New OleDb.OleDbDataAdapter(sql, objcon)
        Dim objdt As New DataTable
        objda.Fill(objdt)
        Return objdt.Rows(0).Item(0)
    End Function

    Public Function Localizar_dados(sql As String) As DataTable
        Dim objda As New OleDb.OleDbDataAdapter(sql, objcon)
        Dim objdt As New DataTable
        objda.Fill(objdt)
        Return objdt
    End Function

End Class

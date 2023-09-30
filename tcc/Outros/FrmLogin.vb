Imports System.Data
Imports System.Data.OleDb

Public Class FrmLogin
    Dim conexao As New OleDbConnection
    Dim comando As New OleDbCommand
    Dim adaptador As New OleDbDataAdapter
    Dim leitor As OleDbDataReader
    Dim consulta As String


    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexao.ConnectionString = "Provider=microsoft.ace.oledb.12.0;data source=bancotcc.mdb"
            conexao.Open()

        Catch ex As Exception
            MsgBox("erro so conectar com banco")
        End Try
    End Sub


    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        Dim x As Integer
        x = 0
        If TxtUsuario.Text = "" Then
            MessageBox.Show("Favor preencher usuario")
            TxtUsuario.Focus()
        ElseIf TxtSenha.Text = "" Then
            MessageBox.Show("Favor preencher a senha")
            TxtSenha.Focus()
        Else

            consulta = "SELECT usuario, senha, area  FROM TabCadFunc WHERE usuario = '" & TxtUsuario.Text &
               "' AND senha = '" & TxtSenha.Text & "'AND area = 'Gerente' "
            comando = New OleDbCommand(consulta, conexao)
            leitor = comando.ExecuteReader
            If leitor.HasRows = True Then
                FrmMenuGerente.Visible = True
                TxtUsuario.Clear()
                TxtSenha.Clear()
                Me.Visible = False
                x = x + 1

            End If

            consulta = "SELECT usuario, senha, area  FROM TabCadFunc WHERE usuario = '" & TxtUsuario.Text &
                "' AND senha = '" & TxtSenha.Text & "'AND area = 'Dono' "
            comando = New OleDbCommand(consulta, conexao)
            leitor = comando.ExecuteReader
            If leitor.HasRows = True Then
                FrmMenuGerente.Show()
                TxtUsuario.Clear()
                TxtSenha.Clear()
                Me.Visible = False
                x = x + 1
            End If

            consulta = "SELECT usuario, senha, area  FROM TabCadFunc WHERE usuario = '" & TxtUsuario.Text &
               "' AND senha = '" & TxtSenha.Text & "'AND area = 'Armaria' "
            comando = New OleDbCommand(consulta, conexao)
            leitor = comando.ExecuteReader
            If leitor.HasRows = True Then
                FrmMenuFuncionario.Show()
                TxtUsuario.Clear()
                TxtSenha.Clear()
                Me.Visible = False
                x = x + 1
            End If

            consulta = "SELECT usuario, senha, area  FROM TabCadFunc WHERE usuario = '" & TxtUsuario.Text &
            "' AND senha = '" & TxtSenha.Text & "'AND area = 'Lançõnete' "
            comando = New OleDbCommand(consulta, conexao)
            leitor = comando.ExecuteReader
            If leitor.HasRows = True Then
                FrmMenuFuncionario.Show()
                TxtUsuario.Clear()
                TxtSenha.Clear()
                Me.Visible = False
                x = x + 1
            End If

            consulta = "SELECT usuario, senha, area  FROM TabCadFunc WHERE usuario = '" & TxtUsuario.Text &
                "' AND senha = '" & TxtSenha.Text & "'AND area = 'Campo' "
            comando = New OleDbCommand(consulta, conexao)
            leitor = comando.ExecuteReader

            If leitor.HasRows = True Then
                FrmMenuFuncionario.Show()
                TxtUsuario.Clear()
                TxtSenha.Clear()
                Me.Visible = False
                x = x + 1
            End If

            If x = 0 Then
                MessageBox.Show("Usuario ou senha incoretas")
                TxtSenha.Clear()

                TxtUsuario.Focus()

            End If

        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TxtUsuario.Clear()
        TxtSenha.Clear()
        TxtSenha.PasswordChar = "*"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If TxtSenha.PasswordChar = "*" Then
            TxtSenha.PasswordChar = ""

        Else
            TxtSenha.PasswordChar = "*"

        End If
    End Sub

End Class
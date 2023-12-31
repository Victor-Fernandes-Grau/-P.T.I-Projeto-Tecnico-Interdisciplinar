﻿Public Class ClsControle
    Public Function So_numeros(caracter As String) As Boolean
        If Asc(caracter) = 8 Or Asc(caracter) = 13 Then
            Return False
        ElseIf Asc(caracter) < 48 Or Asc(caracter) > 57 Then
            Return True
        End If


    End Function
    Public Function So_numerosEvirgula(caracter As String) As Boolean
        If Asc(caracter) = 8 Or Asc(caracter) = 13 Or Asc(caracter) = 44 Then
            Return False
        ElseIf Asc(caracter) < 48 Or Asc(caracter) > 57 Then
            Return True
        End If


    End Function
    Public Sub Limpar_tela(tela As Object)
        Dim controle As Object
        For Each controle In tela.controls
            If TypeOf controle Is TextBox Or
                TypeOf controle Is MaskedTextBox Then
                controle.Text = ""
            ElseIf TypeOf controle Is CheckBox Then
                controle.Checked = False
            End If
        Next
    End Sub
    Public Sub Habilitar_tela(tela As Object, tipo As Boolean)
        Dim controle As Control
        For Each controle In tela.controls
            If TypeOf controle Is TextBox Or
                TypeOf controle Is MaskedTextBox Or
                TypeOf controle Is ComboBox Or
                TypeOf controle Is DateTimePicker Or
                TypeOf controle Is CheckBox Then
                controle.Enabled = tipo
            End If
        Next
    End Sub

    Public Sub Habilitar_botoes(tela As Object, tipo As Boolean)
        Dim controle As Control
        For Each controle In tela.controls
            If TypeOf controle Is Button Then
                controle.Enabled = tipo
                If controle.Name.ToUpper = "BTNGRA" Then
                    controle.Enabled = Not tipo
                ElseIf controle.Name.ToUpper = "BTNSAI" Or
                    controle.Name.ToUpper = "BTNCAN" Then
                    controle.Enabled = True
                End If
            End If
        Next
    End Sub

    Public Function Testar_vazio(tela As Control) As Boolean
        Dim controle As Object
        For Each controle In tela.Controls
            If TypeOf controle Is TextBox Or TypeOf controle Is ComboBox Then
                If controle.text = "" And controle.tag <> "x" Then
                    MessageBox.Show("Preencha todos os campos obrigatorios", "Aviso")
                    controle.Focus()
                    Return True
                End If
            End If
        Next
    End Function

    Public Function So_letras(caracter As String) As Boolean
        If Asc(caracter) = 8 Or Asc(caracter) = 13 Or Asc(caracter) = 44 Then
            Return False
        ElseIf Asc(caracter) > 48 Or Asc(caracter) < 57 Then
            Return True
        End If
    End Function

End Class

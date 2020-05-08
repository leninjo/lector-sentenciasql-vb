Imports System.ComponentModel

Public Class LectorSQL
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles cadena.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub analizar(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick

        Dim reservadas() As String = {"select", "from", "where"}
        Dim identificadores() As String = {"alumnos", "libros", "profesores", "usuarios", "personas"}
        Dim operadores() As String = {"*", "(", ")", "=", ".", ",", "+"}

        Dim text As String = cadena.Text
        Dim sentencia() As String = Split(text)


        For Each palabra As String In sentencia
            ' verifica si la palabra es reservada ¿
            For Each palabra2 As String In reservadas
                If palabra = palabra2 Then
                    lista.Items.Add("» Reservada: " + palabra)
                End If
            Next

            For Each palabra2 As String In identificadores
                If palabra = palabra2 Then
                    lista.Items.Add("» Identificador: " + palabra)
                End If
            Next

            ' verifica si la palabra es un operador '
            For Each palabra2 As String In operadores
                If palabra = palabra2 Then
                    lista.Items.Add("» Operador: " + palabra)
                End If
            Next

            ' verifica si la cadena es número '
            For Each palabra2 As String In sentencia
                If IsNumeric(palabra) Then
                    lista.Items.Add("» Número: " + palabra)
                End If
            Next

            ' verifica si la palabra es una cadena '     
            For Each palabra2 As Char In palabra
                If palabra2 = "'" Then
                    lista.Items.Add("» Cádena: " + palabra)
                    Exit For
                End If
            Next
        Next

    End Sub

    Private Sub lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cadena.Clear()
        lista.Items.Clear()
    End Sub
End Class

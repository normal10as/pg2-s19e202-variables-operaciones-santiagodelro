Imports System

Module Cuadratica
    Sub Main(args As String())
        Dim a = 1
        Dim b = 5
        Dim c = 2
        Dim resultado As Single
        resultado = ((b ^ 2) - (4 * a * c)) / (2 * a)
        Console.Write("X = ((b ^ 2) - (4 * a * c)) / (2 * a) es: " & resultado)
    End Sub
End Module

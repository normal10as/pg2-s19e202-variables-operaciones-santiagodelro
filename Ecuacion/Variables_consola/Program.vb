Imports System

Module Program
    Sub Main(args As String())
        Dim a = 1
        Dim b = 5
        Dim c = 2
        Dim resultado = 0
        resultado = ((b ^ 2) - (4 * a * c)) / (2 * a)
        Console.Write("X = ((b ^ 2) - (4 * a * c)) / (2 * a) es: " & resultado
                      )
    End Sub
End Module

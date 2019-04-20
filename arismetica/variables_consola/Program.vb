Imports System

Module Program
    Sub Main(args As String())
        Dim a, b As Integer
        a = 5
        b = 10
        Dim c, d, resultado As Decimal
        c = 3.5
        d = 6.3

        resultado = a + b
        Console.WriteLine("Suma entero con entero: " & resultado)
        resultado = a + d
        Console.WriteLine("Suma entero con flotante: " & resultado)
        resultado = b - a
        Console.WriteLine("Resta entero con entero: " & resultado)
        resultado = d - c
        Console.WriteLine("Resta flotante con flotante: " & resultado)
        resultado = b * c
        Console.WriteLine("Multiplicacion entero con flotante: " & resultado)
        resultado = b * a
        Console.WriteLine("Multiplicacion entero con entero: " & resultado)
        resultado = d / c
        Console.WriteLine("Division flotante con flotante: " & resultado)
        resultado = b / c
        Console.WriteLine("division entero con flotante: " & resultado)


    End Sub
End Module

Imports System

Module suma_promedio
    Sub Main(args As String())
        Dim a, b, c, d, Suma, Resultado As Integer
        Console.WriteLine("Ingrese 4 valores: ")
        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()
        d = Console.ReadLine()
        Suma = a + b + c + d
        Resultado = Suma / 4
        Console.WriteLine("La suma total es: " & Suma)
        Console.WriteLine("El promedio es: " & Resultado)


    End Sub
End Module

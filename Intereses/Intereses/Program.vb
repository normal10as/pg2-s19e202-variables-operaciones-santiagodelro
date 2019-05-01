Imports System

Module Intereses
    Sub Main(args As String())
        Dim m, r, t, i, c As Single
        Console.Write("Ingrese el monto: ")
        m = Console.ReadLine()
        Console.Write("Ingrese el Interes Anual: ")
        r = Console.ReadLine()
        Console.Write("Ingrese el Tiempo: ")
        t = Console.ReadLine()
        i = (m * r * t) / (360 * 100)
        c = m + i
        Console.WriteLine("El interes es: " & i & "El capital acomulado es: " & c)


    End Sub
End Module

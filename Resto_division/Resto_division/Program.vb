Imports System

Module Resto_division
    Sub Main(args As String())
        Dim a, r As Integer
        Console.Write("Ingresar un Entero: ")
        a = Console.ReadLine()
        r = a Mod 2
        Console.WriteLine("El resto es: " & r)
    End Sub
End Module

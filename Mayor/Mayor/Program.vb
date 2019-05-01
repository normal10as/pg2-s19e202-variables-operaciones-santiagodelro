Imports System
Imports System.Math
Module Mayor
    Sub Main(args As String())
        Dim numero1, numero2, numero3, mayor As Single
        Console.Write("Ingrese un valor: ")
        numero1 = Console.ReadLine()
        Console.Write("Ingrese un valor: ")
        numero2 = Console.ReadLine()
        Console.Write("Ingrese un valor: ")
        numero3 = Console.ReadLine()
        mayor = Max(numero1, numero2)
        mayor = Max(numero3, mayor)
        Console.WriteLine("El numero mayor es: " & mayor)

    End Sub
End Module

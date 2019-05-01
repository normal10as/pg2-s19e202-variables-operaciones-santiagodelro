Imports System
Imports System.Math

Module Matematica1
    Sub Main(args As String())
        Dim numero, absoluto, potencia, raiz As Single
        Console.Write("Ingrese un Valor: ")
        numero = Console.ReadLine()
        absoluto = Abs(numero)
        potencia = Pow(absoluto, 10)
        raiz = Sqrt(absoluto)
        Console.WriteLine("Valor Absoluto: " & absoluto)
        Console.WriteLine("Valor a la decima Potencia: " & potencia)
        Console.WriteLine("Raiz Cuadrada: " & raiz)
    End Sub
End Module

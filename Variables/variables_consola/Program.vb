Imports System
'EJERCICIO 1.1
Module Variables
    Sub Main(args As String())
        Dim Nombre As String
        Dim Apellido As String
        Dim Fecha As String

        Console.Write("Ingrese el nombre: ")
        Nombre = Console.ReadLine()
        Console.Write("Ingrese el Apellido: ")
        Apellido = Console.ReadLine()
        Console.Write("Ingrese la fecha de Nacimiento: ")
        Fecha = Console.ReadLine()

        Console.WriteLine(Apellido & " " & Nombre & " nació el " & Fecha)
    End Sub
End Module


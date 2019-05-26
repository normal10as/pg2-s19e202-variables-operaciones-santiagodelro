Imports System

Module Dias
    Enum DiasSemana As Integer
        lunes = 1
        martes = 2
        miercoles = 3
        jueves = 4
        viernes = 5
        sabado = 6
        domingo = 7
    End Enum
    Sub Main(args As String())
        Dim Dia As DiasSemana
        Console.Write("Ingrese los el Dia(1-7): ")
        Dia = Console.ReadLine
        Console.WriteLine("El dia es: " & Dia.ToString)
    End Sub


End Module

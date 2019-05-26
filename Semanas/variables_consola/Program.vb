Imports System

Module equivalencia_dias
    Sub Main(args As String())
        Dim MinutosPorHora, DiasPorSemana, HorasPorDia As Single
        Const semana As Integer = 7
        Const hora As Integer = 24
        Const minutos As Integer = 60
        Dim Dias As Integer
        Console.Write("Ingrese Los Dias: ")
        Dias = Console.ReadLine()
        DiasPorSemana = Dias / semana
        HorasPorDia = Dias * hora
        MinutosPorHora = HorasPorDia * minutos
        Console.WriteLine("Numero de Semanas: " & DiasPorSemana)
        Console.WriteLine("Numero de Horas: " & HorasPorDia)
        Console.WriteLine("Numero de minutos: " & MinutosPorHora)
    End Sub
End Module

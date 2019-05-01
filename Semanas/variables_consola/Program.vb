Imports System

Module equivalencia_dias
    Sub Main(args As String())
        Dim MinutosPorHora, DiasPorSemana, HorasPorDia As Single
        Dim Dias As Integer
        Console.Write("Ingrese Los Dias: ")
        Dias = Console.ReadLine()
        DiasPorSemana = Dias / 7
        HorasPorDia = Dias * 24
        MinutosPorHora = HorasPorDia * 60
        Console.WriteLine("Numero de Semanas: " & DiasPorSemana)
        Console.WriteLine("Numero de Horas: " & HorasPorDia)
        Console.WriteLine("Numero de minutos: " & MinutosPorHora)



    End Sub
End Module

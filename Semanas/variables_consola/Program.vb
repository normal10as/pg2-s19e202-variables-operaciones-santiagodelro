Imports System

Module Semanas
    Sub Main(args As String())
        Dim Diasanual = 365
        Dim DiasLab, DiasSem As Integer
        DiasSem = 364 / 7
        DiasLab = DiasSem * 5
        DiasLab = DiasLab / 7
        Console.WriteLine("Semanas del a�o: " & DiasSem)
        Console.WriteLine("Semanas Laborales del a�o: " & DiasLab)

    End Sub
End Module

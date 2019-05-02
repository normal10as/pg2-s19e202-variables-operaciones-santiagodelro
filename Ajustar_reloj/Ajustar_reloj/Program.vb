Imports System

Module Ajustar_reloj
    Sub Main(args As String())
        Dim Dia, Hora, mes, anio, fecha
        Dia = 7
        Hora = 21
        mes = Date.Now.Month
        anio = Date.Now.Year
        fecha = Dia & "/" & mes & "/" & anio & "  " & Hora & "Hs."
        Console.Write("La fecha Ajustada es: " & fecha)
    End Sub
End Module

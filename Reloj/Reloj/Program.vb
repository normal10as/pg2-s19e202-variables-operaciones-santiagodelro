Imports System

Module Reloj
    Sub Main(args As String())
        Dim dia, mes, hora, minuto
        dia = Date.Now.Day
        mes = Date.Now.Month
        hora = Date.Now.Hour
        minuto = Date.Now.Minute

        Console.WriteLine("Dia: " & dia & vbLf & "Mes: " & mes & vbLf & "Hora y minuto: " & hora & ":" & minuto)
    End Sub
End Module

Imports System.DateTime

Module Ajustar_reloj
    Sub Main(args As String())
        Dim Dia, Hora As Byte
        Dim fecha As Date
        Console.Write("Ingresar dia: ")
        Dia = Console.ReadLine()
        Console.Write("Ingresar hora: ")
        Hora = Console.ReadLine()
        fecha = New DateTime(now.year, now.month, Dia, Hora, now.minute, now.second)

        Console.Write("La fecha Ajustada es: " & fecha)
    End Sub
End Module

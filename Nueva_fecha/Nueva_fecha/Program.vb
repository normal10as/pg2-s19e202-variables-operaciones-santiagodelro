Imports System

Module Nueva_fecha
    Sub Main(args As String())
        Dim dia, nuevafecha
        Dim fecha As Date
        Console.Write("Ingrese una fecha(dia/mes/anio): ")
        fecha = Console.ReadLine()
        Console.Write("Ingrese los dias a agregar: ")
        dia = Console.ReadLine()
        nuevafecha = fecha.AddDays(dia)
        Console.Write("La fecha es: " & fecha & vbLf & "La nueva fecha es: " & nuevafecha)


    End Sub
End Module

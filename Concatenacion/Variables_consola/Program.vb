Imports System

Module concatenacion
    Sub Main(args As String())
        Dim Nombre = "Microsoft"
        Console.WriteLine(Nombre)
        Dim NombreCalle = "West Flamingo Road "
        Console.WriteLine(NombreCalle)
        Dim Altura = "8448"
        Console.WriteLine(Altura)
        Dim Fecha = "5 / 10 / 1898"
        Console.WriteLine(Fecha)
        Console.WriteLine(vbLf & "Nombre: " & Nombre & vbLf & "Direccion: " & NombreCalle & Altura &
            vbLf & "Inicio de Actividades: " & Fecha
                          )


    End Sub
End Module

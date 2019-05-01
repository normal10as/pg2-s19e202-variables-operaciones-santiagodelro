Imports System

Module concatenacion
    Sub Main(args As String())
        Dim Nombre As String = "Microsoft"
        Console.WriteLine(Nombre)
        Dim NombreCalle As String = "West Flamingo Road "
        Console.WriteLine(NombreCalle)
        Dim Altura As Integer = 8448
        Console.WriteLine(Altura)
        Dim Fecha As Date = #5/10/1898#
        Console.WriteLine(Fecha)
        Console.WriteLine("Conversion Implicita: " & vbLf & "Nombre: " & Nombre & vbLf & "Direccion: " & NombreCalle & Altura &
            vbLf & "Inicio de Actividades: " & Fecha)


        Console.WriteLine("Conversion Explicita: " + vbLf + "Nombre: " + Nombre + " Direccion: " _
            + NombreCalle + Convert.ToString(Altura) + " Inicio de Actividades: " + Convert.ToString(Fecha))



    End Sub



End Module

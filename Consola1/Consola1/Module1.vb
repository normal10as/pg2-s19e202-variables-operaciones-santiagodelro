Module Module1

    Sub Main()
        Dim Palabra As String
        Dim Posicion As Integer
        Console.Write("Ingrese una palabra: ")
        Palabra = Console.ReadLine()
        Posicion = InStr(1, Palabra, "a")
        Console.WriteLine(Posicion)
    End Sub

End Module

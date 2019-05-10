Module Module1

    Sub Main()
        Dim Palabra, Invertida As String
        Dim Posicion As Integer
        Console.Write("Ingrese una palabra: ")
        Palabra = Console.ReadLine()
        Posicion = InStr(1, Palabra, "a")
        Console.WriteLine("La primera a aparece en la posicion: " & Posicion)
        Posicion = InStr(1, Palabra, "o")
        Console.WriteLine("La primera o aparece en la posicion: " & Posicion)
        Invertida = StrReverse(Palabra)
        Console.WriteLine("La palabra invertida: " & Invertida)


    End Sub

End Module

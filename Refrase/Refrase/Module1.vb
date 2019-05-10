Module Module1

    Sub Main()
        Dim Cadena As String = "Aunque la cadena sea de oro, sirve para lo mismo."
        Dim Palabra, PalabraNueva, Resultado As String
        Console.WriteLine("Aunque la cadena sea de oro, sirve para lo mismo.")
        Console.Write("Ingrese la palabra a reemplazar: ")
        Palabra = Console.ReadLine()
        Console.Write("Ingrese la Nueva palabra: ")
        PalabraNueva = Console.ReadLine()
        PalabraNueva = " " + PalabraNueva + " "
        Resultado = Replace(Cadena, Palabra, PalabraNueva)
        Console.WriteLine("Resultado: " & Resultado)

    End Sub

End Module

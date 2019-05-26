Module Module1

    Sub Main()
        Dim Cadena As String = "Aunque la cadena sea de oro, sirve para lo mismo."
        Dim PalabraActual, PalabraNueva, Resultado As String
        Console.WriteLine(Cadena)
        Console.Write("Ingrese la palabra a reemplazar: ")
        PalabraActual = Console.ReadLine()
        Console.Write("Ingrese la Nueva palabra: ")
        PalabraNueva = Console.ReadLine()
        Dim PalabraActual1 = " " + PalabraActual + " "
        Dim PalabraNueva1 = " " + PalabraNueva + " "
        Resultado = Replace(Cadena, PalabraActual1, PalabraNueva1)
        PalabraActual1 = " " + PalabraActual + ","
        PalabraNueva1 = " " + PalabraNueva + ","
        Resultado = Replace(Resultado, PalabraActual1, PalabraNueva1)
        PalabraActual1 = " " + PalabraActual + "."
        PalabraNueva1 = " " + PalabraNueva + "."
        Resultado = Replace(Resultado, PalabraActual1, PalabraNueva1)
        PalabraActual1 = PalabraActual + " "
        PalabraNueva1 = PalabraNueva + " "
        Resultado = Replace(Resultado, PalabraActual1, PalabraNueva1, 1, -1, CompareMethod.Text)

        Console.WriteLine("Resultado: " & Resultado)
        Console.Read()
    End Sub

End Module

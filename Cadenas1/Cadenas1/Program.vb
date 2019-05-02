Imports System


Module Cadenas1
    Sub Main(args As String())


    End Sub
    Function InStr()
        Dim Palabra As String
        Dim Posicion As Integer
        Console.Write("Ingrese una palabra: ")
        Palabra = Console.ReadLine()
        Posicion = InStr(0, Palabra, "a")
        Console.Write(Posicion)

    End Function
End Module

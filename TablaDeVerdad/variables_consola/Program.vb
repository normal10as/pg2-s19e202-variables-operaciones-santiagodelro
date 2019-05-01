Imports System

Module TablaDeVerdad
    Sub Main(args As String())
        Dim P, Q, Resultado As Boolean

        P = 1
        Q = 0
        Resultado = P And Q
        Console.WriteLine("AND: " & Resultado)
        Resultado = P Or Q
        Console.WriteLine("OR: " & Resultado)
        Resultado = P Xor Q
        Console.WriteLine("XOR: " & Resultado)
        Resultado = Not P
        Console.WriteLine("NOT P: " & Resultado)
        Resultado = Not Q
        Console.WriteLine("NOT Q: " & Resultado)
    End Sub
End Module

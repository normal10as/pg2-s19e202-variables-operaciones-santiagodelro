Imports System
Imports System.Math
Module Redondeo
    Sub Main(args As String())

        Dim numero, exceso, defecto, redondeo As Single
        Console.Write("Ingrese un valor: ")
        numero = Console.ReadLine()
        exceso = Ceiling(numero)
        defecto = Floor(numero)
        redondeo = Round(numero)
        Console.WriteLine("Valor por Exceso: " & exceso & vbLf & "Valor por defecto: " &
        defecto & vbLf & "Valor por redondero: " & redondeo)



    End Sub
End Module

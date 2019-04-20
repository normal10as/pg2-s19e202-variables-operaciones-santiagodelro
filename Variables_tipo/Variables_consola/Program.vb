Imports System

Module variables_tipos
    Sub Main(args As String())
        Dim Nombre As String
        Nombre = "Santiago"
        Dim DNI As UInteger
        DNI = 40196662
        Dim Lugar As String
        Lugar = "Posadas Misiones, Argentina"
        Dim Fecha As Date
        Fecha = #1997/11/07#
        Dim Altura As Integer
        Altura = 1.75
        Dim Argentino As Boolean
        Argentino = True
        Dim Temperatura As Byte
        Temperatura = 27
        Dim Calle As String
        Calle = "Felix Aguirre"
        Dim AlturaCalle As UShort
        AlturaCalle = 1172
        Dim Distancia As Integer
        Distancia = 1100
        Dim Profundidad As UShort
        Profundidad = 1150
        Dim Habitantes As UInteger
        Habitantes = 44270000
        Dim Peso As Decimal
        Peso = 21.5
        Dim Monto As Decimal
        Monto = 45.87

        Console.WriteLine("Nombre de una persona: " & Nombre & vbLf & "Número de Documento: " & DNI & vbLf &
            "Lugar de Nacimiento: " & Lugar & vbLf & "Fecha de nacimiento: " & Fecha & vbLf & "Altura Corporal: " & Altura &
            vbLf & "Si es Argentino: " & Argentino & vbLf & "Temperatura ambiente: " & Temperatura & vbLf & "Nombre calle: " &
            Calle & vbLf & "ltura de Calle: " & AlturaCalle & vbLf & "Distancia en kms entre dos ciudades cualquiera: " &
            Distancia & vbLf & "Profundidad en metros: " & Profundidad & vbLf & "Cantidad de habitantes: " & Habitantes &
            vbLf & "Peso de un producto de supermercado en Kilogramos: " & Peso & vbLf & "Monto de un artículo de un supermercado: " &
            Monto
                      )

    End Sub
End Module

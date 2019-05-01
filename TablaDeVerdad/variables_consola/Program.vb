Imports System

Module Table_booleana
    Sub Main(args As String())
        Dim P1, P2, Q1, Q2, R1, R2, R3, R4 As Boolean

        P1 = True
        Q1 = False
        P2 = False
        Q2 = True
        '-----------------AND------------
        R1 = P1 And Q1
        R2 = P2 And Q2
        R3 = P2 And Q1
        R4 = P1 And Q2

        Console.WriteLine("-------AND-------")
        Console.WriteLine("V    V   " & R4)
        Console.WriteLine("V    F   " & R1)
        Console.WriteLine("V    V   " & R2)
        Console.WriteLine("V    V   " & R3)
        '---------------OR--------------
        R1 = P1 Or Q1
        R2 = P2 Or Q2
        R3 = P2 Or Q1
        R4 = P1 Or Q2

        Console.WriteLine("-------OR-------")
        Console.WriteLine("V    V   " & R4)
        Console.WriteLine("V    F   " & R1)
        Console.WriteLine("V    V   " & R2)
        Console.WriteLine("V    V   " & R3)
        '---------------XOR--------------
        R1 = P1 Xor Q1
        R2 = P2 Xor Q2
        R3 = P2 Xor Q1
        R4 = P1 Xor Q2

        Console.WriteLine("-------XOR-------")
        Console.WriteLine("V    V   " & R4)
        Console.WriteLine("V    F   " & R1)
        Console.WriteLine("V    V   " & R2)
        Console.WriteLine("V    V   " & R3)
        '---------------NOT--------------
        R1 = Not P1
        R2 = Not Q1
        Console.WriteLine("-------NOT-------")
        Console.WriteLine("V        " & R1)
        Console.WriteLine("F        " & R2)


    End Sub
End Module

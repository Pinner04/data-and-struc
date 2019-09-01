Module Module1

    Sub Main()
        Dim grade As Integer
        Console.Write("Enter grade: ")
        grade = Console.ReadLine

        Select Case grade
            Case 75 To 79
                Console.WriteLine("Below Average")
            Case 80, 81, 82 'is the same with Case 80 To 82
                Console.WriteLine("Average")
            Case 83 To 85
                Console.WriteLine("Above Average")
            Case 86 To 89
                Console.WriteLine("Excellent")
            Case 90 To 94
                Console.WriteLine("Superior")
            Case 95 To 97
                Console.WriteLine("Extremely Superior")
            Case 98 To 100
                Console.WriteLine("Genius")
        End Select
        Console.Read()
    End Sub

End Module

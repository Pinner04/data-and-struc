Module Module1

    Sub Main()
        Dim growth As Single = 1.03
        Dim population As Single = 150000
        Dim numYears, start As Integer
        start = 1

        Console.Write("Enter the years of growth: ")
        numYears = CInt(Console.ReadLine)
        Console.WriteLine("The current population is: " & _
        population)
        While (start <= numYears)
            population *= growth
            start += 1            
        End While
        Console.WriteLine("The population will be: " & _
        population & " after " & _
        numYears & " years.")
        Console.Read()
    End Sub

End Module

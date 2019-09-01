Module Module1

    Sub Main()
        Dim grade As Integer
        Console.Write("Enter your grade: ")
        grade = CInt(Console.ReadLine)
        Select Case grade
            Case Is >= 60
                Console.WriteLine("You passed!")
            Case Is < 60
                Console.WriteLine("Sorry, you failed.")
            Case Else
                Console.WriteLine("Bad input.")
        End Select
        Console.Read()
    End Sub
End Module

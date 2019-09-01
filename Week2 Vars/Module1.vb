
Module Module1

    Dim nameList As ArrayList = New ArrayList
    Sub Main()
        With nameList
            .Add("Monday")
            .Add("Tuesday")
            .Add("Wednesday")
            .Add("Thursday")
            .Add("Friday")
            .Add("Saturday")
            .Add("Sunday")
        End With

        Dim names As String = String.Empty
        For Each n As Object In nameList
            names &= n & ","
        Next

        Console.WriteLine(names)
        Console.ReadKey()
    End Sub

End Module

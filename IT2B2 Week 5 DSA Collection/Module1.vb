Module Module1

    Sub Main()
        Dim name As New Collection()
        With name
            .Add("Monday", 1)
            .Add("Tuesday", 2)
            .Add("Wednesday", 3)
            .Add("Thursday", 4)
            .Add("Friday", 5)
            .Add("Saturday", 6)
            .Add("Sunday", 7)
            .Add("")
        End With
        printItems(name, 7)
        'printItems(name)
        'name.Add("Sleeping Day", , 2)
        'printItems(name)

        'name.Add("Workout Day", , , 3)
        'printItems(name)
        Console.Read()
    End Sub
    Private Sub printItems(s As Collection)
        For Each i In s
            Console.WriteLine(i)
        Next
    End Sub
    Private Sub printItems(s As Collection, key As Integer)      
        Console.WriteLine(s.Item(key))
    End Sub
End Module


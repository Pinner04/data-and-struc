Module Module1

    Sub Main()
        'Dim s As New Stack
        's.Push("Pe")
        's.Push("Tan")
        's.Push("Go")

        'printItems(s)
        's.Pop()
        'Console.WriteLine()
        'printItems(s)
        'Console.Read()

        Dim q As New Queue
        q.Enqueue("Tan")
        q.Enqueue("Pe")
        q.Enqueue("Go")

        printItems(q)
        Console.WriteLine()
        q.Dequeue()
        printItems(q)
        q.Enqueue("Yu")
        Console.WriteLine()
        printItems(q)

        Console.Read()
    End Sub
    Private Sub printItems(s As Stack)
        For Each n In s
            Console.WriteLine(n)
        Next
    End Sub

    Private Sub printItems(s As Queue)
        For Each n In s
            Console.WriteLine(n)
        Next
    End Sub
End Module

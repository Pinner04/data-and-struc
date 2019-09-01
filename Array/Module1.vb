Module Module1

    Sub Main()
        Dim names() As String = {"Mike", "Francis", "Ed", "Joan", "Terri"}
        System.Array.Sort(names)
        Dim name As String
        For Each name In names
            Console.Write(name & " ")
        Next
        System.Array.Reverse(names)
        Console.WriteLine()
        For Each name In names
            Console.Write(name & " ")
        Next
        Console.ReadKey()
    End Sub

End Module

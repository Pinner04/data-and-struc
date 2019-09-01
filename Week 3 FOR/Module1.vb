Module Module1

    Sub Main()


        'For i = 0 To 10
        '    Console.WriteLine(i)
        'Next

        'For i = 0 To 100 Step 5
        '    Console.WriteLine(i)
        'Next

        'For i As Integer = 100 To 0 Step -1
        '    Console.WriteLine(i)
        'Next

        'Dim greeting As String = "Hello is it me you're looking for?"
        'For Each l As Char In greeting
        '    Console.WriteLine(l)
        'Next

        'Dim arr() As Integer = {5, 10, 15, 20, 25}
        'Console.WriteLine(arr(3))
        ''For Each x As Integer In arr
        ''    Console.WriteLine(x)
        ''Next

        Dim arr(6) As String
        arr(0) = "Monday"
        arr(1) = "Tuesday"
        arr(2) = "Wednesday"
        arr(3) = "Thursday"
        arr(4) = "Friday"
        arr(5) = "Saturday"
        arr(6) = "Sunday"

        'For Each s As String In arr
        '    Console.WriteLine(s)
        'Next
        For i As Integer = 3 To 5
            Console.WriteLine(arr(i))
        Next
        Console.Read()
    End Sub

End Module

Module Module1
    Dim names As New ArrayList

    Sub Main()
        With names
            .Add("Monday")
            .Add("Tuesday")
            .Add("Wednesday")
            .Add("Thursday")
            .Add("Friday")
            .Add("Saturday")
            .Add("Sunday")
        End With

        For Each n As String In names
            If (n Like "*e*") Then
                Console.WriteLine(n)
            End If
        Next
        Console.Read()
    End Sub

End Module

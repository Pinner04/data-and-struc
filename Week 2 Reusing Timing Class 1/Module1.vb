Module Module1

    Sub Main()
        Dim test_array(9999) As Integer
        Dim my_timer As New Timing.Timing
        BuildArray(test_array)
        showArrayContent(test_array)
        my_timer.StopTime()
        Console.WriteLine("Duration: " & my_timer.Result.TotalSeconds)
        Console.Read()
    End Sub
    Private Sub BuildArray(arr() As Integer)
        Dim i As Integer
        For i = 0 To arr.GetUpperBound(0)
            arr(i) = i
        Next
    End Sub
    Private Sub showArrayContent(arr() As Integer)
        For i As Integer = 0 To arr.GetUpperBound(0)
            Console.Write(arr(i))
        Next
    End Sub
End Module

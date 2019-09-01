Module Module1

    'Sub Main()
    '    Dim my_array(999999) As Integer
    '    Dim startTime As DateTime = Now
    '    BuildArray(my_array)
    '    Dim endTime As TimeSpan = Now.Subtract(startTime)
    '    Console.WriteLine("Duration: " & endTime.TotalSeconds)
    '    Console.Read()
    'End Sub
    'Sub Main()
    '    Dim my_array(999999) As Integer
    '    Dim startTime As TimeSpan = New TimeSpan(0)
    '    startTime = Process.GetCurrentProcess.Threads(0).UserProcessorTime
    '    BuildArray(my_array)
    '    Dim endTime As New TimeSpan(0)
    '    endTime = Process.GetCurrentProcess.Threads(0). _
    '    TotalProcessorTime.Subtract(startTime)
    '    Console.WriteLine("Duration: " & endTime.TotalSeconds)
    '    Console.Read()
    'End Sub
    Sub Main()
        Dim my_array(999999) As Integer
        Dim my_timer As New Stopwatch
        my_timer.Reset()
        my_timer.Start()
        BuildArray(my_array)
        my_timer.Stop()
        Console.WriteLine("Duration: " & my_timer.Elapsed.TotalSeconds)
        Console.Read()
    End Sub
    Private Sub BuildArray(arr() As Integer)
        Dim i As Integer
        Dim r As New Random

        For i = 0 To arr.GetUpperBound(0)
            arr(i) = r.Next
        Next
    End Sub
End Module

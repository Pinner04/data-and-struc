Module Module1

    Sub Main()      
        
        'Dim a As Integer = 10
        'Dim b As Integer = 100
        'Console.WriteLine("VAR 1: " & a & " VAR 2: " & b)

        'Console.WriteLine(swap(a, b))
        'Console.Read()

        Console.WriteLine(playGame())
        Console.Read()
    End Sub

    Private Function playGame(Optional t As Integer = 3) As String
        Dim res As String
        Select Case t
            Case 0
                res = "DOTA II"
            Case 1
                res = "ML"
            Case 2
                res = "plants vs. zombies"
            Case 3
                res = "SIMS"
            Case Else
                res = "MMA"
        End Select
        Return res
    End Function
    Private Function swap(a As String, b As String) As String
        Dim x As String = a
        a = b
        b = x
        Return "VAR 1: " & a & " VAR 2: " & b
    End Function
    Private Function sumOfArray(arr() As Integer) As Integer
        Dim res As Integer
        For i As Integer = 0 To arr.GetUpperBound(0)
            res += arr(i)
        Next
        Return res
    End Function


    Private Function sum(a As Integer, b As Integer)
        Return a + b
    End Function

    Private Function greet() As String
        Return "Hello there!"
    End Function
    Private Function greet(t As Integer) As String
        Dim res As String

        If t = 0 Then
            res = "Good Morning"
        ElseIf t = 1 Then
            res = "Good Noon"
        ElseIf t = 2 Then
            res = "Good Afternoon"
        Else
            res = "Good Evening"
        End If

        Return res
    End Function
End Module

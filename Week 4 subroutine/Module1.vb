Module Module1

    Sub Main()
        Console.WriteLine(sumOfInfinite(3, 4, 5, 6))
        sumOfInfinite1(3, 4, 5, 6)
        Console.Read()
    End Sub
    Private Function sumOfInfinite(ParamArray num() As Integer) As Integer
        Dim res As Integer
        For i As Integer = 0 To num.GetUpperBound(0)
            res = res + num(i)
        Next
        Return res
    End Function
    Private Sub sumOfInfinite1(ParamArray num() As Integer)
        Dim res As Integer
        For i As Integer = 0 To num.GetUpperBound(0)
            res = res + num(i)
        Next
        Console.WriteLine(res)
    End Sub
End Module

Module Module1

    Sub Main()      
        Console.WriteLine(sumOfInfinite(10, 5, 3, 2, 50, 6, 80, 3, 56))
        Console.ReadLine()
    End Sub
    Private Function sumOfInfinite(ParamArray num() As Integer)
        Dim res As Integer
        For i As Integer = 0 To UBound(num)
            res = res + num(i)
        Next

        Return res        
    End Function
End Module

Module Module1
    Structure person
        Dim fname As String
        Dim lname As String
        Dim mname As String
        Dim address As String
        Dim bdate As Date

        Function initials() As String
            Return fname.Chars(0) & lname.Chars(0) & mname.Chars(0)
        End Function
        Function get_age() As Integer
            Return DateDiff(DateInterval.Day, bdate, Now.Date) / 365.25
        End Function
    End Structure
    Sub Main()
        Dim student As person
        student.fname = "Jason"
        student.lname = "Bourne"
        student.mname = "Black"
        student.address = "Nowhere"
        student.bdate = #10/20/1999#

        Console.WriteLine(student.get_age)

        'Dim months() As String = {"Jan", "Feb", "Mar", "Apr", "May", _
        '                          "Jun", "Jul", "Aug", "Sep", "Oct", _
        '                          "Nov", "Dec"}

        'Console.WriteLine(months(Console.ReadLine()))
        'Dim msg As String = "MICROSOFT VISUAL STUDIO 2010"
        'For i As Integer = 0 To msg.Length - 1
        '    Console.Write(msg.Chars(i))
        'Next


        Console.Read()


    End Sub

End Module

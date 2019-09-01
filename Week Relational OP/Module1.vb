Module Module1

    Public Class Name
        Private first As String
        Private last As String
        Public Sub New()
            first = ""
            last = ""
        End Sub
    End Class
    Sub Main()
        Dim myName As New Name()
        If (TypeOf (myName) Is Name) Then
            Console.WriteLine("Object is a Name type")
        End If
        myName = Nothing
        If (myName Is Nothing) Then
            Console.WriteLine("Object is now nothing.")
        End If

        myName = New Name()
        If (myName Is Nothing) Then
            Console.WriteLine("Object is now nothing.")
        Else
            Console.WriteLine("Object contains something.")
        End If
        Console.Read()
    End Sub

End Module

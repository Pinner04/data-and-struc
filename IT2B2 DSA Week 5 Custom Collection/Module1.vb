Module Module1
    Public Class CCollection
        Implements IEnumerable
        Protected pCapacity As Integer = 8
        Protected pArr(8) As Object
        Protected pIndex As Integer
        Protected pCount As Integer
        Public Sub New()
            pIndex = 0
            pCount = 0
        End Sub
        ReadOnly Property Count()
            Get
                Return pCount
            End Get
        End Property
        Public Sub Add(ByVal item As Object)
            If (Me.IsFull()) Then
                pCapacity += 8
                ReDim Preserve pArr(pCapacity)
            End If
            pArr(pIndex) = item
            pIndex += 1
            pCount += 1
        End Sub
        Private Function IsFull() As Boolean
            If (pArr(pCapacity) <> Nothing) Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Function Contains(ByVal item As Object) As _
        Boolean
            Dim x As Integer
            Dim flag As Boolean = False
            For x = 0 To pArr.GetUpperBound(0)
                If (pArr(x) = item) Then
                    flag = True
                End If
            Next
            Return flag
        End Function
        Public Sub CopyTo(ByRef arr() As Object)
            Dim x As Integer
            ReDim arr(pCount - 1)
            For x = 0 To pCount - 1
                arr(x) = pArr(x)
            Next
        End Sub
        Public Sub Display()
            Dim x As Integer
            For x = 0 To pCount - 1
                Console.WriteLine(pArr(x))
            Next
        End Sub
        Private Sub ShiftUp(ByVal p As Integer)
            Dim x As Integer
            For x = p To pArr.GetUpperBound(0) - 1
                pArr(x) = pArr(x + 1)
            Next
            pIndex = SetIndex()
        End Sub
        Private Sub RangeShiftUp(ByVal pos As Integer, _
        ByVal n As Integer)
            Dim y As Integer
            Dim toMove As Object
            y = pos + n
            toMove = pArr(y)
            While (CStr(toMove) <> "" And (y < pCount))
                pArr(pos) = toMove
                pArr(y) = ""
                pos += 1
                y += 1
                toMove = pArr(y)
            End While
            pIndex = SetIndex()
            For y = pIndex To pCapacity
                pArr(y) = ""
            Next
        End Sub
        Public Sub Remove(ByVal item As Object)
            Dim x, position As Integer
            For x = 0 To pArr.GetUpperBound(0)
                If (pArr(x) = item) Then
                    pArr(x) = ""
                    position = x
                    Exit For
                End If
            Next
            ShiftUp(position)
            pCount -= 1
        End Sub
        Public Sub RemoveAt(ByVal p As Integer)
            pArr(p) = ""
            pCount -= 1
            ShiftUp(p)
        End Sub
        Public Sub Insert(ByVal item As Object, ByVal pos _
        As Integer)
            ShiftDown(pos)
            pArr(pos) = item
        End Sub
        Private Sub ShiftDown(ByVal n As Integer)
            Dim x As Integer
            If (Me.IsFull()) Then
                pCapacity += 16
                ReDim Preserve pArr(pCapacity)
            End If
            For x = pIndex - 1 To n Step -1
                pArr(x + 1) = pArr(x)
            Next
            pArr(n) = ""
            pIndex += 1
            pCount += 1
        End Sub
        Private Function SetIndex() As Integer
            Dim x As Integer
            For x = 0 To pArr.GetUpperBound(0)
                If CStr(pArr(x)) = "" Then
                    Return x
                End If
            Next
        End Function
        Public Sub Clear()
            ReDim pArr(8)
            pCount = 0
            pIndex = 0
        End Sub
        Public Function IndexOf(ByVal item As Object) _
        As Integer
            Dim x, pos As Integer
            pos = -1
            For x = 0 To pArr.GetUpperBound(0)
                If (pArr(x) = item) Then
                    pos = x
                End If
            Next
            Return pos
        End Function
        Public Function GetEnumerator() As IEnumerator _
        Implements System.Collections.IEnumerable. _
        GetEnumerator
            Return New CEnumerator(pArr)
        End Function
        Private Class CEnumerator : Implements IEnumerator
            Private index As Integer
            Private ccol As Array
            Public Sub New(ByVal pArr As Array)
                ccol = pArr
                index = -1
            End Sub
            'Implementation of IEnumerator
            Public ReadOnly Property Current() As Object _
            Implements System.Collections.IEnumerator.Current
                Get
                    Return ccol(index)
                End Get
            End Property
            Public Function MoveNext() As Boolean Implements _
            System.Collections.IEnumerator.MoveNext
                index += 1
                If index >= ccol.Length Then
                    Return False
                Else
                    Return True
                End If
            End Function
            Public Sub Reset() _
            Implements System.Collections.IEnumerator.Reset
                index = -1
            End Sub
        End Class
    End Class
    Sub Main()
        Dim NameList As New CCollection()      
        NameList.Add("David")
        NameList.Add("Mike")
        NameList.Add("Raymond")
        NameList.Add("Bernica")
        NameList.Add("Jennifer")
        NameList.Add("Frank")
        NameList.Add("Beata")
        NameList.Add("Terrill")
        For Each name In NameList
            Console.WriteLine(name)
        Next
        Console.WriteLine()
        NameList.Remove("Frank")
        For Each name In NameList
            Console.WriteLine(name)
        Next
        Console.Write("Press Enter to quit")
        Console.Read()
    End Sub

End Module

Public Class Timing
    Private startTime As DateTime  
    Private duration As TimeSpan
    Public Sub New()
        startTime = Now   
        duration = New TimeSpan(0)
    End Sub
    Public Sub StopTime()
        duration = Now.Subtract(startTime)
    End Sub
    Public ReadOnly Property Result As TimeSpan
        Get
            Return duration
        End Get       
    End Property



End Class

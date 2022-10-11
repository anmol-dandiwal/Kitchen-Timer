Public Class SecondsCounter
    Inherits Counter
    Public Minutes As MinutesCounter

    Public Sub New()
        InitializeComponent()
        value = 0
        maxValue = 59
    End Sub

    Public Sub Decrement()
        If value > 0 Then
            value -= 1
        Else
            value = maxValue
            'Minutes.Decrement()
        End If
        Text = String.Format("{0:00}", value)
    End Sub

    Public Sub IncreaseBy(newVal As Integer)
        If value + newVal <= maxValue Then
            value += newVal
        Else
            'Minutes.IncreaseBy(1)
            value = newVal - (60 - value)
        End If
    End Sub

    Public Sub SetMinutesCounter(newCounter As MinutesCounter)
        Minutes = newCounter
    End Sub
End Class

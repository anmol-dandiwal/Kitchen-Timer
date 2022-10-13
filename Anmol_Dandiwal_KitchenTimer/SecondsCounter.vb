Public Class SecondsCounter
    Inherits Counter

    Public Sub New()
        InitializeComponent()
        value = 0
        maxValue = 59
    End Sub

    Public Sub Decrement(minutesCounter As MinutesCounter)
        If value > 0 Then
            value -= 1
        Else
            value = maxValue
            minutesCounter.value -= 1
            minutesCounter.Text = String.Format("{0:00}", minutesCounter.value)
        End If
        Text = String.Format("{0:00}", value)
    End Sub

    Public Sub IncreaseBy(newVal As Integer, minutesCounter As MinutesCounter)
        If value + newVal <= maxValue Then
            value += newVal
        ElseIf minutesCounter.value < minutesCounter.maxValue Then
            minutesCounter.value += 1
            minutesCounter.Text = String.Format("{0:00}", minutesCounter.value)
            value = newVal - (60 - value)
        End If
    End Sub
End Class

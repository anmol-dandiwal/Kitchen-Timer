Public Class MinutesCounter
    Inherits Counter
    Public Seconds As SecondsCounter

    Public Sub New()
        InitializeComponent()
        value = 0
        maxValue = 99
        Text = value.ToString
    End Sub

    Public Sub Decrement()
        If value > 0 Then
            value -= 1
        End If
    End Sub

    Public Sub IncreaseBy(newVal As Integer)
        If value + newVal <= maxValue Then
            value += newVal
        End If
    End Sub

    Public Sub SetSecondsCounter(newCounter As SecondsCounter)
        Seconds = newCounter
    End Sub

End Class

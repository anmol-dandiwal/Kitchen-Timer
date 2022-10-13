Public Class MinutesCounter
    Inherits Counter

    Public Sub New()
        InitializeComponent()
        value = 0
        maxValue = 99
    End Sub

    Public Sub Decrement()
        If value > 0 Then
            value -= 1
        End If
    End Sub

    Public Sub IncreaseBy(newVal As Integer)
        If value + newVal <= maxValue Then
            value += newVal
        Else
            value = maxValue
        End If
    End Sub
End Class

Public Class SecondsCounter
    Inherits Counter

    Public Sub New()
        InitializeComponent()
        Me.value = 0
        Me.maxValue = 59
    End Sub

    Public Sub Decrement()
        Me.value -= 1
    End Sub

    Public Sub IncreaseBy(newVal As Integer)
        If Me.value + newVal <= Me.maxValue Then
            Me.value += newVal
        End If
    End Sub

    Public Sub SetMinutesCounter(newCounter As MinutesCounter)

    End Sub
End Class

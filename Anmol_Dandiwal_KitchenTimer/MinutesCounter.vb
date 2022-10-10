Public Class MinutesCounter
    Inherits Counter

    Public Sub New()
        InitializeComponent()
        Me.value = 0
        Me.maxValue = 99
        Text = Me.value.ToString
    End Sub

    Public Sub Decrement()
        Me.value -= 1
    End Sub

    Public Sub IncreaseBy(newVal As Integer)
        If Me.value + newVal <= Me.maxValue Then
            Me.value += newVal
        End If
    End Sub

    Public Sub SetSecondsCounter(newCounter As SecondsCounter)

    End Sub

End Class

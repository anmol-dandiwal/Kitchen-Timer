Public Class SecondsCounter
    Inherits Counter

    Public Sub decrement()
        Me.value = Me.value - 1
    End Sub

    Public Sub increaseBy(newVal As Integer)
        Me.value = Me.value + newVal
    End Sub

    Public Sub setMinutesCounter(newCounter As MinutesCounter)

    End Sub

End Class

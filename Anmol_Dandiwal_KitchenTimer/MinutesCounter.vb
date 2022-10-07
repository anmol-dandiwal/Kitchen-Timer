Public Class MinutesCounter
    Inherits Counter

    Public Sub decrement()
        Me.value = Me.value - 1
    End Sub

    Public Sub increaseBy(newVal As Integer)
        Me.value = Me.value + newVal
    End Sub

    Public Sub setSecondsCounter(newCounter As SecondsCounter)

    End Sub

End Class

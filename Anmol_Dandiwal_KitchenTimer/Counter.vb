Public MustInherit Class Counter
    Public value, maxValue

    Public Function isMax() As Boolean
        If Me.value = Me.maxValue Then
            Return True
        End If
        Return False
    End Function

    Public Function isZero() As Boolean
        If Me.value = 0 Then
            Return True
        End If
        Return False
    End Function

    Public Sub reset()
        Me.value = 0
    End Sub

    Public Sub setToMax()
        Me.value = Me.maxValue
    End Sub

    Public Sub setToValue(newVal As Integer)
        Me.value = newVal
    End Sub
End Class

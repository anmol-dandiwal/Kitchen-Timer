Public Class Center
    Public SelectedTimer As SingleTimer

    Public Sub New()
        InitializeComponent()
        SingleTimer1.MakeActive()
        SelectedTimer = SingleTimer1
    End Sub

    Public Sub TimerClick(sender As Object, e As EventArgs) Handles SingleTimer1.Click, SingleTimer2.Click, SingleTimer3.Click, SingleTimer4.Click
        If sender IsNot SelectedTimer Then
            sender.MakeActive()
            SelectedTimer.MakeInactive()
            SelectedTimer = sender
        End If
    End Sub

    Private Sub SecondsButton_Click(sender As Object, e As EventArgs) Handles SecondsButton1.Click, SecondsButton3.Click, SecondsButton10.Click
        SelectedTimer.AddSeconds(sender.tag)
    End Sub

    Private Sub MinutesButton1_Click(sender As Object, e As EventArgs) Handles MinutesButton1.Click, MinutesButton3.Click, MinutesButton10.Click
        SelectedTimer.AddMinutes(sender.tag)
    End Sub
End Class

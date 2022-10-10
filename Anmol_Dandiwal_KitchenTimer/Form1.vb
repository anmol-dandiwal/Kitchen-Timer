Public Class Form1
    Public SelectedTimer As SingleTimer

    Public Sub New()
        InitializeComponent()
        SingleTimer1.MakeActive()
        SelectedTimer = SingleTimer1
    End Sub

    Public Sub TimerClick(sender As Object, e As EventArgs) Handles SingleTimer1.Click, SingleTimer2.MouseClick, SingleTimer3.Click, SingleTimer4.Click
        If sender IsNot SelectedTimer Then
            sender.MakeActive()
            SelectedTimer.MakeInactive()
            SelectedTimer = sender
        End If
    End Sub

    Private Sub SecondsButton1_Click(sender As Object, e As EventArgs) Handles SecondsButton1.Click
        SelectedTimer.Seconds.IncreaseBy(1)
        SelectedTimer.Seconds.Text = String.Format("{0:00}", SelectedTimer.Seconds.value)
    End Sub

    Private Sub SecondsButton3_Click(sender As Object, e As EventArgs) Handles SecondsButton3.Click
        SelectedTimer.Seconds.IncreaseBy(3)
        SelectedTimer.Seconds.Text = String.Format("{0:00}", SelectedTimer.Seconds.value)
    End Sub

    Private Sub SecondsButton10_Click(sender As Object, e As EventArgs) Handles SecondsButton10.Click
        SelectedTimer.Seconds.IncreaseBy(10)
        SelectedTimer.Seconds.Text = String.Format("{0:00}", SelectedTimer.Seconds.value)
    End Sub

    Private Sub MinutesButton1_Click(sender As Object, e As EventArgs) Handles MinutesButton1.Click
        SelectedTimer.Minutes.IncreaseBy(1)
        SelectedTimer.Minutes.Text = String.Format("{0:00}", SelectedTimer.Minutes.value)
    End Sub

    Private Sub MinutesButton3_Click(sender As Object, e As EventArgs) Handles MinutesButton3.Click
        SelectedTimer.Minutes.IncreaseBy(3)
        SelectedTimer.Minutes.Text = String.Format("{0:00}", SelectedTimer.Minutes.value)
    End Sub

    Private Sub MinutesButton10_Click(sender As Object, e As EventArgs) Handles MinutesButton10.Click
        SelectedTimer.Minutes.IncreaseBy(10)
        SelectedTimer.Minutes.Text = String.Format("{0:00}", SelectedTimer.Minutes.value)
    End Sub
End Class

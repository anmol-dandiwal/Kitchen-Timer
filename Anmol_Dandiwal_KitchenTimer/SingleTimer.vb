Public Class SingleTimer
    Public beeping, countdown As Boolean,
           beeps, frequency As Integer,
           Timer As Timer

    Public Sub New()
        InitializeComponent()
        Me.beeping = False
        Me.countdown = False
        Me.Timer = New Timer()
    End Sub

    Public Sub CustomControlsClick(sender As Object, e As EventArgs) Handles Minutes.Click, Seconds.Click, ColonLabel.Click
        Me.OnClick(EventArgs.Empty)
    End Sub

    Public Sub MakeActive()
        BackColor = Color.Peru
        SelectButton.Checked = True
    End Sub

    Public Sub MakeInactive()
        BackColor = Color.BurlyWood
        SelectButton.Checked = False
    End Sub

    Public Sub AddMinutes(newMins As Integer)
        Minutes.value += newMins
        Minutes.Text = Minutes.value
    End Sub

    'Private Sub addMinutesActive(newMins As Integer)

    'End Sub

    Public Sub AddSeconds(newMins As Integer)
        Seconds.value += newMins
    End Sub

    'Private Sub addSecondsActive(newMins As Integer)

    'End Sub
End Class

Public Class SingleTimer
    Public beeping, countdown As Boolean,
           beeps, frequency As Integer
    Public WithEvents Timer As Timer

    Public Sub New()
        InitializeComponent()
        Me.beeping = False
        Me.countdown = False
        Me.Timer = New Timer With {.Interval = 1000}
    End Sub

    Private Sub CustomControlsClick(sender As Object, e As EventArgs) Handles ColonLabel.Click, Minutes.Click, Seconds.Click, SelectButton.Click
        Me.OnClick(EventArgs.Empty)
    End Sub

    Private Sub HandleTick(sender As Object, e As EventArgs) Handles Timer.Tick
        If Minutes.value = 0 And Seconds.value = 0 Then
            StartBeeping()
        Else
            Seconds.Decrement()
        End If
    End Sub

    Public Sub StartBeeping()
        beeping = True
        If Me.Name = "SingleTimer1" Then
            System.Console.Beep(2500, 800)
        ElseIf Me.Name = "SingleTimer3" Then
            System.Console.Beep(2500, 300)
            System.Console.Beep(2500, 300)
        ElseIf Me.Name = "SingleTimer2" Then
            System.Console.Beep(2500, 200)
            System.Console.Beep(2500, 200)
            System.Console.Beep(2500, 200)
        ElseIf Me.Name = "SingleTimer4" Then
            System.Console.Beep(2500, 100)
            System.Console.Beep(2500, 100)
            System.Console.Beep(2500, 100)
            System.Console.Beep(2500, 100)
        End If
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Timer.Start()
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        If Timer.Enabled Then
            Timer.Stop()
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        If Not beeping Then
            Timer.Stop()
            Seconds.value = 0
            Seconds.Text = String.Format("{0:00}", Seconds.value)
            Minutes.value = 0
            Minutes.Text = String.Format("{0:00}", Minutes.value)
        End If
    End Sub

    Private Sub ButtonHover(sender As Object, e As EventArgs) Handles StartButton.MouseEnter, StopButton.MouseEnter, ClearButton.MouseEnter
        sender.BackColor = Color.Gray
        sender.ForeColor = Color.LightGray
    End Sub

    Private Sub ButtonLeave(sender As Object, e As EventArgs) Handles StartButton.MouseLeave, StopButton.MouseLeave, ClearButton.MouseLeave
        sender.BackColor = Color.FromArgb(232, 232, 232)
        sender.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub

    Public Sub MakeInactive()
        BackColor = Color.BurlyWood
        SelectButton.Checked = False
    End Sub

    Public Sub MakeActive()
        BackColor = Color.Peru
        SelectButton.Checked = True
    End Sub

    Public Sub AddMinutes(newMins As Integer)
        Minutes.IncreaseBy(newMins)
        Minutes.Text = String.Format("{0:00}", Minutes.value)
    End Sub

    Public Sub AddSeconds(newMins As Integer)
        Seconds.IncreaseBy(newMins)
        Seconds.Text = String.Format("{0:00}", Seconds.value)
    End Sub
End Class

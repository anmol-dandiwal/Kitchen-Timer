Imports System.Threading

Public Class SingleTimer
    Public beeping As Boolean
    Public frequency, duration, beeps As Integer
    Public WithEvents Timer As System.Windows.Forms.Timer

    Public Property Title As String
        Get
            Return SelectButton.Text
        End Get
        Set(value As String)
            SelectButton.Text = value
        End Set
    End Property

    Public Property AlarmFrequency As Integer
        Get
            Return frequency
        End Get
        Set(freq As Integer)
            frequency = freq
        End Set
    End Property

    Public Property AlarmDuration As Integer
        Get
            Return duration
        End Get
        Set(dur As Integer)
            duration = dur
        End Set
    End Property

    Public Property AlarmBeeps As Integer
        Get
            Return beeps
        End Get
        Set(numBeeps As Integer)
            beeps = numBeeps
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
        Me.beeping = False
        Me.Timer = New System.Windows.Forms.Timer With {.Interval = 1000}
        StartButton.Enabled = False
        StopButton.Enabled = False
        ClearButton.Enabled = False
    End Sub

    Private Sub CustomControlsClick(sender As Object, e As EventArgs) Handles ColonLabel.Click, Minutes.Click, Seconds.Click, SelectButton.Click, StartButton.Click, StopButton.Click, ClearButton.Click
        Me.OnClick(EventArgs.Empty)
    End Sub

    Private Sub HandleTick(sender As Object, e As EventArgs) Handles Timer.Tick
        If Minutes.value = 0 And Seconds.value = 0 Then
            newThread.Start()
            ClearButton.Enabled = False
            BackColor = Color.OrangeRed
        Else
            Seconds.Decrement(Minutes)
        End If
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Timer.Start()
        MakeActive()
        StartButton.Enabled = False
        StopButton.Enabled = True
        ClearButton.Enabled = True
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        Timer.Stop()
        MakeActive()
        StartButton.Enabled = True
        StopButton.Enabled = False
        beeping = False
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Timer.Stop()
        Seconds.value = 0
        Seconds.Text = String.Format("{0:00}", Seconds.value)
        Minutes.value = 0
        Minutes.Text = String.Format("{0:00}", Minutes.value)
        MakeActive()
        StartButton.Enabled = False
        StopButton.Enabled = False
        ClearButton.Enabled = False
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
        Seconds.IncreaseBy(newMins, Minutes)
        Seconds.Text = String.Format("{0:00}", Seconds.value)
    End Sub

    Public Sub StartBeeping()
        beeping = True
        For i As Integer = 1 To beeps
            System.Console.Beep(frequency, duration)
        Next
    End Sub

    Public Function newThread()
        Dim thread As Thread = New Thread(New ThreadStart(AddressOf StartBeeping))
        Return thread
    End Function
End Class

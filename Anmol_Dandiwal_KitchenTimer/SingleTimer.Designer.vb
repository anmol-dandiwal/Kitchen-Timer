<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SingleTimer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Minutes = New Anmol_Dandiwal_KitchenTimer.MinutesCounter()
        Me.ColonLabel = New System.Windows.Forms.Label()
        Me.Seconds = New Anmol_Dandiwal_KitchenTimer.SecondsCounter()
        Me.SelectButton = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.StartButton.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StartButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StartButton.Location = New System.Drawing.Point(18, 131)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(0)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(87, 50)
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'StopButton
        '
        Me.StopButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StopButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.StopButton.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StopButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StopButton.Location = New System.Drawing.Point(112, 131)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(87, 50)
        Me.StopButton.TabIndex = 2
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClearButton.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ClearButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClearButton.Location = New System.Drawing.Point(205, 131)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(87, 50)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'Minutes
        '
        Me.Minutes.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Minutes.BackColor = System.Drawing.Color.Transparent
        Me.Minutes.Font = New System.Drawing.Font("Ebrima", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Minutes.Location = New System.Drawing.Point(0, 8)
        Me.Minutes.Margin = New System.Windows.Forms.Padding(0)
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Size = New System.Drawing.Size(165, 107)
        Me.Minutes.TabIndex = 4
        Me.Minutes.Text = "00"
        '
        'ColonLabel
        '
        Me.ColonLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ColonLabel.BackColor = System.Drawing.Color.Transparent
        Me.ColonLabel.Font = New System.Drawing.Font("Ebrima", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ColonLabel.Location = New System.Drawing.Point(140, 25)
        Me.ColonLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ColonLabel.Name = "ColonLabel"
        Me.ColonLabel.Size = New System.Drawing.Size(38, 72)
        Me.ColonLabel.TabIndex = 5
        Me.ColonLabel.Text = ":"
        Me.ColonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Seconds
        '
        Me.Seconds.Font = New System.Drawing.Font("Ebrima", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Seconds.Location = New System.Drawing.Point(157, 8)
        Me.Seconds.Margin = New System.Windows.Forms.Padding(0)
        Me.Seconds.Name = "Seconds"
        Me.Seconds.Size = New System.Drawing.Size(164, 106)
        Me.Seconds.TabIndex = 6
        Me.Seconds.Text = "00"
        '
        'SelectButton
        '
        Me.SelectButton.AutoSize = True
        Me.SelectButton.Location = New System.Drawing.Point(293, 3)
        Me.SelectButton.Name = "SelectButton"
        Me.SelectButton.Size = New System.Drawing.Size(14, 13)
        Me.SelectButton.TabIndex = 7
        Me.SelectButton.TabStop = True
        Me.SelectButton.UseVisualStyleBackColor = True
        '
        'SingleTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.Controls.Add(Me.ColonLabel)
        Me.Controls.Add(Me.SelectButton)
        Me.Controls.Add(Me.Seconds)
        Me.Controls.Add(Me.Minutes)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "SingleTimer"
        Me.Size = New System.Drawing.Size(310, 184)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents Minutes As MinutesCounter
    Friend WithEvents ColonLabel As Label
    Friend WithEvents Seconds As SecondsCounter
    Friend WithEvents SelectButton As RadioButton
End Class

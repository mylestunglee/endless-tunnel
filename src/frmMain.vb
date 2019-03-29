Public Class frmMain

    Dim zReady As Boolean = False
    Dim zSpeedMuiltiplier As Single = 1

    Private Sub sReady() Handles Me.Activated
        If zReady Then Exit Sub
        zReady = True
        Me.Show()
        DrawAll()
        Settings.LoadSettings()
    End Sub

    Private Sub sClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Settings.SaveSettings()
        Audio.CleanUp()
    End Sub

    Private Sub sKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, mnu.KeyDown, MyClass.KeyDown
        Select Case e.KeyCode
            Case Keys.N
                sNew()
            Case Keys.P
                sTogglePause()
            Case Keys.W
                _KeyPress.UpPress = True
            Case Keys.A
                _KeyPress.LeftPress = True
            Case Keys.S
                _KeyPress.DownPress = True
            Case Keys.D
                _KeyPress.RightPress = True
        End Select
    End Sub

    Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp, mnu.KeyUp, MyClass.KeyUp
        Select Case e.KeyCode
            Case Keys.W
                _KeyPress.UpPress = False
            Case Keys.A
                _KeyPress.LeftPress = False
            Case Keys.S
                _KeyPress.DownPress = False
            Case Keys.D
                _KeyPress.RightPress = False
        End Select
    End Sub


    Private Sub sLoad() Handles MyBase.Load
        Plane.Move(1, 1, 2, 2)
        Core.Start()
    End Sub


    Private Sub sMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pctDisplay.MouseMove
        If GameStatus = Status.InGame And Not Core.UseKeyboard Then
            Plane.Move(e.X, CInt(e.Y * (Me.ClientSize.Height / Me.pctDisplay.Size.Height)), ClientSize.Width, ClientSize.Height)
        End If
    End Sub

    Private Sub sTick() Handles tmrFrame.Tick
        Dim Start As DateTime = Now
        Dim Finish As DateTime
        Dim Length As TimeSpan
        Core.CodeLoop(zSpeed * zSpeedMuiltiplier)
        Finish = Now
        Length = Finish.Subtract(Start)
        If Length.TotalMilliseconds > tmrFrame.Interval Then
            zSpeedMuiltiplier = CSng(Length.TotalMilliseconds / tmrFrame.Interval)
        Else
            zSpeedMuiltiplier = 1
        End If
    End Sub

    Private Sub sClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pctDisplay.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            sTogglePause()
        ElseIf e.Button = Windows.Forms.MouseButtons.Right And Core.Energy >= zMaxEnergy Then
            Audio.PlayLaser()
            Core.Energy = -zEnergyPowerDuration
        End If
    End Sub

    Private Sub pctDisplay_SizeChanged() Handles MyBase.SizeChanged
        If zReady Then
            DrawAll()
        End If
    End Sub

    Private Sub sTogglePause()
        If GameStatus = Status.InGame Then
            GameStatus = Status.Paused
            tmrFrame.Enabled = False
            Me.Text = "Endless Tunnel - Paused"
        ElseIf GameStatus = Status.Paused Then
            GameStatus = Status.InGame
            tmrFrame.Enabled = True
            Me.Text = "Endless Tunnel"
        End If
    End Sub

#Region "Menu Subs"
    'When a the new button is clicked...
    Private Sub sNew() Handles mnuNew.Click
        Core.Start() 'Sets new locations for the asteroids and stars
        Score = 0 'Resets score
        Energy = 0 'Resets energy
        GameStatus = Status.InGame 'Ingame now
        tmrFrame.Enabled = True 'Start loop
        frmOptions.cmdOk.Enabled = False 'Stop options being changed
    End Sub

    'When the options button is clicked...
    Private Sub sOptions() Handles mnuOptions.Click
        frmOptions.Show()
    End Sub

    'When the close button is clicked...
    Private Sub sClose() Handles mnuClose.Click
        Me.Close()
    End Sub
#End Region 'Toolbar events

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub mnuInstructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInstructions.Click
        'If the help file doesn't exist then messagebox of error and doesn't open file
        If Not System.IO.File.Exists(Application.StartupPath & "\Endless Tunnel Help.txt") Then
            MessageBox.Show("The help file cannot be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Opens the help file in notepad
        System.Diagnostics.Process.Start("notepad.exe", Application.StartupPath & "\Endless Tunnel Help.txt")
    End Sub
End Class

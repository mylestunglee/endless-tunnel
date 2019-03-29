Module Core
#Region "Varibles"
    Public zRestart As Boolean = False

    Public Generator As Random = New Random
    Private zFutherestZ As Integer = 10
    Public Property FutherestZ() As Integer
        Get
            Return zFutherestZ
        End Get
        Set(ByVal value As Integer)
            zFutherestZ = value
            zRestart = True
        End Set
    End Property

    Public zSpeed As Single = 0.1

    Public zAsteroids(zFutherestZ - 1) As Asteroid
    Public zStars(99) As Star

    Private zEnergy As Single = 0
    Public Property Energy() As Single
        Get
            Return zEnergy
        End Get
        Set(ByVal value As Single)
            zEnergy = value
        End Set
    End Property

    Public Enum Status As Byte
        None = 0
        InGame = 1
        Paused = 2
        GameOver = 3
        ExitGame = 4
    End Enum

    Private zGameStatus As Status = Status.None
    Public Property GameStatus() As Status
        Get
            Return zGameStatus
        End Get
        Set(ByVal value As Status)
            zGameStatus = value
        End Set
    End Property

    Public Const zMaxEnergy As Integer = 50
    Public Const zEnergyPowerDuration As Integer = 5

    Private zUseKeyboard As Boolean = False
    Public Property UseKeyboard() As Boolean
        Get
            Return zUseKeyboard
        End Get
        Set(ByVal value As Boolean)
            zUseKeyboard = value
        End Set
    End Property


    Private zScore As Integer = 0
    Public Property Score() As Integer
        Get
            Return zScore
        End Get
        Set(ByVal value As Integer)
            zScore = value
        End Set
    End Property
#End Region

    Public Sub Start()
        zSpeed = 0.1
        If zRestart Then
            ReDim zStars(_Graphics.NumberofStars - 1)
            ReDim zAsteroids(Core.FutherestZ - 1)
            zRestart = False
        End If
        For Index As Integer = 0 To zAsteroids.Length - 1
            zAsteroids(Index) = New Asteroid(0, 0, Index + 10, 32)
            zAsteroids(Index).Start()
        Next
        For Index As Integer = 0 To zStars.Length - 1
            zStars(Index) = New Star(0, 0, CSng((zFutherestZ / zStars.Length) * Index + 10))
            zStars(Index).Start()
        Next
    End Sub

    Public Sub CodeLoop(ByVal iSpeed As Single)
        If UseKeyboard Then
            Plane.Move()
        End If
        Core.MoveAsteroids(zAsteroids, iSpeed)
        Core.MoveStars(zStars, iSpeed)
        DrawAll()
    End Sub

    Public Sub DrawAll()
        frmMain.pctDisplay.Image = _Graphics.GetDrawnBitmap()
    End Sub

    'Draws an array of asteroids
    Public Sub MoveAsteroids(ByVal iAsteroids() As Asteroid, ByVal iSpeed As Single)
        'Loops through all the asteroids
        For Index As Integer = 0 To iAsteroids.Length - 1
            'Moves the asteroid
            iAsteroids(Index).Move(iSpeed)
        Next
        If Energy < zMaxEnergy Then
            Energy += iSpeed
        End If
    End Sub

    'Draws an array of asteroids
    Public Sub MoveStars(ByVal iStars() As Star, ByVal iSpeed As Single)
        'Loops through all the asteroids
        For Index As Integer = 0 To iStars.Length - 1
            'Moves the asteroid
            iStars(Index).Move(iSpeed)
        Next
    End Sub

    Public Function Difference(ByVal iMinimum As Single, ByVal iMaximum As Single) As Single
        Return Math.Abs(iMaximum - iMinimum)
    End Function
    Public Function IsInsideCircle(ByVal iCirclePosition As PointF, ByVal iCircleDiameter As Single, ByVal iTest As PointF) As Boolean
        Return Math.Sqrt((Difference(CSng(iCirclePosition.X + (iCircleDiameter / 2)), iTest.X) ^ 2) + _
               (Difference(CSng(iCirclePosition.Y + (iCircleDiameter / 2)), iTest.Y) ^ 2)) < iCircleDiameter / 2
    End Function
    Public Function IsInsideRectangle(ByVal iRectangle As RectangleF, ByVal iTest As PointF) As Boolean
        Return iTest.X > iRectangle.X And iTest.X < iRectangle.Right And _
               iTest.Y > iRectangle.Y And iTest.Y < iRectangle.Bottom
    End Function
End Module

Module Settings
    Public Sub LoadSettings()
        Try
            With My.Settings
                frmMain.pctDisplay.BackColor = .BackgroundColour
                _Graphics.AntiAlias = .AntiAlias
                _Graphics.DisplayStars = .DisplayStars
                _Graphics.Fill = .Fill
                _Graphics.NumberofStars = .NumberofStars
                _Graphics.AsteroidColour = .AsteroidColour
                _Graphics.StarColour = .StarColour
                _Graphics.TextColour = .TextColour
                _Graphics.TunnelColour = .TunnelColour
                _Graphics.PlaneColour = .PlaneColour
                Audio.PlayMusic = .PlayMusic
                Core.UseKeyboard = .UseKeyboard
                Core.FutherestZ = .VisibleRange
            End With
        Catch
            MessageBox.Show("An error occured when loading settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub SaveSettings()
        With My.Settings
            .AntiAlias = _Graphics.AntiAlias
            .AsteroidColour = _Graphics.AsteroidColour
            .BackgroundColour = frmMain.pctDisplay.BackColor
            .DisplayStars = _Graphics.DisplayStars
            .Fill = _Graphics.Fill
            .NumberofStars = _Graphics.NumberofStars
            .PlaneColour = _Graphics.PlaneColour
            .PlayMusic = Audio.PlayMusic
            .StarColour = _Graphics.StarColour
            .TextColour = _Graphics.TextColour
            .TunnelColour = _Graphics.TunnelColour
            .UseKeyboard = Core.UseKeyboard
            .VisibleRange = Core.FutherestZ
            .Save()
        End With
    End Sub

End Module
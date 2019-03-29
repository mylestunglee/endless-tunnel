Imports System.Drawing.Drawing2D 'Only required for this module
Module _Graphics

#Region "Properties, Varibles & Constant"
    Private zAntiAlias As Boolean = False
    Public Property AntiAlias() As Boolean
        Get
            Return zAntiAlias
        End Get
        Set(ByVal value As Boolean)
            zAntiAlias = value
        End Set
    End Property

    Private zFill As Boolean = False
    Public Property Fill() As Boolean
        Get
            Return zFill
        End Get
        Set(ByVal value As Boolean)
            zFill = value
        End Set
    End Property

    Private zDisplayStars As Boolean
    Public Property DisplayStars() As Boolean
        Get
            Return zDisplayStars
        End Get
        Set(ByVal value As Boolean)
            zDisplayStars = value
        End Set
    End Property

    Private zNumberofStars As Integer
    Public Property NumberofStars() As Integer
        Get
            Return zNumberofStars
        End Get
        Set(ByVal value As Integer)
            zNumberofStars = value
            zRestart = True
        End Set
    End Property

    Private zTunnelColour As Color = Color.Magenta
    Public Property TunnelColour() As Color
        Get
            Return zTunnelColour
        End Get
        Set(ByVal value As Color)
            zTunnelColour = value
        End Set
    End Property

    Private zAsteroidColour As Color = Color.Orange
    Public Property AsteroidColour() As Color
        Get
            Return zAsteroidColour
        End Get
        Set(ByVal value As Color)
            zAsteroidColour = value
        End Set
    End Property

    Private zPlaneColour As Color = Color.Cyan
    Public Property PlaneColour() As Color
        Get
            Return zPlaneColour
        End Get
        Set(ByVal value As Color)
            zPlaneColour = value
        End Set
    End Property

    Private zTextColour As Color = Color.White
    Public Property TextColour() As Color
        Get
            Return zTextColour
        End Get
        Set(ByVal value As Color)
            zTextColour = value
        End Set
    End Property

    Private zStarColour As Color = Color.Yellow
    Public Property StarColour() As Color
        Get
            Return zStarColour
        End Get
        Set(ByVal value As Color)
            zStarColour = value
        End Set
    End Property

#End Region

    'Returns the bitmap to be drawn onto the screen
    Public Function GetDrawnBitmap() As Bitmap
        'Makes a new piece of paper, assuming that the monitor is the paper
        Dim DrawingBitmap As Bitmap = New Bitmap(frmMain.ClientSize.Width, frmMain.ClientSize.Height)
        'Gets the pens to draw onto the paper
        Dim DrawingGraphics As Graphics = Graphics.FromImage(DrawingBitmap)
        'Fill the paper with complete black
        DrawingGraphics.Clear(frmMain.pctDisplay.BackColor)
        'Set the smoothing mode
        If zAntiAlias Then
            DrawingGraphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            DrawingGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Else
            DrawingGraphics.SmoothingMode = Drawing2D.SmoothingMode.None
            DrawingGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.SingleBitPerPixel
        End If
        'Draws background
        DrawTunnel(DrawingGraphics)
        'Draws asteroids
        DrawAsteroids(DrawingGraphics)
        'Draws stars if needed to
        If DisplayStars Then DrawStars(DrawingGraphics, zStars)
        'Draws plane
        DrawPlane(DrawingGraphics)
        'Draws score
        DrawScore(DrawingGraphics)
        'Draws energy bar
        DrawEnergy(DrawingGraphics)
        'Draws gameover if needed to
        If GameStatus = Status.GameOver Then DrawGameOver(DrawingGraphics)
        'Returns the finished frame
        Return DrawingBitmap
    End Function

    'Draws the background, two lines showing a cross at the centre
    Public Sub DrawTunnel(ByVal iGraphics As Graphics)
        With frmMain.pctDisplay.ClientSize
            Dim Centre As PointF = New PointF(CSng(.Width / 2), CSng(.Height / 2)) 'The centre of the picturebox
            DrawGradientLine(iGraphics, New PointF(0, 0), _
                             Centre, TunnelColour) 'Top left...
            DrawGradientLine(iGraphics, New PointF(.Width, 0), _
                             Centre, TunnelColour) 'Top right...
            DrawGradientLine(iGraphics, New PointF(.Width, .Height), _
                             Centre, TunnelColour) 'Bottom right...
            DrawGradientLine(iGraphics, New PointF(0, .Height), _
                             Centre, TunnelColour) 'Bottom left...
        End With
    End Sub

    'Draws an array of asteroids
    Public Sub DrawStars(ByVal iGraphics As Graphics, ByVal iStars() As Star)
        With frmMain.pctDisplay.ClientSize
            'Makes a pen for asteroid
            Dim YellowPen As Pen
            'Loops through all the asteroids
            For Index As Integer = 0 To iStars.Length - 1
                'Sets the pen alpha channel depending on the distant from the camera.
                YellowPen = New Pen(Color.FromArgb(iStars(Index).Brightness, zStarColour))
                'Draws the asteroid, getting all the points needed
                iGraphics.DrawLine(YellowPen, iStars(Index).GetDrawX(.Width), _
                                      iStars(Index).GetDrawY(.Height), _
                                      iStars(Index).GetBackDrawX(.Width), _
                                      iStars(Index).GetBackDrawY(.Height))
            Next
        End With
    End Sub

    'Draws an array of asteroids
    Public Sub DrawAsteroids(ByVal iGraphics As Graphics)
        With frmMain.pctDisplay.ClientSize
            'Makes a pen for asteroid
            Dim YellowPen As Pen
            'Loops through all the asteroids
            For Index As Integer = 0 To zAsteroids.Length - 1
                'Sets the pen alpha channel depending on the distant from the camera.
                YellowPen = New Pen(Color.FromArgb(zAsteroids(Index).Brightness, zAsteroidColour))
                If zAsteroids(Index).IsCircle Then
                    'Draws the asteroid, getting all the points needed
                    iGraphics.DrawEllipse(YellowPen, zAsteroids(Index).GetDrawX(.Width), _
                                          zAsteroids(Index).GetDrawY(.Height), _
                                          zAsteroids(Index).GetDrawWidth(.Width), _
                                          zAsteroids(Index).GetDrawWidth(.Height))
                    'Draws the filled area if needed
                    If Fill Then
                        iGraphics.FillEllipse(New SolidBrush(Color.FromArgb(zAsteroids(Index).Brightness \ 4, zAsteroidColour)), _
                                              zAsteroids(Index).GetDrawX(.Width), _
                                              zAsteroids(Index).GetDrawY(.Height), _
                                              zAsteroids(Index).GetDrawWidth(.Width), _
                                              zAsteroids(Index).GetDrawWidth(.Height))
                    End If
                Else
                    'Draws the asteroid, getting all the points needed
                    iGraphics.DrawRectangle(YellowPen, zAsteroids(Index).GetDrawX(.Width), _
                                          zAsteroids(Index).GetDrawY(.Height), _
                                          zAsteroids(Index).GetDrawWidth(.Width), _
                                          zAsteroids(Index).GetDrawWidth(.Height))
                    'Draws the filled area if needed
                    If Fill Then
                        iGraphics.FillRectangle(New SolidBrush(Color.FromArgb(zAsteroids(Index).Brightness \ 4, zAsteroidColour)), _
                                              zAsteroids(Index).GetDrawX(.Width), _
                                              zAsteroids(Index).GetDrawY(.Height), _
                                              zAsteroids(Index).GetDrawWidth(.Width), _
                                              zAsteroids(Index).GetDrawWidth(.Height))
                    End If

                End If
            Next
        End With
    End Sub

    'Draws the plane
    Public Sub DrawPlane(ByVal iGraphics As Graphics)
        'Makes a corner array for the each corner of the triangle, representing the plane
        Dim Corners() As PointF = {New PointF(Plane.LeftWing.GetDrawX(frmMain.pctDisplay.ClientSize.Width), _
                                             Plane.LeftWing.GetDrawY(frmMain.pctDisplay.ClientSize.Height)), _
                                   New PointF(Plane.RightWing.GetDrawX(frmMain.pctDisplay.ClientSize.Width), _
                                             Plane.RightWing.GetDrawY(frmMain.pctDisplay.ClientSize.Height)), _
                                   New PointF(Plane.Front.GetDrawX(frmMain.pctDisplay.ClientSize.Width), _
                                             Plane.Front.GetDrawY(frmMain.pctDisplay.ClientSize.Height))}
        'Draws the 
        iGraphics.DrawPolygon(New Pen(PlaneColour), Corners)
        'Draws the filled area if needed
        If Fill Then
            iGraphics.FillPolygon(New SolidBrush(Color.FromArgb(64, PlaneColour)), Corners)
        End If
    End Sub

    'Draws the text
    Public Sub DrawScore(ByVal iGraphics As Graphics)
        With frmMain.pctDisplay.ClientSize
            'Draws the game over screen if needed
            Dim SmallerSize As Integer = .Width
            If .Width > .Height Then
                SmallerSize = .Height
            End If
            Dim DrawingFont As New System.Drawing.Font("Arial", SmallerSize \ 10, FontStyle.Regular, GraphicsUnit.Pixel)
            iGraphics.DrawString(Score.ToString, _
                                 DrawingFont, _
                                 New SolidBrush(TextColour), _
                                 0, 0, _
                                 New StringFormat())
        End With
    End Sub

    'Draws the text
    Public Sub DrawGameOver(ByVal iGraphics As Graphics)
        With frmMain.pctDisplay.ClientSize
            'Draws the game over screen if needed
            Dim SmallerSize As Integer = .Width
            If .Width > .Height Then
                SmallerSize = .Height
            End If
            Dim DrawingFont As New System.Drawing.Font("Arial", SmallerSize \ 6, FontStyle.Regular, GraphicsUnit.Pixel)
            Dim Area As SizeF = iGraphics.MeasureString("Game Over", DrawingFont)
            iGraphics.DrawString("Game Over", _
                                 DrawingFont, _
                                 New SolidBrush(TextColour), _
                                 CSng((.Width / 2) - (Area.Width / 2)), _
                                 CSng((.Height / 2) - (Area.Height / 2)), _
                                 New StringFormat())
        End With
    End Sub

    'Draws energy bar
    Public Sub DrawEnergy(ByVal iGraphics As Graphics)
        With frmMain.pctDisplay.ClientSize
            iGraphics.DrawRectangle(New Pen(TextColour), CSng(.Width * 0.5), CSng(.Height * 0.9), _
                                    CSng(.Width * 0.45), CSng(.Height * 0.05))
            If Energy >= 0 Then
                Dim LineX As Single = CSng((.Width * 0.5) + ((Energy / zMaxEnergy) * (.Width * 0.45)))
                iGraphics.DrawLine(New Pen(TextColour), New PointF(LineX, CSng(.Height * 0.9)), _
                                   New PointF(LineX, CSng(.Height * 0.95)))
                If Fill Then
                    iGraphics.FillRectangle(New SolidBrush(Color.FromArgb(64, TextColour)), _
                                            New RectangleF(CSng(.Width * 0.5), CSng(.Height * 0.9), _
                                                           CSng(LineX - (.Width * 0.5)), CSng(.Height * 0.05)))
                End If
            Else
                Dim LineX As Single = CSng((.Width * 0.5) + ((Energy / -zEnergyPowerDuration) * (.Width * 0.45)))
                iGraphics.DrawLine(New Pen(TextColour), New PointF(LineX, CSng(.Height * 0.9)), _
                                   New PointF(LineX, CSng(.Height * 0.95)))
                If Fill Then
                    iGraphics.FillRectangle(New SolidBrush(Color.FromArgb(64, TextColour)), _
                                            New RectangleF(CSng(.Width * 0.5), CSng(.Height * 0.9), _
                                                           CSng(LineX - (.Width * 0.5)), CSng(.Height * 0.05)))
                End If
            End If
        End With
    End Sub

    'Draws an gradient line
    Private Sub DrawGradientLine(ByVal iGraphics As Graphics, ByVal _
    iStart As PointF, ByVal iFinish As PointF, ByVal iColour As Color)
        ' Make the brush.
        Dim GradientBrush As New LinearGradientBrush(iStart, iFinish, iColour, Color.FromArgb(0, 0, 0, 0))
        GradientBrush.WrapMode = WrapMode.TileFlipX

        ' Use the brush to make the pen.
        Dim GradientPen As New Pen(GradientBrush)
        GradientPen.StartCap = LineCap.Round
        GradientPen.EndCap = LineCap.Round

        ' Draw the line.
        iGraphics.DrawLine(GradientPen, iStart, iFinish)

        ' Clean up.
        GradientPen.Dispose()
        GradientBrush.Dispose()
    End Sub
End Module
Public Class Asteroid
    Inherits _3DPoint

    Private zIsCircle As Boolean
    Public Property IsCircle() As Boolean
        Get
            Return zIsCircle
        End Get
        Set(ByVal value As Boolean)
            zIsCircle = value
        End Set
    End Property


    Public Sub New(ByVal iX As Single, ByVal iY As Single, ByVal iZ As Single, ByVal iWidth As Integer)
        MyBase.New(iX, iY, iZ)
        Me.Width = iWidth
    End Sub

    Private zWidth As Integer
    Public Property Width() As Integer
        Get
            Return zWidth
        End Get
        Set(ByVal value As Integer)
            zWidth = value
        End Set
    End Property



    Public Sub Move(ByVal iSpeed As Single)
        If GameStatus <> Status.InGame Then Exit Sub
        If Me.Z < 1 + iSpeed Then
            If Me.IsCircle And Energy >= 0 Then
                If IsInsideCircle(New PointF((Me.X), (Me.Y)), Me.Width, New PointF((Plane.LeftWing.X), (Plane.LeftWing.Y))) Or _
                   IsInsideCircle(New PointF((Me.X), (Me.Y)), Me.Width, New PointF((Plane.RightWing.X), (Plane.RightWing.Y))) Then
                    Crashed = True
                    PlayBoom()
                    Exit Sub
                End If
            ElseIf Energy >= 0 Then
                If IsInsideRectangle(New RectangleF(Me.X, Me.Y, Me.Width, Me.Width), New PointF(Plane.LeftWing.X, Plane.LeftWing.Y)) Or _
                   IsInsideRectangle(New RectangleF(Me.X, Me.Y, Me.Width, Me.Width), New PointF(Plane.RightWing.X, Plane.RightWing.Y)) Then
                    Crashed = True
                    PlayBoom()
                    Exit Sub
                End If
            End If
            zSpeed += CSng(0.002)
            Score += 1
            Me.Z += FutherestZ
            Start()

        End If
        Me.Z = CSng(Me.Z - zSpeed)
    End Sub

    Public Sub Start()
        Me.Width = Generator.Next(64) + 32
        Me.X = Generator.Next(255 + Me.Width) - 128 - (Me.Width \ 2)
        Me.Y = Generator.Next(255 + Me.Width) - 128 - (Me.Width \ 2)
        Me.IsCircle = CBool(Generator.Next(-1, 1))
    End Sub

    Public Function GetDrawWidth(ByVal iWidth As Integer) As Single
        Return CSng((((Me.X + Me.Width) / Me.Z) / 255 * iWidth) + (iWidth \ 2) - Me.GetDrawX(iWidth))
    End Function


End Class

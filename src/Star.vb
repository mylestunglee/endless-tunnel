Public Class Star
    Inherits _3DPoint

    'Constructer for new star
    Public Sub New(ByVal iX As Single, ByVal iY As Single, ByVal iZ As Single)
        MyBase.New(iX, iY, iZ)
    End Sub

    'Moves the star forward
    Public Sub Move(ByVal iSpeed As Single)
        If GameStatus <> Status.InGame Then Exit Sub
        If Me.Z < 1 + iSpeed Then
            Me.Z += FutherestZ
            Start()
        End If
        Me.Z = CSng(Me.Z - zSpeed)
    End Sub

    'Sets a new position. The Z order stays constant
    Public Sub Start()
        Me.X = Generator.Next(255) - 128
        Me.Y = Generator.Next(255) - 128
    End Sub

    'Get the monitor drawing point for the X
    Public Function GetBackDrawX(ByVal iWidth As Integer) As Single
        'The larger the Z, the closer the X will be to the centre
        Return CSng(((Me.X / (Me.Z - zSpeed))) / 255 * iWidth) + (iWidth \ 2)
    End Function

    'Get the monitor drawing point for the Y
    Public Function GetBackDrawY(ByVal iHeight As Integer) As Single
        'The larger the Z, the closer the Y will be to the centre
        Return CSng(((Me.Y / (Me.Z - zSpeed)) / 255 * iHeight) + (iHeight \ 2))
    End Function

End Class

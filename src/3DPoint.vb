'For points which are in 3D
Public Class _3DPoint
#Region "Properties"
    'Horzonial Position
    Private zX As Single
    Public Property X() As Single
        Get
            Return zX
        End Get
        Set(ByVal value As Single)
            zX = value
        End Set
    End Property

    'Vertical Position
    Private zY As Single
    Public Property Y() As Single
        Get
            Return zY
        End Get
        Set(ByVal value As Single)
            zY = value
        End Set
    End Property

    'Depth Position
    Private zZ As Single
    Public Property Z() As Single
        Get
            Return zZ
        End Get
        Set(ByVal value As Single)
            zZ = value
        End Set
    End Property
#End Region

    'Constructor for 3DPoint
    Public Sub New(ByVal iX As Single, ByVal iY As Single, ByVal iZ As Single)
        zX = iX 'Sets the X
        zY = iY 'Sets the Y
        zZ = iZ 'Sets the Z
    End Sub

    'Get the monitor drawing point for the X
    Public Function GetDrawX(ByVal iWidth As Integer) As Single
        'The larger the Z, the closer the X will be to the centre
        Return CSng(((zX / Me.Z)) / 255 * iWidth) + (iWidth \ 2)
    End Function

    'Get the monitor drawing point for the Y
    Public Function GetDrawY(ByVal iHeight As Integer) As Single
        'The larger the Z, the closer the Y will be to the centre
        Return CSng(((zY / Me.Z) / 255 * iHeight) + (iHeight \ 2))
    End Function

    'Sets the brightness from 0 to 255. The futher away, the lower the number
    Public Function Brightness() As Byte
        'If the Z is too far, it is not visible
        If Me.Z > FutherestZ Then Return 0
        Return CByte(Math.Abs((Me.Z / FutherestZ) - 1) * Byte.MaxValue)
    End Function
End Class

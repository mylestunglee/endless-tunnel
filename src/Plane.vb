Public Module Plane
    Public Const zPlaneWidth As Integer = 32

    Private zCrashed As Boolean
    Public Property Crashed() As Boolean
        Get
            Return zCrashed
        End Get
        Set(ByVal value As Boolean)
            If value Then Crash()
            zCrashed = value
        End Set
    End Property

    Private zLeftWing As _3DPoint
    Public Property LeftWing() As _3DPoint
        Get
            Return zLeftWing
        End Get
        Set(ByVal value As _3DPoint)
            zLeftWing = value
        End Set
    End Property

    Private zRightWing As _3DPoint
    Public Property RightWing() As _3DPoint
        Get
            Return zRightWing
        End Get
        Set(ByVal value As _3DPoint)
            zRightWing = value
        End Set
    End Property

    Private zFront As _3DPoint
    Public Property Front() As _3DPoint
        Get
            Return zFront
        End Get
        Set(ByVal value As _3DPoint)
            zFront = value
        End Set
    End Property

    'Movement by the mouse
    Public Sub Move(ByVal iMouseX As Integer, ByVal iMouseY As Integer, _
                    ByVal iWidth As Integer, ByVal iHeight As Integer)
        zLeftWing = New _3DPoint(CSng((((iMouseX - iWidth / 2) / iWidth) * 255 - (zPlaneWidth \ 2))), _
                                 CSng(((iMouseY - (iHeight / 2)) / iHeight * 255)), 1)
        zRightWing = New _3DPoint(CSng((((iMouseX - iWidth / 2) / iWidth) * 255 + (zPlaneWidth \ 2))), _
                                  CSng(((iMouseY - (iHeight / 2)) / iHeight * 255)), 1)
        zFront = New _3DPoint(CSng((((iMouseX - iWidth / 2) / iWidth) * 255)), _
                              CSng(((iMouseY - (iHeight / 2)) / iHeight * 255)), 1.2)
    End Sub

    'Movement by the keyboard
    Public Sub Move()
        Dim temp As Single = 10
        If _KeyPress.LeftPress And Front.X > -128 Then
            LeftWing.X -= temp
            RightWing.X -= temp
            Front.X -= temp
        End If
        If _KeyPress.UpPress And Front.Y > -128 Then
            LeftWing.Y -= temp
            RightWing.Y -= temp
            Front.Y -= temp
        End If
        If _KeyPress.RightPress And Front.X < 128 Then
            LeftWing.X += temp
            RightWing.X += temp
            Front.X += temp
        End If
        If _KeyPress.DownPress And Front.Y < 128 Then
            LeftWing.Y += temp
            RightWing.Y += temp
            Front.Y += temp
        End If
    End Sub

    Public Sub Crash()
        GameStatus = Status.GameOver
        frmMain.tmrFrame.Enabled = False
        DrawAll()
        frmOptions.cmdOk.Enabled = True
    End Sub

End Module

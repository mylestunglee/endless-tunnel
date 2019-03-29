Module Audio
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Private zPlayMusic As Boolean = True
    Public Property PlayMusic() As Boolean
        Get
            Return zPlayMusic
        End Get
        Set(ByVal value As Boolean)
            zPlayMusic = value
            If value Then
                Dim MusicPath As String = Application.StartupPath & "\Looping Background.wav"
                If IO.File.Exists(MusicPath) Then
                    My.Computer.Audio.Play(MusicPath, AudioPlayMode.BackgroundLoop)
                Else
                    My.Computer.Audio.Stop()
                End If
            End If
        End Set
    End Property

    Dim zAudioID As String
    Dim zAudioPath As String
    Sub Open()
        mciSendString("Open " & Chr(34) & zAudioPath & Chr(34) & " alias " & zAudioID, CStr(0), 0, 0)
    End Sub
    Sub Play1()
        mciSendString("play " & zAudioID, CStr(0), 0, 0)
    End Sub
    Sub close1()
        'Close the sound, this is the opposite to Open and will make so 
        'you can't use the sound any more'unless you open it again of course.
        mciSendString("close " & zAudioID, CStr(0), 0, 0)
    End Sub

    Dim zLaserOpened As Boolean
    Dim zBoomOpened As Boolean

    Public Sub PlayLaser()
        Dim LaserPath As String = Application.StartupPath & "\Laser.wav"
        If IO.File.Exists(LaserPath) Then
            zLaserOpened = True
            zAudioID = "Laser"
            zAudioPath = LaserPath
            If zLaserOpened Then
                close1()
            End If
            Open()
            Play1()
        End If
    End Sub

    Public Sub PlayBoom()
        Dim BoomPath As String = Application.StartupPath & "\Boom.wav"
        If IO.File.Exists(BoomPath) Then
            zBoomOpened = True
            zAudioID = "Boom"
            zAudioPath = BoomPath
            If zBoomOpened Then
                close1()
            End If
            Open()
            Play1()
        End If
    End Sub

    Public Sub CleanUp()
        If zLaserOpened Then
            zAudioID = "Laser"
            close1()
        End If
        If zBoomOpened Then
            zAudioID = "Boom"
            close1()
        End If
    End Sub
End Module

Module _KeyPress
    Private zLeftPress As Boolean
    Public Property LeftPress() As Boolean
        Get
            Return zLeftPress
        End Get
        Set(ByVal value As Boolean)
            zLeftPress = value
        End Set
    End Property

    Private zUpPress As Boolean
    Public Property UpPress() As Boolean
        Get
            Return zUpPress
        End Get
        Set(ByVal value As Boolean)
            zUpPress = value
        End Set
    End Property

    Private zRightPress As Boolean
    Public Property RightPress() As Boolean
        Get
            Return zRightPress
        End Get
        Set(ByVal value As Boolean)
            zRightPress = value
        End Set
    End Property

    Private zDownPress As Boolean
    Public Property DownPress() As Boolean
        Get
            Return zDownPress
        End Get
        Set(ByVal value As Boolean)
            zDownPress = value
        End Set
    End Property
End Module
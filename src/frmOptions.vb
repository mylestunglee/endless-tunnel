Public Class frmOptions

    Dim zBackColour As Color
    Dim zTunnelColour As Color
    Dim zAsteroidColour As Color
    Dim zStarColour As Color
    Dim zPlaneColour As Color
    Dim zTextColour As Color

    Private Sub lstObjects_SelectedIndexChanged() Handles lstObjects.SelectedIndexChanged
        With Me.pctPreview 'Set the Preview's backcolour
            Select Case lstObjects.SelectedIndex
                Case 0 'Background
                    .BackColor = zBackColour
                Case 1 'Tunnel
                    .BackColor = zTunnelColour
                Case 2 'Asteroid
                    .BackColor = zAsteroidColour
                Case 3 'Stars
                    .BackColor = zStarColour
                Case 4 'Plane
                    .BackColor = zPlaneColour
                Case 5 'Text
                    .BackColor = zTextColour
            End Select
        End With
    End Sub

    Private Sub cmdChange_Click() Handles cmdChange.Click
        With Me.dlgColour 'Set the Preview's backcolour
            dlgColour.ShowDialog()
            Select Case lstObjects.SelectedIndex
                Case 0 'Background
                    zBackColour = dlgColour.Color
                Case 1 'Tunnel
                    zTunnelColour = dlgColour.Color
                Case 2 'Asteroid
                    zAsteroidColour = dlgColour.Color
                Case 3 'Stars
                    zStarColour = dlgColour.Color
                Case 4 'Plane
                    zPlaneColour = dlgColour.Color
                Case 5 'Text
                    zTextColour = dlgColour.Color
            End Select
        End With
        lstObjects_SelectedIndexChanged()
    End Sub

    Private Sub frmOptions_Load() Handles Me.Load
        zBackColour = frmMain.pctDisplay.BackColor
        zTunnelColour = _Graphics.TunnelColour
        zAsteroidColour = _Graphics.AsteroidColour
        zStarColour = _Graphics.StarColour
        zPlaneColour = _Graphics.PlaneColour
        zTextColour = _Graphics.TextColour

        chcAntiAlias.Checked = _Graphics.AntiAlias
        chcDisplayStars.Checked = _Graphics.DisplayStars
        chcFill.Checked = _Graphics.Fill
        nmrStarNumber.Value = _Graphics.NumberofStars
        chcPlayMusic.Checked = Audio.PlayMusic
        chcUseKeyboard.Checked = Core.UseKeyboard
        nmrVisibleRange.Value = Core.FutherestZ
    End Sub

    Public Sub sOkClick() Handles cmdOk.Click
        Core.UseKeyboard = chcUseKeyboard.Checked
        'music
        _Graphics.DisplayStars = chcDisplayStars.Checked
        _Graphics.NumberofStars = CInt(nmrStarNumber.Value)
        _Graphics.Fill = chcFill.Checked
        _Graphics.AntiAlias = chcAntiAlias.Checked
        Core.FutherestZ = CInt(nmrVisibleRange.Value)

        frmMain.pctDisplay.BackColor = zBackColour
        _Graphics.TunnelColour = zTunnelColour
        _Graphics.AsteroidColour = zAsteroidColour
        _Graphics.StarColour = zStarColour
        _Graphics.PlaneColour = zPlaneColour
        _Graphics.TextColour = zTextColour

        Me.Close()
    End Sub

    Private Sub sCancelClick() Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class
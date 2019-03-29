<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.cmdOk = New System.Windows.Forms.Button
        Me.tab = New System.Windows.Forms.TabControl
        Me.tabGeneral = New System.Windows.Forms.TabPage
        Me.chcPlayMusic = New System.Windows.Forms.CheckBox
        Me.chcUseKeyboard = New System.Windows.Forms.CheckBox
        Me.tabApperance = New System.Windows.Forms.TabPage
        Me.boxStar = New System.Windows.Forms.GroupBox
        Me.lblStarNumber = New System.Windows.Forms.Label
        Me.nmrStarNumber = New System.Windows.Forms.NumericUpDown
        Me.chcDisplayStars = New System.Windows.Forms.CheckBox
        Me.chcFill = New System.Windows.Forms.CheckBox
        Me.lblVisibleRange = New System.Windows.Forms.Label
        Me.boxColour = New System.Windows.Forms.GroupBox
        Me.lblPreview = New System.Windows.Forms.Label
        Me.pctPreview = New System.Windows.Forms.PictureBox
        Me.lstObjects = New System.Windows.Forms.ListBox
        Me.cmdChange = New System.Windows.Forms.Button
        Me.nmrVisibleRange = New System.Windows.Forms.NumericUpDown
        Me.chcAntiAlias = New System.Windows.Forms.CheckBox
        Me.boxCommand = New System.Windows.Forms.Panel
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.dlgColour = New System.Windows.Forms.ColorDialog
        Me.tlt = New System.Windows.Forms.ToolTip(Me.components)
        Me.tab.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.tabApperance.SuspendLayout()
        Me.boxStar.SuspendLayout()
        CType(Me.nmrStarNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxColour.SuspendLayout()
        CType(Me.pctPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrVisibleRange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxCommand.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.Location = New System.Drawing.Point(205, 6)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 1
        Me.cmdOk.Text = "&Ok"
        Me.tlt.SetToolTip(Me.cmdOk, "Closes the Options form.")
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'tab
        '
        Me.tab.Controls.Add(Me.tabGeneral)
        Me.tab.Controls.Add(Me.tabApperance)
        Me.tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab.Location = New System.Drawing.Point(0, 0)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(292, 291)
        Me.tab.TabIndex = 0
        '
        'tabGeneral
        '
        Me.tabGeneral.Controls.Add(Me.chcPlayMusic)
        Me.tabGeneral.Controls.Add(Me.chcUseKeyboard)
        Me.tabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(284, 265)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        Me.tabGeneral.UseVisualStyleBackColor = True
        '
        'chcPlayMusic
        '
        Me.chcPlayMusic.AutoSize = True
        Me.chcPlayMusic.Location = New System.Drawing.Point(8, 29)
        Me.chcPlayMusic.Name = "chcPlayMusic"
        Me.chcPlayMusic.Size = New System.Drawing.Size(77, 17)
        Me.chcPlayMusic.TabIndex = 2
        Me.chcPlayMusic.Text = "Play &Music"
        Me.tlt.SetToolTip(Me.chcPlayMusic, "If checked, music will play.")
        Me.chcPlayMusic.UseVisualStyleBackColor = True
        '
        'chcUseKeyboard
        '
        Me.chcUseKeyboard.AutoSize = True
        Me.chcUseKeyboard.Location = New System.Drawing.Point(8, 6)
        Me.chcUseKeyboard.Name = "chcUseKeyboard"
        Me.chcUseKeyboard.Size = New System.Drawing.Size(93, 17)
        Me.chcUseKeyboard.TabIndex = 0
        Me.chcUseKeyboard.Text = "&Use Keyboard"
        Me.tlt.SetToolTip(Me.chcUseKeyboard, "If checked, the keyboard input will be used instead of the mouse.")
        Me.chcUseKeyboard.UseVisualStyleBackColor = True
        '
        'tabApperance
        '
        Me.tabApperance.Controls.Add(Me.boxStar)
        Me.tabApperance.Controls.Add(Me.chcFill)
        Me.tabApperance.Controls.Add(Me.lblVisibleRange)
        Me.tabApperance.Controls.Add(Me.boxColour)
        Me.tabApperance.Controls.Add(Me.nmrVisibleRange)
        Me.tabApperance.Controls.Add(Me.chcAntiAlias)
        Me.tabApperance.Location = New System.Drawing.Point(4, 22)
        Me.tabApperance.Name = "tabApperance"
        Me.tabApperance.Padding = New System.Windows.Forms.Padding(3)
        Me.tabApperance.Size = New System.Drawing.Size(284, 265)
        Me.tabApperance.TabIndex = 1
        Me.tabApperance.Text = "Appearance"
        Me.tabApperance.UseVisualStyleBackColor = True
        '
        'boxStar
        '
        Me.boxStar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boxStar.Controls.Add(Me.lblStarNumber)
        Me.boxStar.Controls.Add(Me.nmrStarNumber)
        Me.boxStar.Controls.Add(Me.chcDisplayStars)
        Me.boxStar.Location = New System.Drawing.Point(6, 119)
        Me.boxStar.Name = "boxStar"
        Me.boxStar.Size = New System.Drawing.Size(272, 68)
        Me.boxStar.TabIndex = 3
        Me.boxStar.TabStop = False
        Me.boxStar.Text = "Stars"
        '
        'lblStarNumber
        '
        Me.lblStarNumber.AutoSize = True
        Me.lblStarNumber.Location = New System.Drawing.Point(84, 44)
        Me.lblStarNumber.Name = "lblStarNumber"
        Me.lblStarNumber.Size = New System.Drawing.Size(83, 13)
        Me.lblStarNumber.TabIndex = 5
        Me.lblStarNumber.Text = "&Number of Stars"
        '
        'nmrStarNumber
        '
        Me.nmrStarNumber.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nmrStarNumber.Location = New System.Drawing.Point(6, 42)
        Me.nmrStarNumber.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nmrStarNumber.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrStarNumber.Name = "nmrStarNumber"
        Me.nmrStarNumber.Size = New System.Drawing.Size(72, 20)
        Me.nmrStarNumber.TabIndex = 5
        Me.tlt.SetToolTip(Me.nmrStarNumber, "The number of stars displayed.")
        Me.nmrStarNumber.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'chcDisplayStars
        '
        Me.chcDisplayStars.AutoSize = True
        Me.chcDisplayStars.Location = New System.Drawing.Point(6, 19)
        Me.chcDisplayStars.Name = "chcDisplayStars"
        Me.chcDisplayStars.Size = New System.Drawing.Size(87, 17)
        Me.chcDisplayStars.TabIndex = 5
        Me.chcDisplayStars.Text = "&Display Stars"
        Me.tlt.SetToolTip(Me.chcDisplayStars, "If checked, stars will be displayed.")
        Me.chcDisplayStars.UseVisualStyleBackColor = True
        '
        'chcFill
        '
        Me.chcFill.AutoSize = True
        Me.chcFill.Location = New System.Drawing.Point(6, 242)
        Me.chcFill.Name = "chcFill"
        Me.chcFill.Size = New System.Drawing.Size(38, 17)
        Me.chcFill.TabIndex = 4
        Me.chcFill.Text = "&Fill"
        Me.tlt.SetToolTip(Me.chcFill, " ")
        Me.chcFill.UseVisualStyleBackColor = True
        '
        'lblVisibleRange
        '
        Me.lblVisibleRange.AutoSize = True
        Me.lblVisibleRange.Location = New System.Drawing.Point(84, 195)
        Me.lblVisibleRange.Name = "lblVisibleRange"
        Me.lblVisibleRange.Size = New System.Drawing.Size(72, 13)
        Me.lblVisibleRange.TabIndex = 2
        Me.lblVisibleRange.Text = "Visible &Range"
        '
        'boxColour
        '
        Me.boxColour.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boxColour.Controls.Add(Me.lblPreview)
        Me.boxColour.Controls.Add(Me.pctPreview)
        Me.boxColour.Controls.Add(Me.lstObjects)
        Me.boxColour.Controls.Add(Me.cmdChange)
        Me.boxColour.Location = New System.Drawing.Point(6, 6)
        Me.boxColour.Name = "boxColour"
        Me.boxColour.Size = New System.Drawing.Size(272, 107)
        Me.boxColour.TabIndex = 0
        Me.boxColour.TabStop = False
        Me.boxColour.Text = "Colour"
        '
        'lblPreview
        '
        Me.lblPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Location = New System.Drawing.Point(191, 19)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(40, 13)
        Me.lblPreview.TabIndex = 1
        Me.lblPreview.Text = "Colour:"
        '
        'pctPreview
        '
        Me.pctPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctPreview.BackColor = System.Drawing.SystemColors.Window
        Me.pctPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctPreview.Location = New System.Drawing.Point(237, 19)
        Me.pctPreview.Name = "pctPreview"
        Me.pctPreview.Size = New System.Drawing.Size(29, 29)
        Me.pctPreview.TabIndex = 2
        Me.pctPreview.TabStop = False
        Me.tlt.SetToolTip(Me.pctPreview, "The colour of the selected object.")
        '
        'lstObjects
        '
        Me.lstObjects.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstObjects.FormattingEnabled = True
        Me.lstObjects.Items.AddRange(New Object() {"Background", "Tunnel", "Asteroids", "Stars", "Plane", "Text"})
        Me.lstObjects.Location = New System.Drawing.Point(6, 19)
        Me.lstObjects.Name = "lstObjects"
        Me.lstObjects.Size = New System.Drawing.Size(179, 82)
        Me.lstObjects.TabIndex = 0
        Me.tlt.SetToolTip(Me.lstObjects, "Select the object you want to change.")
        '
        'cmdChange
        '
        Me.cmdChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdChange.Location = New System.Drawing.Point(191, 78)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(75, 23)
        Me.cmdChange.TabIndex = 2
        Me.cmdChange.Text = "&Change"
        Me.tlt.SetToolTip(Me.cmdChange, "Click to change the selected object's colour.")
        Me.cmdChange.UseVisualStyleBackColor = True
        '
        'nmrVisibleRange
        '
        Me.nmrVisibleRange.Location = New System.Drawing.Point(6, 193)
        Me.nmrVisibleRange.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.nmrVisibleRange.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nmrVisibleRange.Name = "nmrVisibleRange"
        Me.nmrVisibleRange.Size = New System.Drawing.Size(72, 20)
        Me.nmrVisibleRange.TabIndex = 1
        Me.tlt.SetToolTip(Me.nmrVisibleRange, "The futherest distance visible.")
        Me.nmrVisibleRange.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'chcAntiAlias
        '
        Me.chcAntiAlias.AutoSize = True
        Me.chcAntiAlias.Location = New System.Drawing.Point(6, 219)
        Me.chcAntiAlias.Name = "chcAntiAlias"
        Me.chcAntiAlias.Size = New System.Drawing.Size(69, 17)
        Me.chcAntiAlias.TabIndex = 3
        Me.chcAntiAlias.Text = "&Anti-Alias"
        Me.tlt.SetToolTip(Me.chcAntiAlias, "If checked, anti-alias will be used to smoothen edges.")
        Me.chcAntiAlias.UseVisualStyleBackColor = True
        '
        'boxCommand
        '
        Me.boxCommand.Controls.Add(Me.cmdCancel)
        Me.boxCommand.Controls.Add(Me.cmdOk)
        Me.boxCommand.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.boxCommand.Location = New System.Drawing.Point(0, 291)
        Me.boxCommand.Name = "boxCommand"
        Me.boxCommand.Size = New System.Drawing.Size(292, 41)
        Me.boxCommand.TabIndex = 1
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.Location = New System.Drawing.Point(124, 6)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "&Cancel"
        Me.tlt.SetToolTip(Me.cmdCancel, "Closes the Options form.")
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'dlgColour
        '
        Me.dlgColour.AnyColor = True
        Me.dlgColour.SolidColorOnly = True
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 332)
        Me.Controls.Add(Me.tab)
        Me.Controls.Add(Me.boxCommand)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(300, 359)
        Me.Name = "frmOptions"
        Me.Text = "Options"
        Me.tab.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.tabApperance.ResumeLayout(False)
        Me.tabApperance.PerformLayout()
        Me.boxStar.ResumeLayout(False)
        Me.boxStar.PerformLayout()
        CType(Me.nmrStarNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxColour.ResumeLayout(False)
        Me.boxColour.PerformLayout()
        CType(Me.pctPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrVisibleRange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxCommand.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents tab As System.Windows.Forms.TabControl
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabApperance As System.Windows.Forms.TabPage
    Friend WithEvents lblVisibleRange As System.Windows.Forms.Label
    Friend WithEvents boxColour As System.Windows.Forms.GroupBox
    Friend WithEvents lblPreview As System.Windows.Forms.Label
    Friend WithEvents pctPreview As System.Windows.Forms.PictureBox
    Friend WithEvents lstObjects As System.Windows.Forms.ListBox
    Friend WithEvents cmdChange As System.Windows.Forms.Button
    Friend WithEvents nmrVisibleRange As System.Windows.Forms.NumericUpDown
    Friend WithEvents chcAntiAlias As System.Windows.Forms.CheckBox
    Friend WithEvents boxCommand As System.Windows.Forms.Panel
    Friend WithEvents chcPlayMusic As System.Windows.Forms.CheckBox
    Friend WithEvents chcUseKeyboard As System.Windows.Forms.CheckBox
    Friend WithEvents dlgColour As System.Windows.Forms.ColorDialog
    Friend WithEvents chcFill As System.Windows.Forms.CheckBox
    Friend WithEvents chcDisplayStars As System.Windows.Forms.CheckBox
    Friend WithEvents boxStar As System.Windows.Forms.GroupBox
    Friend WithEvents lblStarNumber As System.Windows.Forms.Label
    Friend WithEvents nmrStarNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents tlt As System.Windows.Forms.ToolTip
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
End Class

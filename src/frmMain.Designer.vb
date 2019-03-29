<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pctDisplay = New System.Windows.Forms.PictureBox
        Me.tmrFrame = New System.Windows.Forms.Timer(Me.components)
        Me.mnu = New System.Windows.Forms.ToolStrip
        Me.mnuNew = New System.Windows.Forms.ToolStripButton
        Me.mnuSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuOptions = New System.Windows.Forms.ToolStripButton
        Me.mnuSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuInstructions = New System.Windows.Forms.ToolStripButton
        Me.mnuAbout = New System.Windows.Forms.ToolStripButton
        Me.mnuSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuClose = New System.Windows.Forms.ToolStripButton
        CType(Me.pctDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pctDisplay
        '
        Me.pctDisplay.BackColor = System.Drawing.Color.Black
        Me.pctDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctDisplay.Location = New System.Drawing.Point(0, 25)
        Me.pctDisplay.Name = "pctDisplay"
        Me.pctDisplay.Size = New System.Drawing.Size(292, 248)
        Me.pctDisplay.TabIndex = 0
        Me.pctDisplay.TabStop = False
        '
        'tmrFrame
        '
        Me.tmrFrame.Interval = 40
        '
        'mnu
        '
        Me.mnu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuSeparator1, Me.mnuOptions, Me.mnuSeparator2, Me.mnuInstructions, Me.mnuAbout, Me.mnuSeparator3, Me.mnuClose})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(292, 25)
        Me.mnu.TabIndex = 1
        Me.mnu.Text = "Menu"
        '
        'mnuNew
        '
        Me.mnuNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuNew.Image = CType(resources.GetObject("mnuNew.Image"), System.Drawing.Image)
        Me.mnuNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(23, 22)
        Me.mnuNew.Text = "&New"
        '
        'mnuSeparator1
        '
        Me.mnuSeparator1.Name = "mnuSeparator1"
        Me.mnuSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'mnuOptions
        '
        Me.mnuOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuOptions.Image = CType(resources.GetObject("mnuOptions.Image"), System.Drawing.Image)
        Me.mnuOptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(23, 22)
        Me.mnuOptions.Text = "&Options"
        '
        'mnuSeparator2
        '
        Me.mnuSeparator2.Name = "mnuSeparator2"
        Me.mnuSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'mnuInstructions
        '
        Me.mnuInstructions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuInstructions.Image = Global.Endless_Tunnel.My.Resources.Resources.InstructionsPicture
        Me.mnuInstructions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuInstructions.Name = "mnuInstructions"
        Me.mnuInstructions.Size = New System.Drawing.Size(23, 22)
        Me.mnuInstructions.Text = "&Instructions"
        '
        'mnuAbout
        '
        Me.mnuAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuAbout.Image = Global.Endless_Tunnel.My.Resources.Resources.HelpPicture
        Me.mnuAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(23, 22)
        Me.mnuAbout.Text = "&About"
        '
        'mnuSeparator3
        '
        Me.mnuSeparator3.Name = "mnuSeparator3"
        Me.mnuSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'mnuClose
        '
        Me.mnuClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuClose.Image = Global.Endless_Tunnel.My.Resources.Resources.ExitPicture
        Me.mnuClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(23, 22)
        Me.mnuClose.Text = "Close"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.pctDisplay)
        Me.Controls.Add(Me.mnu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(16, 150)
        Me.Name = "frmMain"
        Me.Text = "Endless Tunnel"
        CType(Me.pctDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pctDisplay As System.Windows.Forms.PictureBox
    Friend WithEvents tmrFrame As System.Windows.Forms.Timer
    Friend WithEvents mnu As System.Windows.Forms.ToolStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuOptions As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuInstructions As System.Windows.Forms.ToolStripButton

End Class

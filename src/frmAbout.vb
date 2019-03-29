Public NotInheritable Class frmAbout

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LicenseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LicenseButton.Click
        'If the help file doesn't exist then messagebox of error and doesn't open file
        If Not System.IO.File.Exists(Application.StartupPath & "\License.txt") Then
            MessageBox.Show("The license file cannot be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Opens the help file in notepad
        System.Diagnostics.Process.Start("notepad.exe", Application.StartupPath & "\License.txt")
    End Sub

    Private Sub OKButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Close()
    End Sub
End Class

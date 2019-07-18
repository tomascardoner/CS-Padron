Public NotInheritable Class formSplashScreen
    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        labelCompanyName.Text = My.Application.Info.CompanyName
        labelAppTitle.Text = My.Application.Info.Title

        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        labelCopyright.Text = My.Application.Info.Copyright
    End Sub

End Class

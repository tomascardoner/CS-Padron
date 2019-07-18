Module Startup
    Public Sub Main()
        Dim stopwatchStart As New Stopwatch

        formSplashScreen.Show()

        stopwatchStart.Start()

        Do While stopwatchStart.Elapsed.Seconds < 5
            Application.DoEvents()
        Loop

        formMain.Show()
        formSplashScreen.Close()

        Application.Run(formMain)
    End Sub
End Module

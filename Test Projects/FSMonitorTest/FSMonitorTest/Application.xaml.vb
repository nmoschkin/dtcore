﻿Class Application

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.



    Private Sub Application_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
        System.Windows.Forms.Application.EnableVisualStyles()
    End Sub


End Class

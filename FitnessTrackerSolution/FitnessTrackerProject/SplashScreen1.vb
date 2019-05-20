' Andrew Moss
Option Explicit On
Option Strict On
Option Infer Off

Public NotInheritable Class SplashScreen1
    Private Sub tmrLoading_Tick(sender As Object, e As EventArgs) Handles tmrLoading.Tick
        pbrLoading.Increment(20)
    End Sub

    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLoading.Enabled = True
    End Sub

End Class

Imports Microsoft.VisualBasic.Logging
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MyProgressBar.Increment(1)
        Dim Percentage As String
        Percentage = Convert.ToString(MyProgressBar.Value)
        Label2.Text = Percentage + "%"
        If MyProgressBar.Value = 100 Then
            Me.Hide()
            Dim log = New POS
            log.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
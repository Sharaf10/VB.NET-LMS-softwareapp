Public Class FormStartup
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Guna2ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            Guna2ProgressBar1.Value = 0
            Label2.Text = "LOADING COMPLETED!"
            FormLogin.Show()
            Me.Dispose()
        End If
        Guna2ProgressBar1.Value += 1
        Label2.Text = "PLEASE WAIT...LOADING " & Guna2ProgressBar1.Value & "%"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub FormStartup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

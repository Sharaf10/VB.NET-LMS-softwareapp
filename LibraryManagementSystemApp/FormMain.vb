Public Class FormMain

    Sub switchpanel(ByVal panel As Form)
        Guna2Panel3.Controls.Clear()
        panel.TopLevel = False
        Guna2Panel3.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub
    Private Sub Guna2ControlBox1_Click_1(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnmembers.Click
        switchpanel(MemberDetails)
        ' If Guna2Panel3 = MemberDetails Then
        'btnmembers.Checked
        'End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        switchpanel(Home)
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles btnsuppliers.Click
        switchpanel(SupplierDetails)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnbooks.Click
        switchpanel(BookDetails)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles btnstaff.Click
        switchpanel(StaffDetails)
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles btnissue.Click
        switchpanel(IssueDetails)
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        switchpanel(ReturnDetails)
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        FormLogin.Show()
        FormLogin.txtusername.Clear()
        FormLogin.txtpassword.Clear()
    End Sub

End Class
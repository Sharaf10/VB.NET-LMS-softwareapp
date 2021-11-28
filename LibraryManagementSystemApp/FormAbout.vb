Public Class FormAbout
    Private Sub Guna2Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        FormMain.Show()
        Me.Close()
    End Sub

    Private Sub btnsuppliers_Click(sender As Object, e As EventArgs) Handles btnsuppliers.Click
        SupplierDetails.Show()
        Me.Close()
    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        ReturnDetails.Show()
        Me.Close()
    End Sub

    Private Sub btnissue_Click(sender As Object, e As EventArgs) Handles btnissue.Click
        IssueDetails.Show()
        Me.Close()
    End Sub

    Private Sub btnstaff_Click(sender As Object, e As EventArgs) Handles btnstaff.Click
        StaffDetails.Show()
        Me.Close()
    End Sub

    Private Sub btnbooks_Click(sender As Object, e As EventArgs) Handles btnbooks.Click
        BookDetails.Show()
        Me.Close()
    End Sub

    Private Sub btnmembers_Click(sender As Object, e As EventArgs) Handles btnmembers.Click
        MemberDetails.Show()
        Me.Close()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Dim result = 0
        If result = DialogResult.Yes Then
            Me.Close()
        End If

        'Application.Exit()
    End Sub
    Private Sub Guna2Panel4_Paint_1(sender As Object, e As PaintEventArgs) Handles Guna2Panel4.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("https://github.com/Sharaf10/VB.NET-LMS-softwareapp.git")
    End Sub
End Class
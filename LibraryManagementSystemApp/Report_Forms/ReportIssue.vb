Public Class ReportIssue

    Private Sub loads()
        CrystalReportViewer1.ReportSource = Application.StartupPath + "\Report_designing\IssueDetailsRep.rpt"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()
    End Sub
    Private Sub ReportIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loads()
    End Sub
End Class
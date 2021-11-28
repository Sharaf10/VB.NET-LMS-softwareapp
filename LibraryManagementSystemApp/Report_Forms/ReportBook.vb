Public Class ReportBook
    Private Sub loads()
        CrystalReportViewer2.ReportSource = Application.StartupPath + "\Report_designing\BookDetailsRep.rpt"
        CrystalReportViewer2.Refresh()
        CrystalReportViewer2.RefreshReport()
    End Sub

    Private Sub ReportBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loads()
    End Sub
End Class
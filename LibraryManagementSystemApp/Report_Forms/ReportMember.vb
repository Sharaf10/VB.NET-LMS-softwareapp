Public Class ReportMember
    Private Sub load()
        CrystalReportViewer1.ReportSource = Application.StartupPath + "\Report_designing\MemberDetailsRep.rpt"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub
End Class


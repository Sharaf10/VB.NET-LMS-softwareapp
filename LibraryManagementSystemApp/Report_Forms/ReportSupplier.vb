Public Class ReportSupplier
    Private Sub loads()
        CrystalReportViewer1.ReportSource = Application.StartupPath + "\Report_designing\SupplierDetailsRep.rpt"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()
    End Sub
    Private Sub ReportSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loads()
    End Sub
End Class
Imports Microsoft.Reporting.WinForms

Public Class FrmRptViewer
    Private Sub FrmRptViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim rpt As ServerReport
        'RptViewer.ProcessingMode = ProcessingMode.Remote
        'rpt = RptViewer.ServerReport

        'Dim credentials As System.Net.ICredentials
        'credentials = System.Net.CredentialCache.DefaultCredentials

        'Dim rscredentials As ReportServerCredentials
        'rscredentials = rpt.ReportServerCredentials

        'rscredentials.NetworkCredentials = credentials

        'rpt.ReportServerUrl = New Uri("http://90-214-109-208:80/Reports")

        'rpt.ReportPath = "/SerieReportDetail"

        RptViewer.ServerReport.ReportServerUrl = New Uri("http://90-214-109-208/ReportServer")
        RptViewer.ServerReport.ReportPath = "/" & GLOBAL_VARIABLES.ReportName

        Me.RptViewer.RefreshReport()
    End Sub
End Class
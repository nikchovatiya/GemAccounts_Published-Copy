<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptViewer
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RptViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RptViewer
        '
        Me.RptViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RptViewer.Location = New System.Drawing.Point(0, 0)
        Me.RptViewer.Name = "RptViewer"
        Me.RptViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.RptViewer.ServerReport.ReportServerUrl = New System.Uri("", System.UriKind.Relative)
        Me.RptViewer.Size = New System.Drawing.Size(743, 328)
        Me.RptViewer.TabIndex = 0
        '
        'FrmRptViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 328)
        Me.Controls.Add(Me.RptViewer)
        Me.Name = "FrmRptViewer"
        Me.Text = "Report"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RptViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class

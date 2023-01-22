Imports System.ComponentModel

Public Class FrmTest
    Private WithEvents BackgroundWorker As BackgroundWorker, ProgressBar As frmProgressBar

    Private Sub btnProgressBarPOC_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call RunProcessing()
        MsgBox("Main Done", vbInformation)
    End Sub

    Sub RunProcessing()
        BackgroundWorker = New BackgroundWorker()
        BackgroundWorker.WorkerReportsProgress = True
        ProgressBar = New frmProgressBar(BackgroundWorker)
        ProgressBar.ShowDialog()
    End Sub

    Sub Processing() Handles BackgroundWorker.DoWork
        'BackgroundWorker.ReportProgress(33, "Step-1")
        'Threading.Thread.Sleep(3000)

        'BackgroundWorker.ReportProgress(66, "Step-2")
        'Threading.Thread.Sleep(2000)

        BackgroundWorker.ReportProgress(100, "Step-3")
    End Sub

End Class

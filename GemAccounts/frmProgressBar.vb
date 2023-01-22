Public Class frmProgressBar
    Private WithEvents _BGW As System.ComponentModel.BackgroundWorker
    Private _TaskInProgress As String

    Public Sub New(ByVal BGW As System.ComponentModel.BackgroundWorker)
        _BGW = BGW
        InitializeComponent()
    End Sub

    Private Sub frmProgress_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        If Not IsNothing(_BGW) Then
            _BGW.RunWorkerAsync()
        End If
    End Sub

    Private Sub _BGW_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles _BGW.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Me.Text = e.UserState
    End Sub

    Private Sub _BGW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _BGW.RunWorkerCompleted
        Me.Close()
        _TaskInProgress = ""
    End Sub
End Class
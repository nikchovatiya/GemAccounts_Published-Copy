Imports DevExpress.XtraWaitForm

Namespace WaitForm_SetDescription
    Partial Public Class WaitForm1
        Inherits WaitForm
        Public Sub New()

            Me.progressPanel1.AutoSize = True
        End Sub

#Region "Overrides"

        Public Overrides Sub SetCaption(ByVal caption As String)
            MyBase.SetCaption(caption)
            Me.progressPanel1.Caption = caption
        End Sub
        Public Overrides Sub SetDescription(ByVal description As String)
            MyBase.SetDescription(description)
            Me.progressPanel1.Description = description
        End Sub

        Private Function progressPanel1() As Object
            Throw New NotImplementedException()
        End Function

        Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
            MyBase.ProcessCommand(cmd, arg)
        End Sub

        Private Sub InitializeComponent()
            Me.SuspendLayout()
            '
            'WaitForm1
            '
            Me.ClientSize = New System.Drawing.Size(300, 300)
            Me.Name = "WaitForm1"
            Me.ResumeLayout(False)

        End Sub

#End Region

    End Class
End Namespace

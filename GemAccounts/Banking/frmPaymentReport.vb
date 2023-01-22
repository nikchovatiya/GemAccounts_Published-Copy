Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class frmPaymentReport
    Dim a As EventArgs
    Private Sub frmPaymentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFrm()
    End Sub
    Public Shared Sub LoadFrm()
        BAL_Transactions.PaymentCRUD(frmPaymentReport.dg, 3, 0, Now, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "")
    End Sub

    Private Sub btnexport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnexport.ItemClick
        DevFunctions.ExportGrid(dgview)
    End Sub

    Private Sub dgview_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles dgview.RowCellClick
        If e.Column.FieldName = "Edit" Then
            riEdit_OpenLink(sender, New DevExpress.XtraEditors.Controls.OpenLinkEventArgs(e.CellValue))
        ElseIf e.Column.FieldName = "Delete" Then
            riDelete_OpenLink(sender, New DevExpress.XtraEditors.Controls.OpenLinkEventArgs(e.CellValue))
        ElseIf e.Column.FieldName = "PDF" Then
            If IsDBNull(dgview.GetFocusedRowCellValue("Attachment")) = False Then
                Dim path As String = dgview.GetFocusedRowCellValue("Attachment")
                If path Is Nothing Or path Is String.Empty Then Return
                Try
                    With FrmPDFViewer
                        .Show()
                        .Focus()
                        .PdfViewer1.DocumentFilePath = path
                    End With
                Catch ex As Exception
                    DevFunctions.ErrorMsg(ex.Message)
                End Try
            End If

        Else
                Return
        End If
    End Sub

    Private Sub riEdit_OpenLink(sender As Object, e As OpenLinkEventArgs) Handles riEdit.OpenLink
        frmPayment.PaymentID = dgview.GetFocusedRowCellValue("PaymentID")
        frmPayment.PaymentEditFlag = True
        setform(frmPayment)
    End Sub
    Private Sub setform(ByVal ctrl As Form)
        Dim child As Form = Nothing
        For Each child In MdiChildren
            child = ctrl
        Next
        If child Is Nothing Then
            child = ctrl
            child.MdiParent = Me.MdiParent
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            Try
                child.Show()
            Finally
                SplashScreenManager.CloseForm(False)
            End Try
            'child.Show()
        Else
            child = ctrl
            child.MdiParent = Me.MdiParent
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            Try
                child.Show()
            Finally
                SplashScreenManager.CloseForm(False)
            End Try
            'child.Show()
            child.Activate()
        End If
    End Sub

    Private Sub riDelete_OpenLink(sender As Object, e As OpenLinkEventArgs) Handles riDelete.OpenLink
        If XtraMessageBox.Show("Do you want to delete this Row?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If IsDBNull(dgview.GetFocusedRowCellValue("Attachment")) = False Then
                If System.IO.File.Exists(dgview.GetFocusedRowCellValue("Attachment")) = True Then
                    System.IO.File.Delete(dgview.GetFocusedRowCellValue("Attachment"))
                End If
            End If

            GENERAL_FUNCTIONS.NExcuteQuery("DELETE from Dia_Payment_Master where PaymentID=" & dgview.GetFocusedRowCellValue("PaymentID"))
            GENERAL_FUNCTIONS.NExcuteQuery("UPDATE Dia_Purchase SET PaymentFlag=0 WHERE PurchaseID=" & dgview.GetFocusedRowCellValue("PurchaseID"))
            DevFunctions.ErrorMsg("Payment has been deleted successfully")
            frmPaymentReport_Load(sender, a)
        End If
    End Sub
End Class
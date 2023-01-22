Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class FrmD2dTransferList

    Dim dt As New DataTable
    Dim dr As DataRow
    Private Sub FrmD2dTransferList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub
    Private Sub Reload()
        dt = GENERAL_FUNCTIONS.NFetchDatatable("
SELECT m.TransactionID as TransactionID
,m.Barcode as Barcode
,m.StockID as StockID
,b.br_name as Branch
,m.Qty as Qty
,m.Carats as Carats
,s.Shape_Name as Shape
,c.color_name as Color
,cl.clarity_name as Clarity
,f.flo_name as Flo
,l.lab_name as Lab
,m.LCertificateNo as LCertificateNo
,cut.cut_name as Cut
,polish.polish_name as Polish
,sym.symm_name as Sym
,u.user_name as UserName
,M.UnionID as UnionID

 FROM Dia_MainStock m
 left join Dia_Branch_Master b on b.br_id=m.BranchID
left join Dia_Shape_Master s on s.Shape_ID=m.ShapeID
left join Dia_Color_Master c on c.color_id=m.ColorID
left join Dia_Clarity_Master cl on cl.clarity_id=m.ClarityID
left join Dia_Flo_Master f on f.flo_id=m.FloID
left join DIa_Lab_Master l on l.lab_id=m.LabID
left join Dia_Cut_Master cut on cut.cut_id=m.CutID
left join Dia_Polish_Master polish on polish.polish_id=m.PolishID
left join Dia_Symm_Master sym on sym.symm_id=m.SymID
left join Dia_User_Master u on u.user_id=m.UserID
WHERE HistoryDescription='D2D Branch Transfer'
")
        dg.DataSource = dt
        dgview.BestFitColumns()
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
        Else
            child = ctrl
            child.MdiParent = Me.MdiParent
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            Try
                child.Show()
            Finally
                SplashScreenManager.CloseForm(False)
            End Try
            child.Activate()
        End If
    End Sub

    Private Function CheckValidation(ByVal TranscationID As Integer) As Boolean
        Dim empty As Boolean = False
        Dim TID = GENERAL_FUNCTIONS.NExcuteScalerInt("select top(1) TransactionID from Dia_MainStock where barcode=" & dgview.GetFocusedRowCellValue("Barcode") & " Order by TransactionID Desc")
        If TID = TranscationID Then
            empty = True
        Else
            empty = False
        End If
        Return empty
    End Function

    Private Sub riDelete_OpenLink(sender As Object, e As OpenLinkEventArgs) Handles riDelete.OpenLink
        If XtraMessageBox.Show("Do you want to delete this Row?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If CheckValidation(dgview.GetFocusedRowCellValue("TransactionID")) = True Then
                GENERAL_FUNCTIONS.NExcuteQuery("Delete from Dia_MainStock where TransactionID=" & dgview.GetFocusedRowCellValue("TransactionID"))
                DevFunctions.ErrorMsg("Record deleted successfully")
                Reload()
            Else
                DevFunctions.ErrorMsg("You cannot delete this record")
            End If
        Else
            Return
        End If
    End Sub

    Private Sub dgview_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles dgview.RowCellClick
        If e.Column.FieldName = "Delete" Then
            riDelete_OpenLink(sender, New DevExpress.XtraEditors.Controls.OpenLinkEventArgs(e.CellValue))
        Else
            Return
        End If
    End Sub
End Class
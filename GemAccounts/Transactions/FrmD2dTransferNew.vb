Imports GemAccounts.DevFunctions
Public Class FrmD2dTransferNew
    Dim dt As DataTable = GetEmptyMainStockDatatable()
    Dim dr As DataRow
    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        Cancel()
    End Sub

    Private Sub FrmChangeBranchD2D_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dia_Branch_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Branch_Master)
        Me.Dia_Symm_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Symm_Master)
        Me.Dia_Polish_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Polish_Master)
        Me.Dia_Cut_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Cut_Master)
        Me.DIa_Lab_MasterTableAdapter.Fill(Me.Dia_MasterDataset.DIa_Lab_Master)
        Me.Dia_Flo_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Flo_Master)
        Me.Dia_Clarity_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Clarity_Master)
        Me.Dia_Color_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Color_Master)
        Me.Dia_Shape_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Shape_Master)

        Cancel()
    End Sub
    Private Sub Cancel()
        NFill_GridLookupEdit("Dia_Branch_Master", "br_name", "br_id", cmbBranch)
        dg.DataSource = Nothing
        cmbBranch.EditValue = Nothing
        txtBarcode.EditValue = Nothing
        txtStockID.EditValue = Nothing
    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If txtBarcode.EditValue = Nothing Then
                txtStockID.Focus()
            Else
                dr = GENERAL_FUNCTIONS.NFetchDataRow("SELECT TOP(1)* FROM Dia_MainStock where Barcode=" & txtBarcode.EditValue & " ORDER BY TransactionID Desc")
                fetchData()
                dg.DataSource = dt
                txtBarcode.Focus()
                txtBarcode.EditValue = Nothing
            End If
        End If
    End Sub
    Private Sub fetchData()
        If dr Is Nothing Then
            ErrorMsg("Barcode Wrong")
            Exit Sub
        End If
        If dr("ProcessStatus") = True Then
            ErrorMsg(dr("StockID") & " is in process")
            Exit Sub
        End If
        If dr("SalesMasterID") > 0 Then
            ErrorMsg(dr("StockID") & " is sold")
            Exit Sub
        End If
        For i = 0 To dt.Rows.Count - 1
            If dr("Barcode") = dt.Rows(i).Item("Barcode") Then
                ErrorMsg(dr("StockID") & " is already added")
                Exit Sub
            End If
        Next
        dt.Rows.Add(dr.ItemArray)
    End Sub

    Private Sub txtStockID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStockID.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If txtStockID.EditValue = Nothing Then
                txtBarcode.Focus()
            Else
                dr = GENERAL_FUNCTIONS.NFetchDataRow("SELECT TOP(1)* FROM Dia_MainStock where StockID='" & txtStockID.EditValue & "' ORDER BY TransactionID Desc")
                fetchData()
                dg.DataSource = dt
                txtStockID.Focus()
                txtStockID.EditValue = Nothing
            End If
        End If
    End Sub

    Private Sub cmbBranch_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbBranch.KeyDown
        GENERAL_FUNCTIONS.FocusNext(sender, e)
    End Sub

    Private Sub dgview_KeyDown(sender As Object, e As KeyEventArgs) Handles dgview.KeyDown
        If e.KeyCode = Keys.Delete Then
            dgview.DeleteRow(dgview.FocusedRowHandle)
        Else
            Return
        End If
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        save()
        Cancel()
        DevFunctions.InfoMsg("D2D Transfer Successful.")
    End Sub
    Private Sub save()
        If validation() = True Then
            Dim UnionID As Integer = GENERAL_FUNCTIONS.MaxNo("Select max(UnionID) from Dia_MainStock")
            For i = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item("UserID") = GLOBAL_VARIABLES.UID
                dt.Rows(i).Item("BranchID") = cmbBranch.EditValue
                dt.Rows(i).Item("ImportDate") = GENERAL_FUNCTIONS.NExcuteScaler("Select Getdate()")
                dt.Rows(i).Item("LabourUSD") = 0
                dt.Rows(i).Item("LabourExRate") = 0
                dt.Rows(i).Item("LabourINR") = 0
                dt.Rows(i).Item("RAP") = DevFunctions.GetRAP(dt.Rows(i).Item("ShapeID"), dt.Rows(i).Item("ColorID"), dt.Rows(i).Item("ClarityID"), dt.Rows(i).Item("Carats"))
                dt.Rows(i).Item("HistoryDescription") = "D2D Branch Transfer"
                dt.Rows(i).Item("ExecutionDateTime") = GENERAL_FUNCTIONS.NExcuteScaler("Select Getdate()")
                dt.Rows(i).Item("UnionID") = UnionID
            Next
            GENERAL_FUNCTIONS.DataTable_to_SqlTable_Copy(dt, "Dia_MainStock")
        End If
    End Sub
    Private Function validation() As Boolean
        validation = True
        If cmbBranch.EditValue = Nothing Then
            validation = False
            Exit Function
        End If
        If dt.Rows.Count = 0 Then
            validation = False
            Exit Function
        End If

        Return validation
    End Function

    Private Sub btnSaveNClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveNClose.ItemClick
        save()
        Me.Close()
    End Sub

    Private Sub btnLoadClipboard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLoadClipboard.ItemClick
        dt.Rows.Clear()
        Dim msg As String = ""
        For i = 0 To FrmClipboard.dt.Rows.Count - 1
            dr = GENERAL_FUNCTIONS.NFetchDataRow("select top(1)* from dia_mainstock where Barcode=" & FrmClipboard.dt.Rows(i).Item("Barcode").ToString & " Order By TransactionID Desc")
            If dr("ProcessStatus") = True Then
                msg = msg & FrmClipboard.dt.Rows(i).Item("StockID").ToString & " - Lot is in Process" & vbNewLine
            ElseIf dr("SalesMasterID") > 0 Then
                msg = msg & FrmClipboard.dt.Rows(i).Item("StockID").ToString & " - Lot already Sold" & vbNewLine
            End If
            dt.Rows.Add(dr.ItemArray)
        Next
        If msg <> String.Empty Then DevFunctions.ErrorMsg(msg)
        dg.DataSource = dt
    End Sub
End Class
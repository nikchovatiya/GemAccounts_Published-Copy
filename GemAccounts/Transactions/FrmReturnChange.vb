Imports System.ComponentModel
Imports System.Globalization
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class FrmReturnChange
    Dim dr As DataRow
    Dim dt As New DataTable
    Dim DF As New DevFunctions
    Dim GF As New GENERAL_FUNCTIONS
    Dim flag As Boolean

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub txtBarcode_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtBarcode.PreviewKeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If txtBarcode.EditValue = Nothing Then
                txtStockID.Focus()
                Exit Sub
            End If
            If CheckIfStockIdExist("Barcode", txtBarcode) = True Then

            End If
        End If
    End Sub
    Private Sub txtStockID_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtStockID.PreviewKeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If txtStockID.EditValue = Nothing Then
                txtStockID.Focus()
                Exit Sub
            End If
            If CheckIfStockIdExist("StockID", txtStockID) = True Then

            End If
        End If
    End Sub
    Private Function CheckIfStockIdExist(ByVal FieldName As String, ByVal Ctrl As DevExpress.XtraEditors.TextEdit) As Boolean
        CheckIfStockIdExist = True
        dr = GENERAL_FUNCTIONS.NFetchDataRow("select top(1) * from dia_mainstock where " & FieldName & "= '" & Ctrl.EditValue & "' order by TransactionID Desc")

        If dr Is Nothing Then
            DevFunctions.ErrorMsg(FieldName & " wrong")
            Ctrl.EditValue = Nothing
            Ctrl.Focus()
            CheckIfStockIdExist = False
            Exit Function
        ElseIf dr("ProcessStatus") = False Then
            DevFunctions.ErrorMsg(dr("StockID") & " is not in process")
            Ctrl.EditValue = Nothing
            Ctrl.Focus()
            CheckIfStockIdExist = False
            Exit Function
        Else

            For i = 0 To dgview.RowCount - 1
                If dgview.GetRowCellValue(i, FieldName) = Ctrl.EditValue Then
                    DevFunctions.ErrorMsg("Lot already added")
                    CheckIfStockIdExist = False
                    Ctrl.Focus()
                    Ctrl.EditValue = Nothing
                    Exit Function
                End If
            Next
        End If
        dr("LabourUSD") = 0
        dr("LabourINR") = 0
        dt.NewRow()
        dt.Rows.Add(dr.ItemArray)
        dg.DataSource = dt
        txtBarcode.EditValue = Nothing
        txtStockID.EditValue = Nothing
        disableRate()
        Return CheckIfStockIdExist
    End Function

    Private Sub FrmReturnChange_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Dia_Symm_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Symm_Master)
        Me.Dia_Polish_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Polish_Master)
        Me.Dia_Cut_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Cut_Master)
        Me.Dia_Ledger_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Ledger_Master)
        Me.Dia_Process_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Process_Master)
        Me.Dia_Flo_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Flo_Master)
        Me.Dia_Clarity_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Clarity_Master)
        Me.Dia_Color_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Color_Master)
        Me.Dia_Shape_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Shape_Master)
        dt = DevFunctions.GetEmptyMainStockDatatable()

        txtExRate.EditValue = GLOBAL_VARIABLES.ExRate


        'MaskCulture(riUSD, "en-US")
        'MaskCulture(riINR, "hi-IN")
    End Sub
    'Private Sub MaskCulture(ByVal ctrl As Repository.RepositoryItemTextEdit, ByVal CurrencyCulture As String)
    '    ctrl.Mask.Culture = New Globalization.CultureInfo(CurrencyCulture)
    '    ctrl.Mask.MaskType = Mask.MaskType.Numeric
    '    ctrl.Mask.EditMask = "c2"
    '    ctrl.Mask.UseMaskAsDisplayFormat = True
    'End Sub

    Private Sub dgview_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles dgview.CellValueChanged
        Dim view As GridView = TryCast(sender, GridView)
        If view Is Nothing Then
            Return
        End If
        If e.Column.FieldName = "LabourUSD" AndAlso (Not flag) Then
            Dim INR As Double = Convert.ToDouble(view.GetRowCellValue(e.RowHandle, view.Columns("LabourUSD")) * txtExRate.EditValue)
            flag = True
            view.SetRowCellValue(e.RowHandle, "LabourINR", INR)

            flag = False

        ElseIf e.Column.FieldName = "LabourINR" AndAlso (Not flag) Then
            Dim USD As Double = Convert.ToDouble(view.GetRowCellValue(e.RowHandle, view.Columns("LabourINR")) / txtExRate.EditValue)
            flag = True
            view.SetRowCellValue(e.RowHandle, "LabourUSD", USD)
            flag = False
        End If
        view.UpdateTotalSummary()
    End Sub
    Private Sub disableRate()
        If dt.Rows.Count > 0 Then
            txtExRate.Enabled = False
        Else
            txtExRate.Enabled = True
        End If
    End Sub

    Private Sub dtp_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp.KeyDown, txtExRate.KeyDown
        GENERAL_FUNCTIONS.FocusNext(sender, e)
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        dt.Rows.Clear()
        dg.DataSource = Nothing
        disableRate()
        dtp.Focus()
    End Sub

    Private Function CheckValidation() As Boolean
        Dim msgary As String = ""
        For i = 0 To dgview.RowCount - 1
            If dgview.GetRowCellValue(i, "Barcode") = Nothing OrElse dgview.GetRowCellValue(i, "Barcode") = 0 OrElse dgview.GetRowCellValue(i, "Barcode") = String.Empty Then
                msgary = msgary & (dgview.GetRowCellValue(i, "StockID") & " : " & "Barcode Not Valid" & vbCrLf)
                CheckValidation = False
            ElseIf dgview.GetRowCellValue(i, "Qty") = Nothing OrElse dgview.GetRowCellValue(i, "Qty") = 0 OrElse dgview.GetRowCellValue(i, "Qty") = String.Empty Then
                msgary = msgary & (dgview.GetRowCellValue(i, "StockID") & " : " & "Qty Not Valid" & vbCrLf)
                CheckValidation = False
            ElseIf dgview.GetRowCellValue(i, "Carats") = Nothing OrElse dgview.GetRowCellValue(i, "Carats") = 0 OrElse dgview.GetRowCellValue(i, "Carats") = String.Empty Then
                msgary = msgary & (dgview.GetRowCellValue(i, "StockID") & " : " & "Carats Not Valid" & vbCrLf)
                CheckValidation = False
            ElseIf dgview.GetRowCellValue(i, "ShapeID") = Nothing OrElse dgview.GetRowCellValue(i, "ShapeID") = 0 OrElse dgview.GetRowCellValue(i, "ShapeID") = String.Empty Then
                msgary = msgary & (dgview.GetRowCellValue(i, "StockID") & " : " & "Shape Not Valid" & vbCrLf)
                CheckValidation = False
            ElseIf dgview.GetRowCellValue(i, "ColorID") = Nothing OrElse dgview.GetRowCellValue(i, "ColorID") = 0 OrElse dgview.GetRowCellValue(i, "ColorID") = String.Empty Then
                msgary = msgary & (dgview.GetRowCellValue(i, "StockID") & " : " & "Color Not Valid" & vbCrLf)
                CheckValidation = False
            ElseIf dgview.GetRowCellValue(i, "ClarityID") = Nothing OrElse dgview.GetRowCellValue(i, "ClarityID") = 0 OrElse dgview.GetRowCellValue(i, "ClarityID") = String.Empty Then
                msgary = msgary & (dgview.GetRowCellValue(i, "StockID") & " : " & "Clarity Not Valid" & vbCrLf)
                CheckValidation = False
            Else
                CheckValidation = True
            End If
        Next
        If msgary = "" OrElse msgary = String.Empty Then
        Else
            DevFunctions.ErrorMsg(msgary)
        End If
        Return CheckValidation
    End Function
    Private Sub UpdateRowsToDB()

        Try
            Dim UnionID As Integer = GENERAL_FUNCTIONS.MaxNo("Select max(UnionID) from Dia_MainStock")
            For i = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item("ImportDate") = dtp.Value
                dt.Rows(i).Item("Carats") = dgview.GetRowCellValue(i, "Carats")
                dt.Rows(i).Item("ShapeID") = dgview.GetRowCellValue(i, "ShapeID")
                dt.Rows(i).Item("ColorID") = dgview.GetRowCellValue(i, "ColorID")
                dt.Rows(i).Item("ClarityID") = dgview.GetRowCellValue(i, "ClarityID")
                dt.Rows(i).Item("FloID") = dgview.GetRowCellValue(i, "FloID")
                dt.Rows(i).Item("CutID") = dgview.GetRowCellValue(i, "CutID")
                dt.Rows(i).Item("PolishID") = dgview.GetRowCellValue(i, "PolishID")
                dt.Rows(i).Item("SymID") = dgview.GetRowCellValue(i, "SymID")
                dt.Rows(i).Item("ProcessID") = dgview.GetRowCellValue(i, "ProcessID")
                dt.Rows(i).Item("LedgerID") = dgview.GetRowCellValue(i, "LedgerID")
                dt.Rows(i).Item("LTable") = dgview.GetRowCellValue(i, "LTable")
                dt.Rows(i).Item("LTotalDepth") = dgview.GetRowCellValue(i, "LTotalDepth")
                dt.Rows(i).Item("LLength") = dgview.GetRowCellValue(i, "LLength")
                dt.Rows(i).Item("LWidth") = dgview.GetRowCellValue(i, "LWidth")
                dt.Rows(i).Item("LDepth") = dgview.GetRowCellValue(i, "LDepth")
                dt.Rows(i).Item("LCrownHeight") = dgview.GetRowCellValue(i, "LCrownHeight")
                dt.Rows(i).Item("LCrownAngle") = dgview.GetRowCellValue(i, "LCrownAngle")
                dt.Rows(i).Item("LPavillionDepth") = dgview.GetRowCellValue(i, "LPavillionDepth")
                dt.Rows(i).Item("LPavillionAngle") = dgview.GetRowCellValue(i, "LPavillionAngle")

                'Labour Fields
                If dt.Rows(i).Item("LabourINR") = String.Empty Then dt.Rows(i).Item("LabourINR") = 0
                If dt.Rows(i).Item("LabourUSD") = String.Empty Then dt.Rows(i).Item("LabourUSD") = 0
                If dt.Rows(i).Item("LabourExRate") = String.Empty Then dt.Rows(i).Item("LabourExRate") = 0
                dt.Rows(i).Item("LabourINR") = dgview.GetRowCellValue(i, "LabourINR")
                dt.Rows(i).Item("LabourUSD") = dgview.GetRowCellValue(i, "LabourUSD")
                dt.Rows(i).Item("LabourExRate") = txtExRate.EditValue

                'Mandatory Fields
                dt.Rows(i).Item("UserID") = GLOBAL_VARIABLES.UID
                dt.Rows(i).Item("ExecutionDateTime") = Now
                dt.Rows(i).Item("ProcessID") = 0
                dt.Rows(i).Item("LedgerID") = 0
                dt.Rows(i).Item("ProcessStatus") = False
                dt.Rows(i).Item("UnionID") = UnionID
                dt.Rows(i).Item("HistoryDescription") = "Return from Process"
                dt.Rows(i).Item("RAP") = DevFunctions.GetRAP(dgview.GetRowCellValue(i, "ShapeID"), dgview.GetRowCellValue(i, "ColorID"), dgview.GetRowCellValue(i, "ClarityID"), dgview.GetRowCellValue(i, "Carats"))

            Next
            'Copy DataTable Rows to DB Server
            GENERAL_FUNCTIONS.DataTable_to_SqlTable_Copy(dt, "Dia_MainStock")
            FrmStock.MainStock_Grid_Bind()

        Catch ex As Exception
            DevFunctions.ErrorMsg(ex.Message)
        End Try

    End Sub
    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        If CheckValidation() = True Then
            UpdateRowsToDB()
            btnCancel_ItemClick(sender, e)
            SplashScreenManager.CloseForm(False)
            DevFunctions.InfoMsg("Return from process successful.")
        End If

    End Sub

    Private Sub riShapeID_EditValueChanged(sender As Object, e As EventArgs) Handles riShapeID.EditValueChanged, riColorID.EditValueChanged, riClarityID.EditValueChanged, riFlo.EditValueChanged, riCut.EditValueChanged, riPolish.EditValueChanged, riSym.EditValueChanged, riLedger.EditValueChanged, riProcess.EditValueChanged
        If dgview.PostEditor() Then
            dgview.UpdateCurrentRow()
        End If
    End Sub

    Private Sub btnSaveAndClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveAndClose.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        If CheckValidation() = True Then
            UpdateRowsToDB()
            SplashScreenManager.CloseForm(False)
            Me.Close()
        End If
    End Sub

    Private Sub btnLoadClipboard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLoadClipboard.ItemClick
        dt.Rows.Clear()
        Dim msg As String = ""
        For i = 0 To FrmClipboard.dt.Rows.Count - 1
            dr = GENERAL_FUNCTIONS.NFetchDataRow("select top(1)* from dia_mainstock where Barcode=" & FrmClipboard.dt.Rows(i).Item("Barcode").ToString & " Order By TransactionID Desc")
            If dr Is Nothing Then
                Return
            ElseIf dr("ProcessStatus") = False Then
                msg = msg & FrmClipboard.dt.Rows(i).Item("StockID").ToString & " - Lot is not in Process" & vbNewLine
            ElseIf dr("SalesMasterID") > 0 Then
                msg = msg & FrmClipboard.dt.Rows(i).Item("StockID").ToString & " - Lot already Sold" & vbNewLine
            Else
                dr("LabourUSD") = 0
                dr("LabourINR") = 0
                dt.Rows.Add(dr.ItemArray)
                txtBarcode.EditValue = Nothing
                txtStockID.EditValue = Nothing
                disableRate()
            End If
        Next
        If msg <> String.Empty Then DevFunctions.ErrorMsg(msg)
        dg.DataSource = dt
    End Sub
End Class

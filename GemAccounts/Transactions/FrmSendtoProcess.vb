Imports System.Globalization
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraSplashScreen

Public Class FrmSendtoProcess
    Dim GF As New GENERAL_FUNCTIONS
    Dim DF As New DevFunctions
    Dim ds As New Dia_MasterDataset
    Dim GV As New GLOBAL_VARIABLES
    Dim FillDataTable As New DataTable
    Dim MasterDT As New DataTable
    Dim BF As New BAL_Transactions
    Dim UnionID As Integer
    Dim dr As DataRow
    Dim newFlag As Integer = 1
    Private Sub FrmSendtoProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DIA_MASTERDataSet.Dia_User_Master' table. You can move, or remove it, as needed.
        Me.Dia_User_MasterTableAdapter.Fill(Me.DIA_MASTERDataSet.Dia_User_Master)
        'TODO: This line of code loads data into the 'DIA_MASTERDataSet.Dia_Process_Master' table. You can move, or remove it, as needed.
        Me.Dia_Process_MasterTableAdapter.Fill(Me.DIA_MASTERDataSet.Dia_Process_Master)
        'TODO: This line of code loads data into the 'DIA_MASTERDataSet.Dia_Ledger_Master' table. You can move, or remove it, as needed.
        Me.Dia_Ledger_MasterTableAdapter.Fill(Me.DIA_MASTERDataSet.Dia_Ledger_Master)
        'TODO: This line of code loads data into the 'DIA_MASTERDataSet.Dia_Item_Type_Master' table. You can move, or remove it, as needed.
        Me.Dia_Item_Type_MasterTableAdapter.Fill(Me.DIA_MASTERDataSet.Dia_Item_Type_Master)

        'TODO: This line of code loads data into the 'DIA_MASTERDataSet.Dia_Flo_Master' table. You can move, or remove it, as needed.
        Me.Dia_Flo_MasterTableAdapter.Fill(Me.DIA_MASTERDataSet.Dia_Flo_Master)
        'TODO: This line of code loads data into the 'DIA_MASTERDataSet.Dia_Clarity_Master' table. You can move, or remove it, as needed.
        Me.Dia_Clarity_MasterTableAdapter.Fill(Me.DIA_MASTERDataSet.Dia_Clarity_Master)
        'TODO: This line of code loads data into the 'DIA_MASTERDataSet.Dia_Color_Master' table. You can move, or remove it, as needed.
        Me.Dia_Color_MasterTableAdapter.Fill(Me.DIA_MASTERDataSet.Dia_Color_Master)
        'TODO: This line of code loads data into the 'DIA_MASTERDataSet.Dia_Shape_Master' table. You can move, or remove it, as needed.
        Me.Dia_Shape_MasterTableAdapter.Fill(Me.DIA_MASTERDataSet.Dia_Shape_Master)

        loaddata()
        fillGridfromAnotherForm()
    End Sub
    Public Sub fillGridfromAnotherForm()
        If GLOBAL_VARIABLES.DT Is Nothing Then
            Exit Sub
        Else


            For i = 0 To GLOBAL_VARIABLES.DT.Rows.Count - 1
                Dim dr As DataRow = FillDataTable.NewRow
                ' dr = GF.NFetchDataRow("select barcode,StockID,Qty,Carats,ShapeID,ColorID,ClarityID,FloID from Dia_MainStock where Barcode=" & GLOBAL_VARIABLES.DT.Rows(i).Item(0) & " and having max(ExecutionDateTime)")
                dr = GENERAL_FUNCTIONS.NFetchDataRow("select * from Dia_MainStock where TransactionID =" & GLOBAL_VARIABLES.DT.Rows(i).Item(0) & "")
                FillDataTable.Rows.Add(dr.ItemArray)
            Next
            dgnew.DataSource = FillDataTable
        End If
        GLOBAL_VARIABLES.DT = Nothing
    End Sub
    Private Sub loaddata()
        GF.NFillComboWithOneListMemberBlank("Select * from Dia_Process_Master", "ProcessID", "ProcessName", cmbProcess)
        GENERAL_FUNCTIONS.FillSunContractors(cmblocation)
        FillDataTable = DevFunctions.GetEmptyMainStockDatatable
        loadlistgrid()
    End Sub
    Private Sub loadlistgrid()
        dgList.DataSource = GENERAL_FUNCTIONS.NFetchDatatable("Select * from Dia_MainStock where HistoryDescription='Send To Process' Order by TransactionID Desc")
    End Sub
    Private Sub txtbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If txtbarcode.EditValue = Nothing Then
                txtstockid.Focus()
                Exit Sub
            End If
            Dim StockIDRow As DataRow = GENERAL_FUNCTIONS.NFetchDataRow("select top(1) StockID from dia_mainstock where barcode=" & txtbarcode.EditValue & "  and ProcessStatus=0 order by TransactionID Desc")
            If StockIDRow Is Nothing Then
                DevFunctions.ErrorMsg("Barcode wrong")
                txtbarcode.Focus()
                Return
            Else
                txtstockid.EditValue = StockIDRow("StockID")
                If CheckIfStockIdExist() = True Then
                    addNewRow()
                    txtbarcode.EditValue = Nothing
                    txtstockid.EditValue = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub txtstockid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtstockid.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If txtstockid.EditValue = Nothing Then
                Exit Sub
            End If
            Dim BarcodeRow As DataRow = GENERAL_FUNCTIONS.NFetchDataRow("select top(1) Barcode from dia_mainstock where stockid='" & txtstockid.EditValue & "' and ProcessStatus=0 order by TransactionID Desc")
            If BarcodeRow Is Nothing Then
                DevFunctions.ErrorMsg("Stock ID Wrong")
                txtstockid.Focus()
                Return
            Else
                txtbarcode.EditValue = BarcodeRow("Barcode")
                If CheckIfStockIdExist() = True Then
                    addNewRow()
                    txtstockid.EditValue = Nothing
                    txtbarcode.EditValue = Nothing
                End If
            End If

        End If
    End Sub
    Public Sub addNewRow()

        dr = GENERAL_FUNCTIONS.NFetchDataRow("select top(1) * from dia_mainstock where barcode=" & txtbarcode.EditValue & " order by TransactionID Desc")
        If dr("SalesMasterID") > 0 Then
            DevFunctions.ErrorMsg("Lot already Sold")
            Exit Sub
        ElseIf dr("ProcessStatus") = True Then
            DevFunctions.ErrorMsg("Lot already in proceess")
            Exit Sub
        Else
            'dr = FillDataTable.NewRow()
            FillDataTable.Rows.Add(dr.ItemArray)
            dgnew.DataSource = FillDataTable
        End If
    End Sub
    Private Function CheckIfStockIdExist() As Boolean
        CheckIfStockIdExist = True
        For i As Integer = 0 To newView.RowCount - 1
            If newView.GetRowCellValue(i, "Barcode") = txtbarcode.EditValue Then
                DevFunctions.ErrorMsg("Stock ID : " & txtstockid.EditValue & " is already added")
                CheckIfStockIdExist = False
                Exit Function
            Else
                CheckIfStockIdExist = True
            End If
        Next
        Return CheckIfStockIdExist
    End Function

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        ClearControls()
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If SaveData() = True Then
            DevFunctions.InfoMsg("Send to Process Successful")
        End If
    End Sub
    Private Function SaveData() As Boolean
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)

        Try
            SaveData = False
            If validation() = False Then
                Exit Function
            Else
                If newView.PostEditor() Then
                    newView.UpdateCurrentRow()
                End If
                If edf = True Then
                    GENERAL_FUNCTIONS.NExcuteQuery("Delete from Dia_Mainstock where UnionID=" & UnionID)
                Else
                    UnionID = GENERAL_FUNCTIONS.MaxNo("select max(UnionID) from Dia_MainStock")
                End If

                MasterDT = DevFunctions.GetEmptyMainStockDatatable

                For i = 0 To newView.RowCount - 1
                    MasterDT.Rows.Clear()
                    MasterDT.NewRow()

                    Dim dr As DataRow = GENERAL_FUNCTIONS.NFetchDataRow("select top(1) * from Dia_MainStock where barcode=" & newView.GetRowCellValue(i, "Barcode") & " order by TransactionID Desc")

                    dr.BeginEdit()
                    dr("ShapeID") = newView.GetRowCellValue(i, "ShapeID")
                    dr("UnionId") = UnionID
                    dr("ColorID") = newView.GetRowCellValue(i, "ColorID")
                    dr("ClarityID") = newView.GetRowCellValue(i, "ClarityID")
                    dr("FloID") = newView.GetRowCellValue(i, "FloID")
                    dr("Qty") = newView.GetRowCellValue(i, "Qty")
                    dr("Carats") = newView.GetRowCellValue(i, "Carats")
                    dr("ExecutionDateTime") = Now()
                    dr("LedgerID") = cmblocation.SelectedValue
                    dr("ProcessID") = cmbProcess.SelectedValue
                    dr("ProcessStatus") = True
                    dr("HistoryDescription") = "Send To Process"
                    dr("UserID") = GLOBAL_VARIABLES.UID
                    dr("LabourINR") = 0
                    dr("LabourUSD") = 0

                    dr.EndEdit()
                    MasterDT.Rows.Add(dr.ItemArray)
                    BF.DataTable_to_SqlTable_Copy(MasterDT, "Dia_MainStock")
                Next
                FrmStock.MainStock_Grid_Bind()
                FrmStock.dg.RefreshDataSource()
                ClearControls()
                newFlag = 0
            End If
            SaveData = True
            edf = False
        Catch ex As Exception

        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        Return SaveData

    End Function

    Private Sub ClearControls()
        Dim i As Integer = 0
        While i < newView.RowCount
            newView.DeleteRow(i)
        End While
        cmblocation.SelectedIndex = -1
        cmbProcess.SelectedIndex = -1
        txtbarcode.EditValue = Nothing
        txtstockid.EditValue = Nothing
        MasterDT.Columns.Clear()
        MasterDT.Rows.Clear()
        cmbProcess.Focus()
        loadlistgrid()
        edf = False
    End Sub
    Private Function validation() As Boolean
        validation = False
        If cmbProcess.SelectedValue = 0 Then
            DevFunctions.ErrorMsg("Select Process")
            cmbProcess.Select()
            Exit Function
        ElseIf cmblocation.SelectedValue = 0 Then
            DevFunctions.ErrorMsg("Select Location")
            cmblocation.Select()
            Exit Function
        ElseIf newView.RowCount = 0 Then
            DevFunctions.ErrorMsg("Add atleast one lot")
            txtbarcode.Select()
            Exit Function
        End If
        validation = True
        Return validation
    End Function
    Private Sub dgnew_KeyDown(sender As Object, e As KeyEventArgs) Handles dgnew.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this detail ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                newView.DeleteRow(newView.FocusedRowHandle)
            Else

            End If
        Else

        End If
    End Sub

    Private Sub cmbProcess_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbProcess.KeyDown, cmblocation.KeyDown
        GENERAL_FUNCTIONS.FocusNext(sender, e)
    End Sub

    Private Sub btnSaveClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveClose.ItemClick
        If SaveData() = True Then
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub menuEdit_Click(sender As Object, e As EventArgs) Handles menuEdit.Click
        Dim msg As String = ""
        FillDataTable.Rows.Clear()
        Dim dt As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("Select * from Dia_MainStock Where UnionID=" & listView.GetFocusedRowCellValue("UnionID"))

        For Each dr As DataRow In dt.Rows
            If dr.Item("TransactionID") = GENERAL_FUNCTIONS.NExcuteScalerInt("select top(1) TransactionID from Dia_Mainstock where Barcode=" & dr.Item("Barcode") & " order by TransactionID desc") Then
                FillDataTable.Rows.Add(dr.ItemArray)
            Else
                msg = msg & dr.Item("StockID").ToString & " - Lot Not Loaded" & vbNewLine
            End If
        Next
        If msg = "" Then
            dgnew.DataSource = FillDataTable
        Else
            If FillDataTable.Rows.Count = 0 Then
                edf = False
            End If
            DevFunctions.ErrorMsg(msg)
        End If

        UnionID = listView.GetFocusedRowCellValue("UnionID")
        cmblocation.SelectedValue = listView.GetFocusedRowCellValue("LedgerID")
        cmbProcess.SelectedValue = listView.GetFocusedRowCellValue("ProcessID")
    End Sub

    Private edf As Boolean

    Private Sub MenuDelete_Click(sender As Object, e As EventArgs) Handles MenuDelete.Click
        Dim dt As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("Select * from Dia_MainStock Where UnionID=" & listView.GetFocusedRowCellValue("UnionID"))
        Dim bool As Boolean = False
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("TransactionID") = GENERAL_FUNCTIONS.NExcuteScalerInt("select top(1) TransactionID from Dia_Mainstock where Barcode=" & dt.Rows(i).Item("Barcode") & " order by TransactionID desc") Then
                bool = True
            Else
                bool = False
            End If
        Next
        If bool = False Then
            DevFunctions.ErrorMsg("You cannot delete this Entry")
        Else
            For i = 0 To dt.Rows.Count
                GENERAL_FUNCTIONS.NExcuteQuery("Delete from Dia_Mainstock where TransactionID=" & dt.Rows(i).Item("TransactionID"))
            Next
        End If

    End Sub

    Private Sub btnLoadClipboard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLoadClipboard.ItemClick
        FillDataTable.Rows.Clear()
        Dim msg As String = ""
        For i = 0 To FrmClipboard.dt.Rows.Count - 1
            dr = GENERAL_FUNCTIONS.NFetchDataRow("select top(1)* from dia_mainstock where Barcode=" & FrmClipboard.dt.Rows(i).Item("Barcode").ToString & " Order By TransactionID Desc")
            If dr("SalesMasterID") > 0 Then
                msg = msg & FrmClipboard.dt.Rows(i).Item("StockID").ToString & " - Lot already Sold" & vbNewLine
            ElseIf dr("ProcessStatus") = True Then
                msg = msg & FrmClipboard.dt.Rows(i).Item("StockID").ToString & " - Lot already in Process" & vbNewLine
            Else
                FillDataTable.Rows.Add(dr.ItemArray)
            End If
        Next
        If msg <> String.Empty Then DevFunctions.ErrorMsg(msg)
        dgnew.DataSource = FillDataTable
    End Sub
End Class
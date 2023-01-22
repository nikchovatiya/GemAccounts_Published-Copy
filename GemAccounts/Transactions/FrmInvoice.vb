Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab.ViewInfo
Imports GemAccounts.DevFunctions
Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.BAL_Transactions
Imports DevExpress.XtraSplashScreen
Imports System.ComponentModel

Public Class FrmInvoice
    Dim GF As New GENERAL_FUNCTIONS
    Dim DF As New DevFunctions
    Dim dr As DataRow
    Dim dt As New DataTable
    Dim flag As Boolean = False
    Dim AdditionalDT As New DataTable
    Dim BrokerDT As New DataTable
    Dim SaleTotalUSD As Double
    Dim AdditionalTotalUSD As Double
    Dim BrokerageUSD As Double
    Dim SaleTotalINR As Double
    Dim AdditionalTotalINR As Double
    Dim BrokerageINR As Double
    Dim TotalCarats As Double
    Dim AverageDiscount As Double
    Dim TmpFileName As String

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub dtpDate_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpDate.KeyDown, cmbCustomer.KeyDown, cmbTerms.KeyDown
        GENERAL_FUNCTIONS.FocusNext(sender, e)
    End Sub

    Private Sub FrmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dia_MasterDataset.DIa_Lab_Master' table. You can move, or remove it, as needed.
        Me.DIa_Lab_MasterTableAdapter.Fill(Me.Dia_MasterDataset.DIa_Lab_Master)
        'TODO: This line of code loads data into the 'Dia_MasterDataset.Dia_Flo_Master' table. You can move, or remove it, as needed.
        Me.Dia_Flo_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Flo_Master)
        'TODO: This line of code loads data into the 'Dia_MasterDataset.Dia_Clarity_Master' table. You can move, or remove it, as needed.
        Me.Dia_Clarity_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Clarity_Master)
        'TODO: This line of code loads data into the 'Dia_MasterDataset.Dia_Color_Master' table. You can move, or remove it, as needed.
        Me.Dia_Color_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Color_Master)
        'TODO: This line of code loads data into the 'Dia_MasterDataset.Dia_Shape_Master' table. You can move, or remove it, as needed.
        Me.Dia_Shape_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Shape_Master)
        cancel()

        If GLOBAL_VARIABLES.SalesEditFlag = False Then
            txtExRate.EditValue = GLOBAL_VARIABLES.ExRate
        Else
            Dim SalesDetailsDT As DataTable = NFetchDatatable("Select * from Dia_SalesDetails where SalesMasterID=" & FrmInvoiceList.SalesMasterID)
            Dim SalesMasterDR As DataRow = NFetchDataRow("Select * from Dia_SalesMaster where SalesMasterID=" & FrmInvoiceList.SalesMasterID)
            AdditionalDT = NFetchDatatable("Select * from Dia_SalesAdditional where SalesMasterID=" & FrmInvoiceList.SalesMasterID)
            BrokerDT = NFetchDatatable("Select * from Dia_SalesBrokerage where SalesMasterID=" & FrmInvoiceList.SalesMasterID)
            txtExRate.EditValue = SalesMasterDR("ExRate")
            cmbCustomer.SelectedValue = SalesMasterDR("LedgerID")
            cmbTerms.SelectedValue = SalesMasterDR("TermsID")
            dtpDate.Value = SalesMasterDR("SaleDate")
            txtNetINR.EditValue = SalesMasterDR("NetINR")
            txtNetUSD.EditValue = SalesMasterDR("NetUSD")
            Dim termsdays As Integer = Integer.Parse(GENERAL_FUNCTIONS.NExcuteScalerInt("Select terms_desc from Dia_Terms_Master where terms_id=" & cmbTerms.SelectedValue & ""))
            dtpDueDate.Value = dtpDate.Value.AddDays(termsdays)
            txtAttachment.EditValue = FrmInvoiceList.tmpAttachmentPath
            For i = 0 To SalesDetailsDT.Rows.Count - 1
                EditModeRowsAdd("Barcode", SalesDetailsDT.Rows(i).Item("Barcode"))
            Next
            dgAdditional.DataSource = AdditionalDT
            dgBroker.DataSource = BrokerDT

        End If
    End Sub
    Private Sub FillAdditionalGrid()
        AdditionalDT.Rows.Clear()
        AdditionalDT.Columns.Clear()
        AdditionalDT.Columns.Add("LedgerIDExp", GetType(Integer))
        AdditionalDT.Columns.Add("ExpPercent", GetType(Double))
        AdditionalDT.Columns.Add("ExpUSD", GetType(Double))
        AdditionalDT.Columns.Add("ExpINR", GetType(Double))
        AdditionalDT.Columns.Add("SalesAdditionalID", GetType(Integer))
        dgAdditional.DataSource = AdditionalDT
    End Sub
    Private Sub FillBrokerGrid()
        BrokerDT.Rows.Clear()
        BrokerDT.Columns.Clear()
        BrokerDT.Columns.Add("LedgerID", GetType(Integer))
        BrokerDT.Columns.Add("BrokerPercent", GetType(Double))
        BrokerDT.Columns.Add("BrokerageUSD", GetType(Double))
        BrokerDT.Columns.Add("BrokerageINR", GetType(Double))
        BrokerDT.Columns.Add("SalesBrokerageID", GetType(Integer))
        dgBroker.DataSource = BrokerDT
    End Sub
    Private Sub Fill_InPlaceEditors()
        Dim Dt1 As DataTable = DevFunctions.GetCustomLedgerDataTable({"Expenses"})
        riExp.DataSource = Dt1
        Dim dt2 As DataTable = DevFunctions.GetCustomLedgerDataTable({"Broker"})
        riBroker.DataSource = dt2
    End Sub
    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        cancel()
    End Sub
    Private Sub cancel()
        dtpDate.Value = Now
        dtpDueDate.Value = Now
        txtBarcode.EditValue = Nothing
        txtStockID.EditValue = Nothing
        dt.Rows.Clear()
        BrokerDT.Rows.Clear()
        AdditionalDT.Rows.Clear()
        dgLot.DataSource = Nothing
        dgAdditional.DataSource = Nothing
        dgBroker.DataSource = Nothing
        txtNetINR.EditValue = 0
        txtNetUSD.EditValue = 0
        disableRate()
        dtpDate.Focus()
        FillCustomersCombo(cmbCustomer)
        GF.FillTermsCombo(cmbTerms)
        FillAdditionalGrid()
        FillBrokerGrid()
        Fill_InPlaceEditors()
        cmbCustomer.SelectedIndex = 0
        cmbTerms.SelectedIndex = 0
        txtAttachment.EditValue = Nothing
        If GLOBAL_VARIABLES.SalesEditFlag = False Then
            FrmInvoiceList.SalesMasterID = Nothing
        End If


    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        If cmbTerms.SelectedValue = 0 Then
            dtpDueDate.Value = dtpDate.Value
        Else
            Dim termsdays As Integer = Integer.Parse(GENERAL_FUNCTIONS.NExcuteScalerInt("Select terms_desc from Dia_Terms_Master where terms_id=" & cmbTerms.SelectedValue & ""))
            dtpDueDate.Value = dtpDate.Value.AddDays(termsdays)
        End If
    End Sub

    Private Sub txtBarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBarcode.KeyPress
        GF.AcceptNumer(sender, e)
    End Sub

    Private Sub txtStockID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStockID.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If txtStockID.EditValue = Nothing Then
                txtStockID.Focus()
                Exit Sub
            End If
            If CheckIfStockIdExist("StockID", txtStockID) = True Then

            End If
        End If
    End Sub
    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If txtBarcode.EditValue = Nothing Then
                txtStockID.Focus()
                Exit Sub
            End If
            If CheckIfStockIdExist("Barcode", txtBarcode) = True Then

            End If
        End If
    End Sub

    Private Sub txtRate_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtExRate.PreviewKeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Tab Then
            txtBarcode.Focus()
        Else
            Return
        End If
    End Sub

    Private Sub ViewLot_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles ViewLot.CellValueChanged
        Dim RAP As Double = 0
        Dim Rate As Double = 0
        Dim Carats As Double = 0
        Dim SaleDiscount As Double = 0
        Dim SalePPCUSD As Double = 0
        Dim SaleTotalUSD As Double = 0
        Dim SalePPCINR As Double = 0
        Dim SaleTotalINR As Double = 0

        RAP = Double.Parse(ViewLot.GetRowCellValue(e.RowHandle, "RAP"))
        Rate = Double.Parse(txtExRate.EditValue)
        Carats = Double.Parse(ViewLot.GetRowCellValue(e.RowHandle, "Carats"))

        If e.Column.FieldName = "SaleDiscount" AndAlso (Not flag) Then
            flag = True
            SaleDiscount = Double.Parse(ViewLot.GetRowCellValue(e.RowHandle, "SaleDiscount"))
            ViewLot.SetRowCellValue(e.RowHandle, "SalePPCUSD", RAP + ((RAP * SaleDiscount) / 100))
            ViewLot.SetRowCellValue(e.RowHandle, "SaleTotalUSD", Carats * (RAP + ((RAP * SaleDiscount) / 100)))
            ViewLot.SetRowCellValue(e.RowHandle, "SalePPCINR", Rate * (RAP + ((RAP * SaleDiscount) / 100)))
            ViewLot.SetRowCellValue(e.RowHandle, "SaleTotalINR", Carats * (Rate * (RAP + ((RAP * SaleDiscount) / 100))))
            flag = False

        ElseIf e.Column.FieldName = "SalePPCUSD" AndAlso (Not flag) Then
            SalePPCUSD = Double.Parse(ViewLot.GetRowCellValue(e.RowHandle, "SalePPCUSD"))
            flag = True
            ViewLot.SetRowCellValue(e.RowHandle, "SaleDiscount", (((SalePPCUSD * 100) / RAP) - 100))
            ViewLot.SetRowCellValue(e.RowHandle, "SaleTotalUSD", (SalePPCUSD * Carats))
            ViewLot.SetRowCellValue(e.RowHandle, "SalePPCINR", Rate * SalePPCUSD)
            ViewLot.SetRowCellValue(e.RowHandle, "SaleTotalINR", Carats * (Rate * SalePPCUSD))
            flag = False

        ElseIf e.Column.FieldName = "SaleTotalUSD" AndAlso (Not flag) Then
            SaleTotalUSD = Double.Parse(ViewLot.GetRowCellValue(e.RowHandle, "SaleTotalUSD"))
            flag = True
            ViewLot.SetRowCellValue(e.RowHandle, "SaleDiscount", (((SaleTotalUSD / Carats) * 100) / RAP) - 100)
            ViewLot.SetRowCellValue(e.RowHandle, "SalePPCUSD", SaleTotalUSD / Carats)
            ViewLot.SetRowCellValue(e.RowHandle, "SalePPCINR", (SaleTotalUSD * Rate) / Carats)
            ViewLot.SetRowCellValue(e.RowHandle, "SaleTotalINR", SaleTotalUSD * Rate)
            flag = False

        ElseIf e.Column.FieldName = "SalePPCINR" AndAlso (Not flag) Then
            SalePPCINR = Double.Parse(ViewLot.GetRowCellValue(e.RowHandle, "SalePPCINR"))
            flag = True
            ViewLot.SetRowCellValue(e.RowHandle, "SaleDiscount", (((SalePPCINR / Rate) * 100) / RAP) - 100)
            ViewLot.SetRowCellValue(e.RowHandle, "SalePPCUSD", SalePPCINR / Rate)
            ViewLot.SetRowCellValue(e.RowHandle, "SaleTotalUSD", (SalePPCINR / Rate) * Carats)
            ViewLot.SetRowCellValue(e.RowHandle, "SaleTotalINR", SalePPCINR * Carats)
            flag = False
        ElseIf e.Column.FieldName = "SaleTotalINR" AndAlso (Not flag) Then
            SaleTotalINR = Double.Parse(ViewLot.GetRowCellValue(e.RowHandle, "SaleTotalINR"))
            flag = True
            ViewLot.SetRowCellValue(e.RowHandle, "SaleDiscount", ((((SaleTotalINR / Rate) / Carats) * 100) / RAP) - 100)
            ViewLot.SetRowCellValue(e.RowHandle, "SalePPCUSD", (SaleTotalINR / Rate) / Carats)
            ViewLot.SetRowCellValue(e.RowHandle, "SaleTotalUSD", SaleTotalINR / Rate)
            ViewLot.SetRowCellValue(e.RowHandle, "SalePPCINR", SaleTotalINR / Carats)
            flag = False
        End If
        calculateTotals()
        ViewLot.UpdateTotalSummary()
        updategrid()

    End Sub
    Private Function CheckIfStockIdExist(ByVal FieldName As String, ByVal Ctrl As DevExpress.XtraEditors.TextEdit) As Boolean
        CheckIfStockIdExist = True
        'dr = GENERAL_FUNCTIONS.NFetchDataRow("Select top(1) * from dia_mainstock where " & FieldName & "= '" & Ctrl.EditValue & "' order by TransactionID Desc")
        dr = GENERAL_FUNCTIONS.NFetchDataRow("select TOP(1) A.*, 
CAST((isnull( b.PurchaseUSD,0) + isnull(e.LabourUSD,0) ) as float)  as CostTotalUSD ,
(isnull( b.PurchaseUSD,0) + isnull(e.LabourUSD,0))/isnull(a.Carats,0) as CostPPCUSD,

isnull(((((b.PurchaseUSD+e.LabourUSD)/a.Carats)*100)/nullif(a.RAP,0))-100,0) as CostDiscount,

ISNULL( e.AskingPercent,0) as AskingDiscount,
ISNULL(e.AskingPPC,0) as AskingPPCUSD,
ISNULL(e.AskingTotal,0) as AskingTotalUSD,cast(0 as float) as SaleDiscount,
cast(0 as float) as SalePPCUSD,cast(0 as float) as SaleTotalUSD,
cast(0 as float) as SalePPCINR,cast(0 as float) as SaleTotalINR
from Dia_MainStock A
  inner join (select MainPacketID,TotalUSD as PurchaseUSD from Dia_Main_Packet_Master B group by MainPacketID,TotalUSD) b on A.MainLotID = b.MainPacketID
  inner join (select e.Barcode,SUM(E.labourUSD) as LabourUSD,e.AskingPercent,e.AskingPPC,e.AskingTotal from Dia_MainStock E group by Barcode,AskingPercent,AskingPPC,AskingTotal) e on e.Barcode = A.Barcode

  where A. " & FieldName & "= '" & Ctrl.EditValue & "'   ORDER BY A.TransactionID DESC")

        If dr Is Nothing Then
            DevFunctions.ErrorMsg(FieldName & " wrong")
            Ctrl.EditValue = Nothing
            Ctrl.Focus()
            CheckIfStockIdExist = False
            Exit Function
        ElseIf dr("ProcessStatus") = True Then
            DevFunctions.ErrorMsg(dr("StockID") & " is in process")
            Ctrl.EditValue = Nothing
            Ctrl.Focus()
            CheckIfStockIdExist = False
            Exit Function
        ElseIf dr("StatusID") = 5 Then
            DevFunctions.ErrorMsg(dr("StockID") & " is already sold")
            Ctrl.EditValue = Nothing
            Ctrl.Focus()
            CheckIfStockIdExist = False
            Exit Function
        Else
            For i = 0 To ViewLot.RowCount - 1
                If ViewLot.GetRowCellValue(i, FieldName) = Ctrl.EditValue Then
                    DevFunctions.ErrorMsg("Lot already added")
                    CheckIfStockIdExist = False
                    Ctrl.Focus()
                    Ctrl.EditValue = Nothing
                    Exit Function
                End If
            Next
        End If
        If dt.Columns.Count = 0 Then
            For Each c As DataColumn In dr.Table.Columns
                dt.Columns.Add(c.ColumnName, c.DataType)
            Next
        End If
        dt.Rows.Add(dr.ItemArray)
        dgLot.DataSource = dt
        XtraTabControl1.SelectedTabPage = XtraTabPage1
        txtBarcode.EditValue = Nothing
        txtStockID.EditValue = Nothing
        disableRate()
        Return CheckIfStockIdExist
    End Function
    Private Function EditModeRowsAdd(ByVal FieldName As String, ByVal value As String) As Boolean
        If GLOBAL_VARIABLES.SalesEditFlag = True Then
            EditModeRowsAdd = True

            Try
                dr = GENERAL_FUNCTIONS.NFetchDataRow("select TOP(1) A.*, CAST(( b.PurchaseUSD + e.LabourUSD ) as float)  as CostTotalUSD ,( b.PurchaseUSD + e.LabourUSD )/a.Carats as CostPPCUSD,
isnull((((( b.PurchaseUSD + e.LabourUSD )/a.Carats)*100)/nullif(a.RAP,0))-100,0) as CostDiscount, isnull(e.AskingPercent,0) as AskingDiscount,isnull(e.AskingPPC,0) as AskingPPCUSD,isnull(e.AskingTotal,0) as AskingTotalUSD,cast(S.Discount as float) as SaleDiscount,cast(S.PPCUSD as float) as SalePPCUSD,cast(S.TotalUSD as float) as SaleTotalUSD,cast(s.PPCINR as float) as SalePPCINR,cast(s.TotalINR as float) as SaleTotalINR,f.SalesDetailID
from Dia_MainStock A
  inner join (select MainPacketID,TotalUSD as PurchaseUSD from Dia_Main_Packet_Master B group by MainPacketID,TotalUSD) b on A.MainLotID = b.MainPacketID
  inner join (select e.Barcode,SUM(E.labourUSD) as LabourUSD,E.AskingPercent,e.AskingPPC,e.AskingTotal from Dia_MainStock E group by Barcode,AskingPercent,AskingPPC,AskingTotal) e on e.Barcode = A.Barcode
   inner join (select S.* from Dia_SalesDetails S group by  S.Barcode,S.Discount,s.PPCINR,s.PPCUSD,s.RAP,s.SalesDetailID,s.SalesMasterID,s.TotalINR,s.TotalUSD) s on S.SalesMasterID = A.SalesMasterID and S.Barcode=e.Barcode
inner join (Select F.Barcode,F.SalesDetailID from Dia_SalesDetails F group by F.Barcode,F.SalesDetailID)f on f.Barcode=e.Barcode 

  where A. " & FieldName & "= '" & value & "'   ORDER BY A.TransactionID DESC")

                For i = 0 To ViewLot.RowCount - 1
                    If ViewLot.GetRowCellValue(i, FieldName) = value Then
                        DevFunctions.ErrorMsg("Lot already added")
                        EditModeRowsAdd = False
                        Exit Function
                    End If
                Next
                If dt.Columns.Count = 0 Then
                    For Each c As DataColumn In dr.Table.Columns
                        dt.Columns.Add(c.ColumnName, c.DataType)
                    Next
                End If
                dt.NewRow()
                dt.Rows.Add(dr.ItemArray)

                dgLot.DataSource = dt
                XtraTabControl1.SelectedTabPage = XtraTabPage1
                txtBarcode.EditValue = Nothing
                txtStockID.EditValue = Nothing
                disableRate()
            Catch ex As Exception
                ErrorMsg(value & " couldn't Load.")
            End Try

        End If
        Return EditModeRowsAdd
    End Function
    Private Sub disableRate()
        If ViewLot.RowCount > 0 Then
            txtExRate.Enabled = False
        Else
            txtExRate.Enabled = True
        End If
    End Sub

    Private Sub ViewAdditional_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles ViewAdditional.ValidateRow
        Dim requirefields As List(Of String) = New List(Of String)() From {"LedgerIDExp", "ExpPercent", "ExpUSD", "ExpINR"}
        For Each col As GridColumn In ViewAdditional.Columns
            If Not requirefields.Contains(col.FieldName) OrElse Not String.IsNullOrEmpty(ViewAdditional.GetRowCellDisplayText(e.RowHandle, col)) Then Continue For
            e.Valid = False
            ViewAdditional.SetColumnError(col, $"{col.GetCaption()} has not been entered.")
        Next

    End Sub
    Private Sub ViewAdditional_ShownEditor(sender As Object, e As EventArgs) Handles ViewAdditional.ShownEditor
        If ViewAdditional.FocusedRowHandle = GridControl.NewItemRowHandle Then
            ViewAdditional.ActiveEditor.IsModified = True
        End If
    End Sub

    Private Sub ViewAdditional_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles ViewAdditional.InvalidRowException
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub

    Private Sub ViewAdditional_KeyDown(sender As Object, e As KeyEventArgs) Handles ViewAdditional.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Row?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ViewAdditional.DeleteRow(ViewAdditional.FocusedRowHandle)
                calculateTotals()
            Else
                Return
            End If
        End If
    End Sub
    Private Sub ViewLot_KeyDown(sender As Object, e As KeyEventArgs) Handles ViewLot.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Row?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ViewLot.DeleteRow(ViewLot.FocusedRowHandle)
                calculateTotals()
                If dt.Rows.Count = 0 Then txtExRate.Enabled = True
            Else
                Return
            End If
        End If
    End Sub

    Private Sub riExp_EditValueChanged(sender As Object, e As EventArgs) Handles riExp.EditValueChanged, riBroker.EditValueChanged
        updategrid()
    End Sub

    Private Sub ViewAdditional_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles ViewAdditional.CellValueChanged
        Try
            If ViewLot.Columns("SaleTotalUSD").SummaryItem.SummaryValue = 0 OrElse ViewLot.Columns("SaleTotalUSD").SummaryItem.SummaryValue = Nothing Then Return
            Dim ExpPercent As Double = 0
            Dim ExpUSD As Double = 0
            Dim ExpINR As Double = 0
            Dim Rate As Double = txtExRate.EditValue

            If e.Column.FieldName = "ExpPercent" AndAlso (Not flag) Then
                If IsDBNull(ViewAdditional.GetRowCellValue(e.RowHandle, "ExpPercent")) = True Then Return
                flag = True
                ExpPercent = ViewAdditional.GetRowCellValue(e.RowHandle, "ExpPercent")
                ViewAdditional.SetRowCellValue(e.RowHandle, "ExpUSD", (ViewLot.Columns("SaleTotalUSD").SummaryItem.SummaryValue * ExpPercent) / 100)
                ViewAdditional.SetRowCellValue(e.RowHandle, "ExpINR", Rate * ((ViewLot.Columns("SaleTotalUSD").SummaryItem.SummaryValue * ExpPercent) / 100))
                flag = False
            ElseIf e.Column.FieldName = "ExpUSD" AndAlso (Not flag) Then
                If IsDBNull(ViewAdditional.GetRowCellValue(e.RowHandle, "ExpUSD")) = True Then Return
                ExpUSD = ViewAdditional.GetRowCellValue(e.RowHandle, "ExpUSD")
                flag = True
                ViewAdditional.SetRowCellValue(e.RowHandle, "ExpPercent", (ExpUSD * 100) / ViewLot.Columns("SaleTotalUSD").SummaryItem.SummaryValue)
                ViewAdditional.SetRowCellValue(e.RowHandle, "ExpINR", (ExpUSD * Rate))
                flag = False
            ElseIf e.Column.FieldName = "ExpINR" AndAlso (Not flag) Then
                If IsDBNull(ViewAdditional.GetRowCellValue(e.RowHandle, "ExpINR")) = True Then Return
                ExpINR = ViewAdditional.GetRowCellValue(e.RowHandle, "ExpINR")
                flag = True
                ViewAdditional.SetRowCellValue(e.RowHandle, "ExpPercent", ((ExpINR / Rate) * 100) / ViewLot.Columns("SaleTotalUSD").SummaryItem.SummaryValue)
                ViewAdditional.SetRowCellValue(e.RowHandle, "ExpUSD", (ExpINR / Rate))
                flag = False
            End If
            ViewAdditional.UpdateTotalSummary()
            updategrid()
            calculateTotals()
        Catch ex As Exception
            DevFunctions.ErrorMsg(ex.Message)
        End Try

    End Sub
    Sub updategrid()
        If ViewAdditional.PostEditor() Then
            ViewAdditional.UpdateCurrentRow()
        End If
        If ViewLot.PostEditor() Then
            ViewLot.UpdateCurrentRow()

        End If
        If ViewBroker.PostEditor() Then
            ViewBroker.UpdateCurrentRow()

        End If

    End Sub

    Private Sub ViewBroker_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles ViewBroker.CellValueChanged
        Try
            If ViewLot.Columns("SaleTotalUSD").SummaryItem.SummaryValue = 0 OrElse ViewLot.Columns("SaleTotalUSD").SummaryItem.SummaryValue = Nothing Then Return
            Dim BrokerPercent As Double = 0
            Dim BrokerageUSD As Double = 0
            Dim BrokerageINR As Double = 0
            Dim Rate As Double = Double.Parse(txtExRate.EditValue)
            Dim SaleTotalUSD As Double = Double.Parse(ViewLot.Columns("SaleTotalUSD").SummaryItem.SummaryValue)

            If e.Column.FieldName = "BrokerPercent" AndAlso (Not flag) Then
                If IsDBNull(ViewBroker.GetRowCellValue(e.RowHandle, "BrokerPercent")) = True Then Return
                flag = True
                BrokerPercent = Double.Parse(ViewBroker.GetRowCellValue(e.RowHandle, "BrokerPercent"))
                ViewBroker.SetRowCellValue(e.RowHandle, "BrokerageUSD", (SaleTotalUSD * BrokerPercent) / 100)
                ViewBroker.SetRowCellValue(e.RowHandle, "BrokerageINR", Rate * ((SaleTotalUSD * BrokerPercent) / 100))
                flag = False
            ElseIf e.Column.FieldName = "BrokerageUSD" AndAlso (Not flag) Then
                If IsDBNull(ViewBroker.GetRowCellValue(e.RowHandle, "BrokerageUSD")) = True Then Return
                BrokerageUSD = Double.Parse(ViewBroker.GetRowCellValue(e.RowHandle, "BrokerageUSD"))
                flag = True
                ViewBroker.SetRowCellValue(e.RowHandle, "BrokerPercent", (BrokerageUSD * 100) / SaleTotalUSD)
                ViewBroker.SetRowCellValue(e.RowHandle, "BrokerageINR", (BrokerageUSD * Rate))
                flag = False
            ElseIf e.Column.FieldName = "BrokerageINR" AndAlso (Not flag) Then
                If IsDBNull(ViewBroker.GetRowCellValue(e.RowHandle, "BrokerageINR")) = True Then Return
                BrokerageINR = Double.Parse(ViewBroker.GetRowCellValue(e.RowHandle, "BrokerageINR"))
                flag = True
                ViewBroker.SetRowCellValue(e.RowHandle, "BrokerPercent", ((BrokerageINR / Rate) * 100) / SaleTotalUSD)
                ViewBroker.SetRowCellValue(e.RowHandle, "BrokerageUSD", (BrokerageINR / Rate))
                flag = False
            End If
            ViewLot.UpdateTotalSummary()
            updategrid()
            calculateTotals()
        Catch ex As Exception
            ErrorMsg(ex.Message)
        End Try
    End Sub

    Private Sub ViewBroker_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles ViewBroker.InvalidRowException
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub

    Private Sub ViewBroker_KeyDown(sender As Object, e As KeyEventArgs) Handles ViewBroker.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Row?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ViewBroker.DeleteRow(ViewBroker.FocusedRowHandle)
                calculateTotals()
            Else
                Return
            End If
        End If
    End Sub

    Private Sub ViewBroker_ShownEditor(sender As Object, e As EventArgs) Handles ViewBroker.ShownEditor
        If ViewBroker.FocusedRowHandle = GridControl.NewItemRowHandle Then
            ViewBroker.ActiveEditor.IsModified = True
        End If
    End Sub

    Private Sub ViewBroker_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles ViewBroker.ValidateRow
        Dim requirefields As List(Of String) = New List(Of String)() From {"LedgerID", "BrokerPercent", "BrokerageUSD", "BrokerageINR"}

        For Each col As GridColumn In ViewBroker.Columns
            If Not requirefields.Contains(col.FieldName) OrElse Not String.IsNullOrEmpty(ViewBroker.GetRowCellDisplayText(e.RowHandle, col)) Then Continue For
            e.Valid = False
            ViewBroker.SetColumnError(col, $"{col.GetCaption()} has not been entered.")
        Next

    End Sub

    Private Sub XtraTabControl1_CustomHeaderButtonClick(sender As Object, e As CustomHeaderButtonEventArgs) Handles XtraTabControl1.CustomHeaderButtonClick
        Fill_InPlaceEditors()
    End Sub

    Sub calculateTotals()
        Try
            SaleTotalUSD = Val(ViewLot.Columns("SaleTotalUSD").SummaryItem.SummaryValue)
            AdditionalTotalUSD = Val(ViewAdditional.Columns("ExpUSD").SummaryItem.SummaryValue)
            BrokerageUSD = Val(ViewBroker.Columns("BrokerageUSD").SummaryItem.SummaryValue)
            TotalCarats = Val(ViewLot.Columns("Carats").SummaryItem.SummaryValue)
            txtNetUSD.EditValue = Val(SaleTotalUSD + AdditionalTotalUSD + BrokerageUSD)

            SaleTotalINR = Val(ViewLot.Columns("SaleTotalINR").SummaryItem.SummaryValue)
            AdditionalTotalINR = Val(ViewAdditional.Columns("ExpINR").SummaryItem.SummaryValue)
            BrokerageINR = Val(ViewBroker.Columns("BrokerageINR").SummaryItem.SummaryValue)
            txtNetINR.EditValue = Val(SaleTotalINR + AdditionalTotalINR + BrokerageINR)

            'Dim arry1(ViewLot.RowCount - 1) As Double
            'Dim arry2(ViewLot.RowCount - 1) As Double
            'For i = 0 To ViewLot.RowCount - 1
            '    arry1(i) = ViewLot.GetRowCellValue(i, "RAP")
            '    arry2(i) = ViewLot.GetRowCellValue(i, "Carats")
            'Next
            'Dim RAPMultiplyCarat As Double = SUMPRODUCT(arry1, arry2)
            'AverageDiscount = (((SaleTotalUSD / TotalCarats) * 100) / (RAPMultiplyCarat / TotalCarats)) - 100
        Catch ex As Exception
            ErrorMsg(ex.Message)
        End Try

    End Sub

    Private Sub BtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSave.ItemClick
        If SaveData() = True Then
            DevFunctions.InfoMsg("Record saved successfully..")
            cancel()
            XtraTabControl1.SelectedTabPage = XtraTabPage1
            FrmInvoiceList.FrmInvoiceList_Load(sender, e)
        End If
    End Sub
    Private Function CheckValidation() As Boolean
        If cmbCustomer.SelectedValue = 0 Then
            ErrorMsg("Select Customer from the list.")
            CheckValidation = False
            cmbCustomer.Focus()
            Exit Function
        ElseIf cmbTerms.SelectedValue = 0 Then
            ErrorMsg("Select Terms from the list.")
            CheckValidation = False
            cmbTerms.Focus()
            Exit Function
        ElseIf txtNetUSD.EditValue = 0 Or txtNetUSD.EditValue = Nothing Then
            ErrorMsg("Net USD must be greater than zero")
            txtNetUSD.Focus()
            CheckValidation = False
            Exit Function
        ElseIf txtNetINR.EditValue = 0 Or txtNetINR.EditValue = Nothing Then
            ErrorMsg("Net INR must be greater than zero")
            txtNetINR.Focus()
            CheckValidation = False
            Exit Function
        Else
            CheckValidation = True
        End If
        Return CheckValidation
    End Function
    Private Function SaveData() As Boolean
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        Try
            If CheckValidation() = True Then
                If GLOBAL_VARIABLES.SalesEditFlag = True Then
                    NExcuteQuery("DELETE FROM Dia_SalesMaster where SalesMasterID=" & FrmInvoiceList.SalesMasterID)
                    NExcuteQuery("DELETE FROM Dia_SalesDetails where SalesMasterID=" & FrmInvoiceList.SalesMasterID)
                    NExcuteQuery("DELETE FROM Dia_SalesAdditional where SalesMasterID=" & FrmInvoiceList.SalesMasterID)
                    NExcuteQuery("DELETE FROM Dia_SalesBrokerage where SalesMasterID=" & FrmInvoiceList.SalesMasterID)
                    NExcuteQuery("DELETE FROM Dia_MainStock where SalesMasterID=" & FrmInvoiceList.SalesMasterID)
                    DevFunctions.CopY_PDF_to_Server(txtAttachment.EditValue, "Sales", FrmInvoiceList.SalesMasterID)
                Else
                    DevFunctions.CopY_PDF_to_Server(txtAttachment.EditValue, "Sales", GENERAL_FUNCTIONS.MaxNo("Select Max(SalesMasterID) from Dia_SalesMaster"))
                End If

                FullFileName()
                Dim TotalExpUSD As Double = ViewAdditional.Columns("ExpUSD").SummaryItem.SummaryValue
                Dim TotalExPINR As Double = ViewAdditional.Columns("ExpINR").SummaryItem.SummaryValue
                Dim TotalBrokerateUSD As Double = ViewBroker.Columns("BrokerageUSD").SummaryItem.SummaryValue
                Dim TotalBrokerageINR As Double = ViewBroker.Columns("BrokerageINR").SummaryItem.SummaryValue

                If TotalExpUSD = Nothing Then TotalExpUSD = 0
                If TotalExPINR = Nothing Then TotalExPINR = 0
                If TotalBrokerageINR = Nothing Then TotalBrokerageINR = 0
                If TotalBrokerateUSD = Nothing Then TotalBrokerateUSD = 0


                SalesMaster_INSERT(0, dtpDate.Value, cmbCustomer.SelectedValue, cmbTerms.SelectedValue, txtExRate.EditValue, Integer.Parse(ViewLot.Columns("Qty").SummaryItem.SummaryValue), Double.Parse(ViewLot.Columns("Carats").SummaryItem.SummaryValue), Double.Parse(ViewLot.Columns("SaleTotalUSD").SummaryItem.SummaryValue), Double.Parse(ViewLot.Columns("SaleTotalINR").SummaryItem.SummaryValue), TotalExpUSD, TotalExPINR, TotalBrokerateUSD, TotalBrokerageINR, txtNetUSD.EditValue, txtNetINR.EditValue, GLOBAL_VARIABLES.Filename)

                For i = 0 To ViewLot.RowCount - 1
                    Dim LotDiscount As Double = ViewLot.GetRowCellValue(i, "SaleDiscount")
                    If Double.IsInfinity(LotDiscount) = True Then LotDiscount = 0
                    SalesDetails_INSERT(1, 0, FrmInvoiceList.SalesMasterID, ViewLot.GetRowCellValue(i, "Barcode"), ViewLot.GetRowCellValue(i, "RAP"), LotDiscount, ViewLot.GetRowCellValue(i, "SalePPCUSD"), ViewLot.GetRowCellValue(i, "SaleTotalUSD"), ViewLot.GetRowCellValue(i, "SalePPCINR"), ViewLot.GetRowCellValue(i, "SaleTotalINR"))
                Next

                If AdditionalDT.Rows.Count <> 0 Then
                    For i = 0 To ViewAdditional.RowCount - 2
                        SalesAdditional_INSERT(2, 0, FrmInvoiceList.SalesMasterID, ViewAdditional.GetRowCellValue(i, "LedgerIDExp"), ViewAdditional.GetRowCellValue(i, "ExpPercent"), ViewAdditional.GetRowCellValue(i, "ExpUSD"), ViewAdditional.GetRowCellValue(i, "ExpINR"))
                    Next
                End If

                If BrokerDT.Rows.Count <> 0 Then
                    For i = 0 To ViewBroker.RowCount - 2
                        SalesBrokerage_INSERT(3, 0, FrmInvoiceList.SalesMasterID, ViewBroker.GetRowCellValue(i, "LedgerID"), ViewBroker.GetRowCellValue(i, "BrokerPercent"), ViewBroker.GetRowCellValue(i, "BrokerageUSD"), ViewBroker.GetRowCellValue(i, "BrokerageINR"))
                    Next
                End If

                If dt.Rows.Count <> 0 Then
                    Dim UnionID As Integer = MaxNo("Select max(UnionID) from Dia_MainStock")
                    Dim TempDt As DataTable = DevFunctions.GetEmptyMainStockDatatable
                    For i = 0 To dt.Rows.Count - 1
                        Dim dr As DataRow = NFetchDataRow("select top(1)* from Dia_MainStock where Barcode=" & dt.Rows(i).Item("Barcode") & " ORDER BY TransactionID Desc")
                        dr("LabourUSD") = 0
                        dr("LabourExRate") = 0
                        dr("LabourINR") = 0
                        dr("ImportDate") = dtpDate.Value
                        dr("StatusID") = NExcuteScalerInt("select lot_status_id from Dia_Lot_Status_Master where lot_status_name='Sold'")
                        dr("HistoryDescription") = "Sold out"
                        dr("ExecutionDateTime") = NExcuteScalerDate("Select getdate()")
                        dr("LedgerID") = cmbCustomer.SelectedValue
                        dr("UnionID") = UnionID
                        dr("ProcessID") = 0
                        dr("ProcessStatus") = 0
                        dr("UserID") = GLOBAL_VARIABLES.UID
                        dr("SalesMasterID") = FrmInvoiceList.SalesMasterID
                        TempDt.Rows.Add(dr.ItemArray)
                    Next
                    GENERAL_FUNCTIONS.DataTable_to_SqlTable_Copy(TempDt, "Dia_MainStock")
                End If
                SaveData = True
            Else
                SaveData = False
            End If
        Catch ex As Exception
            SaveData = False
            ErrorMsg(ex.Message)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        Return SaveData
    End Function
    Private Sub FullFileName()
        If txtAttachment.EditValue = Nothing Then
            GLOBAL_VARIABLES.Filename = ""
        Else
            If GLOBAL_VARIABLES.SalesEditFlag = False Then
                GLOBAL_VARIABLES.Filename = GLOBAL_VARIABLES.AttachmentPath & "Sales-" & GENERAL_FUNCTIONS.MaxNo("Select Max(SalesMasterID) from Dia_SalesMaster") & ".pdf"
            Else
                GLOBAL_VARIABLES.Filename = GLOBAL_VARIABLES.AttachmentPath & "Sales-" & FrmInvoiceList.SalesMasterID & ".pdf"
            End If

        End If
    End Sub
    Private Sub FrmInvoice_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmInvoiceList.SalesMasterID = Nothing
        GLOBAL_VARIABLES.SalesEditFlag = Nothing
    End Sub

    Private Sub ViewLot_CustomSummaryCalculate(sender As Object, e As CustomSummaryEventArgs) Handles ViewLot.CustomSummaryCalculate
        Dim view As GridView = TryCast(sender, GridView)

        ''If e.IsTotalSummary AndAlso (TryCast(e.Item, GridSummaryItem)).FieldName = "rk_bhav" Then
        'Dim item As GridColumnSummaryItem = TryCast(e.Item, GridColumnSummaryItem)
        'If item.Tag.ToString() = "avgdis" Then

        '    e.TotalValue = AverageDiscount 'Format(ViewRk.Columns("rk_total").SummaryItem.SummaryValue / ViewRk.Columns("rk_vajan").SummaryItem.SummaryValue, "#.##") ' view.Columns("rk_total").SummaryText
        'End If
        ''End If

        Try
            If e.IsTotalSummary Then
                Dim item As GridColumnSummaryItem = TryCast(e.Item, GridColumnSummaryItem)
                Dim tag As String = TryCast(item.Tag, String)
                Select Case e.SummaryProcess
                    Case DevExpress.Data.CustomSummaryProcess.Start
                        If item.Tag.ToString() = "avgdis" Then
                            AverageDiscount = 0
                        End If
                    Case DevExpress.Data.CustomSummaryProcess.Calculate
                        If item.Tag.ToString() = "avgdis" Then
                            Dim arry1(ViewLot.RowCount - 1) As Double
                            Dim arry2(ViewLot.RowCount - 1) As Double
                            For i = 0 To ViewLot.RowCount - 1
                                arry1(i) = ViewLot.GetRowCellValue(i, "RAP")
                                arry2(i) = ViewLot.GetRowCellValue(i, "Carats")
                            Next
                            Dim RAPMultiplyCarat As Double = SUMPRODUCT(arry1, arry2)
                            AverageDiscount = (((Format(ViewLot.Columns("SaleTotalUSD").SummaryItem.SummaryValue / ViewLot.Columns("Carats").SummaryItem.SummaryValue, "#.##")) * 100) / (RAPMultiplyCarat / ViewLot.Columns("Carats").SummaryItem.SummaryValue)) - 100

                        Else

                        End If
                    Case DevExpress.Data.CustomSummaryProcess.Finalize
                        If item.Tag.ToString() = "avgdis" Then
                            e.TotalValue = AverageDiscount
                        Else

                        End If

                End Select
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbTerms_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbTerms.SelectionChangeCommitted
        Dim termsdays As Integer = Integer.Parse(GENERAL_FUNCTIONS.NExcuteScalerInt("Select terms_desc from Dia_Terms_Master where terms_id=" & cmbTerms.SelectedValue & ""))
        dtpDueDate.Value = dtpDate.Value.AddDays(termsdays)
    End Sub

    Private Sub btnSaveClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveClose.ItemClick
        If SaveData() = True Then
            btnCancel_ItemClick(sender, e)
            FrmInvoiceList.FrmInvoiceList_Load(sender, e)
            Me.Close()
        End If
    End Sub

    Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
        Dim cus As Integer = 0
        Dim term As Integer = 0
        cus = cmbCustomer.SelectedValue
        term = cmbTerms.SelectedValue
        FillCustomersCombo(cmbCustomer)
        GF.FillTermsCombo(cmbTerms)

        cmbCustomer.SelectedValue = cus
        cmbTerms.SelectedValue = term
    End Sub

    Private Sub btnAttachment_Click(sender As Object, e As EventArgs) Handles btnAttachment.Click
        txtAttachment.EditValue = DevFunctions.GetFullPath_of_PDF()
    End Sub
End Class

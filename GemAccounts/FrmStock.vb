Imports System.IO
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports System.Text
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Columns

Public Class FrmStock
    Private d As EventArgs
    Dim DF As New DevFunctions
    Private xtraTabbedMdiManager1 As Object
    Dim mc As New MasterConnection
    Dim GF As New GENERAL_FUNCTIONS
    'Dim CurrentFilter As String
    Public Sub New()
        Me.Controls.Clear()
        InitializeComponent()

    End Sub
    Private Sub FrmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainStock_Grid_Bind()
        SetDefaultLayout()
        'CurrentFilter = dgview.ActiveFilterString
        dgview.OptionsView.ShowFooter = True
        CmbAgingFilter.SelectedIndex = 0
        'dgview.ActiveFilterString = CurrentFilter
        '-----******-------Master Row Detail Row Code-------*****------------
        'Dim dataSet11 As New DataSet()
        'dataSet11.Tables.Add(DevFunctions.SelectMainStockDataTable)
        'dataSet11.Tables.Add(DevFunctions.SelectDetailRow)
        'Dim keyColumn As DataColumn = dataSet11.Tables("Table1").Columns("Barcode")
        'Dim foreignKeyColumn As DataColumn = dataSet11.Tables("Table2").Columns("Barcode")
        'dataSet11.Relations.Add("OtherLabResults", keyColumn, foreignKeyColumn)
        'dg.DataSource = dataSet11.Tables("Table1")
        'dg.ForceInitialize()
        '-----******-------Master Row Detail Row Code-------*****------------

        If GLOBAL_VARIABLES.ClipboardFlag = True Then
            If GLOBAL_VARIABLES.FilterString <> Nothing Then
                cmbLayouts.SelectedValue = FrmClipboard.LayoutID
                cmbLayouts_SelectionChangeCommitted(sender, e)
                dgview.Columns("Barcode").FilterInfo = New ColumnFilterInfo(GLOBAL_VARIABLES.FilterString)

            End If
        Else

        End If


    End Sub
    Public Shared Sub MainStock_Grid_Bind()
        Dim dt As DataTable = DevFunctions.SelectMainStockDataTable
        FrmStock.dg.DataSource = dt

    End Sub
    Public Shared Sub SetDefaultLayout()
        Dim text As String

        FrmStock.GF.NFillCombo("IF EXISTS ( SELECT LayoutID,LayoutName FROM Dia_Layouts  WHERE UserID=" & GLOBAL_VARIABLES.UID & ")  
BEGIN   SELECT LayoutID,LayoutName FROM Dia_Layouts where UserID=" & GLOBAL_VARIABLES.UID & " Order by LayoutName END  
ELSE
BEGIN  SELECT LayoutID,LayoutName FROM Dia_Layouts where LayoutID=1111 END ", "LayoutID", "LayoutName", FrmStock.cmbLayouts)
        If GLOBAL_VARIABLES.StockLayoutID = 0 Or GLOBAL_VARIABLES.StockLayoutID = Nothing Then
            text = GENERAL_FUNCTIONS.NExcuteScaler("Select LayoutData from Dia_Layouts where LayoutID=1111")
            FrmStock.cmbLayouts.SelectedValue = 1111
        Else
            text = GENERAL_FUNCTIONS.NExcuteScaler("Select LayoutData from Dia_Layouts where LayoutID=" & GLOBAL_VARIABLES.StockLayoutID)
            FrmStock.cmbLayouts.SelectedValue = GLOBAL_VARIABLES.StockLayoutID
        End If
        Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
        Dim stream As MemoryStream = New MemoryStream(byteArray)
        FrmStock.dgview.RestoreLayoutFromStream(stream)
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        GLOBAL_VARIABLES.DS = New TmpData
        GLOBAL_VARIABLES.DT = Nothing
        GLOBAL_VARIABLES.DT = GLOBAL_VARIABLES.DS.Tables("TempTransactionID")
        Dim dr As DataRow
        Dim srh As Integer() = dgview.GetSelectedRows()
        For i = 0 To srh.Length - 1
            Dim ProcessStatus As String = Convert.ToString(dgview.GetRowCellValue(srh(i), "ProcessStatus"))
            If ProcessStatus = True Then
                DevFunctions.ErrorMsg(Convert.ToString(dgview.GetRowCellValue(srh(i), "StockID")) & " is already in process")
                Exit Sub
            End If

            dr = GLOBAL_VARIABLES.DT.NewRow
            dr("TransactionID") = dgview.GetRowCellValue(srh(i), "TransactionID")
            GLOBAL_VARIABLES.DT.Rows.Add(dr)
        Next

        setform(FrmSendtoProcess)

    End Sub
    Public Sub setform(ByVal ctrl As Form)
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

    Private Sub OpenLink_InBrowser(sender As Object, e As OpenLinkEventArgs)
        Dim process As New System.Diagnostics.Process()
        If e.EditValue Is String.Empty Then Return
        process.StartInfo.FileName = e.EditValue
        process.StartInfo.Verb = "open"
        'process.StartInfo.WindowStyle = (TryCast(sender, HyperLinkEdit)).Properties.BrowserWindowStyle
        process.Start(e.EditValue)
        e.Handled = True
    End Sub

    Private Sub dgview_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles dgview.RowCellClick
        Dim cellvalue As String
        If e.Column.FieldName = "ImageLink1" Then
            cellvalue = dgview.GetRowCellValue(dgview.FocusedRowHandle, "ImageLink")
            OpenLink_InBrowser(sender, New DevExpress.XtraEditors.Controls.OpenLinkEventArgs(cellvalue))
        ElseIf e.Column.FieldName = "VideoLink1" Then
            cellvalue = dgview.GetRowCellValue(dgview.FocusedRowHandle, "VideoLink")
            OpenLink_InBrowser(sender, New DevExpress.XtraEditors.Controls.OpenLinkEventArgs(cellvalue))
        ElseIf e.Column.FieldName = "RoughVideo" Then
            cellvalue = dgview.GetRowCellValue(dgview.FocusedRowHandle, "MainLotVideoLink")
            OpenLink_InBrowser(sender, New DevExpress.XtraEditors.Controls.OpenLinkEventArgs(cellvalue))
        ElseIf e.Column.FieldName = "RoughImage" Then
            cellvalue = dgview.GetRowCellValue(dgview.FocusedRowHandle, "MainLotImageLink")
            OpenLink_InBrowser(sender, New DevExpress.XtraEditors.Controls.OpenLinkEventArgs(cellvalue))
        Else
            Return
        End If
    End Sub
    Private Sub cmbLayouts_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbLayouts.SelectionChangeCommitted
        Dim text As String = GENERAL_FUNCTIONS.NExcuteScaler("Select LayoutData from Dia_Layouts where LayoutID=" & cmbLayouts.SelectedValue)
        If text Is Nothing Or text = String.Empty Then Return
        Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
        Dim stream As MemoryStream = New MemoryStream(byteArray)
        dgview.RestoreLayoutFromStream(stream)
        dg.ForceInitialize()
    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        GLOBAL_VARIABLES.TempStockLayoutID = cmbLayouts.SelectedValue
        Dim frm As New FrmStockLayout
        frm.ShowDialog()
    End Sub

    Private Sub dgview_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles dgview.PopupMenuShowing
        DevFunctions.GridContextMenu(sender, e)
    End Sub

    Private Sub btnRestoreLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRestoreLayout.ItemClick
        FrmStock_Load(sender, d)
    End Sub

    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        DevFunctions.ExportGrid(dgview)
    End Sub

    Private Sub ViewR_Click(sender As Object, e As EventArgs) Handles ViewR.Click
        If IsDBNull(dgview.GetRowCellValue(dgview.FocusedRowHandle, "CountResult")) = True Then Return
        If dgview.GetRowCellValue(dgview.FocusedRowHandle, "CountResult") = 0 Then
            DevFunctions.ErrorMsg("No Result available for the Stock ID " & dgview.GetRowCellValue(dgview.FocusedRowHandle, "StockID"))
        Else
            Dim frm As New frmLabResults
            frm.Text = "Lab Results for the Stock ID : " & dgview.GetRowCellValue(dgview.FocusedRowHandle, "StockID")
            GLOBAL_VARIABLES.Barcode = dgview.GetRowCellValue(dgview.FocusedRowHandle, "Barcode")
            frm.ShowDialog()
        End If

    End Sub

    Private Sub FrmStock_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GLOBAL_VARIABLES.FilterString = Nothing
        GLOBAL_VARIABLES.ClipboardFlag = False
    End Sub

    Private Sub BtnUpdateAsking_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnUpdateAsking.ItemClick
        Dim ds As DataSet = GLOBAL_VARIABLES.DS
        If ds.Tables.Contains("DataTable_UpdateAskingPrice") = True Then ds.Tables.Remove("DataTable_UpdateAskingPrice")
        ds.Tables.Add("DataTable_UpdateAskingPrice")
        ds.Tables("DataTable_UpdateAskingPrice").Columns.Add("TransactionID")
        Dim dr As DataRow
        Dim srh As Integer() = dgview.GetSelectedRows()
        For i = 0 To srh.Length - 1
            dr = ds.Tables("DataTable_UpdateAskingPrice").NewRow
            dr("TransactionID") = dgview.GetRowCellValue(srh(i), "TransactionID")
            ds.Tables("DataTable_UpdateAskingPrice").Rows.Add(dr)
        Next
        setform(FrmUpdateAskingManually)
    End Sub

    Private Sub CmbAgingFilter_EditValueChanged(sender As Object, e As EventArgs) Handles CmbAgingFilter.EditValueChanged
        'Dim Filter As String = ""
        'If CmbAgingFilter.EditValue = "All" Then Filter = ""
        'If CmbAgingFilter.EditValue = "Today" Then Filter = String.Format("[AgingDate] > #{0:dd/MM/yyyy}# AND [AgingDate] < #{1:dd/MM/yyyy}#", Now(), Now())
        'If CmbAgingFilter.EditValue = "Yesterday" Then Filter = String.Format("[AgingDate] > #{0:dd/MM/yyyy}# AND [AgingDate] < #{1:dd/MM/yyyy}#", DateAdd("d", -1, Now()), Now())
        'If CmbAgingFilter.EditValue = "Yesterday" Then MsgBox(DateAdd("d", -1, Now()))
        'dgview.ActiveFilterString = Filter
    End Sub


    'Private Sub btnUpdatePrices_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUpdatePrices.ItemClick
    '    'SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
    '    'Dim dt As DataTable = GLOBAL_VARIABLES.TransactionID_DataTable
    '    'dt.Rows.Clear()
    '    'dt.Columns.Clear()
    '    'dt.Columns.Add("TransactionID", GetType(Integer))
    '    'Dim dr As DataRow
    '    'Dim srh As Integer() = dgview.GetSelectedRows()
    '    'Dim msg As String = ""
    '    'If srh.Length = 0 Then Return
    '    'For i = 0 To srh.Length - 1
    '    '    dr = GENERAL_FUNCTIONS.NFetchDataRow("Select * from Dia_MainStock where TransactionID=" & dgview.GetRowCellValue(srh(i), "TransactionID"))
    '    '    If dr("ProcessStatus") = True Or dr("SalesMasterID") > 0 Or dr("StatusID") <> GENERAL_FUNCTIONS.NExcuteScalerInt("Select lot_status_id from Dia_Lot_Status_Master where lot_status_name='Available'") Then
    '    '        msg = msg & dgview.GetRowCellValue(srh(i), "StockID") & " - Lot not accessed for the Update Prices" & vbNewLine
    '    '    Else
    '    '        dt.Rows.Add(dr.Item("TransactionID").ToString)
    '    '    End If
    '    'Next

    '    'If msg = String.Empty Then
    '    'Else
    '    '    DevFunctions.ErrorMsg(msg)
    '    'End If

    '    'If dt.Rows.Count = 0 Then
    '    '    Return
    '    'Else
    '    '    DevFunctions.ErrorMsg("There are 0 Lot available for Update Prices")
    '    'End If
    '    'SplashScreenManager.CloseForm(False)
    'End Sub

    'Private Sub btnChangePrices_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnChangePrices.ItemClick
    '    'Dim dr As DataRow
    '    'SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
    '    'Try
    '    '    Dim AskingPPC As Double
    '    '    Dim AskingTotal As Double
    '    '    Dim AskingPercent As Double
    '    '    Dim WholesalePPC As Double
    '    '    Dim WholesaleTotal As Double
    '    '    Dim WholesalePercent As Double
    '    '    Dim WebPPC As Double
    '    '    Dim WebTotal As Double
    '    '    Dim WebPercent As Double
    '    '    Dim RAP As Double
    '    '    Dim carats As Double

    '    '    For i = 0 To GLOBAL_VARIABLES.TransactionID_DataTable.Rows.Count - 1
    '    '        dr = GENERAL_FUNCTIONS.NFetchDataRow("Select * From Dia_MainStock Where TransactionID=" & GLOBAL_VARIABLES.TransactionID_DataTable.Rows(i).Item("TransactionID").ToString)
    '    '        If dr Is Nothing Then
    '    '        Else
    '    '            RAP = DevFunctions.GetRAP(dr("ShapeID").ToString, dr("ColorID").ToString, dr("ClarityID").ToString, dr("Carats").ToString)
    '    '            If dr("RAP") = RAP Then
    '    '            Else
    '    '                If dr("RAP") <> 0 Or IsDBNull(dr("RAP")) = False Then
    '    '                    If IsDBNull(dr("AskingPercent")) = True Then AskingPercent = 0 Else AskingPercent = dr("AskingPercent")
    '    '                    If IsDBNull(dr("WebPercent")) = True Then WebPercent = 0 Else WebPercent = dr("WebPercent")
    '    '                    If IsDBNull(dr("WholesalePercent")) = True Then WholesalePercent = 0 Else WholesalePercent = dr("WholesalePercent")
    '    '                    If IsDBNull(dr("Carats")) = True Then carats = 0 Else carats = dr("Carats")
    '    '                    If AskingPercent <> 0 Or IsDBNull(AskingPercent) = False Then
    '    '                        AskingPPC = RAP + ((RAP * AskingPercent) / 100)
    '    '                        AskingTotal = carats * (RAP + ((RAP * AskingPercent) / 100))
    '    '                    End If
    '    '                    If WebPercent <> 0 Or IsDBNull(WebPercent) = False Then
    '    '                        WebPPC = RAP + ((RAP * WebPercent) / 100)
    '    '                        WebTotal = carats * (RAP + ((RAP * WebPercent) / 100))
    '    '                    End If
    '    '                    If WholesalePercent <> 0 Or IsDBNull(WholesalePercent) = False Then
    '    '                        WholesalePPC = RAP + ((RAP * WholesalePercent) / 100)
    '    '                        WholesaleTotal = carats * (RAP + ((RAP * WholesalePercent) / 100))
    '    '                    End If
    '    '                    GENERAL_FUNCTIONS.NExcuteQuery("UPDATE Dia_MainStock Set RAP=" & RAP & ",AskingPPC=" & AskingPPC & " ,AskingTotal=" & AskingTotal & " , WebPPC=" & WebPPC & ", WebTotal=" & WebTotal & " ,WholesalePPC=" & WholesalePPC & " ,WholesaleTotal=" & WholesaleTotal & " where TransactionID=" & GLOBAL_VARIABLES.TransactionID_DataTable.Rows(i).Item("TransactionID") & "")
    '    '                End If
    '    '            End If
    '    '        End If
    '    '    Next
    '    'Catch ex As Exception
    '    '    DevFunctions.ErrorMsg(ex.Message)
    '    'Finally
    '    '    SplashScreenManager.CloseForm(False)
    '    '    DevFunctions.InfoMsg("Prices has been updated Successfully")
    '    '    MainStock_Grid_Bind()
    '    End Try
    'End Sub

    'Private Sub btnChangeDiscount_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnChangeDiscount.ItemClick
    '    'Dim dr As DataRow
    '    'SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
    '    'Try

    '    '    Dim AskingPPC As Double
    '    '    Dim AskingPercent As Double
    '    '    Dim WholesalePPC As Double
    '    '    Dim WholesalePercent As Double
    '    '    Dim WebPPC As Double
    '    '    Dim WebPercent As Double
    '    '    Dim RAP As Double
    '    '    Dim carats As Double
    '    '    For i = 0 To GLOBAL_VARIABLES.TransactionID_DataTable.Rows.Count - 1
    '    '        dr = GENERAL_FUNCTIONS.NFetchDataRow("Select * From Dia_MainStock Where TransactionID=" & GLOBAL_VARIABLES.TransactionID_DataTable.Rows(i).Item("TransactionID").ToString)
    '    '        If dr Is Nothing Then
    '    '        Else
    '    '            RAP = DevFunctions.GetRAP(dr("ShapeID").ToString, dr("ColorID").ToString, dr("ClarityID").ToString, dr("Carats").ToString)
    '    '            If dr("RAP") = RAP Then
    '    '            Else
    '    '                If dr("RAP") <> 0 Or IsDBNull(dr("RAP")) = False Then
    '    '                    If IsDBNull(dr("AskingPPC")) = True Then AskingPPC = 0 Else AskingPPC = dr("AskingPPC")
    '    '                    If IsDBNull(dr("WebPPC")) = True Then WebPPC = 0 Else WebPPC = dr("WebPPC")
    '    '                    If IsDBNull(dr("WholesalePPC")) = True Then WholesalePPC = 0 Else WholesalePPC = dr("WholesalePPC")
    '    '                    If IsDBNull(dr("Carats")) = True Then carats = 0 Else carats = dr("Carats")
    '    '                    If AskingPPC <> 0 Or IsDBNull(AskingPPC) = False Then
    '    '                        AskingPercent = ((AskingPPC * 100) / RAP) - 100
    '    '                    End If
    '    '                    If WebPPC <> 0 Or IsDBNull(WebPPC) = False Then
    '    '                        WebPercent = ((WebPPC * 100) / RAP) - 100
    '    '                    End If
    '    '                    If WholesalePPC <> 0 Or IsDBNull(WholesalePPC) = False Then
    '    '                        WholesalePercent = ((WholesalePPC * 100) / RAP) - 100
    '    '                    End If
    '    '                    GENERAL_FUNCTIONS.NExcuteQuery("UPDATE Dia_MainStock Set RAP=" & RAP & ",AskingPercent=" & AskingPercent & " ,WebPercent=" & WebPercent & " , WholesalePercent=" & WholesalePercent & " where TransactionID=" & GLOBAL_VARIABLES.TransactionID_DataTable.Rows(i).Item("TransactionID") & "")
    '    '                End If
    '    '            End If
    '    '        End If
    '    '    Next
    '    'Catch ex As Exception
    '    '    DevFunctions.ErrorMsg(ex.Message)
    '    'Finally
    '    '    SplashScreenManager.CloseForm(False)
    '    '    DevFunctions.InfoMsg("Prices has been updated Successfully")
    '    '    MainStock_Grid_Bind()
    '    'End Try
    'End Sub
End Class




